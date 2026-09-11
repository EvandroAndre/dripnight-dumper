# Final Player / Headshot Structural Investigation

## Scope

Static structural investigation of Free Fire Unity IL2CPP metadata and
serialized Unity assets.

This investigation does not recover original native method bodies and
does not establish runtime memory offsets.

---

# 1. IL2CPP / metadata reconstruction

Input build:

Free Fire:
versionName 1.130.1

Unity candidate confirmed:
2022.3.47f1

Metadata:
version 31 / actual Cpp2IL interpretation 31.1

The APK-extracted files matched the files analyzed in Codespaces.

Cpp2IL encountered anomalous generic method registration data with
impossible adjustor thunk indices.

A metadata-only recovery mode was therefore used.

Result:

- 74 reconstructed managed assemblies
- Assembly-CSharp.dll successfully generated
- Assembly-CSharp successfully decompiled
- 26k+ C# source files reconstructed

Important limitation:

The generated method bodies are metadata stubs.

Default values such as:

return false;
return 0;
return null;

must not be interpreted as original game behavior.

---

# 2. Player class architecture

Recovered structural inheritance:

COWReplicationEntity
    ↓
AttackableEntity
    ↓
Player
    ↓
PlayerNetwork
    ↓
PlayerControl

PlayerAttributes exists as a separate MonoBehaviour-related component.

Relevant Player methods discovered:

- InitCollider()
- CreateCapsuleHuman()
- EnableSniperCollider(bool)
- EnableCharactorCollider(bool)
- ResizeSniperFireCollider(...)
- ResizeCapsuleCollider(...)
- GetHeadTF()
- GetHipTF()
- GetCharacterControllerTopPosition()
- GetCharacterHeight()
- GetCharacterCenterY()
- IsInNoHeadShotState()
- CheckDamageHitHead(...)

---

# 3. CapsuleHuman

Recovered class:

CapsuleHuman : MonoBehaviour

Relevant structure:

- Player reference
- CapsuleCollider collider
- Init(Player)
- ResizeCapsuleCollider(...)
- OnTriggerEnter(...)
- OnTriggerStay(...)
- OnTriggerExit(...)

This is strong structural evidence that Player capsule collision
infrastructure is initialized and managed through runtime code.

---

# 4. Hit region classification

Recovered enum:

LLEDPGIGCMO

Relevant values:

None
Head
Body
Limb
Vehicle
Protection
UAV
IceWall
Shield
WeaponShield
and many other target categories.

This enum is best described as a hit-region / attackable-target category.

It is not limited to human body parts.

---

# 5. HitDetectColliderHelper

Recovered class:

HitDetectColliderHelper : MonoBehaviour

Important field:

ColliderType : LLEDPGIGCMO

Relevant methods include:

- SetOwner(...)
- SetAttackableOwner(...)
- ClearAttackableOwner(...)
- GetOwner(...)
- IsPlayerHead()
- IsVehicle()
- IsProtection()
- IsWeaponShield()
- IsShield()
- IsDummy()
- IsShootingTarget()
- many additional target-category checks

This creates a strong structural relationship between a Unity collision
object and the game's hit-region classification system.

Exact assignment/control flow is not available because the original
native method bodies were not recovered.

---

# 6. Physics hit information

Recovered class:

GMPGMPFNMFP

Provisional semantic alias:

HitObjectInfo

It contains structural fields including:

- GameObject
- Collider
- several Vector3 values
- float/int data
- JKCLPFEFMNG

Recovered enum:

JKCLPFEFMNG

Values:

Default
Head
Body

This strongly suggests a physical hit result containing a coarse body
region classification.

Exact producer logic remains unavailable.

---

# 7. Physics query layer

Recovered class:

HPFKOGPDBBE

Provisional semantic alias:

PhysicsRaycastUtility

Structural evidence includes:

- RaycastHit arrays
- Collider arrays
- ray queries
- capsule queries
- box queries
- functions accepting GMPGMPFNMFP / HitObjectInfo

AutoFireWeapon also contains a method structurally relating:

RaycastHit
    ↓
GMPGMPFNMFP

Therefore a high-confidence structural chain exists between Unity physics
results and the game's internal hit-result representation.

---

# 8. Damage pipeline

Recovered types:

FDAEPHMIEPC
    provisional alias: WeaponBase

GLLLEDKLLDA
    provisional alias: DamageContext

EECMIDPHCKN
    provisional alias: DamageEvaluationContext

KOBBCCENPBG
    provisional alias: DamageModifierType

CECJMLEEPLG
    provisional alias: DamageEffectType

Important KOBBCCENPBG values include:

- HitBodyRatio
- HitHeadRatio
- HitLimbRatio
- SPHitBodyRatio
- SPHitHeadRatio
- SPHitLimbRatio
- DamageFixScale
- DmgIncreaseRatio
- ArmorDamageIncRatio
- ArmorDamageDecRatio

This demonstrates that body region classification and damage scaling are
represented as distinct structural concepts.

---

# 9. Headshot-related findings

Recovered Player methods:

- CheckDamageHitHead(...)
- IsInNoHeadShotState()

Other recovered structures include:

- HeadShotDamageScale
- HitHeadRatio
- SPHitHeadRatio
- AccumulatedDamageInfo.ColliderType
- AccumulatedDamageInfo.headShotCount

This supports separation between:

1. physical hit detection
2. hit-region classification
3. headshot validation
4. damage scaling
5. damage aggregation / UI reporting

Exact runtime execution order is not proven.

---

# 10. Unity asset extraction

FF_assets.apk was extracted.

Approximately 41k files were recovered.

UnityPy structural scan:

- 2658 files parsed
- 0 parser failures in the main object-name scan
- 7621 matching object-name records

Multiple candidate assets were investigated.

---

# 11. Eliminated candidates

## FireCollider

Asset:
360276293c2d7454ebc613b499b62d22

Hierarchy:

CyberMushroom_Coin
└── Cyber_mushroom
    └── FireCollider

Conclusion:

Not Player-related.

---

## VFX_bone_Head / VFX_bone_Neck

Asset:
17006988cb02da341a83c6329c59e6dc

Root:

FF_VFX_Ingame_Male_Cos_Jumpsuit2022_Lobby

Contains:

- VFX_bone_Head
- VFX_bone_Neck
- ParticleSystems

Conclusion:

Cosmetic/VFX attachment structure, not evidence of the canonical physical
Player collider.

---

## Bip01 Head / Neck candidate

Asset:
d1e2028b9b7ed5b46b7a0c807ae306d6

Root:

Preview_Vehicle_Horse_Magical

Conclusion:

Horse/vehicle preview skeleton.

Not Player.

---

## CityHeroBoy assets

Investigated:

855dd071f9e6c724090c36d57f796e5b
7e204f9bfe35d7548b1e6dc4c2bf9863
6041e8c6b48836e4ca97f5f571a87ffa
f49e81b442cd69d48bf79a0500ff9beb

They contain:

- bone_Head
- bone_Neck
- Animator
- SkinnedMeshRenderer
- CityHeroBoy head bones

But no relevant:

- CharacterController
- CapsuleCollider
- SphereCollider

Their roots identify them as CityHeroBoy ghost/VFX assets.

Conclusion:

Visual/VFX skeletons, not canonical Player physical collision structures.

---

# 12. Final physical-component scan

Name-assisted scan:

207 candidate files

131 contained Unity physics components.

Strict initial candidates were dominated by:

- UI
- HUD
- profile windows
- avatar menus
- social lobby
- scene geometry

A second scan inspected the ancestry of the GameObject owning each
physical component.

Final result:

Strong matches: 0

No serialized:

CharacterController
CapsuleCollider
SphereCollider

was found whose hierarchy confidently belonged to:

Player
Human
Character
Head
Neck
Bip01

without UI / preview / vehicle / lobby contamination.

---

# 13. Final conclusion

The static asset corpus does not expose a simple serialized Player
head/body collider hierarchy.

Combined with the recovered C# API:

Player.InitCollider()
Player.CreateCapsuleHuman()
Player.ResizeCapsuleCollider(...)

and:

CapsuleHuman.Init(Player)
CapsuleHuman.ResizeCapsuleCollider(...)

the strongest supported interpretation is that the principal Player
collision setup is created and/or configured dynamically at runtime.

This explains why the serialized-asset scans recovered:

- visual character skeletons
- cosmetic skeletons
- VFX attachment bones
- level collision
- UI BoxColliders

but did not recover a definitive serialized physical Player head collider.

---

# 14. Supported structural architecture

The evidence supports the following architectural relationship:

Unity physics
    ↓
RaycastHit / Collider
    ↓
GMPGMPFNMFP (HitObjectInfo)
    ↓
Hit region information
    ↓
HitDetectColliderHelper / ColliderType
    ↓
GLLLEDKLLDA (DamageContext)
    ↓
EECMIDPHCKN (DamageEvaluationContext)
    ↓
Player damage/headshot checks
    ↓
damage-region modifiers
    ↓
AccumulatedDamageInfo
    ↓
HUD / event reporting

Player physical collision appears to be initialized/configured through:

Player
    ↓
InitCollider()
CreateCapsuleHuman()
ResizeCapsuleCollider(...)
    ↓
CapsuleHuman
    ↓
Unity CapsuleCollider

The exact runtime link between every stage cannot be proven from the
metadata-only reconstruction.

---

# 15. Confidence boundaries

High confidence:

- recovered class relationships
- recovered method signatures
- recovered enum values
- Unity object hierarchies inspected
- physical-component scan results
- absence of a strong serialized Player collider candidate in the scanned set

Medium/high confidence:

- GMPGMPFNMFP as HitObjectInfo
- HPFKOGPDBBE as PhysicsRaycastUtility
- LLEDPGIGCMO as HitRegionType
- runtime-created/configured Player capsule hypothesis

Not proven:

- exact native control flow
- exact headshot formula
- exact collider dimensions
- exact native pointers
- exact runtime offsets
- exact memory layout
- exact order of every damage processing stage

