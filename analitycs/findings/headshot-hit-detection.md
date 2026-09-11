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
