using System;
using System.Collections;
using System.Collections.Generic;
using COW.Graphics;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class EMKJHAJNPDH
{
	public enum NJMHKHCLBNN
	{
		NotStarted,
		Running,
		WaitingForEnd,
		EatingChickenDelayEnd,
		MatchEnd
	}

	protected class FOBJEAPMMEJ
	{
		public uint AIGDBGLCCMN;

		public uint OKLOJEJFNOK;
	}

	public class KKDAICOONPI : GEvent
	{
		public BHGGAEEHJCO GJKKLNLABPO;

		public bool LEHGCIHJLJD;

		public bool BPJAHADCGDG;

		public void BLJEIAHKEPL(BHGGAEEHJCO GDHOJCDAGHJ, bool DBHJCLICABH, bool OOHPGKKKJJP = true)
		{
		}
	}

	protected delegate void JPCGBALBHFA(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE);

	protected enum AEMIOCIJGBI
	{
		Controller,
		AI,
		Behavior,
		Kinematics,
		Post,
		PendingRevive,
		Destroy,
		NB
	}

	protected delegate void CLFNIKPHMED(NetworkAIPawn KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE);

	protected enum ANFEKDFNLEP
	{
		Behavior,
		Kinematics,
		Post,
		NB
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__15_0;

		public static JPCGBALBHFA _003C_003E9__621_0;

		public static JPCGBALBHFA _003C_003E9__621_1;

		public static JPCGBALBHFA _003C_003E9__621_2;

		public static JPCGBALBHFA _003C_003E9__621_3;

		public static JPCGBALBHFA _003C_003E9__621_4;

		public static JPCGBALBHFA _003C_003E9__621_5;

		public static CLFNIKPHMED _003C_003E9__632_0;

		public static CLFNIKPHMED _003C_003E9__632_1;

		public static CLFNIKPHMED _003C_003E9__632_2;

		public static Action _003C_003E9__700_0;

		public static Action _003C_003E9__710_2;

		internal void ICMEBPALOPP()
		{
		}

		internal void BJNCFONIOCC(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void FHANFACEECM(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void MAMPDGNNLPG(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void GMGKIJBEIGG(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void IIGPMAPKDGO(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void HEMALJOIEGC(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void NFEJANGKDPO(NetworkAIPawn KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void JAECPBNCJLK(NetworkAIPawn KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void OIPADPCKKCK(NetworkAIPawn KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
		{
		}

		internal void GPOLPHKNPKJ()
		{
		}

		internal void LDKJABPPGJD()
		{
		}
	}

	private sealed class ODEJNMFFICN
	{
		public StationTrainController MBPACHDMAKC;

		internal void MHILFEBOLCP()
		{
		}
	}

	private sealed class EFOIOBPKDNJ
	{
		public Player PGEGMKJKOKI;

		internal void PCDNKMEKAPM()
		{
		}
	}

	private sealed class JEAJGBHFLGA
	{
		public Player PGEGMKJKOKI;

		internal void HJNIKFCFOEN()
		{
		}
	}

	private sealed class PKCHMALLHDP
	{
		public EnvWeatherZone BOCPOGEDOOB;

		public EMKJHAJNPDH KOKNHFGCGLN;

		public uint KJLFMPOFELA;

		internal void PFMDAMGPKDF()
		{
		}
	}

	private sealed class CAEGAEACBAF
	{
		public ResourceID FDFIJPPHGFF;

		internal void NBDJLLEBPPK()
		{
		}
	}

	private sealed class LBKNOPIJEEC
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public BHGGAEEHJCO OBMFMAKFDDL;

		internal void MGMGKPDOENG()
		{
		}
	}

	private sealed class JEGADOOFLJN
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public Vector4 PLNNLJEPICJ;

		public FinalShotData MFFCGIKEACP;

		public Vector3 IGDHIDGLOKG;

		public bool JEHCHKOEEPC;

		public Player KDJNEHDAAFL;

		public bool IMNAOAMNKCO;

		public ResourceID GHADJIDJPGH;

		public Vector4 NOPKKBLJCBH;

		public ResourceID OJOCDBCIMED;

		internal void OMMPCODBOLP(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}

		internal void LAMLIPDOONJ(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class EKGDOHMPMJF
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public object DGDDJLEOPBL;

		public ResourceID OCCLMDNGINA;

		public Vector3 IGDHIDGLOKG;

		public Quaternion FOALBMBCJLF;

		public Action<uint, bool, UnityEngine.Object> CEHELPAIELA;

		internal void GHDMCNFLAGN(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class CDONGJJPKAC
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public Player PGEGMKJKOKI;

		public DOENGLMMFID APHHNHEDHKD;

		internal void HMJDLLCCKNJ()
		{
		}
	}

	private sealed class GLNAJLDHINJ
	{
		public PHLHIEGPMMK ONLNNOFPLEF;

		public APELCIGCHDJ ADIJJMBGCLH;

		public CDONGJJPKAC EDIPCAMGBNP;

		internal void FEPPBPEOLJB()
		{
		}

		internal void NAGBMJCPGFJ()
		{
		}
	}

	private sealed class KKAGMEELBOG
	{
		public uint KCGLCOLIFHB;

		public CDONGJJPKAC HIDGOLEIPLE;

		internal void MKAAPIFDGCF()
		{
		}
	}

	private sealed class GOHOLDMAIJF
	{
		public Player PGEGMKJKOKI;

		internal void DOEOAAGDODB()
		{
		}
	}

	private sealed class POJIODPELKE
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public Player PGEGMKJKOKI;

		internal void ONBPHPMHBNC()
		{
		}
	}

	private sealed class COECFFMEFDE
	{
		public Player PGEGMKJKOKI;

		internal void JGOOOEHKGKE()
		{
		}
	}

	private sealed class CEDEKFOKOPF
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public Player PGEGMKJKOKI;

		internal void KPABDGDGGDA()
		{
		}
	}

	private sealed class MFLEAIGILIM
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public PNLIIHCENGK LKOCMCFKKDA;

		public uint ODDBNMALHOB;

		public uint CDPMEECAANM;

		public int ANHNFBJPPPI;

		internal void JHNANAINJEO()
		{
		}
	}

	private sealed class PFFDIPDIIIK
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public int GLCNIFHIMAJ;

		public int KGCFNKCENPB;

		internal void EAFADOIJELK()
		{
		}
	}

	private sealed class FHCFGHNHMPK
	{
		public bool KOMHBCECHKH;

		public EMKJHAJNPDH KOKNHFGCGLN;

		internal void AGEGIILEMHF()
		{
		}
	}

	private sealed class EGNNBIJEACP
	{
		public EMKJHAJNPDH KOKNHFGCGLN;

		public LevelContainer JKEHCDBFJNI;

		public JNBDEBNKKHC APHHNHEDHKD;

		internal void OIGCIGNNPBG()
		{
		}

		internal void JFBBADFEFKG()
		{
		}

		internal void ONALCGDLCIO()
		{
		}
	}

	private sealed class BMPKDIMFFDG
	{
		public ushort DGDDJLEOPBL;

		public Player FFHGOACBDMH;

		public EGNNBIJEACP EDIPCAMGBNP;

		internal void PHABMBFIIBI(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class DDANCPKDADH
	{
		public IOENNEBCHBF GAPPGAIMOPF;

		public ushort DGDDJLEOPBL;

		public uint OBMFMAKFDDL;

		public EGNNBIJEACP HIDGOLEIPLE;

		internal void HNOJNPDMAOD(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}

		internal void GOJHJMFDNPJ()
		{
		}
	}

	private sealed class OOLAPJMHNKI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public OOLAPJMHNKI(int CBPPJACCGOH)
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

	private sealed class BIOGHGOICIL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public EMKJHAJNPDH KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public BIOGHGOICIL(int CBPPJACCGOH)
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

	private bool _003CMGHMOKNPPLK_003Ek__BackingField;

	private uint AEBEKDAOHJH;

	private bool DJAPCFNODAA;

	private uint LDNPBCLKPDC;

	private HashSet<int> FAKCLBDCDCP;

	private uint CCNOOHHHPKK;

	private Vector3 CHOJKDDFBOC;

	private Quaternion JJHHDEBHDMI;

	private bool OMCLBJLMNDO;

	private GameObject KBCBGAOGPJL;

	private bool PIEJCHKJICB;

	private uint FLBICPGIAPB;

	private uint DANODPHEPPP;

	private Color[] PGBFMEMPOCI;

	private bool DJFIDGMKCGI;

	private GameObject CHINBJANIEL;

	private GameObject MPKOCLGGBPD;

	private AudioResource ECANKACGLLO;

	private GameObject BAFNGLJHJFF;

	private Dictionary<uint, EnvWeatherZone> JDMAHKEEHAO;

	private string JDBIIFOOPAN;

	public uint MBPOJMNFPDC;

	public int HCGDECJOLGH;

	public uint OPCPJIPJOIL;

	public int PCAGJBIKCHN;

	private Dictionary<uint, LevelObjectIIVTeleportDoor> OPDJFDJHEKJ;

	private AudioResource FNOOHLJNFBD;

	private bool DDNEPIHDBGL;

	protected NJMHKHCLBNN MAOHIOEAMEA;

	protected GameObject HDGBEMNHCKE;

	protected Player PDBGEOANOEP;

	protected BHGGAEEHJCO AMLJBGAHLKF;

	protected uint IIHPIGBEINA;

	protected PHLHIEGPMMK MPMAGJDHNBI;

	protected APELCIGCHDJ CBFABGILFBI;

	protected JBLBHNDJNKF HCEECGAMHLI;

	protected Dictionary<BHGGAEEHJCO, int> HDODOENHNHI;

	protected Dictionary<BHGGAEEHJCO, string> FHDMFEGOOMJ;

	protected Dictionary<BHGGAEEHJCO, Player> NGFEHJMADOJ;

	protected Dictionary<BHGGAEEHJCO, Player> LNNHDLJFKLI;

	protected Dictionary<BHGGAEEHJCO, string> NPCKOHKHNCH;

	protected Dictionary<BHGGAEEHJCO, Player> ECILNDJHBAL;

	protected Dictionary<byte, Player> MMECELKLHFC;

	protected Dictionary<BHGGAEEHJCO, Player> DANHAGDJLOG;

	protected List<Player> CGLCNGIMJLF;

	protected List<Player> EIEKICOGNHF;

	protected Dictionary<BHGGAEEHJCO, NetworkAIPawn> NECMEPIPNCM;

	protected Dictionary<BHGGAEEHJCO, PHLHIEGPMMK> DLJELOEHOED;

	protected Dictionary<byte, MatchTeam> OJKBIPDHNAK;

	protected Dictionary<ulong, JBLBHNDJNKF> JKMLGAKMNJE;

	protected Dictionary<ushort, LevelVehicle> AKAIIDFKOIB;

	protected Dictionary<ushort, LevelMovePlatform> HHDFIBJIIGC;

	protected Dictionary<uint, NetworkPet> IOEEKNJNCNH;

	protected Dictionary<uint, FOBJEAPMMEJ> LPFFEPABCJO;

	protected Dictionary<byte, NOJKBEOPKKE> HMKHBBFEADN;

	protected HashSet<uint> LLEDMLNMLMP;

	protected uint BNFCAIILKLB;

	protected uint LCMCMPOKDLF;

	private ResourceID NFCKLBLGPKA;

	private ResourceID DJLAHFIMBED;

	public MNMBLBKENMK BPBKFCFJOJM;

	protected bool JFGBAKJJMJJ;

	protected bool DBDIKBLJNJN;

	protected bool MFIONKPHLJL;

	private bool BMKFGAPHBNI;

	private bool KBGNMAACPEB;

	public bool JFCBNIBIAGL;

	private Transform _003CLFMEEGBFOAM_003Ek__BackingField;

	private float CHLJCNDOJKP;

	private const float MMPIJPMNHHP = 4f;

	protected List<BaseLevelObject> FECOAHLOOLB;

	protected List<OGIJAGDFGAM> DOCECBIDPKH;

	protected GameObject NFPHAHNDLOI;

	protected List<OKEAMEELLBB> HCLFEIEFKHP;

	protected List<OKEAMEELLBB> CLAPKLIGMPH;

	protected SafeZone KFHKCIKKGNP;

	private IMMJAOPJAEB LHDCNIENDBH;

	protected LGBPPLOIEON MEMGKKBBOLP;

	protected MDGHHNEMFIE HFJPDIEIJNJ;

	protected IKPCOMMDCAB GKODCKNGAHH;

	protected NNDIBCOGKEJ AOKBNGLNENJ;

	protected AirtransportParams JJOLHADAOEH;

	protected AirTransporter KIIMAHNPMNA;

	protected Entity NFJIDLJEPJB;

	protected ResourceID LDHOFMMDKPI;

	protected JMENFKECPNA KLEOAAKIMAH;

	protected CHJOIHHHAIC LIMFMOACEOM;

	private CENNCIIJNFK _003CEKOCALDAJMH_003Ek__BackingField;

	private readonly List<MECJOKLINMA> FGKFPDGBEBN;

	private readonly List<KAEJKILJHGC> EKHOJILEJEL;

	protected PMIIOOIBNCC BBCKCPPDMPM;

	protected uint JIGDPCOMNOK;

	protected uint LCPKNDPPDEN;

	protected IHFFDJIDIAA CILLAGEEAGJ;

	private Dictionary<uint, bool> IJNLLMDFMJI;

	private Dictionary<uint, LevelContainer> KCFPGDPPDEA;

	private Dictionary<uint, IOENNEBCHBF> OPGJDHEIKAC;

	private uint PNFEDBJDNCA;

	private uint CNBCEELDEGB;

	private Dictionary<byte, Dictionary<LevelContainer, bool>> PIHFPPAPDMB;

	private Dictionary<byte, Dictionary<IOENNEBCHBF, bool>> GCHNHGPOGDL;

	private byte ECOLDCGEIFD;

	private uint HDCACILMDAM;

	private Dictionary<string, string> IAPLBALIAIH;

	private Dictionary<string, LBNKMHIMNIC> KCFBKMAHDEN;

	private CIJEINAHABO FOAIFJCDOOG;

	private uint CDFDCFLPNAL;

	private BHGGAEEHJCO HHMFEFHBHBM;

	private Dictionary<byte, Dictionary<uint, LevelContainer>> EHFKKDAALKA;

	private Dictionary<byte, Dictionary<uint, IOENNEBCHBF>> EKAOKLCPHAH;

	private uint PNCDPEGFKBP;

	private uint PGLHHADPBGF;

	private const float HLOEHKDFNDH = 10f;

	private const int JCAPJCIMNGI = 3;

	private Dictionary<ResourceID, Queue<uint>> JEGFHDNFOGJ;

	private ResourceID FFOKEMJELBM;

	private bool KADKHPAKACC;

	private ResourceID FKGCJNIGHIL;

	private ResourceID MIMCHPNPHIB;

	private ResourceID EJJNJDEMEMB;

	private ResourceID EPKPEHIMFMK;

	private ResourceID AGNJLAOJCBM;

	private ResourceID MEFNJHBJJEO;

	private ResourceID GEKJBMGHCJA;

	private ResourceID ADEPALLMKKG;

	private ResourceID NAHBPDHNBGG;

	protected ResourceID CBBPEMGIMPG;

	protected ResourceID BAPGGKJBOOL;

	private ResourceID IKBCMCCMOHP;

	protected ResourceID GDKKHKEGNIP;

	protected ResourceID NGLCLMKGAPE;

	protected ResourceID JMLJFMEOCGP;

	protected ResourceID NGMPOKIHODH;

	protected ResourceID DDEKJBDIHKJ;

	protected ResourceID DMEOKFOBHBA;

	protected ResourceID AGOEHOMJFNJ;

	protected ResourceID HNEBBNOOCEB;

	protected ResourceID FGHBAMBOLAH;

	protected ResourceID PKBKNLPANIG;

	protected ResourceID OACPGKNHDAG;

	protected ResourceID DHKNELIDLGB;

	protected ResourceID CLEFOPFPCOP;

	protected ResourceID FKHEDCFGAGE;

	protected ResourceID GALHHDDDBCF;

	protected ResourceID ICCKHEDODDH;

	protected ResourceID EAIHGPPLIEL;

	protected ResourceID IKPEALAEMFD;

	protected ResourceID IDGHDGLFCJM;

	private ResourceID PDAJOIDJMOM;

	private ResourceID ANHHHJGIHDP;

	private ResourceID COABKLBCHBC;

	private ResourceID OKMDGCCAKDC;

	private ResourceID BDGKBGELJEK;

	private ResourceID KCFNBOHIPCG;

	private ResourceID JPOHNPDOGME;

	private ResourceID IDACKLMHBPH;

	private ResourceID CHMFMDHGAPL;

	private ResourceID CNMIIEKAFCC;

	private ResourceID KDOEMDODNEG;

	private ResourceID EDOKPAAMHPN;

	private ResourceID GGDEGDCJCPK;

	private ResourceID NBDOHFPOEIH;

	private ResourceID JCAGNLNIFNM;

	private ResourceID JKGDAPLJNFD;

	private ResourceID IAGJHMELKAL;

	protected Dictionary<uint, ResourceID> HJOAEOCGEJK;

	private bool HBGGGHLBBOJ;

	private Dictionary<int, ResourceID> AKMCKHNKFLJ;

	private Dictionary<int, ResourceID> BMBJMOMCINA;

	private Dictionary<int, bool> AECCGPHCCMN;

	private Dictionary<int, string> FMHLBPIMPPF;

	protected ResourceID DBMAINAHMDB;

	protected string BMIPJDFHKML;

	protected string FOOBMMMMKHN;

	protected bool FACGHHPAFJF;

	protected string CFKGCFNINGK;

	protected string PLMLKGBCLAO;

	public Dictionary<uint, JHFEPHIFDHM> BHIDKEEDBKK;

	public HashSet<string> LNLBBJHPGCA;

	public Dictionary<int, List<string>> AEFCBHHCKHL;

	public List<string> CLMBCHPGGKD;

	public Dictionary<string, string> LPEIGPHFGEH;

	public Dictionary<string, float[]> BFEMJHINIKI;

	protected ResourceID AIJELBIDEGG;

	protected ResourceID DGFEKGALODF;

	protected int LNEIPADGCNH;

	private CMDBIPLGLGA _003CJAOEEHPFOJK_003Ek__BackingField;

	private ushort _003CNDEBOKGBEHC_003Ek__BackingField;

	protected bool IABLODJCFAB;

	protected bool LAAPHINEPMC;

	protected NGNAINDLBOP FFOALHEJBIH;

	protected MAAGFHCFOGI CACGLNBOJEE;

	public static ulong JGMCMJHICPD;

	public static ulong JNJMLBPJLAH;

	public static ulong OFCFFJHGCDK;

	public static ulong FKPGGHJGPMC;

	public double NLNPJNLDBEO;

	public Quaternion FHPLOJFIJCG;

	private uint EEDKJCHFFEJ;

	private uint GOOAEFGDLEG;

	private bool HKAMCLBAKME;

	private ADNKHCHHGGG ECLBMPPNLLK;

	private bool EJIHDNJOJBK;

	private string GIEBHEFNGHN;

	public uint NHPFOMNHMGM;

	public uint GGGHDJOBOGE;

	public bool EJPMCLKKDIA;

	private ulong _003CICINHKCJEGF_003Ek__BackingField;

	private ulong _003CLEEEAKCLLFF_003Ek__BackingField;

	public Dictionary<uint, bool> LPJADJMDNCH;

	public static KKDAICOONPI CGNMAOJDDCB;

	private FEKBCHODFLE GELFGDBLHDE;

	protected float DGBDFHMGAFE;

	private bool DFFJGIFJLNJ;

	private const float AOPGNGKHCMI = 2.3f;

	private float HPKAMBEGOHD;

	public GameObject OBBBJAFNKBB;

	public CaptureCustomToMaterial CKKBLFKCGMF;

	public Queue<AvatarManager> NDANMDKEGEN;

	public bool HNOBGFBKLBD;

	private List<ulong> EGCEDNNLAIE;

	public bool HNOOBPLLGPL;

	private Transform AMGHEMIHOID;

	private List<BHGGAEEHJCO> LNLJPDFKLDO;

	protected JPCGBALBHFA[] BDGDFNLMFGK;

	private IEnumerator EMELCPBDMKP;

	private List<Player> OMPOPEJDMDD;

	protected CLFNIKPHMED[] NBLHDJKAHDE;

	private ResourceID[] DDDGBKKEDEC;

	private HashSet<uint> LJPACHPDJGO;

	private const uint MEGEABJHBNG = 63u;

	private uint JJDMHKGBHPM;

	private Dictionary<BHGGAEEHJCO, float> HPEOFEOMLPC;

	private Queue<uint> FOKKCKADGFH;

	private Queue<uint> CBBILFEIEPD;

	private uint EIIODCHPKMN;

	private BCNFJKCDFGH IMJOJKLEKCE;

	public GGKKMMFNHKH EPPCHFAOAKB;

	private NFDDMIMFPID IMNPFFBOBOC;

	private UIUGC_WardrobeConfig EEFEOFCCJNA;

	protected Dictionary<BHGGAEEHJCO, Player> BLCGPGAHCJA;

	protected Dictionary<BHGGAEEHJCO, Player> NMFFGLMHHEE;

	public int DOBDDHJNPMI;

	public bool KFEJLCAABJK;

	public EDLDOIDGDAP DMMOKIOJOCA;

	public EDLDOIDGDAP NGMHBBKIDPO;

	public List<GEABOFHJJGJ> DDMFHPMMGMA;

	public readonly GPDHODOHCII GPDHODOHCII;

	public string CPBCGPFJGHP;

	private CIBEIIDCLEP JILGMIHOBEN;

	private HashSet<string> BMGPJHHPPAO;

	private HashSet<IInGameReloadSelfControlledEntity> NPLACCJHOKN;

	private Dictionary<byte, PreviewTeamFlightView> IFNOOGCBPOI;

	public const uint NKMAMNKBICJ = 1u;

	public const uint DOEMEMJIJNA = 101u;

	public const uint HODMGMGNCFO = 10000u;

	public const uint AHMMPLCOCKG = 20000u;

	public bool NFDGNDJHGNK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ResourceID BLMLMJHBCAM => default(ResourceID);

	public uint OAEFPJOIEON => 0u;

	public uint PKMKLEFDCHM
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint HMGDFLGLDIN
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public ResourceID GEFAGEPBMCE
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID AFNGBFPPJGJ
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public bool GFFMPAHLNGB => false;

	public bool GEKFJFBGBFK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform MJLDKPKHLBG
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public Dictionary<byte, NOJKBEOPKKE> OGJIGKFGCKL => null;

	public Dictionary<ushort, LevelMovePlatform> MOHIPMBGNLM => null;

	public SafeZone MKGAGIAAOBG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IMMJAOPJAEB MJLLHLKPKAA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CENNCIIJNFK NIKABCIFKGD
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CIJEINAHABO ELDJNAJDDLP => null;

	public bool KAFELHDAHBB => false;

	public ResourceID FHCLMKBFIJE => default(ResourceID);

	public ResourceID ABKKNHLHHDG => default(ResourceID);

	public ResourceID JAELFLDNOOJ => default(ResourceID);

	public ResourceID PICAMAHKONN => default(ResourceID);

	public ResourceID PNAFCANPPDO => default(ResourceID);

	public ResourceID NIIIDBPAEBK => default(ResourceID);

	public ResourceID LOANEDAPJBO => default(ResourceID);

	public ResourceID LJGPGJCAFND => default(ResourceID);

	public ResourceID BKFFPGEIBIK => default(ResourceID);

	public ResourceID JKOMJOHLMAO => default(ResourceID);

	public ResourceID KDLCHJBMMDK => default(ResourceID);

	public ResourceID FKLCEPNOLOM => default(ResourceID);

	public ResourceID EPKPGNMOJDB => default(ResourceID);

	public ResourceID BHDLJFDCHOG => default(ResourceID);

	public ResourceID IOLGPJAFEFF => default(ResourceID);

	public ResourceID BANADIHBIFB => default(ResourceID);

	public ResourceID JAICDMKGJPK => default(ResourceID);

	public ResourceID FEMKNJFEDJM => default(ResourceID);

	public ResourceID EKFMJKAIEIF => default(ResourceID);

	public ResourceID PPOJBBBJEFM => default(ResourceID);

	public ResourceID NFKFJMGGBKA
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID HILCNLGMOED
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID APBLPEIJGNC => default(ResourceID);

	public ResourceID APKFDAEFFEI => default(ResourceID);

	public ResourceID DDBNCPMFKGM
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID BAFNEANIFHC
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public ResourceID EHNKFLBEOBM => default(ResourceID);

	public ResourceID DPHCBNAJGEE => default(ResourceID);

	public ResourceID NOGICKCEPJN => default(ResourceID);

	public ResourceID KHLBNGCFKFJ => default(ResourceID);

	public ResourceID FDMPGKPMAPE => default(ResourceID);

	public ResourceID OCACMKGIHFL => default(ResourceID);

	public ResourceID KDCFOBOIFLA => default(ResourceID);

	public ResourceID IHLDEHEAOAL => default(ResourceID);

	public ResourceID MAGFBNKGIAI => default(ResourceID);

	public ResourceID FBCCHIADLCG => default(ResourceID);

	public ResourceID GIOIOFGFADD => default(ResourceID);

	public ResourceID MBOOPEBGABO => default(ResourceID);

	public ResourceID KEHFBHHNAPO => default(ResourceID);

	public ResourceID JDAAGJICFIN => default(ResourceID);

	public ResourceID JMENEPJIIPF => default(ResourceID);

	public ResourceID NFBBOFMIHIE => default(ResourceID);

	public ResourceID FEBJLBJJIKO => default(ResourceID);

	public ResourceID PHHLPCFFIEI => default(ResourceID);

	public ResourceID MAOPCCAHALB => default(ResourceID);

	public string BAJIMDNHPJC => null;

	public string HNPNLIOKOHG => null;

	public bool DMBLHGIOFPJ => false;

	public string LNAKHDBOCKI => null;

	public string AALGNBIKPPJ => null;

	public ResourceID OPDBJGFJBGC => default(ResourceID);

	public ResourceID CMGPJAHLPIF => default(ResourceID);

	public int GHDMADCOMAP => 0;

	public CMDBIPLGLGA HKAAFKGOICD
	{
		get
		{
			return CMDBIPLGLGA.EGROUPMODE_SOLO;
		}
		set
		{
		}
	}

	public ushort DBNDOJFGAIN
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool PHMAEKJAMFE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool JEOIOIKKMAL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public NGNAINDLBOP NGNAINDLBOP => null;

	public MAAGFHCFOGI PLPEFDLKPMG => null;

	public ADNKHCHHGGG KPOEINNCOEH => ADNKHCHHGGG.EMatchEndType_None;

	public bool NOFLABNKFCH => false;

	public ulong GKEHOAPAKDC
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public ulong JEOLAJOGNMG
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public bool DHFCFNHKMKA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform MAIEBLBDMBC => null;

	public BCNFJKCDFGH CAHKBIOHCJK
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public NFDDMIMFPID HMLFHBLPNBA => null;

	public Dictionary<BHGGAEEHJCO, Player> OANMEEIILMI => null;

	public Dictionary<BHGGAEEHJCO, Player> HDCBPFMPLON => null;

	public void FLEKIMPPKPJ()
	{
	}

	private void KHAFKAFDOAG()
	{
	}

	public void JPPIKKMHOLC()
	{
	}

	public void PGNPJEIJJNG(CEJKFOMEIEF APHHNHEDHKD)
	{
	}

	public void JBDNLIEAOEE()
	{
	}

	public void NDDEDEMNCCN(MKJFAJAHLFD APHHNHEDHKD)
	{
	}

	public bool IPGDJFFCFNN(int OMKJDJBIIAC)
	{
		return false;
	}

	public void INEMOEOKNJP()
	{
	}

	private void NHJGFOKCDCF(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	public void GDPOHNHACEB(PLFCENFBADL APHHNHEDHKD)
	{
	}

	public void IDHDCCBBBIL(bool PGECJEONODC = false)
	{
	}

	public void OAMDNEHNKAB(Player PGEGMKJKOKI)
	{
	}

	private void FODGCELFBCA()
	{
	}

	private void JCKGDNANNGM(Vector3 IBDHIOAEOIN)
	{
	}

	public void GOLIODCNKJD(Player FFHGOACBDMH)
	{
	}

	private static Color[] GKOBNPMEJHF(string EEJAILKPDPP)
	{
		return null;
	}

	public Color FNPOJCAPBGJ(byte FJCPAJEPBOD)
	{
		return default(Color);
	}

	public void OOLFJPNBKBF(BNIEEAHJNAA APHHNHEDHKD)
	{
	}

	public void ANOAJFENNOL(Vector3 IBDHIOAEOIN, Vector3 IMALLBDOCBE, Vector3 GEEEDPBOGIM)
	{
	}

	public void NFMPPEFKKCK()
	{
	}

	public void EKEDMFFBCNJ()
	{
	}

	public void ACPAJHJCIDI(Player PGEGMKJKOKI)
	{
	}

	public void NPJNMBMAAGF()
	{
	}

	public void PBMPGHOBNAL()
	{
	}

	public void FHPGANALDOD(NMONOCEJOIL APHHNHEDHKD)
	{
	}

	public void IEHMOMPBODL()
	{
	}

	public void DHIKPLIAMFI(uint KJLFMPOFELA, Vector3 HDFILHFDBKB, float PHGFOKAOBDJ, float HCDLCMAFFJD)
	{
	}

	public void GMKDAKDHHFJ(uint KJLFMPOFELA, Vector3 HDFILHFDBKB)
	{
	}

	public void FGBMAEEMGHG(uint KJLFMPOFELA)
	{
	}

	public void ADMCPJLHFPE(uint NOANDIOONLD, LevelObjectIIVTeleportDoor EBGHHGNFLCE)
	{
	}

	public void ANNAMEHMBGJ(uint NOANDIOONLD)
	{
	}

	public LevelObjectIIVTeleportDoor DDALPEAEHLA(uint NOANDIOONLD)
	{
		return null;
	}

	public void FJBFMCEGFPL(uint NOANDIOONLD, int IDCHLDICNPP, int MKCCNABIKII)
	{
	}

	public void IGIBOIANCHF(uint NOANDIOONLD, uint BOGOEPNNFCP, FOGOEBDAGIK DBJBCFOHNLG, Vector3 HDFILHFDBKB, int IDCHLDICNPP, int MKCCNABIKII)
	{
	}

	public void HKIAFKHKAFD(uint NOANDIOONLD, FOGOEBDAGIK DBJBCFOHNLG)
	{
	}

	public void ACFMHJDGONL(string MFJJEFEPDHF, string GILLLHIPPHM, float HKJKEJONGMC)
	{
	}

	public void MPFNDNKHKEG(string MFJJEFEPDHF, string GILLLHIPPHM, float HKJKEJONGMC)
	{
	}

	public void JCCEJPDHPEA(NMONOCEJOIL APHHNHEDHKD)
	{
	}

	public void HJJFIOIMBGA(byte EIOKHLKJEEL)
	{
	}

	private void PLJEMCOEOFM()
	{
	}

	public void NFIMMGAOEIH(bool MINNOPOBCAL = false)
	{
	}

	public void GFEBMIOFJJE(Player FFHGOACBDMH)
	{
	}

	public void HIFNMAJJEIJ(NMONOCEJOIL APHHNHEDHKD)
	{
	}

	private void BDDJIOAHKAO(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object KMOGBCDKPBI)
	{
	}

	public ResourceID GNAJPBHDPFC(int FJCPAJEPBOD = 1)
	{
		return default(ResourceID);
	}

	public ResourceID FMANCAKCFNO(LevelTriggerFountain.BKEAGLIPIGP CCNBNLAPJFM)
	{
		return default(ResourceID);
	}

	public ResourceID LCODKLNGLGO(LevelBaseDrum.NLNIACDLBGF MOPOBDIPNGM)
	{
		return default(ResourceID);
	}

	public ResourceID DGELAIFPELO(OFNOPJLPNMO JGAINIOBLNB)
	{
		return default(ResourceID);
	}

	public bool FOGHHNEEJDL(DMMPNBABEEG KJFIBGHIJCB)
	{
		return false;
	}

	public string OBFPEJMNNAC(DLAHEFBFNLG KJFIBGHIJCB)
	{
		return null;
	}

	public bool AAFOHMDCDEP()
	{
		return false;
	}

	public static T LCOENFKFAMF<T>() where T : EMKJHAJNPDH, new()
	{
		return null;
	}

	protected EMKJHAJNPDH()
	{
	}

	public virtual void CJFHGJHBCAL()
	{
	}

	private void LNEMMJPMNJP(bool JLAGNEOGHGO)
	{
	}

	public virtual void DNOIMMPIOBJ()
	{
	}

	public bool PDPHNOAOLBJ()
	{
		return false;
	}

	public bool HGMGJAPFLPP()
	{
		return false;
	}

	public bool EGAACGDNKBE()
	{
		return false;
	}

	public bool GCCNKAFCALE()
	{
		return false;
	}

	public bool FEGBONOOAHP()
	{
		return false;
	}

	public void DHEEJFAPBLO(NJMHKHCLBNN GCJPAAPKMMA)
	{
	}

	public Player MBEDKMKBFIE()
	{
		return null;
	}

	public BHGGAEEHJCO FHOCLAMPIHN()
	{
		return default(BHGGAEEHJCO);
	}

	public uint PLGLFADKENH()
	{
		return 0u;
	}

	public bool MKHEDMPAMOJ(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public bool AMNJFGFAEKD(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	public Dictionary<BHGGAEEHJCO, Player> ALEBMIOAMOF()
	{
		return null;
	}

	public bool BEGPNPNDLIB(BHGGAEEHJCO KIFNGKDMHGM)
	{
		return false;
	}

	public bool BJECIDAKHAA(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public bool LHBMMJEMHGM(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public bool LIDAJHLDOCD(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public bool MBLKDPDFAOP(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public bool ELNIOJGAJKD(BHGGAEEHJCO PGEGMKJKOKI)
	{
		return false;
	}

	public void EMLMEINKNML()
	{
	}

	public PHLHIEGPMMK JDALDGLPCCJ()
	{
		return null;
	}

	public void DNPMPMJMJDG()
	{
	}

	public APELCIGCHDJ AEDPAAGMKHB()
	{
		return null;
	}

	public void AAOMLMMDLNN()
	{
	}

	public Dictionary<BHGGAEEHJCO, Player> GDFDMGLIDDM()
	{
		return null;
	}

	public Player HHJLHNGCEKE(BHGGAEEHJCO OBMFMAKFDDL, ulong NOHMJCDAMJG)
	{
		return null;
	}

	public bool FPOCIJFFOKE(BHGGAEEHJCO OBMFMAKFDDL, Player PGEGMKJKOKI, ulong NOHMJCDAMJG)
	{
		return false;
	}

	public void JMKNKJJMCFL()
	{
	}

	public Player CKMJEEAFCIG(byte EJFIALKMAKI)
	{
		return null;
	}

	public Player ADNMDEDAEGN(BHGGAEEHJCO OBMFMAKFDDL, bool EMNEGIGFNHJ = false)
	{
		return null;
	}

	public void DDLKKFNAKDK(BHGGAEEHJCO KJLFMPOFELA)
	{
	}

	public void PDKDOLIDBGO(BHGGAEEHJCO KJLFMPOFELA)
	{
	}

	public void DCNBFCIFPAN(byte LIKPJDHGPFG)
	{
	}

	public void PBGCKEHIFBP(uint PDEAMOFACJG)
	{
	}

	public Player GHDDOPODHNE(ulong HGNIOBLGCII, bool EMNEGIGFNHJ = false)
	{
		return null;
	}

	public Player JLHFKDMHIFF(ulong NIDGHBCCOPB, bool EMNEGIGFNHJ = false)
	{
		return null;
	}

	public string GBJMAGADHKH(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public void PNMHPJEFBOH(BHGGAEEHJCO OBMFMAKFDDL, string DIHLJDLFGFN, ulong KELOJPCCCJK)
	{
	}

	public Dictionary<byte, MatchTeam> IEKKFMJOEOG()
	{
		return null;
	}

	public MatchTeam CMHAJOCHEOK(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public MatchTeam NHFHLGHGKHL(byte IKMGPLIHPFE)
	{
		return null;
	}

	public MatchTeam OMPEPIMIIFI(uint PIBGFBLEBPH)
	{
		return null;
	}

	public MatchTeam HANDHPHBOGJ(string GDDEBLAFLLG)
	{
		return null;
	}

	public bool MHOHEHFLIEL(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public Dictionary<uint, NetworkPet> HGHBFMKFMHA()
	{
		return null;
	}

	public Dictionary<BHGGAEEHJCO, NetworkAIPawn> HOFCMDGAHNC()
	{
		return null;
	}

	public NetworkAIPawn LMNDNEDEGDK(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public bool OIDBNAMAEMO(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public List<OKEAMEELLBB> PDOANJJOLOO()
	{
		return null;
	}

	public void IFCBDGLHEDF(OKEAMEELLBB DNNNJDJIBMP)
	{
	}

	public void MEICKFIIMKK(OKEAMEELLBB DNNNJDJIBMP)
	{
	}

	public List<OKEAMEELLBB> JGIDBIMDNLO()
	{
		return null;
	}

	public Dictionary<BHGGAEEHJCO, Player> KMIHJCKKDBN(BHGGAEEHJCO OBMFMAKFDDL, bool OFPIPNGPPAC = true)
	{
		return null;
	}

	public int LDKBEAFNLMH()
	{
		return 0;
	}

	public List<BHGGAEEHJCO> KPBJOJPNHFB(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public Dictionary<BHGGAEEHJCO, Player> ECEGLKHEFMF(BHGGAEEHJCO OBMFMAKFDDL, bool OFPIPNGPPAC = true)
	{
		return null;
	}

	public Dictionary<BHGGAEEHJCO, Player> PGCEPCPNPFJ(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public bool JHGNOKDEEMO(BHGGAEEHJCO OBMFMAKFDDL, bool OFPIPNGPPAC, out float CGGPBJKCDEG)
	{
		CGGPBJKCDEG = default(float);
		return false;
	}

	public Dictionary<BHGGAEEHJCO, Player> OPNBMHNCJLG(Player PGEGMKJKOKI)
	{
		return null;
	}

	public void BNEADCADCAH(BHGGAEEHJCO JFPADHMCADP, FDAEPHMIEPC PPFBJKMHKGC)
	{
	}

	private void LBNMGKNEPCI(BHGGAEEHJCO FPIDBLAMNLN)
	{
	}

	private void GCBIOOGPPJO(BHGGAEEHJCO JFPADHMCADP, bool PIDINBNGILH)
	{
	}

	public List<BHGGAEEHJCO> IEOGMMIJNMM(BHGGAEEHJCO OBMFMAKFDDL, bool OFPIPNGPPAC = true)
	{
		return null;
	}

	public int NHCDDHJKDOK()
	{
		return 0;
	}

	public int HEGBBHIAIBD()
	{
		return 0;
	}

	public int BGJCJNHFPJD()
	{
		return 0;
	}

	public int KDBJGLCLJME()
	{
		return 0;
	}

	public bool OLAHHOBBNNO(MECJOKLINMA HMDBCFJFGDH)
	{
		return false;
	}

	public List<KAEJKILJHGC> AMOEMDPACLJ()
	{
		return null;
	}

	public TModule PFOKPICCHDD<TModule>() where TModule : class, KAEJKILJHGC
	{
		return null;
	}

	public void PDJJGNJKIIG(List<MECJOKLINMA> IGAKLCBILBN)
	{
	}

	public bool BOPKGPECHKF(KAEJKILJHGC DKIHOHOJHCG)
	{
		return false;
	}

	public void JNHAAAACAJJ()
	{
	}

	public bool MFNKCABGHEF(string FNCPDMJFNFA)
	{
		return false;
	}

	public void PHDNDDDIOPK(string KEDFHFJGEPF)
	{
	}

	public void MMLKLIHNHNA(BOJGFABJIAL APHHNHEDHKD)
	{
	}

	private static void DMAGJFMMDBG(RegionActivityData JCONDDPFBKK, ref ResourceID JDFKHICPGPK, ref ResourceID EBLLHMIDNPF)
	{
	}

	private void JKIPCKAMMMP(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object KMOGBCDKPBI)
	{
	}

	public void PCEHCEGEKEC(OPFEFBGGALB APHHNHEDHKD)
	{
	}

	public void PBCIDJIABMK(KACHKPGKNBI APHHNHEDHKD)
	{
	}

	public AirTransporter JJJLOBDDPKB(Player KDJNEHDAAFL)
	{
		return null;
	}

	public bool AMHKCCLBJMP()
	{
		return false;
	}

	public void HKINKOBFKJJ(List<PJLCGCNEMJE> AOFCDPKJKJO)
	{
	}

	public void DHLINLBLNKD(List<CLGLMGKILGJ> AOFCDPKJKJO)
	{
	}

	public LBNKMHIMNIC KPJGEFIKKJJ(string LPBFPOJDJJF)
	{
		return null;
	}

	public void NNMDPAIOMJC(Vector3 BAPEDKECNLH)
	{
	}

	public void KCJMBJKMFIL(GameObject OIPFKCIMALO)
	{
	}

	public void CILPEAHPOBL(Player KDJNEHDAAFL)
	{
	}

	public void OJGBAJDADNN(Player KDJNEHDAAFL)
	{
	}

	public AirTransporter DMDPMEDDCJK(Vehicle KMJJAIAELMB)
	{
		return null;
	}

	public void POHMEFJEHHE(Vehicle KMJJAIAELMB)
	{
	}

	public void CDNPGHNDBIH()
	{
	}

	public void HELCMOAOFPK()
	{
	}

	public void NOCCCDEICKA()
	{
	}

	public void HJCEFKAJPIP(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void OPHFNKPJOCI(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void HCHJIDAMKFL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void IJAMLMBHOID()
	{
	}

	public void GGNPCFDBDEM(AvatarManager EDKKPKCGCBD)
	{
	}

	public bool FCABKIOPNBH()
	{
		return false;
	}

	public void ILONLKHNFAA()
	{
	}

	public void KNPCIAAJNEL(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void NMKDEKNNJFK(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void GBLDIHGNCHB()
	{
	}

	private void NOOKCABGDIA(bool HFKNJLOFGGA = false)
	{
	}

	private void MHHGMLPMFEJ()
	{
	}

	public void NHNNFGFBKHB()
	{
	}

	public void CPODKFEEBLN()
	{
	}

	public void FFFBOCOIOEF()
	{
	}

	public void NIIJBIHLMEB()
	{
	}

	public void CPNFIMDMKDK(ADNKHCHHGGG GAIBGAFMDCA, int PLGDMIKADEE, bool JJBFFAMPPML, ulong EGHJHCCPLAB, ulong CJOIOFHBDBB, uint NBFHBEFFDCB, bool HBHIILFEJLG, bool APNEPMNFDBA, List<byte> JBANFPLPFBB)
	{
	}

	private void OFPDMKOBGJM(ulong EGHJHCCPLAB, ulong CJOIOFHBDBB, uint NBFHBEFFDCB)
	{
	}

	public void ENKCLDFLLFA()
	{
	}

	public bool DBAMGGEJLGO()
	{
		return false;
	}

	public void EOGKLAGBCBM()
	{
	}

	public void OFFCFDBNKNH()
	{
	}

	public void EADEAIHOEBA()
	{
	}

	public bool NPPEAINMHKI(Player KDJNEHDAAFL)
	{
		return false;
	}

	private bool LEEGKILDMDA(BHGGAEEHJCO LIKPJDHGPFG, ulong PIDINBNGILH, bool AAMGEIDOJLK, Player KDJNEHDAAFL)
	{
		return false;
	}

	private bool NEHGFANFIGF(BHGGAEEHJCO LIKPJDHGPFG)
	{
		return false;
	}

	private void KEOJCOFNLON(ulong HGNIOBLGCII, ulong ELDAFBFFPCC, BHGGAEEHJCO OBMFMAKFDDL, COEDKLIGPPD AHDONPCGJOL, bool NNFPDFIBENC, Player KDJNEHDAAFL)
	{
	}

	public bool IONEOANEDKD(ulong HGNIOBLGCII, ulong ELDAFBFFPCC, BHGGAEEHJCO OBMFMAKFDDL, bool CHDFFDMBMEL = false, object LHLIKBIDIIJ = null, bool FEKKOODMNEH = false, bool HBHJFNPGNCL = false)
	{
		return false;
	}

	public MatchTeam AKIMIABMEKE(byte IKMGPLIHPFE, out bool JFOIMOMNDAH)
	{
		JFOIMOMNDAH = default(bool);
		return null;
	}

	private void OJIODMOFDBN(Player KDJNEHDAAFL)
	{
	}

	private void PJDPNNKAOPL(Player KDJNEHDAAFL, bool OLLABBFIIHJ = true, SceneGraphics.MaterialType CCNBNLAPJFM = SceneGraphics.MaterialType.DepthCull)
	{
	}

	public bool HPCKAMLPHIP(BHGGAEEHJCO OBMFMAKFDDL, BHGGAEEHJCO FNOOENEHBJP, int LPHNICDPDBN, uint ENJBDKJIKJO, bool MCOLBLGMMML = false, bool GGLDMJEFGCG = false, bool FCGHCIOGMGK = false, bool FAJBOHLHDHO = false)
	{
		return false;
	}

	private IEnumerator CHJHBDPENJB()
	{
		return null;
	}

	public void HEHIIEOMBDG(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void MLDDAMGFMIL(BHGGAEEHJCO OBMFMAKFDDL, Player PGEGMKJKOKI)
	{
	}

	public void EJDJOBLFINK(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void HKCDLNDLKJP(Player PGEGMKJKOKI)
	{
	}

	public void DKPMEFHDNFH(Player PGEGMKJKOKI)
	{
	}

	public void POHFEIFGKMF()
	{
	}

	public void DAHJNGGCDPG(bool LIOGELNCMIG, bool LJIKBAKPBDM, bool AKEFKIGMOPE)
	{
	}

	public void JABGIDHAPNG(bool COFLLOEEOOG)
	{
	}

	public void IGIJFHOBDAH(Transform HECDKBIPPPE, float HHCIJJGJGME, bool CAGDJIIANHG = true)
	{
	}

	public bool PCOINMDMALE(BHGGAEEHJCO OBMFMAKFDDL, DNFBGBPINLE GDEKAGHDGKC)
	{
		return false;
	}

	public bool NKMIMGPGAMG(BHGGAEEHJCO OBMFMAKFDDL, BHGGAEEHJCO FNOOENEHBJP, int LPHNICDPDBN, bool MCOLBLGMMML = false)
	{
		return false;
	}

	public void NEDMKOANAIL(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void KCHEKECMIHA(NetworkAIPawn KDJNEHDAAFL)
	{
	}

	public bool GKPNGMJCFLO(BHGGAEEHJCO JFPADHMCADP)
	{
		return false;
	}

	public void GDMGKFBPBDK(BHGGAEEHJCO JFPADHMCADP)
	{
	}

	public bool OPGPBOIPNNK(ulong HGNIOBLGCII, BHGGAEEHJCO OBMFMAKFDDL, BHGGAEEHJCO PBFFCIAIAMG, CAIEKBICLGP JMAPMFJEDGO, int PIBGFBLEBPH, float EAAOAJGDMAG = 3f, ulong ABCDAJGGEMB = 0uL, List<ulong> EGHAPPDJGLF = null, List<NNMKDGHEEGE> BBLFGCFPGBB = null, uint BEFIPHEONMM = 0u)
	{
		return false;
	}

	public bool BBGNEOAHDPO(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public void KHBGPOHHPNM()
	{
	}

	public bool DDHJHIFLBOE(ulong HGNIOBLGCII, BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public void PPJKHFBPCEC(List<HJEPOCAELMC> JHNJIBJFPJM)
	{
	}

	public void DGDLNPONHOP(List<EFAAKBDHEOH> LBJKNILJMNL)
	{
	}

	public void JIHHGKLIMDO(ALCBKBHIOAJ CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	public void JIHHGKLIMDO(JGBBFPKNAPA CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	public void JIHHGKLIMDO(FLPGKKGLKOG CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	public void CNHJFPDCJKO(HCBJILHDGEO HADLEHOEAOH, uint OJFBGFOOKEK)
	{
	}

	public void HJELBLOPJFL(NELNJFIPMIC CHDPPLFBCJA, uint OJFBGFOOKEK)
	{
	}

	private void DEKJAPPHDHO()
	{
	}

	protected void ANMMOBKALBL(float OKJIFBCMDAD, float HOGHEFNINAE, JPCGBALBHFA PMEBBKMLCMM)
	{
	}

	protected void KKIGJEHBHKM(float OKJIFBCMDAD, float HOGHEFNINAE, JPCGBALBHFA PMEBBKMLCMM)
	{
	}

	protected void NKAHKOLCCKL(float OKJIFBCMDAD, float HOGHEFNINAE, JPCGBALBHFA PMEBBKMLCMM)
	{
	}

	private IEnumerator ODECAAGILAF()
	{
		return null;
	}

	protected void GNLPGGKHOBC(float OKJIFBCMDAD, float HOGHEFNINAE, JPCGBALBHFA PMEBBKMLCMM)
	{
	}

	private void HPLOILEDBAF()
	{
	}

	protected void JPEPFFFIBDG(float OKJIFBCMDAD, float HOGHEFNINAE, CLFNIKPHMED PMEBBKMLCMM)
	{
	}

	private Transform KBCGBDMILNE()
	{
		return null;
	}

	public void DBOCLOIBAFF(SafeZone OAFJFGHADHG)
	{
	}

	private void KHOOLIOMDDE()
	{
	}

	public void OHBNABGHPKO(CMCDHCMJGFK APHHNHEDHKD)
	{
	}

	public void OHBNABGHPKO(KJEDIABALBP APHHNHEDHKD)
	{
	}

	protected virtual void DMCKGHCPBNN()
	{
	}

	public void KBFOJGDODBO(int KNKIJMBAKJG, uint FHCABCCIOGP, bool DGHBPMOLCPC = false)
	{
	}

	public void IIHGHCBFLME(OLOACOCJKGC APHHNHEDHKD)
	{
	}

	public bool OFDOGDFDFOL()
	{
		return false;
	}

	public SafeZone JIFGEEOJDEP()
	{
		return null;
	}

	public SafeZone HFENHPIAJFG()
	{
		return null;
	}

	public void DIADOLFMACM(GFCAJNPKNJA APHHNHEDHKD)
	{
	}

	public LGBPPLOIEON KOGAPAKMFGA()
	{
		return null;
	}

	public IHFFDJIDIAA NKCDOAMIHNC()
	{
		return null;
	}

	public void DBNFFDKOHJB(IHFFDJIDIAA AELNCKDCENH)
	{
	}

	public MDGHHNEMFIE DNEBFGPDADN()
	{
		return null;
	}

	public IKPCOMMDCAB CNNOJMNIGLG()
	{
		return null;
	}

	public JMENFKECPNA DBGDCJMNJHO()
	{
		return null;
	}

	public bool HHKDBADEOFK()
	{
		return false;
	}

	public AirtransportParams OPJLPAPIIFA()
	{
		return null;
	}

	public void BFJOAIDJJLL(ushort GNMNAOOGMIJ)
	{
	}

	public void BFJOAIDJJLL(HCEGAJHNFGG JCONDDPFBKK)
	{
	}

	public AirTransporter IJHOBGPPKMM()
	{
		return null;
	}

	public void CCPKJNMDAHM(EIPLLBOAFFK APHHNHEDHKD)
	{
	}

	public LevelVehicle AOCHNPELDNF(uint FFOAOKAFODF, BHGGAEEHJCO OBMFMAKFDDL, int BJDJBPNCMBM, int AHPBOLHPNMH, byte BCGEJGDNJIF)
	{
		return null;
	}

	public void PLLNPFGLICH(uint FFOAOKAFODF)
	{
	}

	public void BKKKEKJDBPE(uint FFOAOKAFODF, int AHPBOLHPNMH, Vector3 HDFILHFDBKB, Quaternion IPKKCHLDJMA, string INPCPDAFMCN, string FBDKCEPEDJM, int HHLLCKFNHPM)
	{
	}

	public void BCBCJNBLBNK()
	{
	}

	public void ANIGCFIKPKG()
	{
	}

	public void BKKKEKJDBPE(ushort LIKPJDHGPFG, LevelVehicle FPNKHFEIBEI)
	{
	}

	public void FJJPPBHKEOG(ushort LIKPJDHGPFG)
	{
	}

	public Dictionary<ushort, LevelVehicle> GJBDCIELAJO()
	{
		return null;
	}

	public void PENEMOOGFDF(ulong EIOKHLKJEEL)
	{
	}

	public void JBHEGFNMBHN(uint OJFBGFOOKEK, List<ODONJOCHJLB> EAGIPKNAGEG)
	{
	}

	public void PNGAIBKPIHL(ushort OIKLPKAOOED, float HGMGHKMGBFL, float IKLNJAJNFNE)
	{
	}

	public void OJBJHPKNIHJ(ushort OIKLPKAOOED, bool IPNPKMJDIPC)
	{
	}

	public void FGDEJAPDJHE(ushort OIKLPKAOOED, int PNLDKNOFPNG, bool JHLNMNMLGPB)
	{
	}

	protected EPKCIHHNJNB EGBLKIHMKCL(ushort OIKLPKAOOED)
	{
		return null;
	}

	private bool JEGNANJLJKO(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return false;
	}

	public void BJOJPAGEPLG(Player GIICBIEIDKE, Player PGEGMKJKOKI)
	{
	}

	public void ONEKAHJNFFI(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	private bool KHCLALLHIIE(BHGGAEEHJCO IDBMLLFFLGF)
	{
		return false;
	}

	private bool LBIBJNLKIDA(BHGGAEEHJCO LDCIMNAAGNO, WeaponSkinData BOBIDPBLHPL, Vector3 IGDHIDGLOKG)
	{
		return false;
	}

	public void HIGHPHGFCPI(ResourceID EEOJGIGGNAA, Vector3 ENHNAPKIOPF, Vector3 JHACAOKJLPN)
	{
	}

	public void IAEIOOLBPAI(bool FALLPLDNOFN, Vector3 ENHNAPKIOPF, Vector3 JHACAOKJLPN, bool PGLCLDJPBFP)
	{
	}

	public void BBEGEPHHPAB(byte GNDANCFCLNK, byte KIHAGFOBILL, Player GCBKHMCHFDH, Vector3 ENHNAPKIOPF, Vector3 JHACAOKJLPN)
	{
	}

	public void HOHCLAPENPH(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void EIGIDANBDNB(BHGGAEEHJCO OBMFMAKFDDL, bool MLGCDPIMIOK = false, Vector3 GKDIOHCMHBG = default(Vector3))
	{
	}

	public void PJCAFLABOHM(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	private void AGBADCKAAMO(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	private void PNHCKAADABC(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private bool PPBHBPIAINE(BHGGAEEHJCO LDCIMNAAGNO, FinalShotData MFFCGIKEACP, Vector3 IGDHIDGLOKG)
	{
		return false;
	}

	public void FCDPBFKACJH(object DGDDJLEOPBL, ResourceID OCCLMDNGINA, Action<uint, bool, UnityEngine.Object> CEHELPAIELA = null, Vector3 IGDHIDGLOKG = default(Vector3), Quaternion FOALBMBCJLF = default(Quaternion))
	{
	}

	public void PBLBEIJFAII(GameObject CLACOPMJHDI, FinalShotData MFFCGIKEACP, Vector3 IMIHEBBAPPF, bool PMIPNENBBOL, Player LDCIMNAAGNO, bool IMNAOAMNKCO = false)
	{
	}

	private void IIDKJFLHBBL(GameObject CLACOPMJHDI, ResourceID GGMIDNEJGNO, FinalShotData MFFCGIKEACP, Player LDCIMNAAGNO)
	{
	}

	private void IOIPAEFJEMI(Player KFABAKAGKLE, bool PIDINBNGILH)
	{
	}

	private void IJONJOPMHBP(DOENGLMMFID APHHNHEDHKD)
	{
	}

	private void NBOFABAIHGJ()
	{
	}

	public void ILKEDIANHCJ(DOENGLMMFID APHHNHEDHKD)
	{
	}

	private void NELFCCCHEDI(Player PGEGMKJKOKI, FinalShotData MFFCGIKEACP)
	{
	}

	private void PLPMKIJOHEB(Player PGEGMKJKOKI, FinalShotData MFFCGIKEACP)
	{
	}

	public bool AJNGNINKHML(BHGGAEEHJCO OBMFMAKFDDL, FinalShotData MFFCGIKEACP, Vector3 HDFILHFDBKB, AvatarEffect.EPlayerLastKillState OJDNJMAKFLM)
	{
		return false;
	}

	public bool DOGMFILMEJF(BHGGAEEHJCO GEKCACGOBLK, BHGGAEEHJCO KCGLCOLIFHB, Vector3 EIOEGFHFOLE)
	{
		return false;
	}

	public void AEJEPFAOGKM(FinalShotData MFFCGIKEACP, uint KOJMAIDGOAO)
	{
	}

	private static void BBBKNHKNPHH(Player GPMLLAFINMM, DOENGLMMFID APHHNHEDHKD)
	{
	}

	private void DKMKGPFPFJO(DOENGLMMFID APHHNHEDHKD)
	{
	}

	public void AJHEEFGLACI(DOENGLMMFID APHHNHEDHKD)
	{
	}

	public void KDDAHCCCHBC(BHGGAEEHJCO HDIMBCNAIJP, BHGGAEEHJCO DLNJGACCOCL)
	{
	}

	private void HPKDBNDFDLA(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public bool JCAKCGIMABE(BHGGAEEHJCO DLNJGACCOCL, BHGGAEEHJCO HDIMBCNAIJP)
	{
		return false;
	}

	public bool CHGCKJDFNKH(BHGGAEEHJCO HDIMBCNAIJP)
	{
		return false;
	}

	private float GPOMEMPGNMB(DOENGLMMFID APHHNHEDHKD)
	{
		return 0f;
	}

	public void JJOPJDFJMPN(LFKAFMFOBIP APHHNHEDHKD)
	{
	}

	private void IHDOMBJDFNL(uint OBMFMAKFDDL, uint DEHPCNKOBLL, bool OOHKKHLMPDN)
	{
	}

	private void DJBMFFNMOEJ(Player PGEGMKJKOKI)
	{
	}

	private void OBOEIJJFPAE(Player PGEGMKJKOKI, LFKAFMFOBIP APHHNHEDHKD)
	{
	}

	private void HFLIKACCHKC(Player PGEGMKJKOKI, LFKAFMFOBIP APHHNHEDHKD)
	{
	}

	private void NBKHCBDFIOC(Player PGEGMKJKOKI, LFKAFMFOBIP APHHNHEDHKD)
	{
	}

	private void JOMFCIDGEFB(Player PGEGMKJKOKI)
	{
	}

	public void PCKJBAOPEFG(ushort LIKPJDHGPFG, LevelMovePlatform EEGHANDKINF)
	{
	}

	public void CMIBJEPEPJB(ulong EIOKHLKJEEL)
	{
	}

	public void KOKLNBMFBKO(BaseLevelObject LFACNELPLCF)
	{
	}

	public void PJMOFOJLFKN(BaseLevelObject LFACNELPLCF)
	{
	}

	public void KOKLNBMFBKO(OGIJAGDFGAM AHFMBBCLBCO)
	{
	}

	public void PJMOFOJLFKN(OGIJAGDFGAM AHFMBBCLBCO)
	{
	}

	public void NIKAJMGKGEB(CCMGHIMDPLC GEEKOPPNKAP, uint PDEAMOFACJG, uint HIDANNMJCDP, uint FHCABCCIOGP, uint OBMFMAKFDDL, string JCIFFMHHBHK, int FJCPAJEPBOD, List<uint> GBKJPBGCPHD, List<message.ECAIGDLJKJO> LIKHLGBKGAF, bool FAHMIEKMODJ = false)
	{
	}

	public void EBIGKLGDKPO()
	{
	}

	public void CAHIBMCHHLC(uint PDEAMOFACJG, uint OBMFMAKFDDL)
	{
	}

	public void ENOLJAIBCCJ(LBPMFJOGOBJ APHHNHEDHKD)
	{
	}

	public void GJMMJDAGKCB(bool FNCMIOCJGOG)
	{
	}

	public void JGLCCBKHLLJ(uint PDEAMOFACJG, uint FHCABCCIOGP)
	{
	}

	public void LAGHHLHBAKP(LKFIKOGIGEL NBLHNPAHGNA)
	{
	}

	public uint LBIOBHNOCMH(uint ECJCMBJODNP)
	{
		return 0u;
	}

	public void JBGFNPBANOP(MANCAFBGENA APHHNHEDHKD)
	{
	}

	public void BJIMONNDOBB(BHGGAEEHJCO OBMFMAKFDDL, Vector3 NOOADLGMGNO)
	{
	}

	public Dictionary<BHGGAEEHJCO, Player> KNPJJHKEDDG()
	{
		return null;
	}

	public List<Player> GEPFGOHGOJI()
	{
		return null;
	}

	public HashSet<Player> FLKKBJAIBPI()
	{
		return null;
	}

	public List<Player> PDOHCIMHKCL()
	{
		return null;
	}

	private void DAALGHOKOAP(Player PGEGMKJKOKI)
	{
	}

	private void ADJLKBANJAK(Player PGEGMKJKOKI)
	{
	}

	public Player ABFOPGGOAIK(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return null;
	}

	public Player AKPPMGACOJH(ulong HGNIOBLGCII)
	{
		return null;
	}

	public Player FMIFNMEKIGD(ulong NIDGHBCCOPB)
	{
		return null;
	}

	public void CPDNFLMKCLC(LLDPPLLNCNA APHHNHEDHKD)
	{
	}

	public void POGCBEPIGHH(bool GMFLCBMPHKK)
	{
	}

	public void INNMNGKLEMB(BHGGAEEHJCO GLBHGADFEEI, BHGGAEEHJCO PKFLGBOGJCD)
	{
	}

	public void MFLNGHOGGMP(BHGGAEEHJCO CBDJONDNFEF, BHGGAEEHJCO PKFLGBOGJCD)
	{
	}

	public void ECJFBFFJMKN(MANCAFBGENA APHHNHEDHKD)
	{
	}

	public void HAHGPHIAKLF(Player FFHGOACBDMH, bool HDPHMFIOIOF, bool ENFCECNLJLA)
	{
	}

	public void HFDKLDPMAPB(List<ulong> BBMHDJKPJEH, int GEHJJDLAGJJ, HEOJAGLBHLJ FIBHEMNPGMG = HEOJAGLBHLJ.EShopType_Common, int GMANEEELMDF = -1)
	{
	}

	public void PIDMABMLOCA(bool PPGGJDHBAPJ = false, Vector3 NMNDFINAGMJ = default(Vector3), bool DPPKLMBJCGA = false)
	{
	}

	public void LPMHCPPKFKD(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void FHPEOJAMDMC(BHGGAEEHJCO OBMFMAKFDDL, bool ODBECFEKBNJ, Player.IGJPHDANPJD CBCAJJJCKLH, EOGPGNIDOKF KKFLJEAPKNF)
	{
	}

	public void JAOEKCCJDCO(BHGGAEEHJCO OBMFMAKFDDL, out bool ODBECFEKBNJ, out JPEOBBKALLB CBCAJJJCKLH, out EOGPGNIDOKF KKFLJEAPKNF, out string LKFCFJIOBML)
	{
		ODBECFEKBNJ = default(bool);
		CBCAJJJCKLH = default(JPEOBBKALLB);
		KKFLJEAPKNF = default(EOGPGNIDOKF);
		LKFCFJIOBML = null;
	}

	public void OLLGILFLCKH(BHGGAEEHJCO JFPADHMCADP, float HKJKEJONGMC)
	{
	}

	public void DANHGNDFDEJ()
	{
	}

	private void KKCGJIJNMCC()
	{
	}

	private void NCEGNOGPIGK()
	{
	}

	private void OGNCENMNNNK()
	{
	}

	private bool LFDNKFNEFDO()
	{
		return false;
	}

	private void PJDIDBCLJPB()
	{
	}

	private void IJIPEGPLNKJ()
	{
	}

	public void PHMIMEBAHJF(uint OBMFMAKFDDL, byte EDIANFHBGDA, uint EHEIOMIEICH, uint ABENBDNEBMB)
	{
	}

	public void MLOOKJKNBIF(uint OBMFMAKFDDL, uint ABENBDNEBMB, byte CBCAJJJCKLH, uint GGOONGCDAIE, uint ENNFLFAHDIN, uint AGPNEHKOPIC = 0u, uint CJEHJFCCGLK = 0u)
	{
	}

	private void KKNELLFIECM(Player PGEGMKJKOKI, object LHLIKBIDIIJ)
	{
	}

	private void BBNLAOEJHEC(Player PGEGMKJKOKI, object LHLIKBIDIIJ)
	{
	}

	public void JNDAFJHCOPK(byte DGDDJLEOPBL)
	{
	}

	public void LDAECAKNMML(Player KDJNEHDAAFL)
	{
	}

	public string HBPJIHLPENN()
	{
		return null;
	}

	private void CCLEIKNHPDG()
	{
	}

	private void NEILMCDMMHL()
	{
	}

	public void IGAAJFHHMJI(uint CPDCONFICBP, bool GADJEMPDDMB)
	{
	}

	public bool LPHDKGPEHJB(uint CPDCONFICBP)
	{
		return false;
	}

	public void PBMKGOEPGMJ(uint CPDCONFICBP, LevelContainer GMKPLBHDMHJ)
	{
	}

	public LevelContainer JEEMHPHHONE(uint CPDCONFICBP)
	{
		return null;
	}

	public void BLCNDKBAECH(uint CPDCONFICBP, IOENNEBCHBF GMKPLBHDMHJ)
	{
	}

	public IOENNEBCHBF FCLPNIKJFKO(uint CPDCONFICBP)
	{
		return null;
	}

	public void NLGHHKNONOK(byte OPMHKKPJNGM, IOENNEBCHBF MLBAMPFOCGP)
	{
	}

	public void OIOMMJPLIAE(byte OPMHKKPJNGM, uint FKPOAJIBBLL)
	{
	}

	public void FFJJMGOJPCE(byte OPMHKKPJNGM, LevelContainer MLBAMPFOCGP)
	{
	}

	public void LFHGIMPAIMI(byte OPMHKKPJNGM, uint FKPOAJIBBLL)
	{
	}

	private void IIABFIKBIJA(bool EOGOGFLCEHL, byte OPMHKKPJNGM)
	{
	}

	public void NNKNKIJIOHL()
	{
	}

	public void PFOGEEDBHJE()
	{
	}

	public void PPJGFDODOJG(bool KFFPHKCHBDB = false)
	{
	}

	public void NOBAKAPFLMD(byte IKMGPLIHPFE, uint FEPNGNPHHBB, bool PIDINBNGILH)
	{
	}

	public bool HABFGBOGEHO(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return false;
	}

	public bool IPIGBAKNKKD(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return false;
	}

	public void CEPECHIEMKG(byte IKMGPLIHPFE, IOENNEBCHBF GMKPLBHDMHJ)
	{
	}

	public IOENNEBCHBF HFGAFHACKOL(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return null;
	}

	public bool NHBJKCCOGCJ()
	{
		return false;
	}

	public void AJGBIAFDJNM(byte IKMGPLIHPFE, uint FEPNGNPHHBB, bool PIDINBNGILH)
	{
	}

	public bool CPKONNLPJEF(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return false;
	}

	public bool DMIJJHOIDAD(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return false;
	}

	public void DJJKKKANOFE(byte IKMGPLIHPFE, LevelContainer GMKPLBHDMHJ)
	{
	}

	public LevelContainer FFAFBEGEPCL(byte IKMGPLIHPFE, uint FEPNGNPHHBB)
	{
		return null;
	}

	public void GPACGMGABEL(uint FEPNGNPHHBB, uint KALHAMBHMMJ)
	{
	}

	public void ICFJIKDPBLF(uint FEPNGNPHHBB, uint KALHAMBHMMJ)
	{
	}

	public void NBLHMIGHPGG(JNBDEBNKKHC APHHNHEDHKD)
	{
	}

	public void MGNIGOACAGA(JNBDEBNKKHC APHHNHEDHKD)
	{
	}

	public CHJOIHHHAIC BBEFHICEMAM()
	{
		return null;
	}

	public void KONNAGBEBMI(ResourceID EEOJGIGGNAA)
	{
	}

	private void AJMBLHKFLAO(BHGGAEEHJCO OBMFMAKFDDL)
	{
	}

	public void EECLDKKPBAM(HIPFFKHINHP APHHNHEDHKD)
	{
	}

	private void FLOHHJPDIKC()
	{
	}

	private Dictionary<string, HudConfigItem> MOLGHIJOGFH(int OGPGFBMCPOL)
	{
		return null;
	}

	public void BFILBGKDBDB(FDAEPHMIEPC MJANBJNJFAP, ResourceID OCCLMDNGINA, Transform FKODMCNOBDM, Vector3 HDFILHFDBKB, Quaternion BBMMDDJPLBP, float INNIDEIFIFN)
	{
	}

	public void OHHNKGKEDKD()
	{
	}

	private void MHGGPGEIFLJ()
	{
	}

	private void PCNKAMAECOG()
	{
	}

	private void BDAJJOCMGBI()
	{
	}

	private void OOJKKJFDIGI()
	{
	}

	private void JMPHNNKKGAH()
	{
	}

	private void LBEPHKAHOHA()
	{
	}

	private void BBFOKLPOAJE()
	{
	}

	private void EFBPNDGHLKP()
	{
	}

	private void ILKIEOAONKK()
	{
	}

	private void DEKNDACLCKI()
	{
	}

	public void LDKEJENHDAN()
	{
	}

	public void GOAFOOPLFON()
	{
	}

	public void PJJHOOKDGKE()
	{
	}

	public void FAMPBDCOJKP()
	{
	}

	public bool IJBKNOMFNHF()
	{
		return false;
	}

	public void FEEFPMHCHCH()
	{
	}

	public void DELEPLPOHID(FKEKGMFJALP APHHNHEDHKD)
	{
	}

	public void FEIBMIIEHDA(DOENGLMMFID APHHNHEDHKD)
	{
	}

	public void LMLBECEGLKC(GMDJLCGLDCH DEKIFJPELCD)
	{
	}

	private void AJPFFEFOLEF(EDLDOIDGDAP GNPADDDMALL, AIEMDEIGHEG OOMEGKHOCIN)
	{
	}

	public void NGEKIADNCKD()
	{
	}

	public bool FHNLLEEDLIH()
	{
		return false;
	}

	public void NECCEPMOFLJ(int OMDFLLEGAPK)
	{
	}

	public void CLPNLBJMBIO(int OMDFLLEGAPK)
	{
	}

	private void ALDBAHNICAM(List<CEKLEBBHLIG> LIKHLGBKGAF)
	{
	}

	public List<ulong> IPJGOOOHHIJ()
	{
		return null;
	}

	public void FGGFLFGLPLP(BDGECNMFJOG APHHNHEDHKD)
	{
	}

	public CIBEIIDCLEP FECLPAKPOCC()
	{
		return null;
	}

	public void KCPNPDBPNKD(bool EPJDBBCPIMF, ResourceID OPPONLOCKLE, ResourceID DIFPIBIEOIC, ResourceID EOEGLKINOMI, ResourceID DMCEHPGHAMC, ResourceID AFCNGGICLDB)
	{
	}

	public void IDPBAGKAJDK(string KJALKHEHBNG)
	{
	}

	public uint BIEDJEGFMMN()
	{
		return 0u;
	}

	public bool JOEDPLBOIOA(string OJIGEMDLBFN)
	{
		return false;
	}

	public void FKEDDPOAEEI(string ADLEJNADCHH, bool EOGOGFLCEHL)
	{
	}

	public void DLCDJIOELJO(IInGameReloadSelfControlledEntity FOFEHBEIMPP)
	{
	}

	private void CKGHDCDBHNE()
	{
	}

	public void KJGIKCNEGPN()
	{
	}

	public PreviewTeamFlightView MICBHPPCBOK(Player PGEGMKJKOKI)
	{
		return null;
	}

	private PreviewTeamFlightView GDKHGABJMEE(byte OPMHKKPJNGM)
	{
		return null;
	}

	public PreviewTeamFlightView IACMKJACFNF(Player PGEGMKJKOKI)
	{
		return null;
	}

	private void GIAGPCDGFCO(PreviewTeamFlightView HOECOJGCDOG, Player PGEGMKJKOKI)
	{
	}

	private Player IONGPLPIGIL(Player PGEGMKJKOKI)
	{
		return null;
	}

	private bool PPANEKPJGCJ(Player PGEGMKJKOKI)
	{
		return false;
	}

	public bool NHGHDCIOCHF(Player PGEGMKJKOKI)
	{
		return false;
	}

	public void HOHIOEGOCBP(Player PGEGMKJKOKI)
	{
	}

	public void BJPGKDJDMLE(Player PGEGMKJKOKI, Transform MAIFPPFLCEB)
	{
	}

	public bool MKKLPKJADEB(Player PGEGMKJKOKI)
	{
		return false;
	}

	private void GNLJKABBJAJ()
	{
	}

	private void NOMEHHGFOAK(Player KDJNEHDAAFL, float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void LAIMEEODHEI()
	{
	}

	private void KPALDGFAGMN()
	{
	}
}
