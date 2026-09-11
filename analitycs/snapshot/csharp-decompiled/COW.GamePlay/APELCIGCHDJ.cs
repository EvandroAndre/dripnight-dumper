using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class APELCIGCHDJ : NKMCHIMCOHK, FDACAOPGNJK, FOCGJHJOBFE
{
	public enum EKLHHPPNJGH
	{
		NONE,
		FREE,
		FIXED_LOCK,
		FIXED_ORBIT
	}

	public enum BOJIAHMNKNJ
	{
		Manual,
		Auto,
		AutoInTeam
	}

	public enum FKMOGIEDEBD
	{
		Damage,
		KnockedDown
	}

	public enum CGFLKNJLMEN
	{
		None,
		Dead,
		KnockedDown,
		Damage,
		EnemyShow
	}

	public enum IDIBLFGPCJM
	{
		Default,
		ZoomIn_Scale1
	}

	public enum MIIJCKDCMNG
	{
		TeamAccStats,
		TeamAliveInfo
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__245_0;

		public static Action _003C_003E9__245_1;

		public static Action _003C_003E9__245_2;

		public static Action _003C_003E9__245_3;

		public static Action _003C_003E9__245_4;

		public static Action _003C_003E9__245_5;

		public static Action _003C_003E9__245_6;

		public static Action _003C_003E9__245_7;

		public static Action _003C_003E9__245_9;

		public static Action _003C_003E9__245_10;

		public static Action _003C_003E9__245_12;

		public static Action _003C_003E9__245_13;

		public static Action _003C_003E9__245_15;

		public static Action _003C_003E9__245_16;

		public static Action _003C_003E9__245_17;

		public static Action _003C_003E9__245_18;

		public static Action _003C_003E9__245_26;

		public static Action _003C_003E9__245_27;

		public static Action _003C_003E9__245_31;

		public static Action _003C_003E9__245_32;

		public static Action _003C_003E9__245_33;

		public static Action _003C_003E9__245_34;

		public static Action _003C_003E9__245_35;

		public static Action _003C_003E9__245_36;

		public static Action _003C_003E9__245_37;

		public static Action _003C_003E9__249_0;

		public static Action _003C_003E9__249_1;

		public static Action _003C_003E9__249_2;

		internal void LINMAGEAHPD()
		{
		}

		internal void LJMHKEFDIBA()
		{
		}

		internal void EFPDCCPOMEL()
		{
		}

		internal void HDIPLGIFIGL()
		{
		}

		internal void DJMLANHHLNK()
		{
		}

		internal void FIMENNOIOED()
		{
		}

		internal void HHLKDAKOJLI()
		{
		}

		internal void FEIEEELMCGJ()
		{
		}

		internal void JDJAIMCBACC()
		{
		}

		internal void CDPEMAGIGND()
		{
		}

		internal void IPNMMEJLDCO()
		{
		}

		internal void FDFPIALEBLK()
		{
		}

		internal void NEGINHOKIKE()
		{
		}

		internal void GNMPCANLPFC()
		{
		}

		internal void ODIOOAKOIMN()
		{
		}

		internal void LFFAJBOGMHJ()
		{
		}

		internal void FFEJKLMCFFO()
		{
		}

		internal void FLAPEBMILMF()
		{
		}

		internal void ACEGDDNDGEA()
		{
		}

		internal void DPDAINCNDML()
		{
		}

		internal void PKDLKKAMLAH()
		{
		}

		internal void HIOANCOPILC()
		{
		}

		internal void HCACEOAMKLB()
		{
		}

		internal void CALIJODCHGI()
		{
		}

		internal void ADNKEHCEDFA()
		{
		}

		internal void GNIPDGPOGNC()
		{
		}

		internal void NLPKBCOBLBK()
		{
		}

		internal void JFCOBJONCOE()
		{
		}
	}

	private sealed class GEGCELEKBDA
	{
		public byte GLHOJABOKOP;

		internal bool IDMHGOBGEMN(TeamData MJIFGJPGLAM)
		{
			return false;
		}
	}

	private sealed class NLIOIHFIFIA
	{
		public APELCIGCHDJ KOKNHFGCGLN;

		public BHGGAEEHJCO FFHGOACBDMH;

		public CGFLKNJLMEN CCNBNLAPJFM;

		internal void PAMGFIMBIHD()
		{
		}
	}

	protected const uint LEMHBEGKGJC = 1u;

	protected const uint NEJJECHNOEI = 2u;

	protected const uint GCKMBDPLDHP = 4u;

	protected const uint GBKMFFGMPFF = 8u;

	private static readonly Vector3 IMIBNBGEDNK;

	private static readonly Vector3 PMFFHMJBIJD;

	private ulong _003COEPCAOOMIAB_003Ek__BackingField;

	private BHGGAEEHJCO _003CFKPJOHKCBBE_003Ek__BackingField;

	public BHGGAEEHJCO OCNEJNFOEDN;

	public BHGGAEEHJCO DOEOCILHJKH;

	private Player JAGIFDNJJFD;

	private BHGGAEEHJCO _003CGELFLIBNKHO_003Ek__BackingField;

	private EKLHHPPNJGH PNMMGJLLJNN;

	public EKLHHPPNJGH AADKFHEPFPO;

	private UIModelSpectator DAAFGKPMOAL;

	public bool NKKLPPBINGL;

	private bool MMGFHKNDDGC;

	private bool AGALOMONABN;

	private bool IEFGGGCMHPH;

	private bool BLGDPBIKLNE;

	private bool JIBICNJLPJD;

	public bool FFDLDEOMCCO;

	private BOJIAHMNKNJ IJJNKNABIJM;

	private int _003CPBCIKEJKDHB_003Ek__BackingField;

	private DPNIICGMOJG MPPLJFECEMN;

	private uint AKNLPCJBOCN;

	private int DJEJFDNHDHF;

	private double NDJPCOCECGC;

	private Vector3 GAGIMNHGPID;

	private Quaternion PAOEFBNOJIM;

	private Vector3 GAAGCDMBHBK;

	private Quaternion CNHLNNPOGMH;

	private EKLHHPPNJGH FBCGIAONPMN;

	private bool GKOOMCAKILP;

	private float FOAFJGNBOLA;

	private Vector3 NFAHIMNIDCO;

	private float EDCMKCADJJJ;

	private float GPKNJCKHFAN;

	private float BFFMPGHKDHG;

	private bool FMPHKJKLCDF;

	private bool BNFELMNCADF;

	private bool DGEBDJFMKNI;

	private float KJAMOHKGDOC;

	private float LHAPBOKDKMI;

	private float BNKHHBEMAJH;

	private float BALKCFIPKLA;

	private HashSet<ResourceID> EPHLOBLBIFO;

	private Dictionary<KeyCode, int> IOIMAKENGGG;

	private bool FKJLMPKLOLE;

	private bool IOGEKOGMAFF;

	private float AIKONAFJBGF;

	private byte KJDCJBIPBHL;

	private float JPBCCLOLOIL;

	private Dictionary<BHGGAEEHJCO, int> GHJPGJEGNMJ;

	private CGFLKNJLMEN EDOJEHLOCCP;

	private Action EHJMNLCPFFA;

	private bool HANMOLPNFFC;

	private float GPMHMEDAJHN;

	private Dictionary<BHGGAEEHJCO, float> GHGCCFIEPHI;

	private Dictionary<int, Action> GJLHFBGGHPL;

	private Dictionary<int, Action> BPAGFFCPAGJ;

	private Dictionary<int, Action> HGKMACABDJN;

	private Dictionary<int, Action> AHPKKOFKHHK;

	public ulong GFMLMAIJJMN
	{
		get
		{
			return 0uL;
		}
		protected set
		{
		}
	}

	public BHGGAEEHJCO BHGGAEEHJCO
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		protected set
		{
		}
	}

	public Player BIPDKDICFAC
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BHGGAEEHJCO JIHIEDCPCDM
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	public EKLHHPPNJGH AGJEPGGIKAN => EKLHHPPNJGH.NONE;

	public bool DIOIEPHKGJE => false;

	public bool NJHHHJBGFHI => false;

	public bool MOBAFBKDCOG => false;

	public bool KEFPBNNLFFD => false;

	public BOJIAHMNKNJ OJKKEBGHNJO => BOJIAHMNKNJ.Manual;

	public BHGGAEEHJCO ICBHLIBLIDF => default(BHGGAEEHJCO);

	public int EGOPCKNPAMI
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public OKEAMEELLBB GBOBMPPGCAO => null;

	public Player OEMPIHKIEPI => null;

	public byte FCAFEBGLNAK => 0;

	public bool IsPassengerInVehicleCanFire()
	{
		return false;
	}

	public bool IsVehicleSupportDriverWeaponFire()
	{
		return false;
	}

	public bool HasHeuristicTarget()
	{
		return false;
	}

	public OKEAMEELLBB GetHeuristicTarget()
	{
		return null;
	}

	public static APELCIGCHDJ GJEGDCBILGA(ulong HGNIOBLGCII, BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public void LMNGOJOJFNM()
	{
	}

	public void DNNIAGDOHCP(EKLHHPPNJGH GGAOKBAMALB, bool IDCHCEECMBE)
	{
	}

	private void MBEINKAPFHE(EKLHHPPNJGH GGAOKBAMALB, bool IDCHCEECMBE = false)
	{
	}

	public void GLOFLPMFPIK(Vector3 HDFILHFDBKB, Vector3 IPKKCHLDJMA)
	{
	}

	public void DKILFAKGPLH(bool LPBPBKGNBKA = false)
	{
	}

	public void JPFGAHOIDBD()
	{
	}

	private void AALNPFKJPNH()
	{
	}

	private void ICAFDNCNHOB()
	{
	}

	private void ICFALCBEBOA(bool IDCHCEECMBE = false)
	{
	}

	private void NIICLEPIBLL()
	{
	}

	private void NAGAJOPPJFE()
	{
	}

	private void GPDJELEFKCB()
	{
	}

	private void OKIICAEBAHF()
	{
	}

	public void GKFJEGEPMDA()
	{
	}

	public void IBEJJIDOLMH(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void INOFPKNHFAA()
	{
	}

	private void LOIFCMGPBMP(float HOGHEFNINAE)
	{
	}

	private bool DJFFKMMMPHF()
	{
		return false;
	}

	private bool GGDINCCMGMN()
	{
		return false;
	}

	public void GMGLOLENKCD()
	{
	}

	public void DLENOBPHCJH()
	{
	}

	public void NNILAGBLAFK()
	{
	}

	public void EJMCBIMJJEK()
	{
	}

	private void KCFCBGGEKJD(int LIKPJDHGPFG)
	{
	}

	private void CJMOCLKBHJA(int OPMHKKPJNGM, int NOJNELMMIJD)
	{
	}

	private void BPEHIOHAGIF(int PAPBHPJKHOP)
	{
	}

	public void ODLEFOJEAAG(float JHLNMNMLGPB)
	{
	}

	public void BMEIGMHCNMO()
	{
	}

	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	public bool IsCameraTrackableEntityAlive()
	{
		return false;
	}

	public List<Vector3> GetBoundingBoxList()
	{
		return null;
	}

	public GameObject GetGameObject()
	{
		return null;
	}

	public bool GetSightingState()
	{
		return false;
	}

	public bool IsSightingUIAvailable()
	{
		return false;
	}

	public bool GPJEGNFAPND()
	{
		return false;
	}

	private void NAKKIABCAGC()
	{
	}

	public void OnSightingUIStateChange(bool BNEEMDFEMDB, float HFPLKBHDHJJ)
	{
	}

	public bool IsLockFire()
	{
		return false;
	}

	public bool IsShowLockFireUI()
	{
		return false;
	}

	public float GetLockFireFinishProgress()
	{
		return 0f;
	}

	public bool IsReallyInStealth()
	{
		return false;
	}

	public bool IsTargetFriend(OKEAMEELLBB PFJFADHEJLJ)
	{
		return false;
	}

	public bool HeuristicTargetIsFriend()
	{
		return false;
	}

	private void PBENMNMDEHO()
	{
	}

	private void FJOHEMANBAD()
	{
	}

	private void KJMCFBIOPOD()
	{
	}

	private void INDEMOGAINN(object[] JCONDDPFBKK)
	{
	}

	private void GIDBDJHJKML(object[] JCONDDPFBKK)
	{
	}

	private void JNBCCCAIFPO(object[] JCONDDPFBKK)
	{
	}

	private void GCPAMMJMIKJ()
	{
	}

	private void LOBHPBJCFBH()
	{
	}

	private void FICNDDKPPNH()
	{
	}

	private void LOCNLMCJOJB(object[] JCONDDPFBKK)
	{
	}

	private void GHDCLEENGLB(object[] JCONDDPFBKK)
	{
	}

	private void LAFEPHIJCNL(object[] JCONDDPFBKK)
	{
	}

	private void BEFEMELLMKL(object[] JCONDDPFBKK)
	{
	}

	private void DHJCIHNHNPA(object[] JCONDDPFBKK)
	{
	}

	private void CNDAKLFJMFF(object[] JCONDDPFBKK)
	{
	}

	public NAELPAAELNO GetItemOnHand()
	{
		return null;
	}

	public NAELPAAELNO GetRealItemOnHand()
	{
		return null;
	}

	public bool IsInVehicle()
	{
		return false;
	}

	public Vehicle VehicleIAmIn()
	{
		return null;
	}

	public bool IsOnStrop()
	{
		return false;
	}

	public bool IsOnChair()
	{
		return false;
	}

	public bool IsInCatapult()
	{
		return false;
	}

	public bool FLBFAOCJIEA()
	{
		return false;
	}

	public bool IsOnGrapplingHook()
	{
		return false;
	}

	public bool IsOnVMEHook()
	{
		return false;
	}

	public bool IsOnHook()
	{
		return false;
	}

	public bool HasGrapplingHook()
	{
		return false;
	}

	public bool HasHook()
	{
		return false;
	}

	public bool HasVMEHook()
	{
		return false;
	}

	public LevelStrop GetStropIAmOn()
	{
		return null;
	}

	private void PPPPOAIMBFL()
	{
	}

	private Vector3? PJBJNDJDIHO(string AAKBIKMJHOL)
	{
		return null;
	}

	private void DNHDDHDBBKD()
	{
	}

	private void ENGOLPLJGBD(BOJIAHMNKNJ GGAOKBAMALB)
	{
	}

	public void HBFBOEKMMJO(ulong EIOKHLKJEEL)
	{
	}

	public void HLCHOHGNIAI()
	{
	}

	public void DEFHFGLEBMP(bool DABLJLGBFKN)
	{
	}

	private void DFNKKCILFJM(bool DABLJLGBFKN, bool NAKMHNGDBBK)
	{
	}

	private void GPNNIPDHHBO(bool DABLJLGBFKN)
	{
	}

	public void FLDFKOIFLOJ(bool DABLJLGBFKN, bool HGDKLPMIIPD, bool DDKLDJLECHP = false)
	{
	}

	private Player BJJPLLOEJGM(bool DABLJLGBFKN, bool HGDKLPMIIPD, BHGGAEEHJCO LIKPJDHGPFG)
	{
		return null;
	}

	public void GELPNGBGCED(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void IKNLDEMJJDA()
	{
	}

	private void COKEIDKAOAG()
	{
	}

	private void NMJJPLEALKO()
	{
	}

	private bool KOIIIJECEID(ref float IHDIKELCFOH, float ABFAEONCGKL, float LHNNHHEGJPN, float APFJEJNMILI)
	{
		return false;
	}

	private void AJGLODBMMAE()
	{
	}

	public void JOFHLPCIDAH(float JHLNMNMLGPB)
	{
	}

	private Vector3 LEHAJHGGMBE()
	{
		return default(Vector3);
	}

	private void FPPEOLCJCNF(float OBNPLABHICH, Vector3 FHFMBHBNHDD)
	{
	}

	private void DMMCBOOJNNM()
	{
	}

	private float GOAAJFDLBEP()
	{
		return 0f;
	}

	private float KEDBGLNMGIO()
	{
		return 0f;
	}

	private void KMIAJHPGABF(float JHLNMNMLGPB)
	{
	}

	private float JBFFAICJDIJ(float BAFIFNKBHLC)
	{
		return 0f;
	}

	private void KPENGIFIPAL(float LLJBJNFLEJJ = 1f)
	{
	}

	public void JLMDPDLHJGI()
	{
	}

	public void CEACHDMEJOL()
	{
	}

	public void LHCCIFDJOBH(BPGGOGDFCEA APHHNHEDHKD)
	{
	}

	public void EMBNCLNBCHD(bool NBDGPKJOCNP = false)
	{
	}

	public void NOGMMPNHKLF(bool MEOKDAPLECD = false)
	{
	}

	private void KNGOMKPHMBM(BHGGAEEHJCO PGEGMKJKOKI)
	{
	}

	private bool DMNDKDJJPGN()
	{
		return false;
	}

	public bool GDGHCIGIPAI(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public bool DDECIJDMDJO(uint EJPBBEFLHNA)
	{
		return false;
	}

	private void ECCGMDFACNH(BOJIAHMNKNJ GGAOKBAMALB)
	{
	}

	public void LELLPGAHEOM(BHGGAEEHJCO JCCBCMDEGOL, BHGGAEEHJCO NAJPMAJMDMG)
	{
	}

	private void FPDADFJFFEI()
	{
	}

	public void AFKEDCGHGGC(bool FKJMCGEFJMD)
	{
	}

	private void CEPHPJGLMGJ()
	{
	}

	private void MGNGGHBMIFA()
	{
	}

	private void EDJBHDEOIMP()
	{
	}

	public void ELAKOHFGOKC()
	{
	}

	private int LLLAAMEAINF()
	{
		return 0;
	}

	public void JEAHLBDIKDJ(DPNIICGMOJG CCNBNLAPJFM, uint PFIHDHGJNLO)
	{
	}

	private void FBNKDAKEGFG()
	{
	}

	private void NILJHNBADKM(DPNIICGMOJG CCNBNLAPJFM, uint PFIHDHGJNLO)
	{
	}

	public void FDANCLGELBJ(byte GLHOJABOKOP)
	{
	}

	public void LHHAJKOENNL()
	{
	}

	public ReplayCamState OPBFPIHKCAG()
	{
		return default(ReplayCamState);
	}

	public void BHKDEBICLKM(ReplayCamState CBCAJJJCKLH)
	{
	}

	public void IHHJBMKJFHJ(Vector3 HDFILHFDBKB, Vector3 IPKKCHLDJMA)
	{
	}

	private void PKHGNDENAID(object[] JCONDDPFBKK)
	{
	}

	public void EJIENEJBCOH(BHGGAEEHJCO JCCBCMDEGOL, BHGGAEEHJCO NAJPMAJMDMG, CGFLKNJLMEN CCNBNLAPJFM = CGFLKNJLMEN.Damage)
	{
	}

	private void FCMOODALLGC()
	{
	}

	private void BJCDCHOMABA(BHGGAEEHJCO FFHGOACBDMH, CGFLKNJLMEN CCNBNLAPJFM)
	{
	}

	private void ONBGGLJIHHE(BHGGAEEHJCO FFHGOACBDMH, CGFLKNJLMEN CCNBNLAPJFM)
	{
	}

	private bool FGBOBALGFID(BHGGAEEHJCO JCCBCMDEGOL, BHGGAEEHJCO NAJPMAJMDMG, CGFLKNJLMEN CCNBNLAPJFM)
	{
		return false;
	}

	private void JGGINJOEDNM()
	{
	}

	public void HPEEMEGJMFP(string BACDJKFBHJE)
	{
	}

	private void EOIKGFIFHIE()
	{
	}

	private void NCBHOLFILJM()
	{
	}

	private void MPDFFCAGJCC()
	{
	}

	private void NBPEIKCKFGA()
	{
	}

	private void NNHHHDNFCDD()
	{
	}

	private void FJNFLAODLIA()
	{
	}

	private void CEHJANHPOCH(MIIJCKDCMNG BNKDLHODPBL)
	{
	}

	private void OKHBGMPIKCA()
	{
	}

	private void IEDODFFANPH()
	{
	}

	private void NLNOECLGOIB()
	{
	}

	private void DPEKKKMPGJN()
	{
	}

	private void GNKCCFMDPLJ()
	{
	}

	private void DNBFLAPIHOJ()
	{
	}

	private void AGPFFEGKKMM()
	{
	}

	private void PCOFDBNJINP()
	{
	}

	private void OMCFEFFIKCM()
	{
	}

	private void HJBPCENGCOK()
	{
	}

	private void JOJJFBJBPLD()
	{
	}

	private void FDGEOIBMJBM()
	{
	}

	private void FPJKPOPFGKG()
	{
	}

	private void LJJOPFPAMGN()
	{
	}

	private void LCPCKDOGJJA()
	{
	}

	private void FLKKNJEAADD()
	{
	}

	private void EIFAPGAJHNH()
	{
	}

	private void JKHGDHNDGBH()
	{
	}
}
