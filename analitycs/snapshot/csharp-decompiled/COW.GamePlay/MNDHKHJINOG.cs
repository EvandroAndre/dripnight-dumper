using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using tcp;

namespace COW.GamePlay;

internal class MNDHKHJINOG : GAJPGHGIIIK, KOFCHBDBMFD, ODJFFCOMHMC, IUIModelDataChangeObserver
{
	public enum OMAKMKKBNCD
	{
		None,
		EnterNinthArea,
		EnterSocialArea
	}

	private struct HBFGFOOJPFO
	{
		public Player PGEGMKJKOKI;

		public float LPMEENCLEKL;
	}

	public class DKIGKFIEFCC
	{
		public byte KFIKKKKOLNA;

		public uint AKIMIECJAKC;

		public uint MLGLBHENIJH;

		public uint KDCMECDALHO;

		public uint KMDLFJAEDHK;

		public uint GJNLNIKHODB;

		public byte DJLCINFMBBK;
	}

	private enum EAKDPOBPABN
	{
		None = -1,
		Click,
		Interaction,
		Aim,
		Distance
	}

	public enum HONMPPEAHMF
	{
		None,
		Silent,
		Notice,
		Tips,
		Time
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__138_4;

		public static Action _003C_003E9__138_1;

		public static Comparison<HBFGFOOJPFO> _003C_003E9__156_0;

		public static Comparison<HBFGFOOJPFO> _003C_003E9__157_0;

		internal void LNCABOFBFLO()
		{
		}

		internal void NHBAFABALDO()
		{
		}

		internal int MMHPOAFEOLG(HBFGFOOJPFO MDFHMBHHGGF, HBFGFOOJPFO OGECPGHMIHA)
		{
			return 0;
		}

		internal int OFMHKBOBJAE(HBFGFOOJPFO MDFHMBHHGGF, HBFGFOOJPFO OGECPGHMIHA)
		{
			return 0;
		}
	}

	private sealed class DEBNJHCMAON
	{
		public MNDHKHJINOG KOKNHFGCGLN;

		public UIPopupMessageBoxController HEGPBHKGICJ;

		public EAccount.Proto OINKNIGKDMO;

		internal void JKFHAEJLAOM()
		{
		}

		internal void BAMIKJMBHOI()
		{
		}

		internal void MIFEOMJMHAL()
		{
		}
	}

	private sealed class MDIEDHEGPJD
	{
		public MNDHKHJINOG KOKNHFGCGLN;

		public string EELNPCJJPAK;

		public string IMCJLDKCGFB;

		internal void OJNGMLOMGEP()
		{
		}
	}

	private sealed class KKNNPMELDPD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public MNDHKHJINOG KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public KKNNPMELDPD(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class PEIECGOOMGF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public MNDHKHJINOG KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public PEIECGOOMGF(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static bool HAPPBINFDPL;

	private UILobbySocialAreaScene EGFIDOHPMFC;

	private BCLHEBDKJFK AMIKLIOJEJK;

	private int IMIIPDEFAHA;

	private BFDBJBBPHMK GECLMJHDKIL;

	private bool EFPMBDJAOIH;

	private bool ICLMDFFMNGN;

	private bool PJCDIKPDBHB;

	private float KPAIBEKMKJB;

	private bool DJADKLGMFKJ;

	private UIModelMatch PNPNCFGJCAL;

	private bool GHLCCAGFHAM;

	private int MKPKJEGBPMK;

	private float NNGAIABOOLD;

	private bool CGCIGKMPBFB;

	private bool PAMFJOPNLBP;

	private ulong JMEFAKNBMDA;

	private uint FDLHFDNJNOC;

	private int APCHKODPBHN;

	private int BNIPGFGOKGB;

	private const int BJNHGDEOIPB = 6;

	public PostEffectManager NFOJDPBEMBF;

	private bool BPPIDIMFMCB;

	private bool IGCKLGMNKFE;

	private bool ALPBPPHMGNC;

	private BAIJLLDCNJE IOGIGJKFILN;

	private bool EDHGNPLMHAD;

	private bool ONCGPJGGOCG;

	private bool MHKKEGOGFHA;

	public bool MPPGABFGHOA;

	private readonly List<HBFGFOOJPFO> MEHMCKHHJML;

	private readonly List<HBFGFOOJPFO> FFGOILIPMCA;

	private readonly List<HBFGFOOJPFO> LCJIFNKNPGN;

	private readonly HashSet<BHGGAEEHJCO> MGBDBILOPJF;

	private readonly HashSet<BHGGAEEHJCO> ADHEEOEAOPJ;

	private bool IPMLKKBFCGH;

	private BHGGAEEHJCO ALBFPLNHJNI;

	private int JCPLPGAMFKC;

	private ulong DBPNJBOOEIK;

	private ulong JMDEKFHPAHJ;

	private int IHJALOJMJEG;

	private UIHudLobbyLWBannerNoticeController DOBPBNMDAFI;

	private UIHudTimerCabinwaitingController MFLFDIMIJJH;

	private byte IGFABFJDHID;

	private int FHMJPLLJCPP;

	private int KHLIABDFPML;

	private bool GAFHCBGNMGK;

	private bool MDFKOGDFMNI;

	private bool GDINNMPBDFE;

	private LevelDynamicCollider[] AHPHILEGLDF;

	private Transform HJGLEAFDKCK;

	private Transform CJFDMDFJGDA;

	private Transform JGOLILFGKBC;

	private Dictionary<BHGGAEEHJCO, UIHudLobbyLWPlayerStateController> BMNKHENAGIN;

	private Dictionary<uint, uint> NMFICIKLCMN;

	private Dictionary<uint, uint> FHJKCIMFCJE;

	private Dictionary<uint, uint> ANPGPDKBPNB;

	private Dictionary<byte, DKIGKFIEFCC> PPOFJJCFBLM;

	private Dictionary<byte, bool> HBOLCKJPOBJ;

	private LobbyLWSceneExporter KICJCBGOOOA;

	private LevelDynamicCollider FILMELLIILH;

	private static List<Type> AHELFLDMHCD;

	private const ulong CFFLDJODHFG = 5uL;

	private ulong PHAEDKBKMMJ;

	public Stack<IEnumerator> ILGOCGEBPFC;

	private Player LHONNNDEAKK;

	private EAKDPOBPABN EGGMNIGKCLK;

	private float GMJANEMFCDK;

	private uint AJCFLEAICDA;

	private Player ADONFJBBBNP;

	private float LCCGCMPPJOP;

	private bool IPIGEGGJFNN;

	private float BEMFHGMHJNH;

	private const float HOBDJIBFLFB = 0.15f;

	private GMPGMPFNMFP MDFFFNCIFNH;

	private float AJEFAGKCNNK;

	private const float JPAEMCIKAOJ = 0.1f;

	private Dictionary<uint, float> AGDLEFMDABH;

	private Dictionary<uint, float> NCLOHKLLJAL;

	private Player JPPMGFOFJHH;

	private float CPOJKCGLLOB;

	private const float KBPHHININDB = 0.1f;

	private bool NCFEKBJIBJG;

	private float NPCDANCLJLF;

	private const float FKJHBGAGJIP = 0.15f;

	private GMPGMPFNMFP MCNDPEHBJDH;

	private Player DHOFALDNHBD;

	private int JJNOBGINGFL;

	private HONMPPEAHMF DOGKAIMJNML;

	private ulong EMGLNNOFDLF;

	private bool LHOBMMPECFF;

	private Dictionary<ulong, List<Player>> IBBFLIFLFHN;

	private uint NFJNGAEEBDD;

	public bool DANDDFHGDKM => false;

	private UIModelMatch BLPAIHIFCBJ => null;

	public bool BFHNMJBLCCJ => false;

	public bool LODNLGMILAF => false;

	public BHGGAEEHJCO LMDIDMAJBOI => default(BHGGAEEHJCO);

	private int IAKELAHDNCH => 0;

	public BCLHEBDKJFK CGIAEDAKAKC => null;

	public UILobbySocialAreaScene GOLPBMOCOGE => null;

	public int OKCAPIKOJPC => 0;

	public bool IJNMCMJPPPP => false;

	public int EELPIDLLGGI => 0;

	public uint DIEDPLMAGHM => 0u;

	private bool AMPFCBOJCJP()
	{
		return false;
	}

	private bool HAJBJHIDBFG()
	{
		return false;
	}

	private bool MIFBPMJOJPI()
	{
		return false;
	}

	public uint MEGEAHIANHJ(uint OBMFMAKFDDL)
	{
		return 0u;
	}

	public Dictionary<uint, uint> ICGABLCAOJC()
	{
		return null;
	}

	public uint AKNOENJKBDA(uint OBMFMAKFDDL)
	{
		return 0u;
	}

	public void GFPHHPFLMGI(uint OBMFMAKFDDL, uint JGLJPLEEIHN)
	{
	}

	public void JFDKIFCMJGF(uint OBMFMAKFDDL, uint FIEIGEBFAIJ, uint JGLJPLEEIHN)
	{
	}

	private void AIOJCGHHDGB(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public uint IEBOGCMKLMP(uint OBMFMAKFDDL)
	{
		return 0u;
	}

	public void HFHJIGFHJLH(uint NMLIDEAEHDJ, uint INPMHPDNMGD, uint HAHOGDLDFEA)
	{
	}

	public void PCICJNBMNAM(uint NMLIDEAEHDJ, uint INPMHPDNMGD)
	{
	}

	private void FHMNBINOLJA()
	{
	}

	private void NDHCEFFILBJ(Player KDJNEHDAAFL)
	{
	}

	public int KODNGPGMDCB()
	{
		return 0;
	}

	public int DIADMAPGPBC()
	{
		return 0;
	}

	public MPIBCFBJNNL GODCNABBDLK()
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	private void LHEOFPBMMGE()
	{
	}

	private void GGMGLAKGFHF()
	{
	}

	private void MDOKMJKFCLO()
	{
	}

	public uint GetInterestedPropID(UIBaseModel NAGHAPBBLKF)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel NAGHAPBBLKF, uint FAICJLONPIK, object[] DJAPBCKDFKA)
	{
	}

	public override bool ShouldClearPreloadAssets(Type PNBPJAMLABK)
	{
		return false;
	}

	protected override void OnSceneLoaded()
	{
	}

	protected override void HEPEKHFOODE(uint PPPGENPKBIN)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CEGCKIAJNMI()
	{
	}

	private void JBMHOCCNODC()
	{
	}

	private void ODKANAMFJJI()
	{
	}

	private bool PIEMBGDGJJE()
	{
		return false;
	}

	private void JEPFFPNMCDK()
	{
	}

	private void LHLJBCCALDH()
	{
	}

	private void AOECHAHMGAN()
	{
	}

	private IEnumerator BJFAMBMPOBM()
	{
		return null;
	}

	private int GBKAHEIDEBB(ResourceID GGMIDNEJGNO)
	{
		return 0;
	}

	private void NMDALCPICJL()
	{
	}

	protected override void OnPreloadLoaded()
	{
	}

	public override LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	public override bool IsOnlineGame()
	{
		return false;
	}

	protected override bool CJIMFNLGNPG()
	{
		return false;
	}

	protected override bool HICAHNILDDI()
	{
		return false;
	}

	protected override void FKNOEAKPBIF()
	{
	}

	protected override bool BlockReturnToLobby()
	{
		return false;
	}

	public override bool CanFreeQuit()
	{
		return false;
	}

	public override bool NAOGJDKDCBI()
	{
		return false;
	}

	protected override bool BBHMICFJAPO()
	{
		return false;
	}

	private void KLACCLLHBKH()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnFixedUpdate()
	{
	}

	private void PIPHNPHINHM()
	{
	}

	public override void OnDelPlayer(Player KDJNEHDAAFL)
	{
	}

	protected override void InitGRIData()
	{
	}

	public override void AfterJoinMatchFinish()
	{
	}

	private void HAKHODGJBAO()
	{
	}

	private void AAKKDJEPEPK(EMKJHAJNPDH MNNJOCCOALP, Vector3 AFKCGGIMKMD, float ACCHMKDLKAE, float PODDABBCJDC, bool PGDAMCINKIB)
	{
	}

	private void HHPCMNGBIBO(Player DCAPIHJMMBL, ref int NHDPJKCAOII)
	{
	}

	private void PKAMBJFCFPN(Player DCAPIHJMMBL, ref int NHDPJKCAOII)
	{
	}

	private void LHHAKPKOLOA(EMKJHAJNPDH MNNJOCCOALP, ref int KCNBMJKIDAP)
	{
	}

	private bool FACKADLLGAF(Player PGEGMKJKOKI, ref int NHDPJKCAOII)
	{
		return false;
	}

	private int PLGNBOKGEPL(Player PGEGMKJKOKI)
	{
		return 0;
	}

	private int IOFCLCPOJIL(Player PGEGMKJKOKI)
	{
		return 0;
	}

	private void INMMOFJCKOO(Player PGEGMKJKOKI)
	{
	}

	private void KBGIONJDFOJ(EMKJHAJNPDH MNNJOCCOALP)
	{
	}

	private void CPHBKFLLCJB(Player PGEGMKJKOKI, bool KGOHDEBHENF)
	{
	}

	private void KPMCPAAIOLP(EMKJHAJNPDH MNNJOCCOALP, ref int KCNBMJKIDAP)
	{
	}

	private void NOGCKLOMBPD(List<HBFGFOOJPFO> IPCPKIPFHKF)
	{
	}

	private void JENLEBFBLGC(Player DCAPIHJMMBL, List<HBFGFOOJPFO> IPCPKIPFHKF)
	{
	}

	private void OJPIODPFMOB()
	{
	}

	private void DPGHKPEJJPM(bool GLEPMAENGNF)
	{
	}

	protected override void PHCIBIKNFLI(AODHDBMJFKH OINKNIGKDMO)
	{
	}

	private bool EPMIHBHOFAB(bool MONOJGPHPNF)
	{
		return false;
	}

	private void ODJJFKLCCCH()
	{
	}

	private void KHAMMLOOAMN()
	{
	}

	private void IGEHBGGNEDH()
	{
	}

	private void NMGEBFAPPBC()
	{
	}

	public void EFBLEMHBFOA()
	{
	}

	public void JMCNGOFGEML()
	{
	}

	public void LFBEGKOIPLH()
	{
	}

	private void CEKGAOLFAIH()
	{
	}

	private void BLCBFHFIFPH()
	{
	}

	public void PHIJJODNPOF()
	{
	}

	public void NENBECMEDOE()
	{
	}

	public void OIELECPMKBH()
	{
	}

	private void CHCEPGIGFLN()
	{
	}

	public void FAKFKCGMFGN(GameFacade.ESocialLobbyState CBCAJJJCKLH = GameFacade.ESocialLobbyState.ExitSocialArea)
	{
	}

	public void HECFJJMJNLA()
	{
	}

	private void DBEBEGPFKKD()
	{
	}

	public void DONONPJDJLI()
	{
	}

	private void GCNDLIHOBCK(object[] JCONDDPFBKK)
	{
	}

	private void MIOLNGOFKAM()
	{
	}

	private void IMJICKPJFCN()
	{
	}

	private COEDKLIGPPD KHLCGGEEMOO()
	{
		return null;
	}

	private void GCDKCEMHMCO()
	{
	}

	private void PDEJPKBDOLD(object[] JCONDDPFBKK)
	{
	}

	private void NCLOJAABJDG(object[] JCONDDPFBKK)
	{
	}

	private void DEABOKKNABE(bool DJMACFPJHLB = true)
	{
	}

	private void FCNLLHOGFCH(object[] JCONDDPFBKK)
	{
	}

	public void HBPIGJECDMD()
	{
	}

	private void LJILABMOLJM(Player DCAPIHJMMBL, out Vector3 HDFILHFDBKB, out Vector3 BAPEDKECNLH, out Quaternion HOAIBNGIOPP)
	{
		HDFILHFDBKB = default(Vector3);
		BAPEDKECNLH = default(Vector3);
		HOAIBNGIOPP = default(Quaternion);
	}

	public void OLEFOKKHGEG(Action OHAOABHJIOI = null)
	{
	}

	public void EFPHGKAIIII(bool HKGNEMEHBIG)
	{
	}

	private void CLEGKEKIHKN()
	{
	}

	private void DKJCLJIOLGM(uint IALLJFNIHFG)
	{
	}

	private void LDIBAOFLEHC(uint IALLJFNIHFG)
	{
	}

	private void HLGEABBJIPP()
	{
	}

	public void HCJOOCPOPLM(string KAEPDGADBPN, float CNKMEPFCJOM = 2f, string NAOHDOFAEOL = "", string LLEFLKLJCBG = "", string ADKDBFJPIHH = "", Color PBGNBFBBBAC = default(Color), bool KGLAMFIMKJM = true, Color IJFPBPEBFDB = default(Color), bool NGHLFNBNAPK = false)
	{
	}

	public void PIFPFLAICHB()
	{
	}

	private void EAOHNMNKKNI(OBOHAOFFODK OLBPPGANKJL)
	{
	}

	private void ABEFDMPKGKF(OBOHAOFFODK OLBPPGANKJL)
	{
	}

	private void APIOCBGJHKG()
	{
	}

	private void HKDGNNPCLPJ()
	{
	}

	private void IIGCGIIAOFI()
	{
	}

	private bool BIBLNMIKBIA()
	{
		return false;
	}

	private void FIIEHFNKIND(byte JJNFMJLKPPK)
	{
	}

	private void BNHEBPNJMGB(int JJNFMJLKPPK)
	{
	}

	private void HNGOBLKOIDI(bool IDCHCEECMBE = false)
	{
	}

	private void FAKHNJCIACB()
	{
	}

	private void ONPFJLGCAFL(byte JJNFMJLKPPK)
	{
	}

	private bool LBMLDHJBDEK()
	{
		return false;
	}

	private void KBDFPCMJCAJ(string LCADIHPKFPD, string JJPLCFEKCJB, ulong MKCCNABIKII, OnFinished LKFKPEOKIHB)
	{
	}

	private void DOPMHGCKJGC()
	{
	}

	private void ACAAJOENLJO()
	{
	}

	private void GKBGFPBDMHO()
	{
	}

	private void BNDANIANMHB()
	{
	}

	private bool FBNNGGLMJDK()
	{
		return false;
	}

	private void ECDHCCOBJND()
	{
	}

	public void PGDFOODBKLI(uint HDAKHGBKKAD, bool DOGJGFKCFJC, bool BPHIFGCEIDE)
	{
	}

	public void JDJCGELKKGC(byte JJNFMJLKPPK, byte DJNIMMLLMBB, bool CGANHKDFAJF)
	{
	}

	public void IHHIIKDEOBF()
	{
	}

	public void PCOJPDLPEDC()
	{
	}

	private bool EPHJAIIPHGD()
	{
		return false;
	}

	public void BAIKMGJLGAF(byte JJNFMJLKPPK, byte CBCAJJJCKLH, uint HEMAINCHDGN, uint EOANDEFKBGI, uint AGCAAELMABN, uint HLHDOHLPKBH, uint ALLPCGCCEOL, byte MGOLCPKCIDE)
	{
	}

	public bool POPGJJDDEOK(byte JJNFMJLKPPK, out DKIGKFIEFCC NBLHNPAHGNA)
	{
		NBLHNPAHGNA = null;
		return false;
	}

	public bool JHAFBLFJDEH(uint OBMFMAKFDDL, out DKIGKFIEFCC NBLHNPAHGNA)
	{
		NBLHNPAHGNA = null;
		return false;
	}

	public void BANKBCJFEGP(uint OBMFMAKFDDL)
	{
	}

	private uint EEKKKEKNIFA()
	{
		return 0u;
	}

	private void NFCIEFOAFFK()
	{
	}

	private UIHudLobbySocialAreaNameController KGAGEAPBGPN()
	{
		return null;
	}

	public Transform BBFINAKELCL()
	{
		return null;
	}

	private Transform JOCHLPBEGOG()
	{
		return null;
	}

	public bool JJDPNOJCFDL()
	{
		return false;
	}

	public bool HPEGCDEPKHC()
	{
		return false;
	}

	public bool NBLPAJDGPHK()
	{
		return false;
	}

	private void BDBILMEMJGH(bool FMKKPHJALHL)
	{
	}

	private void HLBJOKBLADP(bool NJDBJAFIAAK = false)
	{
	}

	private void KMCJBLGEFCJ()
	{
	}

	private bool GLFOJOAIMIA(UIModelGroup ADEDGKALOND)
	{
		return false;
	}

	private void ANNECBNMIHP()
	{
	}

	private void IMPAEFNOCIH()
	{
	}

	private void CAAOGGKACOP()
	{
	}

	private void BGIBBKHGEII(Transform ONDFEPGKOBO)
	{
	}

	private Transform OIAJADGMKNP(string FEDLCFIPGFJ)
	{
		return null;
	}

	public void GONJJLKCJNF()
	{
	}

	public void CKEOBKJPLIL()
	{
	}

	public IEnumerator IDHIHMKLBDG()
	{
		return null;
	}

	public void KJPNABNFNIG()
	{
	}

	private bool MEOEMKHHJNO(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public void HCFNKACNPOM()
	{
	}

	public void BMECIBICDBJ(uint[] OBFKKBDHFAK)
	{
	}

	public void NLBLGNIDMHM()
	{
	}

	public void OHMEKPJAEPI()
	{
	}

	public void HEDINDJDEFA(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void GHAOBCGJAAL()
	{
	}

	public bool CPNJKGDEOLD(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	private void KILDMEAFOMJ()
	{
	}

	private void PPBLCPMFIOI()
	{
	}

	public void EEGNBEBCCIF(bool EOGOGFLCEHL)
	{
	}

	public void JJAGPAILNND(byte JJNFMJLKPPK, bool HCLGHJNEFIC)
	{
	}

	private void ENEGAKCMLEA()
	{
	}

	private void PGOBNCBILKB(byte JJNFMJLKPPK, bool HCLGHJNEFIC)
	{
	}

	private LobbyLWSceneExporter PGOEPLJPJFN()
	{
		return null;
	}

	private LevelDynamicCollider KEPFLLGLFJG(LobbyLWSceneExporter FMMMCFCMNIE)
	{
		return null;
	}

	private int HBDIPLNEBCF()
	{
		return 0;
	}

	public override bool NAJLMDOMMNE()
	{
		return false;
	}

	public override bool AllowPlayerMoving()
	{
		return false;
	}

	private void LBAIJMAELLD()
	{
	}

	private void JAKJNONNDNI()
	{
	}

	private void MGEAOBDJEGF()
	{
	}

	private void LCPOHMEGDPC()
	{
	}

	public void NDFNNKFAMOI()
	{
	}

	private void DBNLDJBPPBJ(bool KKLBDPGJGFL)
	{
	}

	public bool IIDNMFNENEB(bool DABLJLGBFKN)
	{
		return false;
	}

	private Player GMEDCOLMFPG(uint OBMFMAKFDDL)
	{
		return null;
	}

	private void CCLGKIMGNKG(CameraControllerManager MDKMGGEOOOD, Player PFJFADHEJLJ)
	{
	}

	private void AOLMJFDBJEL(bool EOGOGFLCEHL)
	{
	}

	private void JKFJOCKAEBL(bool GICJAPOKJFP)
	{
	}

	public bool CFLONPBGDAM(uint OBMFMAKFDDL)
	{
		return false;
	}

	public void CMMHNIBKBFO()
	{
	}

	private void PBGNHCFMBKP(Player PGEGMKJKOKI, EAKDPOBPABN GKMFJPIEFGH, EventLogger.ESocialHubPersonalInfoTriggerSource LBGOPHDLJKH)
	{
	}

	private bool MCHDKJMFNOG(Player PGEGMKJKOKI)
	{
		return false;
	}

	private bool OIMILMCOACL(Player PGEGMKJKOKI)
	{
		return false;
	}

	public void DGMOAKNDLBG(Player PGEGMKJKOKI)
	{
	}

	public void AIAGFGHFALC(Player PGEGMKJKOKI, EventLogger.ESocialHubPersonalInfoTriggerSource LBGOPHDLJKH)
	{
	}

	public void ODHBEKEKFGM()
	{
	}

	private void LIAALHALALE()
	{
	}

	private void HFBCGFJHMCD(Player PGEGMKJKOKI)
	{
	}

	private void FAMKNECFLLE(Player PGEGMKJKOKI)
	{
	}

	private void DHLECCCEMEP(float HOGHEFNINAE)
	{
	}

	private void DINIEMNKCMH()
	{
	}

	private void MHCNFAIBOLF(float HOGHEFNINAE)
	{
	}

	private void GGNNOMDAIAH(float HOGHEFNINAE)
	{
	}

	public void JAPIFNKNJJO()
	{
	}

	public void IJHAAMCNGOK()
	{
	}

	public void OJEHJFNPNEC()
	{
	}

	public Player FFJIINDEAPL()
	{
		return null;
	}

	private void NIPOHGGKGDP(float HOGHEFNINAE)
	{
	}

	private void CGBNFJJHJBC()
	{
	}

	private bool LMJOFKNLGCB(Player PFJFADHEJLJ, Player DCAPIHJMMBL)
	{
		return false;
	}

	private void DCBOBJMHFCB()
	{
	}

	private void PHLFCHPKFBD(bool HKGNEMEHBIG)
	{
	}

	private void LNMAPPGKENP()
	{
	}

	private void MAKKACOPFMI()
	{
	}

	private void MKHDGHCCKKD(object[] JCONDDPFBKK)
	{
	}

	private void PGFFCCEHHHI(int PNBCCLOBJPN, int EKPCLIALINJ)
	{
	}

	private void IFKMKINMKDK()
	{
	}

	private void PCAEGOOKPJF()
	{
	}

	private void MIHBPNOBPFG(HONMPPEAHMF PPPGENPKBIN)
	{
	}

	private void DJMPMBIODLB()
	{
	}

	public bool MFDEALHEOBD()
	{
		return false;
	}

	public bool NFKOIINKGCP()
	{
		return false;
	}

	private static ulong DBIINHDAONP(uint OJMFPMFDLPA, uint CDGMELDBOPO)
	{
		return 0uL;
	}

	public void KJGAAMJJAMM(Player PGEGMKJKOKI, uint OJMFPMFDLPA, uint CDGMELDBOPO)
	{
	}

	public void HKAPICDNFME(Player PGEGMKJKOKI, uint OJMFPMFDLPA, uint CDGMELDBOPO)
	{
	}

	public List<Player> KOPCKNGGLKM(uint OJMFPMFDLPA, uint CDGMELDBOPO)
	{
		return null;
	}

	public bool KJDADHHALCP()
	{
		return false;
	}

	public int HGHNKIHCMEG(float NMEEAHMNACE = 0f)
	{
		return 0;
	}

	public int CLCJPONJFJI(bool HIHJBDOBEIH, bool LPBPBKGNBKA = false)
	{
		return 0;
	}

	public bool NIHAMAGIDAP(uint FJCPAJEPBOD, out float CNKMEPFCJOM)
	{
		CNKMEPFCJOM = default(float);
		return false;
	}

	public bool BEAOPABPJNF(out float CNKMEPFCJOM)
	{
		CNKMEPFCJOM = default(float);
		return false;
	}

	private void GJCGKMFAOJH(bool JCONDDPFBKK)
	{
	}

	public override void OnAddPlayer(Player KDJNEHDAAFL)
	{
	}

	private void BBOMAHBOJDJ()
	{
	}

	private void GPGHOABJCFJ()
	{
	}

	private void JAMOFGBPLEF(string IMCJLDKCGFB, string EELNPCJJPAK)
	{
	}

	public void ONNNJLDBGGI()
	{
	}

	private void OPLGPBJPHPC()
	{
	}

	private void IBGBDGJAJBM()
	{
	}

	public override ResourceID[] GetPreloadResourceIDSeq()
	{
		return null;
	}

	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	private void PGFOFBCIPHC(EAccount.Proto OINKNIGKDMO)
	{
	}

	public override void OnStartLoadScene()
	{
	}

	private void EPBNILMDCED()
	{
	}

	private void JOCJMAICLPE()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new bool _003C_003EiFixBaseProxy_ShouldClearPreloadAssets(Type P0)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_HEPEKHFOODE(uint P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}

	public new LoadingProcess[] _003C_003EiFixBaseProxy_GetLoadingProcesses()
	{
		return null;
	}

	public new bool _003C_003EiFixBaseProxy_IsOnlineGame()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CJIMFNLGNPG()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_HICAHNILDDI()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_FKNOEAKPBIF()
	{
	}

	public bool _003C_003EiFixBaseProxy_BlockReturnToLobby()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CanFreeQuit()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NAOGJDKDCBI()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_BBHMICFJAPO()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDelPlayer(Player P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitGRIData()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterJoinMatchFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_PHCIBIKNFLI(AODHDBMJFKH P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NAJLMDOMMNE()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_AllowPlayerMoving()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAddPlayer(Player P0)
	{
	}

	public new ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceIDSeq()
	{
		return null;
	}

	public new ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnStartLoadScene()
	{
	}
}
