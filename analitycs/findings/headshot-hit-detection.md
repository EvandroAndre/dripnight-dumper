# Headshot / Hit Detection Findings

## Confirmado pelo metadata reconstruído

LLEDPGIGCMO representa categorias de regiões/alvos atingíveis.

Valores relevantes:

- None = 0
- Head = 1
- Body = 2
- Limb = 3
- ShootingTargetHead = 16
- WeaponShield = 17
- UGCAimAssistPart = 35
- KnockDownShield = 37

HitDetectColliderHelper possui diretamente:

public LLEDPGIGCMO ColliderType;

Também possui:

public bool IsPlayerHead();

Portanto existe uma ligação estrutural direta entre um collider e uma categoria LLEDPGIGCMO.

HitDetectColliderHelper também mantém:

private OKEAMEELLBB ECKJLCJMJKF;
private GameObject LDCIMNAAGNO;

e métodos de owner:

UpdateOwner()
SetOwner(GameObject)
SetAttackableOwner(GameObject)
ClearAttackableOwner()
GetOwner()
GetOwnerID()

Além de métodos de classificação como:

IsVehicle()
IsIceWall()
IsWeaponShield()
IsProtection()
IsShootingTarget()
IsPlayerHead()
IsKnockDownShield()
IsUGCAimAssistPart()

## DamageEvaluationContext

EECMIDPHCKN possui:

public int HPPACPHIPCP;
public LLEDPGIGCMO NPEMKNFIIHL;

Seu método de inicialização recebe:

GLLLEDKLLDA
Player
AttackableEntity
FDAEPHMIEPC
int
LLEDPGIGCMO
LOAEBBHPMEK

Portanto a categoria de região atingida faz parte diretamente do contexto de avaliação de dano.

## DamageContext

GLLLEDKLLDA possui diretamente:

public LLEDPGIGCMO DNFNNJMHNEK;
public FDAEPHMIEPC FDAEPHMIEPC;
public BHGGAEEHJCO NIMANCBDPFK;

e múltiplos métodos que recebem LLEDPGIGCMO durante cálculo de dano.

## Player

Player possui:

public bool IsInNoHeadShotState()

public bool CheckDamageHitHead(EECMIDPHCKN JCONDDPFBKK)

Também possui vários métodos CheckDamageCondition que recebem o mesmo
EECMIDPHCKN.

## Damage modifier taxonomy

KOBBCCENPBG contém:

HitBodyRatio
HitHeadRatio
HitLimbRatio

SPHitBodyRatio
SPHitHeadRatio
SPHitLimbRatio

## Damage calculation taxonomy

NEIBGAFJNMN contém categorias como:

EDamageCalcType_Weapon_BodyRatio
EDamageCalcType_Weapon_HeadRatio
EDamageCalcType_Weapon_LimbRatio

EDamageCalcType_FS_Buff_HeadShotDamageRate
EDamageCalcType_Buff_WeaponHeadShotDamageScale
EDamageCalcType_Buff_HeadShotDamageRate
EDamageCalcType_UGC_HeadShotDamageDecrease

EDamageCalcType_Weapon_SPHitHead
EDamageCalcType_Weapon_SPHitBody
EDamageCalcType_Weapon_SPHitLimb

## Weapon / hit-detection bridge

FDAEPHMIEPC possui:

private ResourceID GKGHOEIMIIC(HitDetectColliderHelper PCAMLNIKFPO)

private void DDOAOJAMCGA(
    OKEAMEELLBB NNHKGODKFCL,
    HitDetectColliderHelper MLAOIHOMKHL,
    GLLLEDKLLDA PMMCGNJHOOA,
    bool FNKILOAEFMC
)

Isso liga estruturalmente:

WeaponBase
Attackable
HitDetectColliderHelper
DamageContext

O corpo original do método não está disponível no dump metadata-only,
portanto a lógica interna exata ainda não está comprovada.

## GMPGMPFNMFP

GMPGMPFNMFP herda ObjectPoolCallbackBase e contém:

GameObject
Collider
vários Vector3
int
float
JKCLPFEFMNG
PhysicMaterial
bool
short
LazyDictionary<short, LAGLGLHKHJJ>

JKCLPFEFMNG possui:

Default
Head
Body

GMPGMPFNMFP também é utilizado junto de HitDetectColliderHelper em
JNHIOHFMPFN e PIFLODLPKEO.

Hipótese atual:
GMPGMPFNMFP aparenta ser um registro/contexto transitório relacionado a
detecção física/hit result.

Isso ainda é hipótese e não deve ser tratado como nome original confirmado.

## NBOLADIFKCG

NBOLADIFKCG contém:

Head
Body
Limb

Busca global encontrou somente sua própria declaração.

Neste build reconstruído não há referências visíveis ao tipo.
Pode ser tipo legado, não utilizado ou referência perdida pelo processo
metadata-only.

## Pipeline estrutural atual

Collider físico
    ↓
HitDetectColliderHelper
    ↓
ColliderType : LLEDPGIGCMO
    ↓
Head / Body / Limb / outros
    ↓
GLLLEDKLLDA
    ↓
EECMIDPHCKN
    ↓
Player.CheckDamageHitHead(...)
    ↓
Damage modifier categories
    ↓
TakeDamage pipeline

A ordem exata de execução e as fórmulas não estão disponíveis nos corpos
metadata-only e permanecem não comprovadas.

## AOB

Busca textual realizada por:

AOB
ArrayOfBytes
Array Of Bytes
BytePattern
Byte Pattern
SignaturePattern

Resultado: nenhuma ocorrência no código C# decompilado.

AOB não foi identificado como conceito/nome interno do metadata.

Nenhuma assinatura AOB ou patch de memória foi produzida.

# Update - Physics Hit Result

GMPGMPFNMFP recebe alias provisório:

HitObjectInfo

Evidências:

- contém GameObject
- contém Collider
- contém múltiplos Vector3
- contém PhysicMaterial
- contém JKCLPFEFMNG
- utilizado em campos chamados m_HitObjectInfo
- utilizado em campo m_CacheHitInfo
- utilizado por LevelProjectile
- utilizado por AutoFireWeapon
- utilizado por física/raycast
- utilizado junto de RaycastHit
- utilizado junto de HitDetectColliderHelper

HPFKOGPDBBE recebe alias provisório:

PhysicsRaycastUtility

Evidências:

- grande quantidade de métodos recebendo origem/direção/distância
- recebe RaycastHit
- recebe Collider
- recebe Func<Collider,bool>
- preenche GMPGMPFNMFP por referência
- produz listas de GMPGMPFNMFP

Player contém:

GetHeadTF()
InitCollider()
CreateCapsuleHuman()
SetSniperFireCollider()
EnableSniperCollider()
EnableCharactorCollider()
ResizeSniperFireCollider()
ResizeCapsuleCollider()

Isso confirma que existe infraestrutura explícita para:
- transform da cabeça
- collider do personagem
- collider usado durante disparo

Ainda não está confirmado que GetHeadTF define diretamente a hitbox de headshot.

# Update - Raycast and Player Head Structure

## AutoFireWeapon

AutoFireWeapon contém:

private void MBLEOAIJBBL(
    ref RaycastHit LMHJIDCOHLD,
    GMPGMPFNMFP NKEPDPFIOFJ
)

Isso estabelece uma relação estrutural direta entre:

Unity RaycastHit
GMPGMPFNMFP / HitObjectInfo

## GMPGMPFNMFP

O alias HitObjectInfo ganhou confiança alta.

Contém diretamente:

GameObject
Collider
Vector3 x vários
float
int
JKCLPFEFMNG
PhysicMaterial
flags booleanas
dados adicionais de shield

JKCLPFEFMNG contém:

Default
Head
Body

Também existem campos legíveis em outras classes:

m_HitObjectInfo
m_CacheHitInfo
m_HitObjectInfoCache

Portanto GMPGMPFNMFP representa informação de impacto/resultado físico.

O nome original exato continua desconhecido.

## Player head and collider infrastructure

Player contém:

GetHeadTF()
GetHipTF()
InitCollider()
CreateCapsuleHuman()
SetSniperFireCollider()
EnableSniperCollider()
EnableCharactorCollider()
ResizeSniperFireCollider()
ResizeCapsuleCollider()
GetCharacterControllerTopPosition()
GetCharacterHeight()
GetCharacterCenterY()

Isso demonstra infraestrutura separada para:

- transforms corporais
- character collider
- sniper/fire collider
- redimensionamento de capsule collider

GetHeadTF confirma um transform específico da cabeça.

Ainda não há evidência suficiente para afirmar que GetHeadTF,
sozinho, define os limites físicos da hitbox de headshot.

## BigHead

Player possui BigHeadComponent e BigHeadDataConfig.

BigHeadData possui HeadShotDamageScale.

Esses tipos parecem relacionados a uma mecânica/modo de alteração
de tamanho de cabeça e dano de headshot.

Não devem ser tratados automaticamente como a implementação da hitbox
normal do jogador.

## Current structural map

Physics / Raycast
        ↓
HPFKOGPDBBE / PhysicsRaycastUtility
        ↓
RaycastHit
        ↓
GMPGMPFNMFP / HitObjectInfo
        ├── Collider
        ├── GameObject
        ├── contact/position vectors
        └── JKCLPFEFMNG Default / Head / Body
                ↓
HitDetectColliderHelper
        └── ColliderType : LLEDPGIGCMO
                ├── Head
                ├── Body
                ├── Limb
                └── outros attackable types
                        ↓
GLLLEDKLLDA / DamageContext
                        ↓
EECMIDPHCKN / DamageEvaluationContext
                        ↓
Player.CheckDamageHitHead(...)

# Update - Head/Body physical classification

## Physics query layer

HPFKOGPDBBE possui:

- buffers RaycastHit[]
- buffer Collider[]
- métodos recebendo RaycastHit
- métodos recebendo CapsuleCollider
- métodos recebendo BoxCollider
- métodos recebendo Func<Collider,bool>
- métodos produzindo GMPGMPFNMFP
- métodos produzindo listas de GMPGMPFNMFP

Alias de análise:

HPFKOGPDBBE -> PhysicsRaycastUtility

Confiança: alta.

## Hit result layer

GMPGMPFNMFP possui diretamente:

- GameObject
- Collider
- múltiplos Vector3
- PhysicMaterial
- JKCLPFEFMNG
- flags e informações adicionais

O tipo aparece em campos legíveis chamados:

m_HitObjectInfo
m_CacheHitInfo
m_HitObjectInfoCache

Alias:

GMPGMPFNMFP -> HitObjectInfo

Confiança: alta.

## Hit object region

JKCLPFEFMNG:

Default
Head
Body

Alias provisório:

JKCLPFEFMNG -> HitObjectRegion

Confiança: média/alta.

## Physical player collider

CapsuleHuman possui:

CapsuleCollider collider
Player owner

e:

Init(Player)
OnTriggerEnter
OnTriggerStay
OnTriggerExit
ResizeCapsuleCollider

Isso aparenta representar uma capsule física/trigger geral do Player,
não uma hitbox exclusiva da cabeça.

## Big Head

BigHeadComponent possui:

Transform
CapsuleCollider
UpdateScale(float)
SetNeckRevertScaleMult(Vector3)

BigHeadData possui:

HeadScale
HeadShotDamageScale

Isso confirma que a mecânica Big Head altera uma estrutura visual/física
associada à cabeça.

Não está comprovado que o CapsuleCollider interno do BigHeadComponent
seja a hitbox normal utilizada fora dessa mecânica.

## UGC bone scaling

UGCPlayerRepItem contém:

HeadBonesScale
BodyBonesScale
LimbBonesScale

Isso demonstra suporte para escalas independentes das regiões do esqueleto.

Não implica automaticamente alteração equivalente das hitboxes normais.

## Current confidence map

PhysicsRaycastUtility
    ↓
RaycastHit
    ↓
HitObjectInfo
    ├── Collider
    ├── GameObject
    ├── vectors / material
    └── HitObjectRegion
          ├── Default
          ├── Head
          └── Body
    ↓
HitDetectColliderHelper
    └── HitRegionType
          ├── Head
          ├── Body
          ├── Limb
          └── other attackable regions
    ↓
DamageContext
    ↓
DamageEvaluationContext
    ↓
CheckDamageHitHead
    ↓
damage/headshot modifier taxonomy

Exact method execution logic is unavailable in the metadata-only reconstruction.

# Metadata headshot analysis - final status

## Managed references

CheckDamageHitHead(EECMIDPHCKN) aparece somente em sua própria declaração.

IsInNoHeadShotState() aparece somente em sua própria declaração.

Isso significa que o metadata reconstruído não contém evidência suficiente
para reconstruir seus callers ou sua implementação original.

## Accumulated headshot information

AccumulatedDamageInfo possui:

- LLEDPGIGCMO ColliderType
- int headShotCount
- int TotalDamage
- int TotalShieldDamage
- int PelletCount
- int WeaponID

AccumulateDamageEvent possui:

- HeadShotCount

A HUD recebe AccumulatedDamageInfo em SetupHitLabel.

Portanto existe uma etapa posterior do pipeline que acumula a classificação
do impacto e a quantidade de headshots antes da apresentação na HUD.

## HitObjectRegion

JKCLPFEFMNG contém:

Default
Head
Body

No metadata reconstruído, sua referência visível principal é:

GMPGMPFNMFP.FLCLOHCBJEI

Não há atribuições visíveis no C# reconstruído.

A lógica que atribui Head/Body provavelmente estava nos corpos IL2CPP
nativos que não foram recuperados pelo modo metadata-only.

## Player transforms

GetHeadTF está declarado em Player e sobrescrito em Player_Watching.

O metadata não mostra o corpo original dessas funções.

Não foi possível determinar por metadata-only qual bone/path exato é
retornado por GetHeadTF.

## Conclusion

A reconstrução C# metadata-only chegou ao seu limite para a lógica de
headshot.

Foi possível reconstruir a arquitetura de:

Physics query
RaycastHit
HitObjectInfo
Collider
Hit region
Damage context
Damage evaluation
Headshot classification
Accumulated headshot information
HUD

Não foi possível reconstruir por esta fonte:

- condições internas exatas
- atribuições de Head/Body dentro dos métodos nativos
- dimensões normais da hitbox
- bone/path exato da cabeça
- fórmulas originais de dano
- ordem exata de branches internos

## Asset investigation - FireCollider

Asset:
360276293c2d7454ebc613b499b62d22

Hierarchy:

CyberMushroom_Coin
└── Cyber_mushroom
    └── FireCollider

Conclusion:

The object named FireCollider in this asset is associated with the
Cyber Mushroom object hierarchy and is not evidence of a Player
head/body collider.

The FireCollider GameObject has three unresolved component references:

- path_id 19
- path_id 54
- path_id 35

No MonoScript objects are stored directly in this SerializedFile.

This candidate is therefore removed from the Player collider investigation.

## Asset investigation - VFX Head/Neck candidate

Asset:
17006988cb02da341a83c6329c59e6dc

Root:
FF_VFX_Ingame_Male_Cos_Jumpsuit2022_Lobby

Relevant hierarchy:

FF_VFX_Ingame_Male_Cos_Jumpsuit2022_Lobby
├── VFX_bone_Neck
│   ├── gantan01
│   ├── gantan01 (1)
│   ├── Particle System
│   └── Particle System (1)
├── VFX_bone_Head
│   └── box001
├── VFX_bone_LeftLeg
├── VFX_bone_RightLeg
└── VFX_Bip01

The SerializedFile contains:

- 14 GameObjects
- 14 Transforms
- 8 ParticleSystems
- 8 ParticleSystemRenderers
- 5 MonoBehaviours

Conclusion:

VFX_bone_Head and VFX_bone_Neck are attachment points belonging to a
lobby/cosmetic VFX hierarchy.

They are useful evidence that the game uses Head/Neck attachment nodes,
but this asset is not evidence of the main Player physical collider or
canonical Player skeleton.

This candidate is removed from the physical Player collider investigation.

## Asset investigation - Bip01 Head/Neck candidate

Asset:
d1e2028b9b7ed5b46b7a0c807ae306d6

Root:
Preview_Vehicle_Horse_Magical

Relevant skeleton:

Bone_Root
└── Bip01
    └── Bip01 Pelvis
        └── Bip01 Spine
            ├── Bip01 Tail...
            └── Bip01 Spine1
                └── Bip01 Spine2
                    └── Bip01 Neck
                        └── Bip01 Neck1
                            └── Bip01 Head

Conclusion:

This asset contains a complete Bip01-style skeleton, but its root is
Preview_Vehicle_Horse_Magical and the hierarchy includes horse-specific
bones such as Tail and HorseLink.

Therefore this is a vehicle/horse preview skeleton and not the physical
Player skeleton.

Removed from Player collider investigation.

## Final serialized physics scan

A final ancestry-aware scan inspected Unity physical components associated
with Player/Head/Neck/Character naming.

Candidate files: 207

Files containing physical components in the prior scan: 131

High-confidence result:

Strong matches: 0

All highest-ranked matches were UI/HUD/profile/avatar-menu BoxColliders.

No CharacterController, CapsuleCollider, or SphereCollider was found with
a clean Player/Head/Neck ancestry.

Combined with Player.InitCollider(), Player.CreateCapsuleHuman(),
Player.ResizeCapsuleCollider(), and CapsuleHuman.ResizeCapsuleCollider(),
the strongest supported interpretation is that the principal Player
collision structure is initialized/configured dynamically at runtime
rather than stored as a simple serialized Player prefab collider.
