using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public class IKFMICGECHK : SingletonModule<IKFMICGECHK>
{
	public enum FNJKNONOFNM
	{
		None,
		AssetID,
		CollectionID,
		LevelObjectID,
		AIType
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<LJICFKFGFHL> _003C_003E9__18_0;

		public static Predicate<LJICFKFGFHL> _003C_003E9__22_0;

		internal bool ECAEHOAJABE(LJICFKFGFHL OFNAKBFCBIB)
		{
			return false;
		}

		internal bool OMMLNJAPEHB(LJICFKFGFHL OFNAKBFCBIB)
		{
			return false;
		}
	}

	public const int ONDAANFJLCJ = 37;

	private readonly Dictionary<uint, UGCResInfo> KDBAGJLMBLO;

	private readonly Dictionary<uint, UGCResInfo> AOMHJGMDHNP;

	private readonly HashSet<string> LLANEOFKHPB;

	private readonly Dictionary<string, UGCResInfo> HGAMIPMGPHE;

	private Queue<string> CGHNFDBEFOA;

	private readonly Dictionary<int, HashSet<ResourceID>> FLLNNLMIAFK;

	private readonly Dictionary<int, HashSet<ResourceID>> OPBGFCKIKOK;

	private readonly Dictionary<int, HashSet<ResourceID>> NAPGFLPHCPA;

	private readonly Dictionary<int, HashSet<ResourceID>> ANCEKMLNCBK;

	private CSVAsyncDataMap<uint, WorkshopAvatarData> NIDJGBFHLMM;

	private readonly HashSet<ResourceID> MGDJAEEEFGG;

	public static bool KPHBLHEMCOE;

	public static bool MKIBGDOMLCE;

	private static HashSet<string> AFKGNGOKGDJ;

	private Dictionary<string, UGCSimpleDownloadTask> KKKFPNILNPO;

	private bool LHMFBKEFNOL;

	private HashSet<ResVersionInfo.FileInfo> CLDDLIIEANM;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void EHNHOMNACEN()
	{
	}

	public bool DPNPJNOFNAH(KCJDEKIJAKH HDNAALELHPA, EditorMiscData GIKJOCCHKAC)
	{
		return false;
	}

	public GNHAFLDPNJI DPNPJNOFNAH(KCJDEKIJAKH HDNAALELHPA)
	{
		return null;
	}

	public bool BNJGEIPBCDE(JOEANMPIFAB FCKBPGPIAGK, ref PDNPIMFAGEN EMGCPKKJEON, out GNHAFLDPNJI HPCLBJJDCOC, EditorMiscData GIKJOCCHKAC, bool FPDAKLCAKOO = false)
	{
		HPCLBJJDCOC = null;
		return false;
	}

	public GNHAFLDPNJI BNJGEIPBCDE(JOEANMPIFAB FCKBPGPIAGK, ref PDNPIMFAGEN EMGCPKKJEON, bool FPDAKLCAKOO = false)
	{
		return null;
	}

	public ResCollectingContext FGKFPCBKMLP()
	{
		return null;
	}

	private void EFCFLKHCMGA(ResCollectingContext JPPOFGHGPGE, GNHAFLDPNJI FEEGALMDNEI, ref PDNPIMFAGEN EMGCPKKJEON)
	{
	}

	private void EMCLLCAAABA(JOEANMPIFAB FCKBPGPIAGK, ResCollectingContext JPPOFGHGPGE)
	{
	}

	private void KPACFNHHBGA(long DLMGDEAFLHD, UGCSimpleValue GACMHEPKKNL, ResCollectingContext JPPOFGHGPGE)
	{
	}

	private void KPACFNHHBGA(IPIFNFDIIKK GACMHEPKKNL, ResCollectingContext JPPOFGHGPGE)
	{
	}

	private void MPIGNGNMDNK(List<INAMDLOFOHF> AGBBBOBEIGH, ResCollectingContext JPPOFGHGPGE)
	{
	}

	private void BDMGKLKLFDF(ref ResCollectingContext JPPOFGHGPGE)
	{
	}

	private void CJLEJJKHOGC(List<PLMKOPJMIEP> AGBBBOBEIGH, ResCollectingContext JPPOFGHGPGE)
	{
	}

	public void EFIKDIPHCCG(BlockEditContext CCMGPBAFCEC, ResCollectingContext JPPOFGHGPGE, List<GraphData> JKKJHBKKPHM = null)
	{
	}

	public void OCJFEDHEBKH(ResCollectingContext JPPOFGHGPGE, ref PDNPIMFAGEN ALKHJDMCPJE, List<SceneEditObjectBase> NDPIOIOMDHN = null)
	{
	}

	private void EBNFEGJGJKJ(GNHAFLDPNJI ENPECOACPDP, ResCollectingContext JPPOFGHGPGE)
	{
	}

	public bool IGDINOIANCC(IEnumerable<UGCCustomLevelObjectEditorPackageInfo> IEPLBFNHEAL, ref PDNPIMFAGEN ALKHJDMCPJE)
	{
		return false;
	}

	public FNJKNONOFNM LFLAOOJEBIJ(long HICDHJNKMPJ)
	{
		return FNJKNONOFNM.None;
	}

	public UGCResInfo DKKHNLFMJEC(SceneEditSlotInfo NBLHNPAHGNA, byte[] FCKBPGPIAGK, bool NIBGDCNMGED = false, bool ODFECNPGKCB = false)
	{
		return null;
	}

	public UGCResInfo DKKHNLFMJEC(uint JNACDFINCPH, uint JMPGKJJEMEP, byte[] FCKBPGPIAGK, bool NIBGDCNMGED = false, bool ODFECNPGKCB = false)
	{
		return null;
	}

	public void FCABLFEALPJ(SceneEditSlotInfo NBLHNPAHGNA, byte[] FCKBPGPIAGK)
	{
	}

	public void HMAAINEBMHF(SceneEditSlotInfo NBLHNPAHGNA, byte[] FCKBPGPIAGK)
	{
	}

	public void IOBFCNJJMON(SceneEditSlotInfo NBLHNPAHGNA)
	{
	}

	private bool NOLMEHEMJPL(SceneEditSlotInfo NBLHNPAHGNA)
	{
		return false;
	}

	public UGCResInfo LCDPDOIEJEI(uint DBNIBOECBKD)
	{
		return null;
	}

	public void MFOKPAPCCAF(SceneEditSlotInfo NBLHNPAHGNA)
	{
	}

	public UGCResInfo JLLCMGKGFFF(byte[] ICGLLNKOOEG, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
		return null;
	}

	public UGCResInfo JLLCMGKGFFF(AEKGOFIODHM ONMBIECCJBF, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
		return null;
	}

	public void DFOIJOAAHCK(string IECDIFKJJGI)
	{
	}

	public bool JDDEHLCLNHF(string MMOMBMFCKMF)
	{
		return false;
	}

	public bool BPIHEDHJDKF(SceneEditSlotInfo NBLHNPAHGNA, bool OAJHFMMFNMI = true)
	{
		return false;
	}

	public UGCResInfo KKGNJOCBAKA(SceneEditSlotInfo MMAHAIMIGND)
	{
		return null;
	}

	public UGCResInfo PJPIEAPHDID(SceneEditSlotInfo MMAHAIMIGND, out byte[] JEFHCDDMPLK)
	{
		JEFHCDDMPLK = null;
		return null;
	}

	public bool PFDBPNPINOH(string MFLHABMMAJB, out byte[] JEFHCDDMPLK)
	{
		JEFHCDDMPLK = null;
		return false;
	}

	public UGCResInfo GLIJKJNKDGD(string MFLHABMMAJB, uint JNACDFINCPH, uint JMPGKJJEMEP)
	{
		return null;
	}

	public UGCResInfo NPOPJKKFNBN(string MFLHABMMAJB, uint JNACDFINCPH, uint JMPGKJJEMEP, out byte[] JEFHCDDMPLK)
	{
		JEFHCDDMPLK = null;
		return null;
	}

	public UGCResInfo NPOPJKKFNBN(SceneEditSlotInfo MMAHAIMIGND, out byte[] JEFHCDDMPLK)
	{
		JEFHCDDMPLK = null;
		return null;
	}

	private UGCResInfo GGBIEADMLME(string MFLHABMMAJB)
	{
		return null;
	}

	public bool OEJDOICEFMN(string MFLHABMMAJB, UGCResInfo NNKEKBBGGKP)
	{
		return false;
	}

	public void HGBKMAIHMBE()
	{
	}

	private void ELMCIPJLPGG(HashSet<ResourceID> FGOHBKNLFPD, SceneEditSlotInfo MMAHAIMIGND, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, bool FNONPENGEJB = true)
	{
	}

	private void IKJFFOPOIEH(HashSet<ResourceID> FGOHBKNLFPD, UGCResInfo LEJGCOCLNOK, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
	}

	public void MECJOCHFLAM(HashSet<ResourceID> FGOHBKNLFPD, GNHAFLDPNJI GHNNOJGKJDI)
	{
	}

	public void GKIPIBJICHI(HashSet<ResourceID> FGOHBKNLFPD)
	{
	}

	public void MMLALBBCNDL(UGCResInfo LEJGCOCLNOK, Dictionary<string, UGCResourceShopMetaData> HOLGKOGKEMD)
	{
	}

	public bool KFJILKCCBNL()
	{
		return false;
	}

	public bool OLHLCFKLHLF()
	{
		return false;
	}

	private void EMHJBNBNAKB(HashSet<ResourceID> FGOHBKNLFPD, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC)
	{
	}

	public void KKEGDHHPGEO(HashSet<ResourceID> FGOHBKNLFPD, int ILJIDKEGKPI, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, bool JMCKPJNGOFG = true)
	{
	}

	public void OCFJJEEIOGI()
	{
	}

	public void CILCAKLEPKK(HashSet<ResourceID> FGOHBKNLFPD, WorkshopCreateNewConfigData DKLKGHGFNCC)
	{
	}

	public void LCMNDGLPKMD(HashSet<ResourceID> FGOHBKNLFPD, GNHAFLDPNJI GHNNOJGKJDI)
	{
	}

	private void LCMNDGLPKMD(HashSet<ResourceID> FGOHBKNLFPD, ICollection<string> IHJPEPOMBBC, ICollection<uint> MJFPHEOFJLN, ICollection<uint> FBDGKIKEELG, ICollection<int> KIDMKDMHEKF)
	{
	}

	public void JPPBFOELLIJ(HashSet<ResourceID> FGOHBKNLFPD, uint JMPGKJJEMEP, uint JNACDFINCPH)
	{
	}

	public void HGMLKAKMBIP(HashSet<ResourceID> FGOHBKNLFPD, int MPAMIKHFEMK, uint JNACDFINCPH)
	{
	}

	public void JGEHACHMBGN(HashSet<ResourceID> FGOHBKNLFPD, int[] PJMGBIAHJBH)
	{
	}

	public bool DNHANAGPFJI(ICollection<ResourceID> GDHAFBKPHIE, ICollection<ResourceID> KMAAMMKDPFA)
	{
		return false;
	}

	public UGCSimpleDownloadTask PLANLNCPCGA(UGCCustomLevelObjectEditorPackageInfo JEMHMCELJCO, string EPCPDGEFAKA)
	{
		return null;
	}

	public EUGCMapResourceInfoState IEGAKOMGLKI(SceneEditSlotInfo MMAHAIMIGND)
	{
		return EUGCMapResourceInfoState.Unknown;
	}

	public EUGCMapResourceInfoState HPEAEPAEEOE(Dictionary<string, UGCResourceForGameData.PackageOrABFileInfo> LKNONBGGMPG)
	{
		return EUGCMapResourceInfoState.Unknown;
	}

	public List<ResourceID> NACAOELOMNM(SceneEditSlotInfo MMAHAIMIGND, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, HashSet<ResourceID> KLEMIDNPBID = null, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
		return null;
	}

	public List<ResourceID> IGGJKHPCHIO(UGCResInfo LEJGCOCLNOK, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, HashSet<ResourceID> KLEMIDNPBID = null, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
		return null;
	}

	public List<ResourceID> KGGOPHBDKED(List<UGCResInfo> HEMEMHNEDLE, UGCOptionalResConfigData.EUGCOptionalResDownloadType FJPPFKFKCIC, HashSet<ResourceID> KLEMIDNPBID = null, bool FNONPENGEJB = true, bool JMCKPJNGOFG = true)
	{
		return null;
	}

	public bool MHCPBJINHKP(SceneEditSlotInfo MMAHAIMIGND, out bool JHJDPFAGCHP)
	{
		JHJDPFAGCHP = default(bool);
		return false;
	}

	public GNHAFLDPNJI HBEANDNNDJF(byte[] FEKOLCAAEKB, out int ILJIDKEGKPI, out PDNPIMFAGEN ALKHJDMCPJE, out JOEANMPIFAB FCKBPGPIAGK, bool ODFECNPGKCB = false)
	{
		ILJIDKEGKPI = default(int);
		ALKHJDMCPJE = null;
		FCKBPGPIAGK = null;
		return null;
	}

	public GNHAFLDPNJI PHAIADBOKKH(byte[] FEKOLCAAEKB, out int ILJIDKEGKPI, out PDNPIMFAGEN ALKHJDMCPJE, out DAOBBJALGIG EPGJEOBFIPI)
	{
		ILJIDKEGKPI = default(int);
		ALKHJDMCPJE = null;
		EPGJEOBFIPI = null;
		return null;
	}

	public JOEANMPIFAB DPLINELOLDA(byte[] FEKOLCAAEKB, out int ILJIDKEGKPI, out PDNPIMFAGEN ALKHJDMCPJE)
	{
		ILJIDKEGKPI = default(int);
		ALKHJDMCPJE = null;
		return null;
	}

	public DAOBBJALGIG JAAOCGCPGNN(byte[] FEKOLCAAEKB, out int ILJIDKEGKPI, out PDNPIMFAGEN ALKHJDMCPJE)
	{
		ILJIDKEGKPI = default(int);
		ALKHJDMCPJE = null;
		return null;
	}

	public byte[] MLLJKIBHPEI(byte[] FEKOLCAAEKB, out int ILJIDKEGKPI, out PDNPIMFAGEN ALKHJDMCPJE)
	{
		ILJIDKEGKPI = default(int);
		ALKHJDMCPJE = null;
		return null;
	}

	public PDNPIMFAGEN OJJBDABCPME(byte[] GNPENCFPPIG, MFMLHNJCNGB PPENDBHDFKM)
	{
		return null;
	}

	public void KIFDPJLAGKH(List<ResourceID> LAKJEGDKPBH, bool HPBHDGNHDHK = false, bool JNHAPJEOCDN = false)
	{
	}

	public void EPCBDKGJALA(IEnumerable<ResVersionInfo.FileInfo> LKNONBGGMPG)
	{
	}

	public void GMBLJECCFMH()
	{
	}

	public void MJFLJDEGEBD()
	{
	}

	public void HOEJKOGOHKH()
	{
	}

	public bool EHAPECFHKMC()
	{
		return false;
	}

	public int PKFKCBIPKIP()
	{
		return 0;
	}
}
