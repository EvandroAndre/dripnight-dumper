using System;
using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class UIBlockEditMgr : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<List<BEEnumData>> _003C_003E9__30_0;

		public static Comparison<BEEnumData> _003C_003E9__30_3;

		public static Func<List<BEEnumData>> _003C_003E9__30_1;

		public static Func<List<BEEnumData>> _003C_003E9__30_2;

		public static Predicate<BEEnumData> _003C_003E9__31_2;

		public static Predicate<JINIKKACLOC> _003C_003E9__36_0;

		internal List<BEEnumData> EHFHDAJPKBI()
		{
			return null;
		}

		internal List<BEEnumData> OOOOKMJPPEH()
		{
			return null;
		}

		internal int OFDMDCAIGMN(BEEnumData FADOEDJHAGD, BEEnumData LJJDHJOELML)
		{
			return 0;
		}

		internal List<BEEnumData> AFODDEIFMPL()
		{
			return null;
		}

		internal bool HOHEIGENLPI(BEEnumData DNNNJDJIBMP)
		{
			return false;
		}

		internal bool DMNIKFLKHOM(JINIKKACLOC DNNNJDJIBMP)
		{
			return false;
		}
	}

	private sealed class EFOIOBPKDNJ
	{
		public ValueData LABNPBJKCDN;

		internal bool NDGHONDEPAC(BEEnumData DNNNJDJIBMP)
		{
			return false;
		}

		internal bool GBIEOMBCOKC(BEEnumData DNNNJDJIBMP)
		{
			return false;
		}
	}

	private sealed class NJLIMGHGDGN
	{
		public long NHPIDHEPAFE;

		public long MHBHPAOEKAE;

		internal bool GECCNGPHGAF(BEEnumData DNNNJDJIBMP)
		{
			return false;
		}

		internal bool KDFNCBLIELA(BEEnumData DNNNJDJIBMP)
		{
			return false;
		}
	}

	private sealed class LKKAOGFPDPE
	{
		public GameObject JPDDNCDHMHG;

		public BlockData POANKHIAKCN;

		internal void AKACBBOEOPF()
		{
		}
	}

	private static UIBlockEditMgr _003CKPLDKGNCFCA_003Ek__BackingField;

	public bool IsRecoveGraphDone;

	private Dictionary<ResourceID, Queue<JINIKKACLOC>> NPOLIBBDBNF;

	private Queue<BE_DropdownItem> LAIGFIBFFJB;

	private Dictionary<string, Func<List<BEEnumData>>> AJJIJMEGEPH;

	public static UIBlockEditMgr DOKEBNDMAKA
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public Color GetBlockTypeColor(string IMMNDBGBNHH)
	{
		return default(Color);
	}

	public string GetBlockTypeText(string IMMNDBGBNHH)
	{
		return null;
	}

	public string GetBlockTypeName(string IMMNDBGBNHH)
	{
		return null;
	}

	public string GetBlockTypeIconLabelName(string IMMNDBGBNHH)
	{
		return null;
	}

	public string GetBlockIconName(string IMMNDBGBNHH)
	{
		return null;
	}

	public GameObject BuildGraphVarTypeLabel(TypeInfo CCNBNLAPJFM)
	{
		return null;
	}

	public GameObject BuildGraphBlock(BlockData POANKHIAKCN)
	{
		return null;
	}

	public GameObject BuildEventBlock(BlockData POANKHIAKCN, bool BHGIELDIBGG = false, bool CJENLLPMBJA = false, bool APBEFDHFLJO = true, bool GGNHCHDBEFO = false)
	{
		return null;
	}

	public GameObject BuildUserCustomEventBlock(BlockData POANKHIAKCN, bool BHGIELDIBGG = false)
	{
		return null;
	}

	public void BuildDispatchUserCustomEventBlock(BlockData POANKHIAKCN, BE_BodyBlock LHIHHNLCBLN)
	{
	}

	public GameObject BuildFuncDefinerBlock(BlockData POANKHIAKCN)
	{
		return null;
	}

	public GameObject BuildActionBlock(BlockData POANKHIAKCN, bool BHGIELDIBGG = false, bool CJENLLPMBJA = false, bool APBEFDHFLJO = true, bool GGNHCHDBEFO = false, bool IMFDENFBOFM = false)
	{
		return null;
	}

	public GameObject BuildDataBlock(BlockData POANKHIAKCN, bool BHGIELDIBGG = false, bool CJENLLPMBJA = false, bool APBEFDHFLJO = true, bool GGNHCHDBEFO = false)
	{
		return null;
	}

	private UILabel BCFGDOBDPBC(DataBlockDefine CKGLPHFDCPB, Transform GJDLFMIFHMG)
	{
		return null;
	}

	public void BindDataBlockHeaderItem(JINIKKACLOC CFFBINMFPAK, BE_DataBlock NFDGLENJLIE, ValueData FMKDPFEDGLN = null, int NIBBKONKPHP = -1)
	{
	}

	public void BuildDataFuncCallerBlock(BlockData POANKHIAKCN, FuncDefineData IFKIAGOBEOF, BE_DataBlock NFDGLENJLIE)
	{
	}

	public void BuildActionFuncCallerBlock(BlockData POANKHIAKCN, FuncDefineData HFMKECDCKFM, BE_BodyBlock LHIHHNLCBLN)
	{
	}

	public void BuildDefLocalVar(BlockData POANKHIAKCN, BE_BodyBlock LHIHHNLCBLN)
	{
	}

	public GameObject GetResObj(ResourceID AOFCDPKJKJO, Transform FKODMCNOBDM = null)
	{
		return null;
	}

	public void RegisterEnumDynamicHandler(string MHFLJAPHKEM, Func<List<BEEnumData>> EAPONNKANOB)
	{
	}

	private void NFIIDEINLHH()
	{
	}

	public List<JINIKKACLOC> BuildField(BlockFieldDefine CKGLPHFDCPB, BlockData POANKHIAKCN, Transform HDLNPMNBLHA, bool FHPOEBGCFCK = false)
	{
		return null;
	}

	public bool BuildHeaderItem(ResourceID EEOJGIGGNAA, Transform HDLNPMNBLHA, bool FHPOEBGCFCK, out GameObject HACIJIFIDKM, out JINIKKACLOC AJKPFBKNANE)
	{
		HACIJIFIDKM = null;
		AJKPFBKNANE = null;
		return false;
	}

	public GameObject BuildBodyBlock(int MDJKOCLLCHC, int BKCIEFBJLBO, bool NADGJFCEJJD, bool HAPIIPPALNC, Transform FKODMCNOBDM, bool GEEHHMIENAG)
	{
		return null;
	}

	public void SetHudWidgetPairData(BE_BlockSectionHeader_DropdownList FBPBLCJGEJO, BE_BlockSectionHeader_DropdownList FOBJLKOJKJI, bool BHGIELDIBGG)
	{
	}

	public void ShowMsgPop(string NNKEKBBGGKP, float CNKMEPFCJOM = 2f)
	{
	}

	public void ShowTutorial(BlockData EFLCNAKAJCM)
	{
	}

	public void CreateQuestionMark(BlockData POANKHIAKCN, Transform HDLNPMNBLHA, UILabel AFMIBOOHNDE = null)
	{
	}

	private UILabel NGPGNGELFME(string ILOAEFJNOBO, Transform HDLNPMNBLHA)
	{
		return null;
	}

	public void UpdateBlockAvailableUI(GraphData PGNDIEFJNPN)
	{
	}

	public string GetMissingLabel(bool HEBAPMJLIHA = true)
	{
		return null;
	}

	public string GetUnselectedLabel(bool HEBAPMJLIHA = true)
	{
		return null;
	}

	public string BuildTypeMismatchMsg(string IMMNDBGBNHH, string GLLHFBOGBCM, bool MOPBBIPONFC)
	{
		return null;
	}

	public JINIKKACLOC GetCachedHeaderItem(ResourceID EEOJGIGGNAA)
	{
		return null;
	}

	public void RecycleHeaderItem(ResourceID EEOJGIGGNAA, JINIKKACLOC BPDGEMBOGAA)
	{
	}

	public BE_DropdownItem GetCacheDropDownItem()
	{
		return null;
	}

	public void RecycleDropDownItem(BE_DropdownItem BPDGEMBOGAA)
	{
	}
}
