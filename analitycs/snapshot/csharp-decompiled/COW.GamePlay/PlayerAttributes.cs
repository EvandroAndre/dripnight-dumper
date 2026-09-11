using System.Collections.Generic;
using GCommon;
using GCommon.Obfuscate;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class PlayerAttributes : MonoBehaviour
{
	public enum PNIHKNJCNLH
	{
		Run,
		Crouch,
		Creep,
		Dying,
		Dash,
		Swimming,
		SwimmingSurf,
		SwimmingDash,
		JetFly,
		JetFlyDash,
		JetFlyV,
		JetFlyVDash,
		FlightRoamHorizontal,
		FlightRoamVertical,
		FlightRoamRush,
		SwimmingSurfDash,
		NB
	}

	public enum NHJPEJNGDHE
	{
		Moco,
		DeliveryMarkEnemy,
		MarkIceWallNearbyEnemy,
		SanitinoBombMarkEnemy,
		SlowDownMarkEnemy
	}

	public enum DKOGEAGJFDN
	{
		LimitedTimes,
		CostHP,
		Distance
	}

	public enum BDACINNPFDD
	{
		Invalid = -1,
		KellySkill = 0,
		ActSkill = 1,
		MonkeyKingSkill = 2,
		BloodPoolSkill = 3,
		PRMode = 4,
		FrozenZone = 5,
		FSMode = 6,
		SpaceShieldSkill = 7,
		GameMode = 8,
		Inhaler = 9,
		HealingDance = 10,
		CustomRoom = 11,
		BuffDebris = 12,
		Hype = 13,
		DamageZone = 14,
		SpeedUpSkill = 15,
		SHOOTRATETOMOVESPEEDSkill = 16,
		PetShark = 17,
		EnergyStone = 18,
		AutoFlightBomb = 19,
		InfectionSlowDown = 20,
		UGCScale = 21,
		MoveEmote = 22,
		HealingDanceWithFaction = 23,
		ForbidMove = 24,
		WeaponOnHand = 25,
		SlowDownMark = 26,
		IncreaseShootAndMoveSpeed = 27,
		UGCCrouch = 28,
		UGCKnockDown = 29,
		UGCCreep = 30,
		UGCDash = 31,
		MetropolisAddSpeedBuff = 32,
		KapellaSkill = 33,
		UGCSwimScale = 34,
		JosephSkillScale = 35,
		PetCrouchSpeedUp = 36,
		ExecuteBuffSpeedUp = 37,
		SnowSlideWaySpeedUp = 38,
		MonkeyKingSkill_Dash = 39,
		GBFootballSpeedUp = 40,
		BuffSystem = 500,
		BuffSystem_AllState = 501,
		SkillSystem = 600,
		SkillSystem_AllState = 601,
		BuffECASystem = 700,
		BuffECASystem_AllState = 701,
		BuffECASkillSystem = 800,
		BuffECASkillSystem_AllState = 801
	}

	public enum DLFIJMCICOC
	{
		RunSpeedUp,
		ArcShield,
		NBDash,
		CityHeroBoy,
		IIVDashBoxing
	}

	public enum DEOMDELEGMI
	{
		None,
		JumpHeight,
		CrouchSpeed,
		BuffSystem_WeaponAmmoClipSize,
		Max
	}

	public enum AEEOMAHHIEE
	{
		Default,
		JumpHeight_Hype,
		JumpHeight_Custom,
		JumpHeight_GameMode,
		JumpHeight_FSModeBuff,
		JumpHeight_Normal,
		JumpHeight_UGC,
		JumpHeight_UGC_JumpStatus,
		JumpHeight_FPP_Mode,
		CrouchSpeed_PetSkill,
		JumpHeight_BuffECAJumpScale
	}

	public struct GLLHIMENBBM
	{
		public uint MKPJODIJLMO;

		public ResourceID LAHGNAFFJDK;
	}

	public enum DLAODHEODPG
	{
		Invalid = -1,
		RunSpeedUp
	}

	private Player MBPMMLMJOHL;

	private Dictionary<int, float> FJCLLBACPGH;

	private Dictionary<int, List<uint>> KDJMMCCKJGF;

	private List<uint> DFGJCFKOKBN;

	private float[] LJKMBHOLIEF;

	private Dictionary<int, MNIJCDHGGEC> HJHJGFEDNBN;

	private KCOGMDJEMBO PLEDBHEMELL;

	private Dictionary<int, uint> JPEAOHJNMDN;

	private Dictionary<int, float> BLHBDGOLGFG;

	private Dictionary<uint, int> LHNEBMIHOJB;

	private float LLFCBMMLKLE;

	private const float HHNFLFMHEBK = 1f;

	public bool SuperArmorSkillEffecting;

	public HashSet<int> SkillWeaponTypeSet;

	private float INCCJCOEDNG;

	public bool CanAimassistOnStrop;

	public float BuffArmorMinDurability;

	public bool InfiniteIceWall;

	public bool PreInfiniteIceWall;

	private float BLCIIJGBNJJ;

	private float NAJLJMHJJHD;

	private float NMJEGFBCJMM;

	private float PNLLLKKNBOG;

	private float NKGEPOINCPL;

	private int IMAOMANGLEG;

	private int KPBGDKFOLMC;

	private int ICLCOKEPMPO;

	private uint FNAPCELGFJB;

	private uint NKMCMOJGDIJ;

	private int GIINAJJJECC;

	private float PEEPLPANHPF;

	private float _003CKJBMEKMCMIE_003Ek__BackingField;

	private float CNHBKMNDIMD;

	private float LJEIDPNLNNA;

	private float FPNMKLJMDFD;

	private List<Vector2> AGEPLAPFMBO;

	protected const int ILGFEGKGAIE = -1;

	public bool ReloadNoConsumeAmmoclip;

	public bool ShootNoReload;

	public MNIJCDHGGEC BuffWeaponScatterScale;

	public MNIJCDHGGEC BuffEcaWeaponScatterScale;

	public MNIJCDHGGEC BuffEcaJumpHeightScale;

	public MNIJCDHGGEC BuffEcaHpLossScale;

	public SafeReference<uint> BuffEcaWeaponReloadNoConsumeAmmoclip;

	public bool ShowMatchAICoinAnimation;

	public float DamageAdditionScale;

	private Dictionary<int, float> JKBNLPONHIE;

	public float ExecuteDamageScale;

	public Dictionary<uint, bool> ExecuteDamageExclueType;

	public float BuffWeaponDamageScale;

	public float BuffWeaponReloadScale;

	public float BuffWeaponMoveSpeedScale;

	public int BuffWeaponAmmoClip;

	public int TalentWeaponAmmoClip;

	private float _003CPBJIOFBCJDM_003Ek__BackingField;

	private float _003CKPHEGJPOLFL_003Ek__BackingField;

	private bool _003CMDKIKMHEJEO_003Ek__BackingField;

	private bool _003CGDCFOPALKCI_003Ek__BackingField;

	private float JELOIDPAHIC;

	private float IJEDMDBFJDD;

	private float NOPGOKAMPCM;

	public BHGGAEEHJCO EffectOwner;

	public bool ShowEnermyTargetOnMap;

	public bool ShowEnermyTargetOnHud;

	public bool ShowEnemyFootStep;

	public int EnemyFootStepMaxDistanceDelta;

	public int EnemyFootStepMinDistanceDelta;

	public int EnemyFootStepLimitNumDelta;

	private bool DKEFANLHLNJ;

	private Dictionary<int, JDOPDJCMKID> DHACIGKHAOH;

	private float EEDHOFHBCGO;

	public float PetSkillCDReduction;

	public float ActiveSkillCdReduction;

	private float LNNGFKKFGMA;

	private Dictionary<uint, float> PMEIMFENIEB;

	private readonly List<GLLHIMENBBM> KDJMHHNKLNB;

	private float FFLODAIPKIH;

	private float BIKLJBHEAJC;

	private float JLHENPLIJBP;

	private int LBKECCPGPML;

	private int OBAACAIICKN;

	private float IJDBOAPOPLF;

	private float HBEIFOKHGDD;

	private float CHJNILPCADN;

	private int JDILOCAJJJM;

	private int NHEMGDJCGHJ;

	private float GFIHFCAKHLK;

	private float PNPEIBLHEEM;

	private DAEDCJGHBHI BEOGNJEDPKD;

	private float JPAOGMBBJKL;

	private float JFGPFNCFCEI;

	private float _003CBOJFEACDNHO_003Ek__BackingField;

	private float _003CDMFENPJHKLP_003Ek__BackingField;

	private float _003CBKFFJLBIHPO_003Ek__BackingField;

	public float GrenadeThrowSpeedScaleDefault;

	public float GrenadeThrowSpeedScale;

	private float MEKIMJJGFGF;

	private float BONAJJEOPNF;

	private float FDLNKHLJAAH;

	private float PNINKHOKJOL;

	public readonly EBMBEEHGBKP FireIntervalScaleBuffECA_AccumulateWithBounds;

	private float MMBOJGNBFEA;

	private int NIPNEEJLOEL;

	private int CHOCDPOKNHK;

	private int LEAMEJEFPDF;

	private float MLIBBLIPGFH;

	private List<CMOLCHJGJDH> HHNCBHLJLAO;

	private Dictionary<uint, float> BNNHCNJIPCK;

	private HAGPBAIKECP FOMBNGEOPGN;

	private float IBCNKIMOJFP;

	private float PPDOMIKEDAD;

	private float LMJMHFGBECI;

	public bool Eighth_GP_InfiniteHealer;

	public bool FootballShooter;

	protected BitArrayBoolean FGAMGBFKCGM;

	protected const uint NAFJFAAGBNG = 1u;

	protected const uint DJLPEOMDBML = 2u;

	public bool IsSuperArmorEnable;

	public float FallingSpeedUpScale;

	public float RunSpeedUpScale;

	private Dictionary<int, float> NLJOBJDNAJE;

	private float PDIDMKOLNGD;

	public bool CanGrenadeSplit;

	public int GrenadeSplitNum;

	public float GrenadeSplitTime;

	public float SubGrenadeExplodeTime;

	public float GrenadeSplitVelocityFactor;

	public float GrenadeSplitVelocityFactorForStatic;

	public float SubGrenadeRangeScale;

	public float SubGrenadeDamageScale;

	public float SubGrenadeModelScale;

	public float MainGrenadeRangeScale;

	public float MainGrenadeDamageScale;

	public float MainGrenadeModelScale;

	public float GrenadeStaticSplitTan;

	private ArrayMap<BKKPCMFNEFM> OCBOHGAPPKB;

	private Dictionary<uint, Dictionary<int, BKKPCMFNEFM>> FBALAPHIMAC;

	private EECMIDPHCKN CNEKEPCBPEM;

	private bool _003CICJGJIOHPOM_003Ek__BackingField;

	private float _003CBCFCLAGHMGJ_003Ek__BackingField;

	private int _003CDMLAJAAHELP_003Ek__BackingField;

	private float _003CNPOGCMHIEOP_003Ek__BackingField;

	private List<Vector2> _003CNODJOALCANP_003Ek__BackingField;

	public SafeReference<uint> BuffEcaForbidChangeWeapon;

	public SafeReference<uint> BuffEcaIgnoreWeaponFireSpeedScale;

	public SafeReference<uint> BuffEcaIgnoreWeaponAimDecay;

	public SafeReference<uint> BuffEcaIgnoreWeaponScatter;

	public SafeReference<uint> BuffEcaKeepDashInFalling;

	public SafeReference<uint> BuffEcaBlockUserMoveControl;

	public SafeReference<uint> BuffEcaForbidActiveSkill;

	public SafeReference<uint> BuffEcaForbidPassiveSkill;

	public StackDictionary<uint, string> BuffEcaForbidActiveSkillTips;

	public SafeReference<uint> BuffEcaForbidControlBtn;

	private Dictionary<uint, SafeReference<uint>> FKIDFEGAELK;

	public float ForceSetRunAndDashSpeed;

	public float DeltaRotationPerFrameBySkill;

	public bool SpeedDecreaseWhenSteeringUseRealAngle;

	private LazyDictionary<uint, FBNAAHOLKBH> AMAPNCDEDMM;

	private FBNAAHOLKBH BOLFELGGFOA;

	public int ReviveCardDiscount;

	private Dictionary<int, float> JHBFPJFPCMH => null;

	private Dictionary<int, List<uint>> NEGGOPMACFF => null;

	private List<uint> GKIGOAFKAEG => null;

	private Dictionary<int, MNIJCDHGGEC> LCJAPFMMKBA => null;

	private KCOGMDJEMBO GEJFILNKKKA => null;

	private Dictionary<int, uint> EIFOIOKAGKO => null;

	private Dictionary<int, float> CDAGHGBOLDF => null;

	private Dictionary<uint, int> DILJPILFHML => null;

	public Player NKPFAEIGJLB
	{
		set
		{
		}
	}

	public float JEPNFDFOOMO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float BCJDPBDNPJB
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float CNKFIMKMICO => 0f;

	public float LACDFHBGEKD
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float LPGPOFMDJDE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int ONBNILINLOI
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int OBPNIGAOKKK
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int KOPHPLGNNPD
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint CCBLPHMOCJD
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint PDANBGFJNFO
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public int GHHLBPAINBA
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float INGHAIGNJFE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DHMPDEBDKPD
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float LMOLIOAMNLH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DMLBIKHJFGC
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public List<Vector2> AMIBCLHCPMB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<int, float> FNPPHAIMCKL => null;

	public float FNODLIJOBEL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float JKMOKADFAOH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool NDPHPADOLAI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool KJELFEPFGDP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float EOEOBEOFNLO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float AFEGGFFDPGE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float KNDMJJPHOBO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private Dictionary<int, JDOPDJCMKID> DOIHKOKHKPC => null;

	public float LPLMDICLIME
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float BCNIIHPKLAM
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Dictionary<uint, float> PDKCELOECDO => null;

	public float AMPDAFJCPIH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float IGJLCHKKGEJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PMBHLCLINEJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float IEEECAEKKOI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float FANEGDPMOJD
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int FJJIGDCPHCL
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DJACHOEKDLO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float HIGCPNOKMAO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float FBGGAKCAPCC
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float KEPLIABEKHL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DNANJJDCBJH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NJAKMHCJENH
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float IEACKCJAKHF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HEHCHHIBPHA
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PABOODPFPJP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HAOPBHEBJDP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float KKFJONNFJJG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float JLMAHAOFNJG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float NABJJBPOIIJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int EEFFJAJGGGI
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NAOCOKAOLAB
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int OPNBMAAJCOJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float NLLHDLOGNPG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public List<CMOLCHJGJDH> HGMEAIJODGO => null;

	private Dictionary<uint, float> OPKOBPBEJHH => null;

	public float PLHGJOKCCIJ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float LEECMDIEDCG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float EBDNEEABGNG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float OIKBEADCAEI => 0f;

	public bool LKIGPJICDNM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float MPJNGHKFEGF => 0f;

	public EECMIDPHCKN LDDEKLJGEJK => null;

	public bool OEHFGOKNJEK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float HLFONOIEKHO
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int LBKHIMANAMP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float JCFCKEAOELM
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public List<Vector2> HPNMJNHNBMN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<uint, SafeReference<uint>> JPLNFADGPLK => null;

	public void Init()
	{
	}

	public static BDACINNPFDD GetBuffBehaviorSpeedType(bool KBJKJDLOKAE, AJDNGNIFAFA GIKBFAHPFGE)
	{
		return BDACINNPFDD.KellySkill;
	}

	public static BDACINNPFDD GetBuffECASpeedType(bool KBJKJDLOKAE, AJDNGNIFAFA GIKBFAHPFGE)
	{
		return BDACINNPFDD.KellySkill;
	}

	public static BDACINNPFDD GetBBSpecialSpeedTypeBySpeedType(PNIHKNJCNLH GIKBFAHPFGE, bool KBJKJDLOKAE)
	{
		return BDACINNPFDD.KellySkill;
	}

	public static BDACINNPFDD GetBECASpecialSpeedTypeBySpeedType(PNIHKNJCNLH GIKBFAHPFGE, bool KBJKJDLOKAE)
	{
		return BDACINNPFDD.KellySkill;
	}

	public void SetSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM, float PLNBKKNHAKO)
	{
	}

	public void ResetSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM)
	{
	}

	public void SetCoverableSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM, uint OJANLPFFBOC, float PLNBKKNHAKO)
	{
	}

	public void ResetCoverableSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM, uint OJANLPFFBOC)
	{
	}

	public void SetSpecialRunSpeedScaleByKeyAndValue(BDACINNPFDD CCNBNLAPJFM, ulong DGDDJLEOPBL, float PLNBKKNHAKO)
	{
	}

	public void AddSpecialRunSpeedScaleByKeyAndValue<T>(BDACINNPFDD CCNBNLAPJFM, ulong DGDDJLEOPBL, float PLNBKKNHAKO) where T : MNIJCDHGGEC, new()
	{
	}

	public void GiveDeltaSpeedScaleByKeyAndValue(BDACINNPFDD CCNBNLAPJFM, ulong DGDDJLEOPBL, float PLNBKKNHAKO)
	{
	}

	public void RemoveSpecialRunSpeedScaleByKey(BDACINNPFDD CCNBNLAPJFM, ulong DGDDJLEOPBL)
	{
	}

	public float GetSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM)
	{
		return 0f;
	}

	public bool HasSpecialSpeedScaleBelowThreshold(HashSet<int> DJINJDADDEP, float APCNKKIEFMK)
	{
		return false;
	}

	public float GetSpecialRunSpeedScale(BDACINNPFDD CCNBNLAPJFM, float NMNOEMLKCEH)
	{
		return 0f;
	}

	public void SetWeaponRunSpeedScale(int CCNBNLAPJFM, float PLNBKKNHAKO)
	{
	}

	public float GetWeaponRunSpeedScale(int CCNBNLAPJFM)
	{
		return 0f;
	}

	private float HKMFCAAAJKB(PNIHKNJCNLH GIKBFAHPFGE)
	{
		return 0f;
	}

	private float PJJLLJJJPGJ()
	{
		return 0f;
	}

	private float BIINGKCCOGA()
	{
		return 0f;
	}

	private float KDPNEODFANJ()
	{
		return 0f;
	}

	private float LDNGNEIONBJ()
	{
		return 0f;
	}

	private float AGKCMEFGEAH()
	{
		return 0f;
	}

	private float MDLOIKIDNOD()
	{
		return 0f;
	}

	private float CADMDJIDGPM()
	{
		return 0f;
	}

	private float AEFCIHAGHCO()
	{
		return 0f;
	}

	private float JELDNJKIFNF()
	{
		return 0f;
	}

	private float AKPNDCDCIPA()
	{
		return 0f;
	}

	private float MGKOCPEOOKA(PNIHKNJCNLH GIKBFAHPFGE)
	{
		return 0f;
	}

	private float NCEGBILNPKN()
	{
		return 0f;
	}

	private float BFPOPDPPGEH()
	{
		return 0f;
	}

	private float BAFHACHCBGE()
	{
		return 0f;
	}

	private float MAJJPCKCFNF()
	{
		return 0f;
	}

	private float KNBKBKJOAFM(BDACINNPFDD CCNBNLAPJFM, float MPJMENJCMCN)
	{
		return 0f;
	}

	public float GetBaseSpeedBySpeedType(PNIHKNJCNLH MJIFGJPGLAM)
	{
		return 0f;
	}

	public float GetSpeedScaleBySpeedType(PNIHKNJCNLH MJIFGJPGLAM)
	{
		return 0f;
	}

	public float GetSpeedByType(PNIHKNJCNLH MJIFGJPGLAM)
	{
		return 0f;
	}

	private float HINCFAGDPBK()
	{
		return 0f;
	}

	public void SetDebugSpeedScale(float GLPLIHEECAP)
	{
	}

	public bool CheckCanDampNoise(int NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	private bool PIFJEKFOJAI(int NJMMDDMIION, int KJAEDIGHOMN, List<Vector2> IPCPKIPFHKF)
	{
		return false;
	}

	public void UpdateDamageAdditionScaleForAIType(bool MCABMDPCKKG, int CCNBNLAPJFM, float PLNBKKNHAKO)
	{
	}

	public bool IsUnKillable()
	{
		return false;
	}

	public float GetScatterRate()
	{
		return 0f;
	}

	public void AddReloadScale(int NJMMDDMIION, float JGJAPIKMGDA)
	{
	}

	public float GetReloadScale(int NJMMDDMIION)
	{
		return 0f;
	}

	public void MultiplyFireIntervalScaleByWeaponType(int NJMMDDMIION, float JLIMIPBNFCG)
	{
	}

	public float GetMultiplyFireIntervalScaleByWeaponType(int NJMMDDMIION)
	{
		return 0f;
	}

	public void UpdatemWeaponDamageReviseDict(List<FGGENBBKHEO> LKLGFIEAOKG)
	{
	}

	public int GetWeaponDamageReviseByWeaponType(FDAEPHMIEPC.DBENAPILEBC NJMMDDMIION)
	{
		return 0;
	}

	public JDOPDJCMKID GetScaleMapByScaleType(DEOMDELEGMI CCNBNLAPJFM)
	{
		return null;
	}

	public float GetScaleInSpecialScaleMapByDefaultScale(DEOMDELEGMI CCNBNLAPJFM, float GLPLIHEECAP = 1f)
	{
		return 0f;
	}

	public void RemoveValueByKeyInSpecialScaleMap(DEOMDELEGMI CCNBNLAPJFM, string DGDDJLEOPBL)
	{
	}

	public void SetValueByKeyInSpecialScaleMap(DEOMDELEGMI CCNBNLAPJFM, string DGDDJLEOPBL, float GPFPIAMCEMI)
	{
	}

	public void AddValueByKeyInSpecialScaleMap(DEOMDELEGMI CCNBNLAPJFM, string DGDDJLEOPBL, float GPFPIAMCEMI)
	{
	}

	public ResourceID GetTopSkillCdReductionIconResId()
	{
		return default(ResourceID);
	}

	public void PushSkillCdReductionIcon(uint CIHDJJHAPLP, ResourceID CCLAINOJAGN)
	{
	}

	public void RemoveSkillCdReductionIcon(uint CIHDJJHAPLP)
	{
	}

	public void UpdateExtraLimitedTimeDamageRate(float JHLNMNMLGPB)
	{
	}

	public float GetExtraLimitedTimesDamageRate()
	{
		return 0f;
	}

	public void UpdateExtraDamageLimitedTimes(int LHEEOLCCPOD)
	{
	}

	public int GetDamageLimitedTimes()
	{
		return 0;
	}

	public void UpdateDamageEffectTimes(int LHEEOLCCPOD)
	{
	}

	public int GetDamageEffectTimes()
	{
		return 0;
	}

	public bool HasUnusedLimitedTimesDamage()
	{
		return false;
	}

	public bool IsLimitedTimesDamageValidWeapon(FDAEPHMIEPC.DBENAPILEBC NJMMDDMIION)
	{
		return false;
	}

	public DAEDCJGHBHI GetBuffAdditionalHealingEffectScales()
	{
		return null;
	}

	public float GetBeHealingDecreaseRatio()
	{
		return 0f;
	}

	public float GetSkySurfingMaxHSpeed()
	{
		return 0f;
	}

	public float GetSkyDivingMaxHSpeed()
	{
		return 0f;
	}

	public float GetParachutingMaxVSpeed()
	{
		return 0f;
	}

	public void AddMarkState(NHJPEJNGDHE DIIGDDJMDGL, uint LIKPJDHGPFG)
	{
	}

	public void RemvoeMarkState(NHJPEJNGDHE DIIGDDJMDGL, uint LIKPJDHGPFG)
	{
	}

	public void ClearMarkState(NHJPEJNGDHE DIIGDDJMDGL)
	{
	}

	public void AddEclipseManLinker(uint KFNHFIGEOPP)
	{
	}

	public void RemoveEclipseManLinker(uint KFNHFIGEOPP)
	{
	}

	public void ClearEclipseManLinkers()
	{
	}

	public bool HasEclipseManLinker()
	{
		return false;
	}

	public List<uint> GetEclipseManLinkers()
	{
		return null;
	}

	public bool CanPersonaTakeEffect(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool IsSkillDamageLimitedScaleEffecting(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool IsSkillDamageLimitedScaleEffecting(AGACNOCEEFP NGJDOCHFBKJ)
	{
		return false;
	}

	public float GetSkillDamageScale(AGACNOCEEFP NGJDOCHFBKJ, OKEAMEELLBB BCKIGKDGNKE)
	{
		return 0f;
	}

	public void UpdatePetSharkSpeed(uint LIKPJDHGPFG, float GLPLIHEECAP)
	{
	}

	public bool GetDamageReductionRateByBeHurtExpendEPEnable()
	{
		return false;
	}

	public void SetIsBloodPoolEffecting(bool OGECPGHMIHA)
	{
	}

	public void SetIsInvincibleByImmortalitySkill(bool OGECPGHMIHA)
	{
	}

	public bool IsInvincible()
	{
		return false;
	}

	public void SetWalkDownSpeedScale(DLAODHEODPG DGDDJLEOPBL, float GPFPIAMCEMI)
	{
	}

	public void ResetWalkDownSpeedScale(DLAODHEODPG CCNBNLAPJFM)
	{
	}

	private void FAKDKAGAPAJ()
	{
	}

	public void UpdateLastBattleTimeStamp()
	{
	}

	public void ResetLastBattleTimeStamp()
	{
	}

	public bool EscFromBattle()
	{
		return false;
	}

	public bool IsWeaponSupportHealingBullet(int NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	public void initDamageCalc()
	{
	}

	public float GetDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM)
	{
		return 0f;
	}

	public float GetDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, uint CKLAHJDPNCI)
	{
		return 0f;
	}

	public float GetDamageCalcValue(KOBBCCENPBG LMFHNNEALPF)
	{
		return 0f;
	}

	public float GetWeaponTypeDamageCalcValue(KOBBCCENPBG LMFHNNEALPF, FDAEPHMIEPC.DBENAPILEBC NJMMDDMIION)
	{
		return 0f;
	}

	public void UpdateDynamicDamage(EECMIDPHCKN NADOGLBIKEF)
	{
	}

	public void ClearAllDynamicDamage()
	{
	}

	public bool CheckDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM)
	{
		return false;
	}

	public bool CheckDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, uint CKLAHJDPNCI)
	{
		return false;
	}

	public void AddDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, float EIDECPPHMGP, FELPGEPKPJM OHALJGAPMOJ = null)
	{
	}

	public void AddDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, uint CKLAHJDPNCI, float EIDECPPHMGP, FELPGEPKPJM OHALJGAPMOJ = null)
	{
	}

	public void ResetDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM)
	{
	}

	public void ResetDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, uint CKLAHJDPNCI)
	{
	}

	public void AddDynamicDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM)
	{
	}

	public void AddDynamicDamageScale(KOBBCCENPBG LMFHNNEALPF, uint CCNBNLAPJFM, float EIDECPPHMGP)
	{
	}

	public void AddWeaponTypeDamageScale(KOBBCCENPBG LMFHNNEALPF, FDAEPHMIEPC.DBENAPILEBC PAOCFLFGIDP, uint CCNBNLAPJFM, float EIDECPPHMGP, FELPGEPKPJM OHALJGAPMOJ = null)
	{
	}

	public void ResetWeaponTypeDamageScale(KOBBCCENPBG LMFHNNEALPF, FDAEPHMIEPC.DBENAPILEBC PAOCFLFGIDP, uint CCNBNLAPJFM)
	{
	}

	public void RefreshDynamicDamage(GLLLEDKLLDA PMMCGNJHOOA, Player FNOOENEHBJP, AttackableEntity CJOKKFOFHPO, FDAEPHMIEPC KEDHIAANLGO, int HPPACPHIPCP, LLEDPGIGCMO NPEMKNFIIHL, LOAEBBHPMEK AOJANNHGCEA)
	{
	}

	public void UpdateBlockDamage(uint NNDAGDKKCMO, uint KHCLGJBKFPA, bool FNEEDDGOIIE)
	{
	}

	public void ClearBlockDamage()
	{
	}

	public float GetDamageAfterBlockDamageBuff(float FCAOOKIBKJK, out bool LFNAJCODNPB)
	{
		LFNAJCODNPB = default(bool);
		return 0f;
	}

	public bool IsPlayerSkillWeapon(uint PFDCJPHHDEN)
	{
		return false;
	}

	public bool IsPlayerSkillWeapon(int NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	public void AddBuffEcaSpeedScaleValueByTime(uint FNEBMOADAFJ, FBNAAHOLKBH JMNACCPPMOF)
	{
	}

	public void RemoveBuffEcaSpeedScaleValueByTime(uint FNEBMOADAFJ)
	{
	}

	public void OverwriteBuffEcaForceSetRunAndDashSpeedValueByTime(FBNAAHOLKBH JMNACCPPMOF)
	{
	}

	public bool TryClearBuffEcaForceSetRunAndDashSpeedValueByTime(uint FNEBMOADAFJ)
	{
		return false;
	}

	public void UpdateBuffEcaSpeedScaleValueByTime()
	{
	}

	public void UpdateForceRunAndDashSpeedValueByTime()
	{
	}

	public void GiveIceWallMakerDeltaBuffSpeedScaleByKeyAndValue(ulong DGDDJLEOPBL, float PLNBKKNHAKO)
	{
	}

	public float GetIceWallMakerBuffSpeedScale()
	{
		return 0f;
	}

	public void SetStropSpeedScale(float GLPLIHEECAP)
	{
	}

	public void ResetStropSpeedScale()
	{
	}

	public float GetStropSpeedScale()
	{
		return 0f;
	}

	private float JPIIFPAHIOE()
	{
		return 0f;
	}

	private float LOAMFLKJLHG()
	{
		return 0f;
	}
}
