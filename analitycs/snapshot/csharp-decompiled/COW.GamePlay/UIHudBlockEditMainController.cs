using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class UIHudBlockEditMainController : UIPopupWindowController
{
	private class AIAssistAPISearchResp
	{
		public AIAssistAPIItemQueryResult response;
	}

	private class AIAssistAPIItemQueryResult
	{
		public List<AIAssistAPIItem> query_result;
	}

	private class AIAssistAPIItem
	{
		public string FunctionName;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, UGCBlockEditBlockSubTypeConfigData> _003C_003E9__59_0;

		public static Action _003C_003E9__59_5;

		public static Func<UIHudBESubTypeNodeItemController, bool> _003C_003E9__61_0;

		public static Comparison<UIHudBESubTypeNodeItemController> _003C_003E9__61_1;

		public static Predicate<JINIKKACLOC> _003C_003E9__72_0;

		public static Func<KeyValuePair<string, ODKIGJJOGEN>, ODKIGJJOGEN> _003C_003E9__151_1;

		internal UGCBlockEditBlockSubTypeConfigData JFDOECEOHHF(CSVBaseData HKHDBHIAPGL)
		{
			return null;
		}

		internal void KBICCJKCBOC()
		{
		}

		internal bool CLENHDIFKEB(UIHudBESubTypeNodeItemController FADOEDJHAGD)
		{
			return false;
		}

		internal int IEBLDKCEMCF(UIHudBESubTypeNodeItemController MDFHMBHHGGF, UIHudBESubTypeNodeItemController OGECPGHMIHA)
		{
			return 0;
		}

		internal bool FBALKBCCFGD(JINIKKACLOC DNNNJDJIBMP)
		{
			return false;
		}

		internal ODKIGJJOGEN JNACKLLHJFA(KeyValuePair<string, ODKIGJJOGEN> BPDGEMBOGAA)
		{
			return null;
		}
	}

	private sealed class JOFHMAGKCPD
	{
		public UISprite NDMACEJONLK;

		internal void NEEIDNBGMGI()
		{
		}
	}

	private sealed class MBOABEPFHJM
	{
		public GraphVarDefineData FNMJFLLBEPE;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		internal void HKHGAIMFADD()
		{
		}
	}

	private sealed class DAMLEHAEJGJ
	{
		public GraphVarDefineData FNMJFLLBEPE;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		internal void EBBCFDJPPHP()
		{
		}
	}

	private sealed class BGPFHMJLLNF
	{
		public UIHudBlockEditMainController KOKNHFGCGLN;

		public GraphVarDefineData FNMJFLLBEPE;

		internal void KILJFBJKDMC()
		{
		}
	}

	private sealed class PEMBLOOEMAK
	{
		public KeyValuePair<string, FuncDefineData> KLDIEAKFBPE;

		public UIButton GFEMCFNMCKJ;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		internal void PHDAKMHGCEG()
		{
		}
	}

	private sealed class HIBCIMJFNCC
	{
		public KeyValuePair<string, FuncDefineData> KLDIEAKFBPE;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		internal void EKMLGOHAHHL()
		{
		}
	}

	private sealed class JKBPDMGKFBA
	{
		public UIHudBlockEditMainController KOKNHFGCGLN;

		public FuncDefineData MEFDPJMJEHJ;

		internal void OHOHEFCOELA()
		{
		}
	}

	private sealed class FMJONDOEHED
	{
		public FuncDefineData MEFDPJMJEHJ;

		public UIHudSceneEditPopupMenuController LLGADNLPALG;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		internal void NMKONFDKNDA()
		{
		}

		internal void NACGOENNJHB()
		{
		}

		internal void HIBCOIDLCLJ()
		{
		}
	}

	private sealed class MOBICPJDFKP
	{
		public string FHFMBHBNHDD;

		internal int CBDIOFLKMEM(KeyValuePair<string, ODKIGJJOGEN> MDFHMBHHGGF, KeyValuePair<string, ODKIGJJOGEN> OGECPGHMIHA)
		{
			return 0;
		}
	}

	private sealed class AAIMGGGHELH
	{
		public UIHudBlockEditMainController KOKNHFGCGLN;

		public List<string> NPFPJPCPKIL;

		public UIScrollView.OnDragNotification FPOMKOPIJJL;

		public UIScrollView.OnDragNotification CCFACPABNHI;

		internal void LINJHCPNFKM()
		{
		}

		internal void PNMOFDEMBMG()
		{
		}
	}

	private sealed class CAJIAOFCALK
	{
		public int GNLIAKMGDDG;

		public AAIMGGGHELH EDIPCAMGBNP;

		internal bool MDLGLKFHOBK(UGCBlockEditBlockSubTypeConfigData DNNNJDJIBMP)
		{
			return false;
		}
	}

	private sealed class BKPGOKJGDDL
	{
		public string HNMLENBPDLI;

		public CAJIAOFCALK HIDGOLEIPLE;

		internal void MMPMGICPOGI()
		{
		}
	}

	private sealed class JJCPOGEFJHK
	{
		public UIHudBESubTypeNodeItemController ANPNJFMHOKL;

		internal void MLPOOBJOINJ()
		{
		}
	}

	private sealed class ABHLFOPIDCA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public UIHudBlockEditMainController KOKNHFGCGLN;

		private UIPopupWindowController IDGIDMPAMGM;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public ABHLFOPIDCA(int CBPPJACCGOH)
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

	public readonly Dictionary<string, List<KDAPIMCJEHJ>> m_GlobalGraphVarDic;

	public readonly Dictionary<string, List<KDAPIMCJEHJ>> m_LocalGraphVarDic;

	private readonly Dictionary<string, KDAPIMCJEHJ> DDKAADIAFKD;

	private readonly Dictionary<string, KDAPIMCJEHJ> AONLJKCGEPG;

	private readonly Dictionary<string, KDAPIMCJEHJ> OHLBPKFDICE;

	private Dictionary<string, JGFEALBJPGE> IFAOOGFPLMB;

	private List<BlockData> POEOFBBBEFN;

	private UIHudBlockEditMainView CGIEAOLABHM;

	private GraphData CBBMIEBNOCM;

	private GraphData HOAKFBLHIAE;

	private GraphData GNIGBLMJHCH;

	private string KOLOICFAKKF;

	private CKIDLEAGCBF MIDGAIBMADE;

	private BE_ProgrammingEnv JFPIAPJMFAA;

	private BE_DragDropManager EAJIFLLCBIE;

	private GraphData AACIBLGALNM;

	private bool HCCJCJDFCIL;

	private UISwitchScriptMenuController PHNHFCPCEFF;

	private UIHudBlockEditBlockHelpController BCBBJGNPOEE;

	private UIUnBlockOtherHudScript ANMPOFLPCFG;

	private UIModelSceneEdit EPCGBABJEDD;

	private string DPCFOGGCNFN;

	private float OCFPFOBAPJJ;

	private bool DMFLIOMEMPN;

	private ulong EHFIEKAALKI;

	private bool FBFGHIKIOKB;

	private const int DCAMEHJIFPC = 30;

	private int LDAHIMGCPOC;

	private List<List<ODKIGJJOGEN>> MCLNDJOHBIB;

	private List<BlockData> GKJCDAMKEAJ;

	private UIHudBESubTypeNodeItemController DDAFDGJJKIO;

	private List<string> CPCMFEIAHAK;

	private bool PBMAEBOFDIM;

	private HNDHJGJILHC NDFOOKIEOJH;

	private string DPAIGIIHDND;

	private UIUGCDebuggerConsole GPCFMHDGCON;

	private int LEJHIAHBEJA;

	private HHKELKPHNCL HJDJBJGJNOP;

	private GFJODHODOKC HFEMCPOIAPP;

	private NIHICNLMENM AIGHABBBEEK;

	private HOEKGGPFBIA AJCCLFECDBL;

	private int OMIFFJEKACP;

	private static readonly string MCHPBHLKFIM;

	private bool HAMCGKEFFBK;

	private string CICFEONHDMJ;

	private int EEBOBFALFPO;

	private int KEEBNAKIDMO;

	private string BHAKJMOEBBM;

	private double EPKFDKJDCKH;

	private List<KDAPIMCJEHJ> EIFJGIDEHOH;

	private List<BlockData> PMCEBNAFMCP;

	private bool DOOIOFGKLIN;

	private bool KPCMKDNMJOA;

	private int OLEHNAMCCMN;

	private BE_BlockSectionHeader_Slot BGEOJEPDHBI;

	private BE_BlockSectionHeader_AddParaBtn DIHNGFDGNDL;

	private bool OMNDLALDMMG;

	public BE_BlockSectionHeader_Slot ILIMKDDGCLE => null;

	public BE_BlockSectionHeader_AddParaBtn EHNCMLDOMDJ
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool ALOGPIGHECM => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void EINHCONCFCJ(UIScrollView KMBCJIJEKAL, Action HJCBFAOMBME)
	{
	}

	private void IMBOMIMHOHM()
	{
	}

	private void PDIAAMLDGFO()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private IEnumerator KJBFHJFJMNK()
	{
		return null;
	}

	private void APHFKFILMPI()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void BLKIOFLODLJ()
	{
	}

	private float JCDNLEKMCDF(string JCIFFMHHBHK, ref float IDCHLDICNPP)
	{
		return 0f;
	}

	public void RecoverGraph(GraphData ABDEKMCGPON)
	{
	}

	public void ResetEnvironment()
	{
	}

	public bool CenterAndHighlightBlock(string PDMMKDDNIHE)
	{
		return false;
	}

	public List<BlockData> GetAllBlockDataByTypeName(string JCIFFMHHBHK)
	{
		return null;
	}

	private void HPKJMOGNBEG()
	{
	}

	private void HLJJDINAMDM()
	{
	}

	private void BCFIGHHEFAJ(List<KDAPIMCJEHJ> LLKFPLGCGFM, bool EKBLBMGGEHF)
	{
	}

	private bool NBIOCOEEKHA(BlockData EABOCFFFGPM)
	{
		return false;
	}

	private void DEMENDACFJB()
	{
	}

	private void FDMIECDCKIN()
	{
	}

	private void OAJGKELMOAE()
	{
	}

	private void KHANHBLIABN(bool PIDINBNGILH)
	{
	}

	public void RefreshShowType()
	{
	}

	private void HGELNDDBGHA(UIHudBESubTypeNodeItemController ANPNJFMHOKL)
	{
	}

	private void GALONPOFAJK()
	{
	}

	public void ShowBlockTemplateAndSelect(string CFACJEKCGFJ)
	{
	}

	public void ShowBlockTemplate()
	{
	}

	private UIHudUGCBlockTemplateWndController HAEMCNJFCGB()
	{
		return null;
	}

	private void KBPFPLHLNAJ()
	{
	}

	public bool InitLibraryBlock(string DKFCFEAIBFD, int PAPBHPJKHOP = 0)
	{
		return false;
	}

	private bool ALJPOMOOKPL(BlockData EABOCFFFGPM)
	{
		return false;
	}

	private GameObject JFEKBOJCBJG(BlockData EABOCFFFGPM, bool CJENLLPMBJA = false, bool APBEFDHFLJO = true, bool GGNHCHDBEFO = false)
	{
		return null;
	}

	private bool GOKAMINLFEH(GameObject CNFBDMCJCNJ, BlockData EABOCFFFGPM)
	{
		return false;
	}

	private void CGEGFNEMPCJ()
	{
	}

	private void PBBFEJLAEIN()
	{
	}

	private void MAODDNEMEOH()
	{
	}

	public void CenterAndHighlightBlock(string HNMLENBPDLI, string LIKPJDHGPFG)
	{
	}

	private void GMOFONNIHLJ(string LKFPHFHKJBM, bool MGGFGEHLKOE = false)
	{
	}

	private void BEJFGEGJENE(string BGMOBDFANBD)
	{
	}

	private void EMEDCHICOKD()
	{
	}

	private void PCDKPBEHLEL(CKIDLEAGCBF OJANLPFFBOC)
	{
	}

	private void DGPPCJHGOJC()
	{
	}

	private void FONIGBGAOMM()
	{
	}

	private void NJNDEJJNKFC(List<GameObject> MDEPOMACIKD)
	{
	}

	private void BGHCLHMMCFJ()
	{
	}

	private void AFPKKJBGOBG()
	{
	}

	private void IOFKADAMAMJ()
	{
	}

	private void HDCFPAGGBCP()
	{
	}

	private void ELOBDMJBICF()
	{
	}

	private void BPMHMKCDGIC()
	{
	}

	private void CFMBKOJPOKM()
	{
	}

	private void BHHDNEGIPEL(object[] JCONDDPFBKK)
	{
	}

	private void HLDKMNPFPGB(object[] JCONDDPFBKK)
	{
	}

	private void NOGJIFADFGI(object[] JCONDDPFBKK)
	{
	}

	private void DADIKGENNIF(object[] JCONDDPFBKK)
	{
	}

	private void FNHCEMHGJHL(object[] JCONDDPFBKK)
	{
	}

	private void BFCLJFOJPCH(object[] JCONDDPFBKK)
	{
	}

	private void HGGHDPOIJBG(object[] JCONDDPFBKK)
	{
	}

	public void HideBlockPreset()
	{
	}

	private void DFHAHNOBBNL(object[] JCONDDPFBKK)
	{
	}

	private void EOCGKIGBFIJ(object[] JCONDDPFBKK)
	{
	}

	private void CDNBFJKAFDN(object[] HACIJIFIDKM)
	{
	}

	public void InitPopMenu()
	{
	}

	private void ELOBDMJBICF(EJPPDGBHFGO NBLHNPAHGNA)
	{
	}

	private void ELOBDMJBICF(string LIKPJDHGPFG, int EAFCDCGLPCD = 0)
	{
	}

	private void EAHBCNLCDON()
	{
	}

	private void AFBBEJIJNOC()
	{
	}

	private void CEPIFCHMIKP()
	{
	}

	private void OMEDLMDFLMM()
	{
	}

	private void PMGNPAJLLEI()
	{
	}

	private void BOHFENFJNJB()
	{
	}

	private void JKNAFILHMPH()
	{
	}

	private GraphData DIHFCHFAEGM(int EAFCDCGLPCD)
	{
		return null;
	}

	public void RefreshGraphVar()
	{
	}

	public GameObject AddGraphVarTypeLabel(Transform FKODMCNOBDM, GraphVarDefineData FNMJFLLBEPE, out UILabel MBHKNOPFIOO)
	{
		MBHKNOPFIOO = null;
		return null;
	}

	public void ReposAndLocateToNewVar(GraphVarRecord BMDHOAHLPCJ)
	{
	}

	public void OnGraphVarDeleteBtnClick(GraphVarDefineData FNMJFLLBEPE)
	{
	}

	public void RemoveGraphVarCmd(GraphVarDefineData FNMJFLLBEPE)
	{
	}

	public void RemoveGraphVarAndRelocate(GraphVarRecord NCCIDBMGDHD)
	{
	}

	public void CreateLocalGraphVar(string JCIFFMHHBHK, TypeInfo CCNBNLAPJFM)
	{
	}

	private bool GHJNIAIJOBK(string JCIFFMHHBHK, GraphData PGNDIEFJNPN)
	{
		return false;
	}

	private void NCPBAMPNHDD(FuncDefineData MEFDPJMJEHJ)
	{
	}

	public void RefreshCustomFunc()
	{
	}

	public void ReposAndLocateToNewFunc(FuncDefineRecord BMDHOAHLPCJ, ref float? EFMLCKBMOEJ)
	{
	}

	private void FJCLOOAMBLJ(FuncDefineData MEFDPJMJEHJ)
	{
	}

	private void NCKOIDNAFAH(Transform GJDLFMIFHMG, FuncDefineData MEFDPJMJEHJ)
	{
	}

	private void NGDOLMELNKA(FuncDefineData JCONDDPFBKK)
	{
	}

	public void DeleteCustomFuncAndRelocate(FuncDefineData MEFDPJMJEHJ, float? EFMLCKBMOEJ)
	{
	}

	private void AHJLEFFAEHL()
	{
	}

	public bool CheckSearchDuringCD()
	{
		return false;
	}

	private void FCAGAKOMADG(bool LBIAJFKFHPN = false)
	{
	}

	private void OCGEPGFNLJC(string FHFMBHBNHDD)
	{
	}

	private void AHDFGJHIFGJ()
	{
	}

	private void DCLCOOBEPPJ(bool NCABHJJOAEC)
	{
	}

	private void BADAPMOFIPJ(string FHFMBHBNHDD)
	{
	}

	private void EDNEKOEPKHH(GameObject HACIJIFIDKM)
	{
	}

	private void OJHAJOGIDIP(object[] JCONDDPFBKK)
	{
	}

	private void MLPLIGBACHD()
	{
	}

	private void LLAFNBDMOJC(bool GBCJHNIBAMH = false, bool NPHIAKDHOMK = true, bool CDJIIKPOCPB = true)
	{
	}

	private void LGBBMBHOJCJ()
	{
	}

	private void DJHMEKGDODI(TypeInfo CCNBNLAPJFM)
	{
	}

	private void LFMNOHLDMAB(TypeInfo CCNBNLAPJFM)
	{
	}

	public void SearchFormalType(BE_BlockSectionHeader_Slot DBPNIDJEAAE, BE_BlockSectionHeader_AddParaBtn GFEMCFNMCKJ)
	{
	}

	public void SearchFormalTypeOptimized(BE_BlockSectionHeader_Slot DBPNIDJEAAE, BE_BlockSectionHeader_AddParaBtn GFEMCFNMCKJ)
	{
	}

	private void NKJCLJLJKEG(TypeInfo CCNBNLAPJFM)
	{
	}

	private void FAEGGGGNHGO(GraphData HGHNCOAHCNF, TypeInfo CCNBNLAPJFM)
	{
	}

	private void BEGIFDPOFDG(GraphData HGHNCOAHCNF, TypeInfo CCNBNLAPJFM)
	{
	}

	public void BuildPartialParameterResultBlocks()
	{
	}

	private void PDFMFGBDOOC()
	{
	}

	private bool PMBDJAPIHBC(TypeInfo MMBEHJMNPDF, TypeInfo NLCLFBKFGKO)
	{
		return false;
	}

	private bool OGGIKNFNOEJ(BlockData JCONDDPFBKK, TypeInfo CCNBNLAPJFM)
	{
		return false;
	}

	public void CreateParameterResult()
	{
	}

	public void ShowParameterResult(bool EOGOGFLCEHL)
	{
	}

	public void AddButtonForParameterResult(GameObject KGCKHGNKALJ, BlockData JCONDDPFBKK)
	{
	}

	private void NMMDDPHCJIB(GameObject CLACOPMJHDI)
	{
	}

	private void CMBFNGOPOMI()
	{
	}

	private void EDIGHKFPHDI()
	{
	}

	private void NGLHMNFCHAK()
	{
	}

	public void CloseParameterResult()
	{
	}

	public void RefreshUserCustomEvent()
	{
	}

	private void OPAHOHHJDLM()
	{
	}

	private void PFFHEBEPMFJ()
	{
	}

	private void EDKKBENMGNL(bool MDOMDMKHLLJ)
	{
	}

	private void KCMHEAMMGEE()
	{
	}

	private void MGKDFJEEHHJ()
	{
	}

	private void CCMNMEBMGPO()
	{
	}

	private void ACCIMMNFOOB()
	{
	}

	private void PPIBBLOGMME()
	{
	}

	private void GFBAKFDFJDK()
	{
	}

	private void BEGJIHFLCDC()
	{
	}

	private int CLLDOIKFALN(BlockData MDFHMBHHGGF, BlockData OGECPGHMIHA)
	{
		return 0;
	}

	private int FKIGJANBIIC(BlockData MDFHMBHHGGF, BlockData OGECPGHMIHA)
	{
		return 0;
	}

	private void ONBNLFNPJMG(DOEOGBNPNAJ JJLCPPNJDFG, ELLGAABJFFP HNOPOGABFLN, byte[] CPMPOFNEDIJ)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
