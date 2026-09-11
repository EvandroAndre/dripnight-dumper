using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class HNDHJGJILHC : HBCDLOBDAON
{
	public enum EHKDFPGMGMK
	{
		Normal,
		Player,
		Map,
		Template
	}

	public class JBMEGEPHDOL
	{
		public OALEGBJOANK PPANGLNHMAN;

		public int JAGLCKPHKHA;

		public List<string> PJDELDCADEA;

		public JBMEGEPHDOL(OALEGBJOANK OFFDDDDNPCG, int NBLHNPAHGNA, List<string> AIPMOBECKCM)
		{
		}
	}

	private class CLKHLMIBPND
	{
		public LevelTriggerFountain AHABELNAKDC;

		public GameObject OGNCNEJGAOD;

		public ResourceID IGMIOBDIOFI;

		public SceneEditTireLine HKMKINOGOGA;

		public ResourceID BAAFIFBAGEA;

		public GameObject POPBMNAIPNN;
	}

	private sealed class ILIPFMIHDMI
	{
		public CNGBCLDDJEF DBIDOEGLGPL;

		internal bool BFGPPHJCJEC(SceneEditObjectBase DNNNJDJIBMP)
		{
			return false;
		}
	}

	public const string CKNGNPMJBDM = "T_28_T_WS_DEFAULTNAME";

	public const string FLAJLBNIOPB = "T_30_T_WS_DEFAULTDESCRIPTION";

	public SceneEditFocus DIHMPHINMPP;

	public SceneEditAgent BCCMOEBJDBL;

	public WorkshopSceneData MHLBKBCDNPK;

	private BJJBCNEJPEF KMJFIIOMAAB;

	private SceneEditObjectBase INKHDFHFLJM;

	private Vector3 IKBLFNOFDPM;

	private Quaternion LFMPNEJJADM;

	private int GMGMILLKIHN;

	private bool JELJHGCPGMG;

	private uint DLLFHMLAMIO;

	private ulong BPIJEAEDBBL;

	public const uint KJAKDIFKLJP = 999u;

	public Dictionary<uint, uint> ONHFHDNJNGL;

	public Dictionary<uint, int> FCPBFJJFLNM;

	private SceneEditResourceShopManager _003CPCLEFINEBJD_003Ek__BackingField;

	private UGCTutorialFlowManager GLDHKDBNFFC;

	private UGCEditorManager JNKGBHKIKNI;

	private UGCAssembly ODOOGOELDHP;

	public IHFPALDENNM MPKONMANJBC;

	private bool POJFIAFGEGH;

	public Transform EDFGEOFGOIC;

	private bool LNJLOMDPBJE;

	private List<GameObject> MFAHNCAEODF;

	public const int DDNDNNPDECM = 10;

	private GameObject OOOIFLBDDMO;

	private ANNLJGEPODG BJHCIEPCECF;

	private MKHKEEJECEH IBMCLMGBBFP;

	private IFBLFCGIHJP JNNMHPBEFDF;

	public EHKDFPGMGMK EDLANPCJNMN;

	public WorkshopPrefabItemManager HKPFAMFEMLL;

	private int DGKDFABMINB;

	private Dictionary<int, SceneEditObjectBase> HCHKNMHDGKI;

	private Dictionary<uint, uint> CNONMAHJFNG;

	private Dictionary<string, SceneEditObjectBase> IPAFMPLKKIA;

	private Dictionary<string, SceneEditObjectBase> DLPPDNKOIJI;

	private Dictionary<int, LevelTriggerFountain> HIDANLLIPPG;

	private List<int> GCHMCINJIEH;

	private Material EJEOFAOMLGH;

	private Dictionary<uint, Material> BMJBMGHJOMA;

	private Dictionary<uint, Material> GJHKPIGNNEA;

	private uint _003CKOHNDGCLOKE_003Ek__BackingField;

	private string ELHCOBBPIPI;

	private bool BOMOIBAFMDE;

	private bool _003CAHGCPLGANEI_003Ek__BackingField;

	private uint CFJBMCEAABN;

	private bool BPPIDIMFMCB;

	private uint _003CJBCPNPPJEFI_003Ek__BackingField;

	public uint CAJHPHHEJHP;

	public uint ICOJEIJILDP;

	public uint CLMJPLMLIEF;

	private string OLGBIOOAPLK;

	public ulong JLPKPBFBDKK;

	private UIModelSceneEdit EPCGBABJEDD;

	private List<List<CNGBCLDDJEF>> CHGDKJPOBCC;

	private List<List<CNGBCLDDJEF>> OJDJNJKJFPJ;

	public List<SceneEditObjectBase> CGMNPFNHAKG;

	private bool _003CLGNPCGNPOJA_003Ek__BackingField;

	private ENKPMBMCFKL _003CGODHNCFCHCH_003Ek__BackingField;

	private string _003CGKBKOPEAMEN_003Ek__BackingField;

	public Action<SceneEditObjectBase> FKBFFECMPPH;

	public const float FMPMHBEMINI = 0.01f;

	private uint _003CDEOKHAEIGEH_003Ek__BackingField;

	private uint _003CHMMDIMINIMP_003Ek__BackingField;

	private Vector3 _003CDPFPALCIALL_003Ek__BackingField;

	private float _003CAHEOMOLMNNO_003Ek__BackingField;

	public const int GEMFLBMCBIH = 93;

	public const int ACHJHECIAKB = 94;

	private int DLOJGPFDFAH;

	private CLKHLMIBPND OHELJBBNPOB;

	private CLKHLMIBPND NBDHFNKGLGG;

	private Vector3 JPDLHNIPBFH;

	private bool FJLAPGIGEBK;

	private Player.FGAHFBDAKPI FGAHFBDAKPI;

	private float HJBLGFLMABG;

	public UGCSimpleDownloadTask MJILJFKGDKN;

	private GAPHGOAAKML BBMLNNGALLJ;

	public BJJBCNEJPEF IBGNGEFBOGK
	{
		get
		{
			return BJJBCNEJPEF.None;
		}
		set
		{
		}
	}

	public bool KGGNPBFBFMM
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public SceneEditResourceShopManager GGBEAOEINGI
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public UGCTutorialFlowManager MADFKCNDLPF => null;

	public UGCEditorManager MDEEPPHEOAF => null;

	public UGCAssembly JCIKBFIHOCE => null;

	public IHFPALDENNM NOIGHPIEMIC => null;

	public bool BODEIPCCAPD => false;

	public bool ENIANHJONFI => false;

	public bool BMPBKIJHMBK => false;

	public ANNLJGEPODG AGPBIDKPHAF => null;

	public MKHKEEJECEH DIBKLKHMAHF
	{
		get
		{
			return MKHKEEJECEH.None;
		}
		set
		{
		}
	}

	public IFBLFCGIHJP PDAIHKGJHAK => IFBLFCGIHJP.Normal;

	public Dictionary<int, SceneEditObjectBase> IEPLJKHFKHM => null;

	public Dictionary<uint, uint> JJLPFICEMIA => null;

	public Dictionary<string, SceneEditObjectBase> IHJJIBAPHID => null;

	public Dictionary<string, SceneEditObjectBase> AGHHKCHDAOC => null;

	public Dictionary<int, LevelTriggerFountain> FNFPDIPGKFF => null;

	public List<int> LNBNHBJKGBK => null;

	public int IENIPCECGAN => 0;

	public uint DCFMFIINKCI
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string OLJCFDCPJDD => null;

	public bool PEAEEMNFPEC => false;

	public bool NENIDDAPEAD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint PKOIKEKLBPP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool FDJMBLGBKHH => false;

	public uint GCCEHKOLJMP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string NJNPFLAFJHA => null;

	public List<List<CNGBCLDDJEF>> APCFDJCKCDM => null;

	public bool FPGFDGGGGCP => false;

	public List<List<CNGBCLDDJEF>> KHCAKJODKIN => null;

	public bool NKMHMNJBIPJ => false;

	public bool ANCPOGOJLKJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ENKPMBMCFKL JPNDHPOKKJL
	{
		get
		{
			return ENKPMBMCFKL.ESceneEditItemType_Normal;
		}
		set
		{
		}
	}

	public string HBPKGLKJILN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint HPMDFAJDMJM
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public uint HOFOAAAJEJN
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public Vector3 OAAEIOFIAFL
	{
		get
		{
			return default(Vector3);
		}
		private set
		{
		}
	}

	public float OJKJIKLHHOE
	{
		get
		{
			return 0f;
		}
		private set
		{
		}
	}

	public float EDJOOMCPFIO => 0f;

	public GAPHGOAAKML ONCFBEDAEPH => null;

	public static float KCKPLJKLNGF(uint NFFPFLGDPLF, uint NMDPFPPLHEO = 0u)
	{
		return 0f;
	}

	public uint JJJOIGEKIBF(ulong ABCIJDNAEND)
	{
		return 0u;
	}

	public void BPCFGGOBOPM()
	{
	}

	public void MGGBFFFCLHK()
	{
	}

	public void CAALMBCBNDF()
	{
	}

	private void OGEICPNOHPA()
	{
	}

	public static GameObject MDPFMKDHGEB(ANNLJGEPODG IDOOIJEBGKJ)
	{
		return null;
	}

	public static void EEIKHIDDNKJ(Vector3 IGDHIDGLOKG, Vector3 DFDAPIDCHMF, GameObject FKODMCNOBDM)
	{
	}

	public void OIJNIBJDKBD()
	{
	}

	public WorkshopCostLimitData OINIBLCKDHA()
	{
		return null;
	}

	public WorkshopCostLimitData BHEKHLLGAIF(float JAPKNLDKKGM)
	{
		return null;
	}

	public int MGEKGEDGHDA(int NCOMACMJCJB = 0)
	{
		return 0;
	}

	private void NBEHMCABCCB()
	{
	}

	public Material MCAKLDIGHCI(SceneEditPrefabConfigData DKLKGHGFNCC, float IFDHHGECCCM)
	{
		return null;
	}

	public Material ALKNCLEAAHC(SceneEditPrefabConfigData DKLKGHGFNCC, float IFDHHGECCCM)
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	public override bool IsOnlineGame()
	{
		return false;
	}

	public override LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	private void DBPMJKDHFCI()
	{
	}

	protected override void OnSceneLoaded()
	{
	}

	private void LDNFCAEGBIM()
	{
	}

	protected override void OnDestroy()
	{
	}

	private JOEANMPIFAB JLPDBJMMNBP()
	{
		return null;
	}

	protected override void GCLGIKFHIFH()
	{
	}

	public override bool EnableGlassBG()
	{
		return false;
	}

	public void PFLLEMEPFPC(IFBLFCGIHJP JMLNJGONEEC)
	{
	}

	public void FCPBBPFOIIL()
	{
	}

	public void OPGLIAGKCPG(KMBEHIGOKNF CCNBNLAPJFM)
	{
	}

	public void HMGOALHIBPK()
	{
	}

	public void JAJDDFFKHNB(BJJBCNEJPEF GGAOKBAMALB)
	{
	}

	public void EDCFGCDKLFE()
	{
	}

	public void GFIKMJLCDPD()
	{
	}

	public void GJLGBEJKNKN()
	{
	}

	public void FPABMNHLEEB()
	{
	}

	public void ALOENECHJKC()
	{
	}

	public void EHIGEHNNFMF()
	{
	}

	public void GCDIGNHPNHL()
	{
	}

	public BJJBCNEJPEF PPEKAIFHAFG()
	{
		return BJJBCNEJPEF.None;
	}

	public override int GetGameType()
	{
		return 0;
	}

	public override void OnLoadingSceneFailed()
	{
	}

	public void GGKMPAHAAOL(string JCIFFMHHBHK, bool OIBDJFMPLFE = false)
	{
	}

	public void BANBGJGAMFN(string JJPLCFEKCJB)
	{
	}

	public SceneEditObjectBase KHKOIMEEMPO(int NIBBKONKPHP)
	{
		return null;
	}

	public bool JKAGEOFLPCH(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	public static SceneEditObjectBase FDANPOHEAFI(SceneEditPrefabConfigData JCONDDPFBKK)
	{
		return null;
	}

	public SceneEditObjectAttrBase OONKLPLGDMN(SceneEditObjectBase IKPOMJKDIPI, uint OGCAAIIIFGO)
	{
		return null;
	}

	public void DFMCJILDDAB(AFAJGEBMGIP JCONDDPFBKK)
	{
	}

	public bool DINNGMKJCAG(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	public bool HDBMPIOCDMI(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public void GCHGJLPJGLL(SceneEditObjectBase BBBAEKPCBBF)
	{
	}

	public void OGIMIGNONIG(SceneEditObjectBase BBBAEKPCBBF)
	{
	}

	public bool ENNPFKIHJEH(List<SceneEditObjectBase> GADKGNIOOMP)
	{
		return false;
	}

	private bool KPOCNICABNB(SceneEditObjectBase JBCDHLNHGIH, Dictionary<uint, uint> KFLJEFOMNAM, HashSet<SceneEditObjectBase> LMHAOAJOBNL)
	{
		return false;
	}

	private void ODJFKIJBFHN()
	{
	}

	public void BGCGFIJDNHL(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public void PPLCICDKHGP(SceneEditObjectBase JBCDHLNHGIH, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	public KDHKEDFHDHF PMCKEPGHHOM(SceneEditPrefabConfigData FECBOCBHKLD, Vector3 HDFILHFDBKB, int NCOMACMJCJB, List<CNGBCLDDJEF> BMDHOAHLPCJ, ref SceneEditObjectBase JBCDHLNHGIH, FSceneEditObjectData GPPCPDCBIBL = null, Vector3 IPKKCHLDJMA = default(Vector3), Vector3 GLPLIHEECAP = default(Vector3), bool JCAHFODLBNB = false)
	{
		return KDHKEDFHDHF.Error;
	}

	public SceneEditObjectBase EGKABKPNLNK(SceneEditPrefabConfigData JCONDDPFBKK, Vector3 HDFILHFDBKB, Vector3 IPKKCHLDJMA = default(Vector3), Vector3 GLPLIHEECAP = default(Vector3))
	{
		return null;
	}

	public SceneEditObjectBase GFAMNCOPMCL(Vector3 HDFILHFDBKB)
	{
		return null;
	}

	public void PDHBCIPABEC(SceneEditObjectBase BPDGEMBOGAA, SceneEditObjectBase FKODMCNOBDM, List<CNGBCLDDJEF> BMDHOAHLPCJ = null, int DDNJKMPIHEC = -1)
	{
	}

	public void LIFHONDEFKH(int NIBBKONKPHP, List<CNGBCLDDJEF> BMDHOAHLPCJ, bool DJPJBGKKEPC = false)
	{
	}

	public void ILMCFGPCDPK(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public void IDBLIJMAFFP(bool LPBPBKGNBKA)
	{
	}

	public void EEIMEIOKCKB()
	{
	}

	public List<CNGBCLDDJEF> HOHDCKLFNNN()
	{
		return null;
	}

	public void AAFNFMOMMEN(CNGBCLDDJEF DBIDOEGLGPL, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	private DLLFALCEOCM FCNJBPHKLAK(DLLFALCEOCM CCNBNLAPJFM)
	{
		return DLLFALCEOCM.None;
	}

	public void AOPKACMDFHC()
	{
	}

	public void BNKJJBCDMBO(List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	public void NAPJLECCFDI(CNGBCLDDJEF DBIDOEGLGPL)
	{
	}

	private void LCKNJLMPJJL(CNGBCLDDJEF DBIDOEGLGPL)
	{
	}

	private void IAJFFMHOPAG(CNGBCLDDJEF DBIDOEGLGPL)
	{
	}

	public JBMEGEPHDOL AMHONJLLDMA()
	{
		return null;
	}

	private int MCNCOAHDLBD()
	{
		return 0;
	}

	private bool GHLPJLFIPIE(uint BCGFIJHEDBO)
	{
		return false;
	}

	private bool PLEBECDENFF(ICollection<uint> FHBBPGDINFA)
	{
		return false;
	}

	private bool DGAHMAGNBBK()
	{
		return false;
	}

	private JBMEGEPHDOL MFLLNEKOIDN()
	{
		return null;
	}

	public void BBAMLNDCFKD(DLLFALCEOCM EDIMLPFKLLI, SceneEditObjectBase HACIJIFIDKM, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	public List<CNGBCLDDJEF> MMJEINGCPJA(bool KAKBPNEHCDB = true, bool OEELGHMOGBJ = true)
	{
		return null;
	}

	public bool JMKFCLMOEMH(List<CNGBCLDDJEF> BMDHOAHLPCJ, bool OEELGHMOGBJ)
	{
		return false;
	}

	public void DEGHFCADFBJ(SceneEditObjectBase IBDNJDLJPDG, bool MCABMDPCKKG)
	{
	}

	public void AAPAFHAPIFP(bool OADFPPJJHLL, LevelTriggerFountain GIHMGEJOFIL, bool HBFNCAPPMCJ)
	{
	}

	private void LJMLLKMEOLD(bool OADFPPJJHLL, LevelTriggerFountain GIHMGEJOFIL, CLKHLMIBPND AIEMIHKABNL)
	{
	}

	public void HJAEHLNALLL()
	{
	}

	public LevelTeleportDoor HKOAOLMEIPE(LevelTeleportDoor EBGHHGNFLCE)
	{
		return null;
	}

	protected override void OnFixedUpdate()
	{
	}

	private void OFHHABDHIEO()
	{
	}

	private void NMGHNEOFLME()
	{
	}

	public void HNMCJKLINCB()
	{
	}

	public void KGMJCMCBHEP()
	{
	}

	public bool OKCIFGBLCII()
	{
		return false;
	}

	public override int GetSubGameType()
	{
		return 0;
	}

	public void PJNBMPFOEAD()
	{
	}

	private void GGLCEJKKFPL(uint PFIHDHGJNLO, bool PCGMOOHAIDE, UnityEngine.Object HIMIPILNHMA)
	{
	}

	private void DEEKEOENLCA()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	public new bool _003C_003EiFixBaseProxy_IsOnlineGame()
	{
		return false;
	}

	public new LoadingProcess[] _003C_003EiFixBaseProxy_GetLoadingProcesses()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_GCLGIKFHIFH()
	{
	}

	public bool _003C_003EiFixBaseProxy_EnableGlassBG()
	{
		return false;
	}

	public new int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnLoadingSceneFailed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	public int _003C_003EiFixBaseProxy_GetSubGameType()
	{
		return 0;
	}
}
