using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class FDAEPHMIEPC : NAELPAAELNO, GOHFBGHFEJE, IBridgingEntity
{
	public enum DBENAPILEBC
	{
		Rifle = 0,
		Sniper = 1,
		HandGun = 2,
		Knife = 3,
		ShotGun = 4,
		Grenade = 5,
		SubMachineGun = 6,
		GrenandeLauncher = 7,
		CrossBow = 8,
		BuildingGun = 9,
		ExternalMachineGun = 10,
		HealingGun = 11,
		ChargeGun = 12,
		HeavyWeapon = 13,
		SpawnGun = 14,
		GrapplingHookGun = 15,
		HandCannon = 16,
		PaintSprayer = 17,
		ThrowingKnife = 18,
		HandCannonIceWall = 19,
		VerticalManeuveringEquipment = 20,
		SprayWeapon = 21,
		ThrowingKnifeBR = 22,
		NB = 23,
		FakeWeaponRedEnvelope = 24,
		FakeWeaponPersonalUAV = 25,
		ChargeShotGun = 26,
		FootballGun = 27,
		UGCSprayRifle = 28,
		SwingGun = 29,
		AirBurst = 30,
		Shuriken = 31,
		EasterEggTelescope = 32,
		IIVHammer = 33,
		WaterGun = 34,
		BRShopTokenHeatGun = 35,
		NB_ALL = 36,
		ForAll = 255
	}

	public enum IALEJJDKIEO
	{
		SubMachineGun_General,
		SubMachineGun_Vss
	}

	public enum JDCGPDDOMKF
	{
		None,
		SkinGun,
		Attachment
	}

	public enum HDHLILEOEII
	{
		BRShopTokenHeatGun_General,
		BRShopTokenHeatGun_RedPacket
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct CCLHCCJMGID
	{
		[FieldOffset(0)]
		public uint LEOPGGPNNOK;

		[FieldOffset(0)]
		public float LKLILIFNHIK;
	}

	public enum NHMNBDFPMJP
	{
		Explosive = 0,
		Flash = 1,
		Smoke = 2,
		Bow = 3,
		GrapplingHook = 4,
		WaterBall = 5,
		Knife = 6,
		LoadOut = 7,
		VMEHook = 8,
		BigToy = 9,
		Frozen = 10,
		Dummy = 11,
		SnowBall = 12,
		FlameFlask = 13,
		SmokeFlask = 14,
		DeIceWall = 15,
		MultiExplosive = 16,
		EMP = 17,
		AirBurstWeapon = 18,
		FireKunai = 19,
		ThunderKunai = 20,
		WindKunai = 21,
		NBGPHiraishin = 22,
		DreamlandBoy = 23,
		ForceField = 24,
		Bullet = 100,
		MapCannon = 101,
		BlastBall = 102,
		JumpPad = 103,
		HandCatapult = 104,
		PocketRevivePointPlacer = 105,
		Dart = 106,
		AstrolGate = 107,
		LobbySocialDanceGrenade = 108,
		LobbySocialFrozenGrenade = 109,
		LobbySocialPartyFirework = 110,
		LobbySocialFirework = 111,
		LobbySocialScaleUp = 112,
		LobbySocialScaleDown = 113,
		LobbySocialScaleHead = 114,
		LobbySocialDeformHand = 115,
		LobbySocialDeformFoot = 116,
		LobbySocialDeformArm = 117,
		LobbySocialDeformLeg = 118,
		LobbySocialDeformNeck = 119,
		MAX = 120
	}

	public enum BDBGCCPLCHO
	{
		TimeExplode,
		InstantExplode,
		NoExplode,
		Stick,
		ClientInstantExplode,
		TriggerExplode,
		PenetrateInstantExplode
	}

	public enum DKGHCBCDKDO
	{
		Throw,
		ManualTrigger
	}

	public enum JDEJOFPMKJC
	{
		Grenade,
		MissileSecond,
		Missile,
		PenetrateGrenade
	}

	public enum HFPIEIBCFEO
	{
		IceWall,
		BrickBlock,
		Craft
	}

	public enum NBEKMPJLDLD
	{
		Fist,
		Changuo,
		Machete,
		Katana,
		LightStick,
		Sickle,
		Hammer,
		ZombieFist,
		BalloonGenerator,
		Umbrella,
		FunHammer
	}

	public enum KALFGHEAJOE
	{
		DefaultRifle,
		MachineGun,
		ShieldGun,
		PrecisionRifle
	}

	public enum IJNAKGNEDIL
	{
		DefaultMachineGun,
		Kord
	}

	public enum NLMHKJMBAMC
	{
		DefaultSniper,
		Kar98k,
		NoOuterCollider
	}

	public enum LOEOIALJLCE
	{
		DefaultHandGun,
		M1873,
		Vector,
		UZI
	}

	public enum OJOCAGHMJAB
	{
		DefaultShuriken,
		ShurikenReverseFireFeature
	}

	public enum OEJFOJHEEIN
	{
		None = -1,
		Auto,
		Single,
		Three,
		Double,
		Dump,
		Burst
	}

	public enum EHPMMEAHPFA
	{
		Normal,
		NormalFire,
		Sight,
		SightFire
	}

	public enum DFBAIDPKJFN
	{
		Invalid,
		MiniSentry,
		Dummy,
		MagneticField
	}

	public enum FHHGDLPCCJE
	{
		fire_effect,
		second_fire_effect,
		melee_fire_effect,
		gun_trace,
		gun_trace_3p,
		reload_effect,
		bullet_effect,
		shotgun_smoke,
		laser_sight,
		MAX_ENTITY_VISUAL_EFFECT_ENUM
	}

	private enum NHDBAHIEEPP
	{
		EFirstWeapon,
		ERightWeapon,
		EMaxWeapon
	}

	private sealed class PBBAMKDDOBH
	{
		public FDAEPHMIEPC KOKNHFGCGLN;

		public ResourceID OJDIGMJEEHN;

		public float FKJMCGEFJMD;

		internal void NGAHMLMLNDE()
		{
		}
	}

	private const int HOKBEANGPCO = 999999;

	private float DPMIEJHDEEO;

	private static readonly byte[] DNJPLIOABHB;

	private float _003CHJFONIBGAAC_003Ek__BackingField;

	private float _003CONPMPBKNDGA_003Ek__BackingField;

	private bool _003CCLFNOMPJPJP_003Ek__BackingField;

	protected float HNLFGAAHBNN;

	public static readonly int CMKHCDPDPGP;

	public const float MDABFDDJDNF = 0.05f;

	public const float BPFEHCKHFLM = 0.04f;

	protected bool MIGBBFHNKBL;

	public const uint NBAGONFIKAI = 1u;

	public const uint DGHMNOHOHAF = 2u;

	public const uint OJNAGOLEPNI = 4u;

	public const uint FIBKLEENHKL = 8u;

	private JFPPEJHPMNH _003CFLCGCBLDMLK_003Ek__BackingField;

	protected FAHCEKAKGMG KCJFIFMODGE;

	protected FEGPBNJHOLO ECFFNOFKGCM;

	protected AGACNOCEEFP DJMMOHAJFPB;

	protected JMDLFOBDECJ CGBAIPKKHDO;

	protected EDDCGAGJBLO JJMOJGHDLIF;

	protected QTEParams PJBACIIPDJD;

	protected ECEPHAJAGPP FLEBILKODPO;

	protected HADOMIJBNJH MFOBMEOONBL;

	protected MHBJEGBLHBN PGKDKOJMBNL;

	protected JDFHFELHOHN NOKJIEIBJBB;

	protected BCPNECMKNFO EFHOOKENEFB;

	protected WeaponSwitchBySightData EGIECBDDLOL;

	protected JMOJNHKDPDB JOLFPCGPMJE;

	protected WeaponAimAssistAutoAbsorbData JPHDENEEANG;

	protected WeaponMountGrenadeData PIBCJIANPPK;

	protected ANPDKBBGMEL BGDFKJJKBFM;

	protected WeaponMultiLineData HIPBCNCFKNA;

	protected BPDDFABOENF IHODOCEBGKF;

	protected bool NBEPAJFDAFK;

	protected int HBDGPOFPNBB;

	protected bool GENHHHCEMOL;

	private bool _003CFLEMFLHJIGE_003Ek__BackingField;

	protected uint PGMLNMHDCOA;

	protected uint EFFPMIHOEGG;

	protected uint GEDENJIFLDF;

	protected uint JBKBOPDNPHJ;

	protected bool PKKIKJGLCLG;

	protected WeaponSkinData PIAIHONMGDD;

	protected GPOMIKBBFNG ECHINGHIPPH;

	private ArrayMap<MMJDDGALNDP> HKANMKDOCGG;

	protected JNHIOHFMPFN AEBAGCKEJIC;

	protected OPHCLCHELCE MJCBCOBJGOJ;

	protected JLOFMCKFFHB DMAKHBGOLEI;

	public bool GBCPHGGLGEB;

	protected float FAMKPDLKEMN;

	protected float MLGMDJJBJBK;

	private int MMPLDMPMBMO;

	private float NNEMELFFINJ;

	protected bool KPIDOAMNKLD;

	protected float HOOHGIHLAIO;

	protected int LICAGEJEIHL;

	public ResourceID HONGIDFCOEJ;

	private float _003CIMBDNNABIGK_003Ek__BackingField;

	private float EJOJELKIBEI;

	public bool IKNHEDLELIB;

	public bool INCJABOBOAB;

	protected ResourceID HGBJJILGFDB;

	protected ResourceID GAMNOIGACJC;

	protected ResourceID AECJLPPJOGM;

	private ResourceID NKPDIIIFGPO;

	public List<uint> NBLLNFNNOOJ;

	public List<uint> FGKJHKHCLEB;

	public Dictionary<uint, WeaponTerm> NNEALCGMGGL;

	protected bool HDHFGMADEOB;

	protected bool BJBENDOBEEK;

	private float PHCBHFMAODD;

	private const float GHNGLLMJPPB = 0.1f;

	private float LIAPKFIMIHM;

	private float GCAENPKHGJC;

	private bool _003CPNKCCCHLJEN_003Ek__BackingField;

	protected EJNFNOJNCPE OOPCGHFCAAC;

	public const uint PHIHKFIPIGO = 5519u;

	protected int NEOCHCPEMCK;

	protected float KECCBDIMCDB;

	protected int NHELJIIGHFA;

	protected float EGBAMHOHOIN;

	protected float DLODPKIGIFA;

	private float NGDNOIPIEIA;

	private LazyDictionary<int, float> IFPGLIEMLLK;

	public const float MMMEDJDALEN = 0.5f;

	protected int FMDMDFCIAMG;

	private List<ResourceID> PPPAKNFGHGL;

	private MECIKMJPMOP PANBMCMAFKB;

	private bool _003CIKGDMGONCMH_003Ek__BackingField;

	private float _003CIFOCFPNFDEC_003Ek__BackingField;

	private float _003CIEEDGMCKJDD_003Ek__BackingField;

	private float _003CFAPCCPENIBC_003Ek__BackingField;

	private float _003CEBOMNJALGIP_003Ek__BackingField;

	private int _003CNAIJCMKEKLP_003Ek__BackingField;

	private bool DLCDMCFJEHM;

	protected bool DHHLODPEOLK;

	private int HPFCFFCPOIA;

	private bool _003CAPMNKCNOLJJ_003Ek__BackingField;

	private uint _003CDCMNIKDGMOI_003Ek__BackingField;

	private float _003CDCNLNAJOGIK_003Ek__BackingField;

	private LazyDictionary<uint, float> BAGFKGCJAEB;

	protected TssSdtSmallFloat EPPOACFHBOO;

	protected uint ALMIHPIMFHA;

	protected uint CFIIAOJJPGI;

	protected uint OANFPIKBJNB;

	protected uint HDPAPJALEIJ;

	protected float NAGGOHBGHKK;

	protected uint JHPLHPJCAML;

	protected Transform IOLBAPEFNAN;

	protected ResourceID AFCFMHDHFIK;

	protected GameObject LGLNAGLNBJP;

	protected GameObject DMJMNOBACNB;

	protected ResourceID CDFEICJMIAE;

	protected GameObject FLDHFNCFPNN;

	protected TweenProperty[] IOMAGFAOJDE;

	protected TweenProperty[] LBNNFOAMNEL;

	protected Transform NEMENPCAIOI;

	protected Transform DEBAAFBIOIP;

	protected Animator MIAMEAMMKDO;

	protected Animator DCLNBIKOLOI;

	protected RuntimeAnimatorController JAHDGGLNBAM;

	protected RuntimeAnimatorController FPPNPDBOOLI;

	protected WeaponAnimComponent BIJGHLHAABG;

	protected uint PHAHIFIMAFK;

	protected uint KIIPECGPDPB;

	protected uint FHIHBGHKIIK;

	protected uint EIBAHNKHLGP;

	protected uint PBAFAOGMAKD;

	protected uint PDCKPKCMOOI;

	protected uint KGPNBILHCAE;

	protected uint GPELEOCJAHP;

	protected uint KOCPHHDPDPK;

	protected uint EBHEMNHONCI;

	protected uint FKEKENOIKKE;

	protected uint DAKMJBECDBH;

	protected uint HBKLKPCCFPL;

	protected uint EFMIILGJODF;

	protected uint ALOOILCPHHB;

	protected uint CJKHIKNIMPK;

	protected BitArrayBoolean JHMBBODJCDH;

	protected ResourceID DEALKONPMCN;

	protected GameObject BBNJPMOPHJF;

	protected ParticleSystem DACBLANHFFL;

	private ResourceID KLFKMFBJHGC;

	private bool HOKCLDILIMJ;

	private GameObject BJPKNPAFFDG;

	private ParticleSystem PHGLIDAGNOB;

	private bool HLAMFKLKBDL;

	private ResourceID POEPLAHBPBF;

	private const string MAOGOEGDMME = "bone_RightArm";

	private const string JCIMPJEBMPA = "bone_LeftArm";

	private ResourceID KHEEKOCPCJP;

	private GameObject PALHJDFENHI;

	private ParticleSystem DBCNCGBNAOD;

	private int JHDLMAMENNB;

	private UGCWeaponRepItem MDAMCGCCLLM;

	private Action<bool> IMCGCDKFKIA;

	private ManagedVisualInstanceHolder.OnManagedInstanceAttached IPLELBBNNOK;

	protected ManagedVisualInstanceHolder.OnManagedInstanceAttached CGBCBJMAFAF;

	protected bool NMPGNGLJPPG;

	protected ResourceID PPEOJLGNKPL;

	protected uint[] PMEEAPIGAIP;

	protected uint[] BKBKLIJAMFA;

	private uint[] GODHMFFJOOB;

	private UnityEngine.Object[] GMKIHKCFFMM;

	private UnityEngine.Object[] GPCMDEAKJAO;

	private const int ILNGHMFDIJM = 9;

	private Queue<Vector3> AEFKCPGFJNI;

	private Queue<bool> HKKBDCGIAAK;

	protected uint[] LPAOHMNGGHJ;

	private EntityVisualEffectManager HJCIADKBDMF;

	public bool BNAPINPOEII;

	private bool MMKELINFNMI;

	private const float DEAECMHILGJ = 0.5f;

	private uint MAONADHHDLK;

	public bool MKCGOBECDLP;

	private bool ICHHGKKKHNB;

	private int NLIOJDJBAIJ;

	private uint FMAHDJEKPFJ;

	private uint NICNJKBLHNB;

	private bool _003CMOLHALDCNCJ_003Ek__BackingField;

	protected GameObject GFJKJLCHLIJ;

	protected GameObject MGNANCDGJIC;

	protected GameObject BCNOCNMDALC;

	protected bool BBGIIFAIAEG;

	protected bool FEAEMNKMGKK;

	private float OKPKHFBPIGL;

	private bool PBJJMLOOLGH;

	private bool PBLEIALHNMI;

	private uint ICBMMMPFOOH;

	private float EAKCNJFEJEP;

	protected float KHGGPJEKDHE;

	private EJNFNOJNCPE DIODEEIJPIC;

	private EJNFNOJNCPE MAEDAADIHME;

	private EJNFNOJNCPE NOCAFJPIFHF;

	private List<float> FOALAJOELMN;

	private float[] PFMLAGAFABC;

	private int[] JNHDHGHAFKN;

	private float[] HMAEEFKIBOI;

	private float[] HCBKEAAPIHH;

	private float[] FLCLDHGMEKK;

	protected bool AEPEPBJIBJD;

	protected BHGGAEEHJCO MKPLPGELAAB;

	protected ResourceID HPEJILPAIGB;

	protected ResourceID BDLENLKODHL;

	private float BHNHLDLOENC;

	private ECMLFCBMLIC DDOOLHMBFJL;

	private bool NAINCJEEJAF;

	protected BitArrayBoolean ALPOLOPGIPM;

	protected GameObject CHFEMKLEKMM;

	public bool EPJKHKAKCJF;

	protected WeaponAnimComponent BBDENDCIJAD;

	private uint APCKJPLFBEL;

	private Transform IPFPBJJDOOA;

	private Transform FJIGBJNHBIK;

	private Transform DLLIEGHFDHJ;

	private IGOKECDKMIO LGADDOFFNBF;

	private FPPCollectionWeapon ECIMPCGCNEN;

	public string AJMEEOHBMDO => null;

	public float HNILIFHEMCG
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float ELAPEHLBIEA
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool CAELANODJFG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public JFPPEJHPMNH EBIPOBLCEKK
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public WeaponMultiLineData PBGPIKAJMGM => null;

	public uint LOKCMGENNAO => 0u;

	public uint EJGODABJIKE => 0u;

	public uint DHOKKMGKJDI => 0u;

	public bool HEDEKPNOHGC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint CPPPJGHBLAD => 0u;

	public bool ADJHBODGBGA => false;

	protected WeaponSkinData BFCOHCILIFO => null;

	public OPHCLCHELCE OPHCLCHELCE => null;

	public JLOFMCKFFHB GNMNBBBALMK => null;

	public int BAJHCCCEDKN => 0;

	public bool LOIOFKNKDIO
	{
		set
		{
		}
	}

	public float AEGKOONGIDH
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public ResourceID JPFOLICFPBE => default(ResourceID);

	public bool IAGCPECAKOO
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float FCNDLHFFAJO => 0f;

	public float OBADAHDOAKJ => 0f;

	public ArrayMap<MMJDDGALNDP> GFPPIJCLBGD => null;

	public virtual float KPPLKCNCMML => 0f;

	public virtual float HBGLNEIOENH => 0f;

	public virtual float PGJBMNPEINA => 0f;

	public virtual bool DLOHAAEFOBC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual float HJHKEMGPAGL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GNCBKIJABKE
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float EBPLCDDFNCF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float CNPMLFNIMCI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int FGJBLLOENIJ
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool OKLIEBKEOBP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IMPNAIDOIDF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual float AOIMBGOCFJE => 0f;

	public int DIOBDALJAPL => 0;

	public int FMPECBHGOHN => 0;

	public bool PMJMGHJNPFN => false;

	public int KHDAPBLOEML
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int GJEDGBGGAAL => 0;

	public virtual int LLIKCPNFAPO => 0;

	public virtual bool KBACAIEKEEF => false;

	public virtual bool FOPODCGKEOP => false;

	public virtual bool HOEDLNHEFOI => false;

	public virtual bool CNBPFKMMJDL => false;

	public virtual float LDFLFKMMCFP => 0f;

	public float AMPPIADIBMO => 0f;

	public float NDHPBMIEPDL => 0f;

	public float ADMMFGJLBPD => 0f;

	public float NBNDCBLNEEP => 0f;

	public virtual float LDLJAPGNHBE => 0f;

	public float PIFGFPCBJFL => 0f;

	public virtual int FHDPFGHNPJH => 0;

	public virtual DBENAPILEBC KPAKIMLMBBC => DBENAPILEBC.Rifle;

	public virtual int BGKGJKDILEA => 0;

	public virtual int JEFPLNGGCMH => 0;

	public CustomWeaponParams GIGFKKDEAMC => default(CustomWeaponParams);

	public virtual int BMFOKGPHFOL => 0;

	public float HDGGKDLKHIJ => 0f;

	public virtual float FBLBCJOLDMM => 0f;

	public float JFFPONPGFHL => 0f;

	public virtual float MBAHMAKHEKA => 0f;

	public float JOLEGACBIKJ => 0f;

	public virtual float DBJPFJMAFLO => 0f;

	public virtual int AKGPIAMBLHI => 0;

	public virtual int MFNKLGJEAOL => 0;

	public float MHJKONNAKJJ => 0f;

	public float ILJPACNOMCL => 0f;

	public float LODLLAJNLIB => 0f;

	public virtual float GAOKGMGDEIH => 0f;

	public virtual float FKJHOCMLIIB => 0f;

	public float FJLKPAKGJIF => 0f;

	public float AIAADAMNIGC => 0f;

	public string OFIPINNODMK => null;

	public virtual bool MPNJLIBCCEA => false;

	public virtual bool BLGKNCDLPPO => false;

	public virtual bool PAPAPNIPJJL => false;

	public virtual bool DKIAABNDHLB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual uint AKJGPCJFDJI
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public virtual bool PIPPCHAJLOP => false;

	public virtual bool EIHLLFHMKNP => false;

	public bool GIJLCNCAAJE => false;

	public bool OLGHDBLIMGL => false;

	public virtual bool LHMDPKJHBPF => false;

	public virtual bool FJJJCCNJKOJ => false;

	public virtual float KEEJBEDBADP => 0f;

	public virtual float PABMMPJDPFI => 0f;

	public bool NOLOGNOEPHJ => false;

	public float KJOJMOOOANL
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int NHLLCNGEIJC
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	public GameObject JAIIBDGLKMC => null;

	public GameObject BHHIHGBLCIN => null;

	public RuntimeAnimatorController GBHCALDPOAC => null;

	public RuntimeAnimatorController ABPDDBAAHMP => null;

	public bool PJLBKGPNOJJ => false;

	public override bool ABILILEHFNC => false;

	public bool JPMFENAHHGD => false;

	public uint HKDOPKGEHEO => 0u;

	public bool NNCOJEHIKAF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BCPNECMKNFO BJNGEHNAJPO => null;

	public WeaponSwitchBySightData MMOALFFBAHO => null;

	public bool BKBJICEJFPB => false;

	public int BINFDNHCCMP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected int MKOFDNNOFAJ => 0;

	public bool LFJACJIAIJL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool BNEEMDFEMDB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float KHAJBNKBGCD => 0f;

	public bool LILAHDDPJMG => false;

	public float KCFNINNIOLK => 0f;

	public float HCPMOLBCKIM => 0f;

	public float BFAAOAPDBDO => 0f;

	public EJNFNOJNCPE HBMICKAJNLG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EJNFNOJNCPE LCINLNFGGHK
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCWeaponRepItem OENHJBAANME
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected bool GABFGHJEHBC => false;

	protected GameObject HFMAOPLMHNM => null;

	protected bool JEFMGEMLFLO => false;

	protected int OHPAKMLCGNA => 0;

	protected bool JCLLEOGEDJF => false;

	public bool GBCNMOKEEBA => false;

	public GameObject CCMPMPCMINI => null;

	public Transform DEOGKMEEDIE => null;

	public Transform FLOPOAOGGHO => null;

	public IGOKECDKMIO ICGBHMMINMI
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public FPPCollectionWeapon EPPHEPPPEBD
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	private static float JMCENJNEHKE(uint EJBLLGOMAIC)
	{
		return 0f;
	}

	public static bool IHAKKAEDBOP(DBENAPILEBC NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	public static bool JHAANGPINDK(DBENAPILEBC NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	public static bool LDIHIFIGJIO(DBENAPILEBC NJMMDDMIION, int KJAEDIGHOMN)
	{
		return false;
	}

	public static string AOIKDFKMDPF(DBENAPILEBC NJMMDDMIION, int KJAEDIGHOMN)
	{
		return null;
	}

	public void AKJMNDLDBCC(bool GFOBGICLKCE)
	{
	}

	public virtual AGACNOCEEFP NCKOBFFNHEG()
	{
		return null;
	}

	public virtual uint MNFGOECIHEH()
	{
		return 0u;
	}

	public ResourceID GPBAIHHDJCH()
	{
		return default(ResourceID);
	}

	public MECIKMJPMOP JOEFBAANGMH()
	{
		return MECIKMJPMOP.CombineType_None;
	}

	public bool EELKDFFECME()
	{
		return false;
	}

	public EDDCGAGJBLO JECDGLNIBLG()
	{
		return default(EDDCGAGJBLO);
	}

	protected virtual float IEPLDNPMOMN()
	{
		return 0f;
	}

	protected virtual float CMNPMINLOAA()
	{
		return 0f;
	}

	public float DDLLJALOHGI()
	{
		return 0f;
	}

	public float CAIIAGJBBND()
	{
		return 0f;
	}

	public void AFPOGMDEGHA(float JHLNMNMLGPB)
	{
	}

	public float KDICACPIBEH()
	{
		return 0f;
	}

	public void IFAAJGJFNNM(float JHLNMNMLGPB)
	{
	}

	public int JNGKDNDLHGB()
	{
		return 0;
	}

	public void EFGDEDJAHPJ(int JHLNMNMLGPB, float AOOCNKPILEO = 0f)
	{
	}

	public float BODMFLICABF()
	{
		return 0f;
	}

	public float OEAELNBHBDL(bool JGGNLPPGMIF)
	{
		return 0f;
	}

	public float KJDPBBENCHH(bool JGGNLPPGMIF)
	{
		return 0f;
	}

	public int CFMGPLDCEGD(float IFDHHGECCCM)
	{
		return 0;
	}

	public int HCDPBGBENGM()
	{
		return 0;
	}

	public JDFHFELHOHN KBNLLCPNAOK()
	{
		return default(JDFHFELHOHN);
	}

	public float BDHDIPJEIJG()
	{
		return 0f;
	}

	public float OCKNGJJMOGF(int OPOEOPALIHP, int EAECMDACGBN)
	{
		return 0f;
	}

	public override void IPBPLNPADJG(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	public override void IMPCADBKDCP(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	private void AEJPMMJOJPB(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	private void OIBAAKEJDDI(bool GFHLCBIODKL, ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	public void JPAMFOEKKHE(ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	private void KMLBDDNFMCF(bool GFHLCBIODKL, ref ICollection<ResourceID> CFJCHCNHHLA, ref ICollection<ResourceID> HKEDEILHOGE, ref ICollection<ResourceID> PDCPGCDKNNB)
	{
	}

	protected virtual void BJLOFMGPHNA()
	{
	}

	public virtual void BAECJPPEODH()
	{
	}

	public bool PGIGNJDKEIF()
	{
		return false;
	}

	public bool FMJKFDEPEOG()
	{
		return false;
	}

	public bool ICPBCIHHIAH()
	{
		return false;
	}

	public Player OCGODHJGEEE()
	{
		return null;
	}

	public bool BOMNGMFFMEO()
	{
		return false;
	}

	public bool BOGAOGIENOK(uint CBCAJJJCKLH)
	{
		return false;
	}

	public float KFPMELMHFAF()
	{
		return 0f;
	}

	public float NDHCLBDCGIJ()
	{
		return 0f;
	}

	public float PADIHKAALDJ()
	{
		return 0f;
	}

	public float CLCBHNGIOGB()
	{
		return 0f;
	}

	public int HNFFNLLHAHG()
	{
		return 0;
	}

	public bool PFOJNPFFIFO()
	{
		return false;
	}

	public void JLOMKOGCKJE(int GPFPIAMCEMI)
	{
	}

	public uint BGJMNBFHCHJ()
	{
		return 0u;
	}

	public virtual bool IPNIOKMIBEN()
	{
		return false;
	}

	public virtual bool CILCEDKNGCG()
	{
		return false;
	}

	public virtual void JABHLBACLCN(int KHDAJCLICDL)
	{
	}

	public virtual float GIGNHDADPKO(float HKJKEJONGMC)
	{
		return 0f;
	}

	public bool NMIKILBOOFD()
	{
		return false;
	}

	public float MPGHCHIJGBE()
	{
		return 0f;
	}

	public virtual float BAGLBAIJAOC(bool LAKDHNBNKMD)
	{
		return 0f;
	}

	public virtual float ENNALFDFBFJ(bool LAKDHNBNKMD, bool PJPOJJCHIHA)
	{
		return 0f;
	}

	public virtual float HBFALJBFMBK(bool LAKDHNBNKMD, bool PJPOJJCHIHA)
	{
		return 0f;
	}

	public virtual bool OHDIKHBDBPJ()
	{
		return false;
	}

	public bool IODMMCPMMOG()
	{
		return false;
	}

	public virtual bool OIOKNCMOJCO()
	{
		return false;
	}

	public void HAHGEOADFHM()
	{
	}

	public bool OKBPKFPOGGO()
	{
		return false;
	}

	public bool BABNNPPONHE()
	{
		return false;
	}

	public void HEIMOJJKNHB(float CBDFCKAONJG)
	{
	}

	public virtual bool EHBAIGFLNGH()
	{
		return false;
	}

	protected virtual bool GKEPLLOJDHK()
	{
		return false;
	}

	private float OBCAPDDGHGE(float AMJAOEOPAEM, float FAONLDMNLPM)
	{
		return 0f;
	}

	private float AKJJMJLOLFJ()
	{
		return 0f;
	}

	private float HCADKHMEFGC()
	{
		return 0f;
	}

	private float FJHNKNODLJP()
	{
		return 0f;
	}

	private float KPLCLBIJLJA()
	{
		return 0f;
	}

	private float LJMMNALGEAK()
	{
		return 0f;
	}

	public virtual float HBHIBGLDDJF()
	{
		return 0f;
	}

	public float JOEKFHCNHCL()
	{
		return 0f;
	}

	public virtual float MHIBMKGNFDP()
	{
		return 0f;
	}

	public bool DNGOIACCBAB()
	{
		return false;
	}

	public bool MCDMDJNJLIM()
	{
		return false;
	}

	public virtual bool DKMFEIHNCBJ()
	{
		return false;
	}

	public virtual bool FPOAJJJPOID()
	{
		return false;
	}

	public bool DEINBGDFJHE()
	{
		return false;
	}

	public override bool GBGFFPBPKKP(Player LDCIMNAAGNO, uint HMEEAGECFIO, uint PNLDKNOFPNG, HENEHAGJCLI BGDIPMPKKCE, object[] PJDELDCADEA = null)
	{
		return false;
	}

	public EntityVisualEffectManager GOKDPINCDCJ()
	{
		return null;
	}

	public void DLJEDKMANFI(FHHGDLPCCJE BIIDIBMHMPJ)
	{
	}

	public void IOHAJHALMMD(FHHGDLPCCJE BIIDIBMHMPJ, uint JDHNCLHNJIP)
	{
	}

	protected void LANENCFNMCE()
	{
	}

	private void MHIIOAPBJAN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void IKELFFJJDJL(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	protected void NKNMLEMOHBI(int GNLIAKMGDDG)
	{
	}

	private void BGLFLHDOADB(int GNLIAKMGDDG)
	{
	}

	protected void ALODMMMJCGN(GameObject ABOFACKMLIB, GameObject NDEIHNALHJN)
	{
	}

	protected virtual void NJCAAAAKAON(int GNLIAKMGDDG)
	{
	}

	protected virtual void PJLIGOCBLML()
	{
	}

	protected void BBPGHMMFEKM()
	{
	}

	private bool OAHBFHBPLFB()
	{
		return false;
	}

	protected virtual void EKBPFHKFDEB(GameObject EBNOJFHOJDI, bool MPDLAAKEEEJ)
	{
	}

	public static void OKCDKPIBPNK(Player LDCIMNAAGNO, AGACNOCEEFP NGJDOCHFBKJ, ref List<ResourceID> CFJCHCNHHLA)
	{
	}

	public override bool JJHDLCBBFLN()
	{
		return false;
	}

	protected bool IKDGPHJHLNG(ref GameObject OBLFFNAEEJL, bool BNKAAAHGFFM = false)
	{
		return false;
	}

	protected ResourceID KHMMADCCAOC(AFOLPMOCBOG LBANGCILPHD, bool AJOJFMAAPCP = false)
	{
		return default(ResourceID);
	}

	protected ResourceID IBJEFOIKCBP(AFOLPMOCBOG LBANGCILPHD, bool AJOJFMAAPCP = false)
	{
		return default(ResourceID);
	}

	public bool GFKBJDEIBLH()
	{
		return false;
	}

	public void AKLJGFJBMHJ(Action<bool> HALOHOFFOKJ)
	{
	}

	public override bool LABDBGOHLDM()
	{
		return false;
	}

	public virtual void BHFOCBHDOHE()
	{
	}

	private void MELLKCIPCEA()
	{
	}

	private void KKKLMEMDDHP(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private bool MAFFJOJCOLN(GameObject OBLFFNAEEJL, ResourceID GIHOBKADMFA, GameObject JOILNNNFOIJ, ResourceID ILEMGKDHCCD)
	{
		return false;
	}

	protected virtual ResourceID FGIAJLDJJKJ()
	{
		return default(ResourceID);
	}

	protected virtual RuntimeAnimatorController AFKANGOKAAG()
	{
		return null;
	}

	public RuntimeAnimatorController HGOAFCHAJEC(ResourceID GGMIDNEJGNO, bool JODKBLFEGKH = false)
	{
		return null;
	}

	private RuntimeAnimatorController EHCMPPOICHJ(RuntimeAnimatorController EMANEBGLLJG)
	{
		return null;
	}

	protected ResourceID PHEBMNNNANH()
	{
		return default(ResourceID);
	}

	protected virtual RuntimeAnimatorController BBCJHEOCMHN()
	{
		return null;
	}

	public RuntimeAnimatorController DJHGENFPNPB(ResourceID OCCLMDNGINA, bool LBCGFCJJLJO = false)
	{
		return null;
	}

	public void LFGBCBCEGBI()
	{
	}

	internal virtual bool LMNGOJOJFNM(AGACNOCEEFP NGJDOCHFBKJ, GameObject EBNOJFHOJDI, ResourceID HFDLMMAMBDA, GameObject PMOHBCDLANA, ResourceID EHONGLBNEKH, FEGPBNJHOLO FOPJPFLKCOJ = null, JFPPEJHPMNH GELODLKMOPJ = null)
	{
		return false;
	}

	protected void KDNLMFCCJOB()
	{
	}

	private void JKHJHJMCOED(GameObject HACIJIFIDKM)
	{
	}

	private void ALIDLGDKGMK()
	{
	}

	protected virtual RuntimeAnimatorController LENDCEGPKED()
	{
		return null;
	}

	protected virtual ResourceID NCNACHJKIEJ()
	{
		return default(ResourceID);
	}

	protected virtual RuntimeAnimatorController AOFFOJKGALG()
	{
		return null;
	}

	protected virtual FEGPBNJHOLO BKJAHPAFJGD()
	{
		return null;
	}

	public override void JBGCLEHFLAF()
	{
	}

	public virtual void DAOAOOJMAJP(bool FKJMCGEFJMD)
	{
	}

	public uint ACGEFCIADCL()
	{
		return 0u;
	}

	public uint NIAJIOKBJLO()
	{
		return 0u;
	}

	public JDCGPDDOMKF GLIPMOENJOJ()
	{
		return JDCGPDDOMKF.None;
	}

	public bool DPLFOGPHAJC()
	{
		return false;
	}

	public virtual void BNOENNDDMNB(OAICFPKEJNE BEEACJDCBBE, KKLOIPIACBL APHHNHEDHKD)
	{
	}

	public float KFLGFLMAOHH(MFHOLGEKNLI EDPEPPDDJBJ)
	{
		return 0f;
	}

	public float BNHOFAINFDD()
	{
		return 0f;
	}

	private void KLLPNGBKOKM(MFHOLGEKNLI EDPEPPDDJBJ, float GPFPIAMCEMI)
	{
	}

	public virtual void IAHCEGKCGLN()
	{
	}

	public void JKBKFNIFEMD()
	{
	}

	public virtual ResourceID DMKMFENCAPJ()
	{
		return default(ResourceID);
	}

	public virtual RuntimeAnimatorController DCPLAHKIOIO()
	{
		return null;
	}

	public virtual void HBGLJLIIIDL(bool NCPDGPCNCII)
	{
	}

	public virtual void LCDLCDEHJPP(bool ILLNDPKJAFD)
	{
	}

	public virtual void EHMEBFDGOOH(bool ILLNDPKJAFD)
	{
	}

	public virtual void KJLKIKEDIFB(bool ILLNDPKJAFD)
	{
	}

	public virtual void DEHEHBCCJCN(bool ILLNDPKJAFD)
	{
	}

	public virtual void PFPDJPOCHAJ(bool CENDKAONEDG)
	{
	}

	public virtual void MECOPPPBHMJ(bool AOGGADPEFCC)
	{
	}

	public virtual void CJKPMEOIEDG(bool AOGGADPEFCC)
	{
	}

	public virtual void LAOHGJBNOME(bool AOGGADPEFCC)
	{
	}

	public virtual void LLFFKEEOLDA(bool NIPCALFAJKB)
	{
	}

	public virtual void ECHPIIEFEDM(bool KADPAKEGBCA)
	{
	}

	public virtual void NGHOFCBPHBF(bool NMBDCECLKML)
	{
	}

	public virtual void NBIIMPNBCLB(bool FKJMCGEFJMD)
	{
	}

	public override void HEGAMHJNIKJ(bool NDGMENGEGIE)
	{
	}

	public virtual void MLPLNIOIEAK(int PNLKPJNLDGB)
	{
	}

	public virtual void LACFGPAKDCO(bool CPMAPKLECMI)
	{
	}

	protected virtual void ABPBCPGLEEC()
	{
	}

	public void HMBPAMEPKIK(GIANNEDDMLL[] GFPPIJCLBGD)
	{
	}

	public bool BEOFFODNAKJ(HENEHAGJCLI DLOMCIHJJJG)
	{
		return false;
	}

	public bool BEOFFODNAKJ(object EIPDLBHGOPF)
	{
		return false;
	}

	public bool MENMGGIJGCK(GIANNEDDMLL NPFJPEGLPEI)
	{
		return false;
	}

	public void GGDFPGGOCBF(object EIPDLBHGOPF)
	{
	}

	public void IBKDAFFFKJD(object EIPDLBHGOPF)
	{
	}

	public void LDECENOLNLD()
	{
	}

	public bool OMIIHEPPKKH()
	{
		return false;
	}

	public bool EJNDJDLDBFI()
	{
		return false;
	}

	public void NEELIFAOMOJ()
	{
	}

	private void KCAEMJKALGH()
	{
	}

	private void MJLLLFBDLEF(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void MGCLDEJKLNB()
	{
	}

	private void IACDFAAJHDE()
	{
	}

	private void COEFDOAFNFC()
	{
	}

	private void LAKDGCOILCG(object[] JCONDDPFBKK)
	{
	}

	public object KLPBHDNNPFI(int IJEAILJPPEI)
	{
		return null;
	}

	public bool AGNMDFJLFHP(GIANNEDDMLL NPFJPEGLPEI)
	{
		return false;
	}

	public bool MNDNBHMLDBI()
	{
		return false;
	}

	public MMJDDGALNDP GCKMHMBJGEC(GIANNEDDMLL NPFJPEGLPEI)
	{
		return null;
	}

	public object DBKOJBIIMAK(uint NFGBJLPCCMG)
	{
		return null;
	}

	public void NAAMFGCCHNN()
	{
	}

	private void KKPKPFMALIK()
	{
	}

	public override void LNCNPFBPMBP()
	{
	}

	public virtual void CFEABFEAAFK(bool NIDHGNGEBEL = false)
	{
	}

	protected virtual void NDHNODPLCMK()
	{
	}

	public void NKMAGPLBCOM()
	{
	}

	public void KLEICKHDIIB()
	{
	}

	public void CBOJICHKMHO()
	{
	}

	public void MDDEIAGFKPD()
	{
	}

	public override void LILEEJOFLPJ()
	{
	}

	public override bool NCHAMAGEDPD()
	{
		return false;
	}

	public virtual void AELICMGKCLE(float NKNNPEMLIGD)
	{
	}

	public virtual void LPLACPJHBAE()
	{
	}

	public virtual void MKBLPPEEEFB()
	{
	}

	public virtual void CIDMNJMDJBJ(float OGGAHALDFOL)
	{
	}

	public virtual void GGNGBPIIHPP(float NKNNPEMLIGD)
	{
	}

	public virtual void IKIDFHPGIFM(float NKNNPEMLIGD, bool GJMJDOELOPA)
	{
	}

	public void FHHLOOGNLHI()
	{
	}

	public void HNJJAFADHNF(bool HDNGFBOJOIA)
	{
	}

	public bool PHBEKPOFMNG()
	{
		return false;
	}

	public virtual bool IHMLCIJAGMH()
	{
		return false;
	}

	protected bool PNMPMJGELNG(ResourceID GHDLAAEMJDO)
	{
		return false;
	}

	protected void BMKFDFGOFEK()
	{
	}

	public virtual void JIKJLNIDDDJ(bool BOJIDHIFINO = false)
	{
	}

	public virtual void GNGLCPOGCCN(bool NMLHNDMIOOD, bool KPDCILHJOBF = false)
	{
	}

	public bool NPIDHMOLEJP()
	{
		return false;
	}

	public bool HEJMHBGFODD()
	{
		return false;
	}

	public virtual void OBACLCKINNJ()
	{
	}

	public virtual bool ILPKDKNNGMM()
	{
		return false;
	}

	public void ELBHJIBFNIH()
	{
	}

	public void BLAKDHHJMOP()
	{
	}

	public bool FDBBGKKPMEF()
	{
		return false;
	}

	public bool IKMOMNMEDCL()
	{
		return false;
	}

	public void KMGPLEMDLGO()
	{
	}

	public void GMCAKKOCPAH()
	{
	}

	public void NPKNOFGAJAM()
	{
	}

	public override void IBEJJIDOLMH(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void KJLHPJENIGL()
	{
	}

	public virtual void HBENOEMEFMA(bool FKGFFFGNCNG)
	{
	}

	public virtual bool KOOFCFDOOAB()
	{
		return false;
	}

	public virtual bool FCFPPNPJELL()
	{
		return false;
	}

	public virtual bool HPCJOELCLED()
	{
		return false;
	}

	public virtual bool GJJGDFBFGEL()
	{
		return false;
	}

	public virtual bool MMBMEOCICPE()
	{
		return false;
	}

	public virtual bool GHKGIKALKEF()
	{
		return false;
	}

	public virtual bool CHPAJIDOBLH()
	{
		return false;
	}

	public virtual bool CNLOJJBOIFB(bool JGGNLPPGMIF = false)
	{
		return false;
	}

	public virtual bool MONENFLFFCA()
	{
		return false;
	}

	public virtual bool MAOANEMAAGM()
	{
		return false;
	}

	public bool ENELDHPPONN()
	{
		return false;
	}

	public bool FBMGJEJEGMB()
	{
		return false;
	}

	public bool KOOIICDCIIM()
	{
		return false;
	}

	public bool GLMFGNMLKAL()
	{
		return false;
	}

	public virtual bool ACGBDDIMJMP()
	{
		return false;
	}

	public virtual bool FBJAMKGDFIO()
	{
		return false;
	}

	public override void IAAJNKPKJFL()
	{
	}

	public override void LBKODCNLHFD()
	{
	}

	public override void MGAMBOMLCIB(float OKJIFBCMDAD)
	{
	}

	public override void AAKFKAJNILD(bool GOKFNGGAGKF = false, bool JNFNLEEFGHN = true)
	{
	}

	public virtual void FJOIMJLGJKD()
	{
	}

	public virtual void GCINCMJCFDL()
	{
	}

	public override void HDMKBLLDNGJ(bool AFENPIJKMFA)
	{
	}

	public virtual void ECPFOMEINAE()
	{
	}

	public virtual void CLAPPENNMPH()
	{
	}

	public float AEKEOFAONAG()
	{
		return 0f;
	}

	protected virtual void FIPOEKNCJLO()
	{
	}

	public float FICLNJHMBIL()
	{
		return 0f;
	}

	protected virtual void EBEMBCDDAIH()
	{
	}

	public void CLHHIOHDDCO(uint FOKBKNEBJEB)
	{
	}

	private void BDOCLFLHPLA()
	{
	}

	private bool EBPOAEOFICK()
	{
		return false;
	}

	private bool AKJPKOLNDEJ()
	{
		return false;
	}

	public bool CCKEBFCJMMH()
	{
		return false;
	}

	public bool EBPHNNPNBAF()
	{
		return false;
	}

	public int CIIPEIFOOAD()
	{
		return 0;
	}

	public float AMNPEKHFONL()
	{
		return 0f;
	}

	public uint PACBJNKCMKM()
	{
		return 0u;
	}

	public int MBGBBJHHEBJ()
	{
		return 0;
	}

	protected virtual bool OBKKLHBLMAA()
	{
		return false;
	}

	public virtual void BJBCCDLPCFE()
	{
	}

	public virtual void HLCIMOJFAOM()
	{
	}

	public virtual bool PFGHNAHOJCE()
	{
		return false;
	}

	public virtual void AMBIBKLKGNB()
	{
	}

	public override void IKJMLNGEBHN(HDAEFOANBGJ EBGFBLIANGI)
	{
	}

	public override void PPKCCNPEIMA()
	{
	}

	protected virtual void OAFMLLHEMND()
	{
	}

	public override void ADHECLOECCM()
	{
	}

	public virtual void MJKOAHAKHOK()
	{
	}

	public virtual void FMOBBKAPFNH()
	{
	}

	protected void FKBONDBNDDC(AGACNOCEEFP JCONDDPFBKK)
	{
	}

	protected virtual void NCDOCLGNOPF(bool IHNGEPPCPBK = false)
	{
	}

	protected virtual ResourceID CCLGMHACCPD()
	{
		return default(ResourceID);
	}

	protected float BGEAEENLACL()
	{
		return 0f;
	}

	public virtual void MPAHAJHEEAM(float KFIBPMGCPIB = 0f)
	{
	}

	public virtual void EHOAKPFBCCM()
	{
	}

	public virtual ResourceID IKLKALDJADO()
	{
		return default(ResourceID);
	}

	public virtual ResourceID PAHAIEKIEMC()
	{
		return default(ResourceID);
	}

	public virtual ResourceID AJKNCHFJDKF()
	{
		return default(ResourceID);
	}

	public virtual ResourceID KAMACBFLEMH()
	{
		return default(ResourceID);
	}

	public virtual ResourceID CIHEFAJFFEE()
	{
		return default(ResourceID);
	}

	public virtual ResourceID MHMJCPNHCOI()
	{
		return default(ResourceID);
	}

	public virtual void OLKGNBLCLNI(float GOMNGFFGLKD)
	{
	}

	public virtual void DMIMMMOLEDF()
	{
	}

	public virtual Quaternion ONLAOILLJDE()
	{
		return default(Quaternion);
	}

	public virtual Vector3 JNDOOCCPNKI()
	{
		return default(Vector3);
	}

	private bool MDHFKOCOLNI()
	{
		return false;
	}

	private ResourceID OEACGAEPEFL()
	{
		return default(ResourceID);
	}

	protected virtual void EIJPLCGIKNH()
	{
	}

	private void DNENKHFBFNL()
	{
	}

	private void DIILGNJAMKL(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	protected void EFCAMCEFGAD(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void FLDCJAFGEEN()
	{
	}

	private void IJHLDIHHKKL(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void FKNAIOPFGFE()
	{
	}

	private void LHIHCFPEFPG(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	protected virtual void CLDKCGEKGBE()
	{
	}

	private void COFCOJFLLDP(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void JJJFDBHOFKE()
	{
	}

	private ResourceID EIAKAPBBHLG(bool MFDADHIGFAM)
	{
		return default(ResourceID);
	}

	private void DOLGPMMBADG()
	{
	}

	private void GGLKBJEOKEJ(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void CNDIAAHNAGG()
	{
	}

	private void IAIKCKEMNCH()
	{
	}

	private void PADCMCHJAFG(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void EAAODDLEFLH(GameObject CLACOPMJHDI)
	{
	}

	protected virtual void LCFCDBENFPG()
	{
	}

	protected bool KOHGENDHOKL()
	{
		return false;
	}

	public virtual void EFLFOGGEIFH()
	{
	}

	protected virtual void KHIMOMPCMBM()
	{
	}

	protected virtual void KBBLLFDOFLC()
	{
	}

	protected virtual GameObject LJMBJBMIBDK(ResourceID AOFCDPKJKJO)
	{
		return null;
	}

	public virtual void LMBNLNMIGOA(Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD, GameObject DLJLLLHBHAH = null, short OEBHIPIHALI = 0)
	{
	}

	public MLJNBIIJBKE IDGNAPCANND(float GBMIINKMLBC)
	{
		return MLJNBIIJBKE.None;
	}

	public Vector3 FCHBFNKFKDI(Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD)
	{
		return default(Vector3);
	}

	private KNCFNJLGPDM GABABFOKAIE()
	{
		return KNCFNJLGPDM.Local;
	}

	private void MBJELKCBKDL(PCGunTraceEffect DHJMMGHNCKJ, Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD, bool BJCMIGBEHHE, bool KDEEPLDCJNL = false)
	{
	}

	public virtual void ALJINBJLIFI(GameObject OIKEGHIGGBE, Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD, bool BNEAHALINFB = false)
	{
	}

	public virtual void JDIOHGPICMF(Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD, Vector3 BJFKBEIFNON, GameObject DLJLLLHBHAH = null)
	{
	}

	private void GIPCMKGFKNH(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	protected virtual bool LBAPFNMDOFP()
	{
		return false;
	}

	public virtual void OHDAIIMPFFP(GameObject OIKEGHIGGBE, Vector3 OCLFLNINDAP, Vector3 MNBPEEDKIAD, bool BNEAHALINFB)
	{
	}

	private ResourceID DILBGMKLCFL()
	{
		return default(ResourceID);
	}

	private bool MGFAPPHMBPA(GameObject DLJLLLHBHAH)
	{
		return false;
	}

	protected virtual ResourceID MKHADNPCHDC(GameObject DLJLLLHBHAH = null, short OEBHIPIHALI = 0)
	{
		return default(ResourceID);
	}

	private bool ADFHFPPFBDF()
	{
		return false;
	}

	private void JPFHCJIBOAL(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private bool LOFKLNPMOHL()
	{
		return false;
	}

	private void FKINOLGOGBC(GameObject LDAODILGGOH, float ABPKDCKICLA)
	{
	}

	private void IANAAGAHADE(bool KGOHDEBHENF)
	{
	}

	public bool LGAMDCIDLBO(float ABPKDCKICLA)
	{
		return false;
	}

	public bool KMFDANNOMEG()
	{
		return false;
	}

	public uint CFHEFPDMGII()
	{
		return 0u;
	}

	public uint PAMDCKLHENH()
	{
		return 0u;
	}

	public virtual void KCKLGPLBMEN()
	{
	}

	public virtual bool BJGIFCMLIDA()
	{
		return false;
	}

	public virtual bool DDANBCBFGLA()
	{
		return false;
	}

	public virtual bool CAGLNJJMNIB()
	{
		return false;
	}

	public virtual bool POJNMMLKDAC()
	{
		return false;
	}

	public virtual bool JAHCLGNDKDG()
	{
		return false;
	}

	public virtual bool FMACIGCNIKC()
	{
		return false;
	}

	public virtual bool KPMOFEGLKCE()
	{
		return false;
	}

	public DCKEBAKIIKP GEINJMBAHGI()
	{
		return (DCKEBAKIIKP)0;
	}

	public virtual bool JOLOBDDHJMO()
	{
		return false;
	}

	public bool KNGNNLPHLAC()
	{
		return false;
	}

	public bool DKEOECMNDGF()
	{
		return false;
	}

	public bool KDHEDPBPIMF()
	{
		return false;
	}

	public virtual bool OMPDFJHKHJF()
	{
		return false;
	}

	public virtual int PCNDPPAEIIP(GMPGMPFNMFP NKEPDPFIOFJ, MonoBehaviour HACIJIFIDKM = null, float OBNPLABHICH = 0f)
	{
		return 0;
	}

	public void JKHABBNBFDG(GMPGMPFNMFP NKEPDPFIOFJ)
	{
	}

	public virtual Vector3 HPPEOBCHJLL()
	{
		return default(Vector3);
	}

	public bool FGPHKCMGGAD()
	{
		return false;
	}

	public Transform PPBDNCCHMJD()
	{
		return null;
	}

	public void KDIPAEGAIFL(GMPGMPFNMFP NKEPDPFIOFJ, MonoBehaviour HACIJIFIDKM, float OBNPLABHICH)
	{
	}

	public void GLKBNFHNAIL()
	{
	}

	public void JLFIOHEEEEL()
	{
	}

	protected virtual bool EFFAJEKLDDP()
	{
		return false;
	}

	protected int KOODEKEKFEK(GMPGMPFNMFP NKEPDPFIOFJ)
	{
		return 0;
	}

	public virtual void OCACCODLOFG(bool BBDKHFIEBIL)
	{
	}

	public override void PAGCEKFEMBC()
	{
	}

	private bool DMJKACEDLDM()
	{
		return false;
	}

	public void GCNHNKIFLEO(int BABOFFHCAHJ, float CFACCMOANKI, float PDCPBGHLLFG)
	{
	}

	public void GPKDAFPCKBO(float PDCPBGHLLFG = 1f)
	{
	}

	public virtual bool APGNLENEEIF(DBENAPILEBC NJMMDDMIION)
	{
		return false;
	}

	public bool ACNFOKIKCMM()
	{
		return false;
	}

	public virtual int DHPIALPBGFG(float DJMFAOODDFJ)
	{
		return 0;
	}

	public virtual float IJDLEHDPKFN(bool KHDAJCLICDL)
	{
		return 0f;
	}

	public void CBMKOIALKLK(ref bool KMPLOBEDKIL, ref bool FPACAMFMHJK)
	{
	}

	protected virtual float KPDLKLCIBGI()
	{
		return 0f;
	}

	public float FKNBFMEHJIO()
	{
		return 0f;
	}

	public float BHPDINMLCOA()
	{
		return 0f;
	}

	public float NOLFHFFHPNE(float NMNOEMLKCEH)
	{
		return 0f;
	}

	public Vector4 KIGKJKAFPJO(Vector4 NMNOEMLKCEH)
	{
		return default(Vector4);
	}

	public Vector4 EJIFBDJCGEI(Vector4 NMNOEMLKCEH)
	{
		return default(Vector4);
	}

	public float BOMFALJPLJC(float DJMFAOODDFJ)
	{
		return 0f;
	}

	public bool DCJADPGOHMK()
	{
		return false;
	}

	public virtual float CIKHOJECHCG()
	{
		return 0f;
	}

	public virtual float DCBEANEOIOP()
	{
		return 0f;
	}

	public float AMPFKKOFOGG()
	{
		return 0f;
	}

	public void MHHBDBCHEKK()
	{
	}

	protected virtual void GAEPEFGGIDL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void DPJFINFFHNK()
	{
	}

	private void NDLAFKMLIOD()
	{
	}

	public void LHJFIFDCGAL()
	{
	}

	private void BMMEPMFAEHF()
	{
	}

	public bool OPHCBMNOMFD(GIANNEDDMLL GELBENFHBJN)
	{
		return false;
	}

	public float KHAPBJIBEHE()
	{
		return 0f;
	}

	protected virtual void GEOEJHNFCAE()
	{
	}

	private void DGJPADFIJBA(CPLMBOBGNFE AIHBBKMCMEI)
	{
	}

	private void OODNAGHJGFG(EJNFNOJNCPE EOCLMAIEFGI)
	{
	}

	protected LFAAGMJOKHG PKHJIELHLAK()
	{
		return null;
	}

	protected virtual void MLCJMAMCBBN()
	{
	}

	protected virtual void KEDKOCKEGDI()
	{
	}

	private void CMCFKEEBBCA(EDDCGAGJBLO LIGDBKIBPIG)
	{
	}

	private void EJGOBINCCJE(float ANHPOBODDNN, int AKECMLNMBEO, float IMDCHKIKHHH)
	{
	}

	private void DIDHPHLKKCB(float CNKMEPFCJOM, int DDIJPPMPBJD, int CLPBMIOOIGD)
	{
	}

	protected void BGCKPLPDNHF()
	{
	}

	public bool GHIALPGBEFO()
	{
		return false;
	}

	public bool MEBKACJNLFI()
	{
		return false;
	}

	public bool HLKLHEDGMHH()
	{
		return false;
	}

	public void JHPKECADLKI(EJNFNOJNCPE PDBMIGJBLAE)
	{
	}

	private EJNFNOJNCPE PJIAONEFFIE()
	{
		return null;
	}

	public float GMPNHDHHHGC()
	{
		return 0f;
	}

	public bool AHEDOMJDHGL()
	{
		return false;
	}

	public virtual void IKCDBOOLKLE()
	{
	}

	public virtual void PLICFMHMDKD()
	{
	}

	public virtual bool HPHJEGCOHDF()
	{
		return false;
	}

	public virtual void MMCHCHFMKFO(bool HIDFPAJBEMF)
	{
	}

	public bool MAIHIKGGNLH(GameObject DLJLLLHBHAH)
	{
		return false;
	}

	public bool DOFHABFGFGC(GMPGMPFNMFP NKEPDPFIOFJ)
	{
		return false;
	}

	private void IJBAPAJAINA(List<float> LFLPGCMLPFM, uint ACBGNPCFOME)
	{
	}

	private void OALHJIDICJI(OKEAMEELLBB HNMMPKNLJBH, float PLNBKKNHAKO, float GLPLIHEECAP)
	{
	}

	private float IDFHLCGNKOP()
	{
		return 0f;
	}

	private List<float> LKHKGOFALIB(OKEAMEELLBB HNMMPKNLJBH, Collider NPEMKNFIIHL, bool OMMJNLDFCCE = false, GLLLEDKLLDA PMMCGNJHOOA = null)
	{
		return null;
	}

	private void CMHACDIEHIA(bool GKPCGBDPNAN)
	{
	}

	public override void EEAHIMOAENF(bool GBLMFCPGODI)
	{
	}

	public override void IAAKMPGAPOB(bool IKHPLOJNKPM)
	{
	}

	private void AKOJMIKGLHG()
	{
	}

	public void FDBFDDNNNFB(uint PIDINBNGILH, bool FKJMCGEFJMD)
	{
	}

	public void NDKJLNGEKIB(bool FKJMCGEFJMD)
	{
	}

	public void AGONLINNNLP()
	{
	}

	public virtual uint AGBKDOFMPHC()
	{
		return 0u;
	}

	public virtual bool MKGAOHKPBJI()
	{
		return false;
	}

	protected virtual int FMDNPGMGDIJ()
	{
		return 0;
	}

	public virtual int CFILKIICNGG()
	{
		return 0;
	}

	protected int NNNOIILOALI(bool MPDLAAKEEEJ)
	{
		return 0;
	}

	public void CFLCFDNHMJO()
	{
	}

	public void NCDLCLMNFGN()
	{
	}

	public void DOOGFKDKKNC(LLEDPGIGCMO KHLIJODOLOF)
	{
	}

	private void CCBIHNDJKID()
	{
	}

	public bool FECAIANENOB(EECMIDPHCKN JCONDDPFBKK)
	{
		return false;
	}

	public bool FECAIANENOB(Vector3 COGCLFOAKMC, Vector3 JFELINLEGHL)
	{
		return false;
	}

	public virtual void HLHGHAMMMBG()
	{
	}

	public virtual void FFCIEJHOJGD()
	{
	}

	public virtual void INGJLEBHLOJ()
	{
	}

	public virtual void BGGBDIMHMMC()
	{
	}

	public void HNLPAOJGPFH()
	{
	}

	protected void AGPKJGNEJCC(TweenProperty[] HBAGNMEMGEI)
	{
	}

	public void HEDJCFCGKLP(List<NCDOODDEHOD> ENPHPBKCIAL)
	{
	}

	protected void KCPCCEEEIEJ()
	{
	}

	protected virtual void IOLLHCBJDBJ(bool FKJMCGEFJMD)
	{
	}

	public bool MLKEFIENPFD()
	{
		return false;
	}

	public uint KGHGKFICABG()
	{
		return 0u;
	}

	public bool LIOOEIACMJI()
	{
		return false;
	}

	public void NDLLBBCKLMF(Player FFHGOACBDMH, uint MCDOPEMIHGP)
	{
	}

	public void PCABJHEEEPC()
	{
	}

	protected virtual bool KIBCPCLMEMB()
	{
		return false;
	}

	protected virtual bool KCPFLGKHANP(out JLOFMCKFFHB MPKEEIBCOAB)
	{
		MPKEEIBCOAB = null;
		return false;
	}

	private bool FMDPBGJGOJI<T>(out T HLFLDCOPHGL) where T : INBGODDAJOK
	{
		HLFLDCOPHGL = null;
		return false;
	}

	protected void OJJFHLFCFKC(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	public virtual bool OHCMLDBLNIK()
	{
		return false;
	}

	public virtual int EMJMGMCKDKE()
	{
		return 0;
	}

	protected void JAFFNPPKLMB()
	{
	}

	public void GMOGEMCEDNL()
	{
	}

	protected bool PMDBAEIBNHK(ref GameObject OBLFFNAEEJL, bool BNKAAAHGFFM = false, bool EALOKCBJCDH = true)
	{
		return false;
	}

	protected virtual void ODLPCHODPIJ()
	{
	}

	public bool DCMICDIAJAH()
	{
		return false;
	}

	protected void MPODFKKMOMM()
	{
	}

	public void BDDJDBGJMCB()
	{
	}

	private bool HPIONKFDKID()
	{
		return false;
	}

	string IBridgingEntity.UGCEntityID()
	{
		return null;
	}

	public int BridgingTypeID()
	{
		return 0;
	}

	public void OnLogicEntityCreated(string GDDEBLAFLLG)
	{
	}

	public IUGCValue BridgingPropGetter(long DLOFKFKIMGC)
	{
		return null;
	}

	public bool BridgingPropSetter(long DLOFKFKIMGC, UGCSimpleValue GPFPIAMCEMI)
	{
		return false;
	}

	public void PFFDIADLCKH(bool HCLGHJNEFIC)
	{
	}

	public virtual NMCBIHOOFFF DBOKJLGKIFH()
	{
		return NMCBIHOOFFF.ESTARTFIRESTATE_NONE;
	}

	public GameObject GEPHNLEFPMK()
	{
		return null;
	}

	public bool GCONBFMLAJH(uint DNBCDKBENBM)
	{
		return false;
	}

	public bool KNFOADECIAK()
	{
		return false;
	}

	public void JNFAMJGKHCA(List<uint> ODBAGJCFCBO)
	{
	}

	public WeaponTerm DIKDEGFLJNF()
	{
		return null;
	}

	public void IHHHCDMLMNB(List<MIOHOOONPJB> MJCJHGGCNEB)
	{
	}

	public void BADLIGBHJIG(MIOHOOONPJB GPJOHKDBKOL, bool IHFOIMPCGPL)
	{
	}

	public bool NIJPOLNNFHM()
	{
		return false;
	}

	public float EPDFJECKPBD()
	{
		return 0f;
	}

	public void OJNGFDPFKGI(bool FKJMCGEFJMD)
	{
	}

	public void CKKEIMOOCED(BHGGAEEHJCO LOHDCKEJJON)
	{
	}

	public override void NGDHJACOJKO()
	{
	}

	public void PPCNKOIDEGB(ref float BILNJDGCOHP, ref float LJAABJPOBNL, bool EEPKDPKADCF, bool PPNGLFCBGHA)
	{
	}

	public uint PGLENLCEJCF()
	{
		return 0u;
	}

	public virtual float DPCMJGKJHDC()
	{
		return 0f;
	}

	public static bool AKNICLFBNGA()
	{
		return false;
	}

	public virtual bool GLIGAFFGEGG()
	{
		return false;
	}

	private void ONOFJEDPHNE(ref ICollection<ResourceID> OOBHJAJKGBA)
	{
	}

	private void KFDIBMMNBMM(ref ICollection<ResourceID> OOBHJAJKGBA)
	{
	}

	private void OCMDNLNJFLF(WeaponSkinData IMCPLIHNPMD, ref ICollection<ResourceID> OOBHJAJKGBA)
	{
	}

	protected virtual ResourceID HENONEFPKHO(bool PEGODMGMOCL = false)
	{
		return default(ResourceID);
	}

	public ResourceID BOGLFCPIHAJ(bool EALOKCBJCDH)
	{
		return default(ResourceID);
	}

	public ResourceID CLPNNIBLHBA(Player LDCIMNAAGNO)
	{
		return default(ResourceID);
	}

	public ResourceID ADDJHMHNOLD(Player LDCIMNAAGNO)
	{
		return default(ResourceID);
	}

	private void IFOBIBFGIKJ(MMJDDGALNDP DHCIHCPEPIM)
	{
	}

	public static bool HGAFDBKJGOA(DBENAPILEBC CCNBNLAPJFM)
	{
		return false;
	}

	protected void IKIOJDDAJKP(Vector3 GAOGGGBHACA, bool FKPHCNGONIP, bool PHPJGBILOED)
	{
	}

	private void FOPPEAHJFKP()
	{
	}

	protected ResourceID JFAAEJNPJIB()
	{
		return default(ResourceID);
	}

	public void MABCANMKEIO()
	{
	}

	protected void AKHCOBDGANK(bool CFPJGEOOCOE)
	{
	}

	public virtual void IBCPBBIMHJE(bool FKJMCGEFJMD)
	{
	}

	public static bool HPLFONKAKMP(DBENAPILEBC CCNBNLAPJFM)
	{
		return false;
	}

	private ResourceID GKGHOEIMIIC(HitDetectColliderHelper PCAMLNIKFPO)
	{
		return default(ResourceID);
	}

	private void DDOAOJAMCGA(OKEAMEELLBB NNHKGODKFCL, HitDetectColliderHelper MLAOIHOMKHL, GLLLEDKLLDA PMMCGNJHOOA, bool FNKILOAEFMC)
	{
	}

	private void FCFBBJNNOLO(Player PFJFADHEJLJ)
	{
	}

	protected virtual ResourceID HMBPLAHNNAP()
	{
		return default(ResourceID);
	}

	protected virtual ResourceID LOOMOANNHAP()
	{
		return default(ResourceID);
	}

	protected virtual ResourceID LHMAPKHMHCL()
	{
		return default(ResourceID);
	}

	protected virtual ResourceID KCGNMPDHEID()
	{
		return default(ResourceID);
	}

	public virtual ResourceID FJOBNMKMIIM()
	{
		return default(ResourceID);
	}

	public virtual ResourceID NDGGPKFADDK()
	{
		return default(ResourceID);
	}

	public virtual ResourceID FGAMDMAHJOL()
	{
		return default(ResourceID);
	}

	public virtual void CJCECAMNJEP()
	{
	}

	public virtual void HJLOLJEEDDL(float GOMNGFFGLKD)
	{
	}

	public virtual void LBMNABCIMNK()
	{
	}

	public static void JCAOCIHIPHH(Player LDCIMNAAGNO, AGACNOCEEFP NGJDOCHFBKJ, ref List<ResourceID> CFJCHCNHHLA)
	{
	}

	public static ResourceID JCAOCIHIPHH(Player LDCIMNAAGNO, PIJKGPDBNJC NLGLCIODINF, AGACNOCEEFP NGJDOCHFBKJ, int CCEIPENIPLN = 0)
	{
		return default(ResourceID);
	}

	protected static ResourceID IJIKLAONLBH(bool PPNGLFCBGHA, PIJKGPDBNJC NLGLCIODINF, AGACNOCEEFP NGJDOCHFBKJ, int CCEIPENIPLN = 0)
	{
		return default(ResourceID);
	}

	protected static ResourceID BDMLJKAGFCJ(bool PPNGLFCBGHA, PIJKGPDBNJC NLGLCIODINF, AGACNOCEEFP NGJDOCHFBKJ, int CCEIPENIPLN = 0)
	{
		return default(ResourceID);
	}

	public static ResourceID OCGBDHKMAFL(bool PPNGLFCBGHA, AGACNOCEEFP NGJDOCHFBKJ)
	{
		return default(ResourceID);
	}

	private void CHFJEJLNNDB(JMDPBIEEPJE AHKCJIOBDHO, int OAKECDEMHBK)
	{
	}

	private void ENKNIJFLHAD(int DFDAPIDCHMF)
	{
	}

	private void HBJHOKJKGEC(int GPFPIAMCEMI)
	{
	}

	private void GECNAPHFKJC(int GPFPIAMCEMI)
	{
	}

	public void DANNJEMHMLP()
	{
	}

	private void AFOBFNCFPLH(GameObject IBDNJDLJPDG)
	{
	}

	public void FBJNFFIANFL(bool NDGMENGEGIE)
	{
	}

	public void HGCEABPJNDP()
	{
	}

	public void IIPMJPGBODG()
	{
	}

	protected virtual void GEDELKGPPEG()
	{
	}

	private void GFFMPMBMPFI(uint GGAOIPIHOBP, bool PCGMOOHAIDE, UnityEngine.Object OHLBJNPEMGF)
	{
	}

	private void KICDKDBDODI()
	{
	}

	public void HJMNNHLFKEO(float IMKNJGHAHPI)
	{
	}

	public void GACHPDJBHHI(float IMKNJGHAHPI)
	{
	}

	public void CJAEPHADBJN()
	{
	}

	public void BFILBGKDBDB()
	{
	}

	protected virtual RuntimeAnimatorController JCEDCKDIHBL()
	{
		return null;
	}

	protected virtual RuntimeAnimatorController LINLMDFFLIO(ResourceID GGMIDNEJGNO)
	{
		return null;
	}

	private void JDLOOIIJDDJ()
	{
	}

	private void GBMDEEIHGCN()
	{
	}

	public bool _003C_003EiFixBaseProxy_GBGFFPBPKKP(Player P0, uint P1, uint P2, HENEHAGJCLI P3, object[] P4)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_LNCNPFBPMBP()
	{
	}

	public void _003C_003EiFixBaseProxy_LILEEJOFLPJ()
	{
	}

	public void _003C_003EiFixBaseProxy_IBEJJIDOLMH(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_AAKFKAJNILD(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_JBGCLEHFLAF()
	{
	}

	public void _003C_003EiFixBaseProxy_IPBPLNPADJG(ref ICollection<ResourceID> P0, ref ICollection<ResourceID> P1, ref ICollection<ResourceID> P2)
	{
	}

	public void _003C_003EiFixBaseProxy_IMPCADBKDCP(ref ICollection<ResourceID> P0, ref ICollection<ResourceID> P1, ref ICollection<ResourceID> P2)
	{
	}

	public void _003C_003EiFixBaseProxy_MGAMBOMLCIB(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_LABDBGOHLDM()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_HEGAMHJNIKJ(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_JJHDLCBBFLN()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KFICCMFBNGO()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NCHAMAGEDPD()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_IAAJNKPKJFL()
	{
	}

	public void _003C_003EiFixBaseProxy_LBKODCNLHFD()
	{
	}

	public void _003C_003EiFixBaseProxy_HDMKBLLDNGJ(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_IKJMLNGEBHN(HDAEFOANBGJ P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PPKCCNPEIMA()
	{
	}

	public void _003C_003EiFixBaseProxy_ADHECLOECCM()
	{
	}

	public void _003C_003EiFixBaseProxy_PAGCEKFEMBC()
	{
	}

	public void _003C_003EiFixBaseProxy_EEAHIMOAENF(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_IAAKMPGAPOB(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_NGDHJACOJKO()
	{
	}
}
