using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class BE_DragDropManager : MonoBehaviour
{
	private sealed class BOBFJKPNDIG
	{
		public BlockData EMANEBGLLJG;

		internal void IECLIHLJJMO()
		{
		}
	}

	private sealed class BHHIHLLMOIF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public BE_DragDropManager KOKNHFGCGLN;

		private BE_Base LLBMDLEBHCD;

		private UIRoot KEFJFELHIHE;

		private RenderTexture LOFICEKELAC;

		private Transform NBGNDHEBKLF;

		private Vector3 PIAAGGMPKCL;

		private List<UIWidget> HNDBGDIHKJP;

		private List<bool> OBMGIKPBEEN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public BHHIHLLMOIF(int CBPPJACCGOH)
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

	public static float ButtonOffsetX;

	public static float ButtonOffsetY;

	private BE_DragDropItemBase _003CNKKADFJNKLA_003Ek__BackingField;

	private BlockData PDMDHFPBCLD;

	public UISprite HorizHighLightSprite;

	public UISprite VerticalHighLightSprite;

	private HashSet<BE_BlockSpot> LBCFIHEDGDJ;

	private HashSet<BE_SlotSpot> OEJEMJHGLFC;

	private bool DELOCGHKLPD;

	public UIPanel BlockContainerPanel;

	public UIPanel DragRelativePanel;

	public UITable CallOutTab;

	public UIButton CopyBtn;

	public UIButton PasteBtn;

	public UIButton ClearButton;

	public UIButton ExportBtn;

	public UIButton ExportAllBtn;

	public UIButton ImportBtn;

	public UIButton GotoDefBtn;

	public float DetectionSpotDistance;

	public NCFBEOGFKCN LastHighLight;

	private UIClickMask OIBBEDNNOJH;

	public static readonly Dictionary<string, LocalVarDefineData> LocalVarDefineCache;

	public static readonly Dictionary<string, FuncDefineData> FuncDefineCache;

	public UIButton BtnClear;

	public UIPanel ClipboardPanel;

	public Transform LineAdjust;

	public UIGrid GridAdjust;

	public UIButton BtnCopy;

	public UIButton BtnPaste;

	public UIButton BtnPopup;

	public UIButton BtnDisable;

	public UIButton BtnEnable;

	public UIButton BtnDelete;

	public UIButton BtnSaveBlockTemplate;

	public UIButton BtnGotoDef;

	public UIButton BtnEditFunc;

	public GameObject BlockTemplateImageContainer;

	public UITexture BlockTemplateImageBg;

	private GameObject GLNFHBAOFPP;

	private Camera IGLPCLBDMBC;

	private const int BDPGAMDBMJM = 264;

	private const int AFKJGECLMKI = 172;

	private const int ACEGMJNKIPL = 44;

	private const int JDEOGJOLHNB = 32;

	private float MGAJKGMIAED;

	public int m_MargineSpace;

	public int m_displayDistance;

	public BE_DragDropItemBase CAGDJDMFGCD
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BlockData PJNHPCLDLFP
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetCurrentBlockData(BlockData POANKHIAKCN)
	{
	}

	public void OnDragStart(BE_DragDropItemBase EECMGLNNKFJ)
	{
	}

	public void OnDragEnd()
	{
	}

	public void OnApplicationFocus(bool CPBFBNOMDPG)
	{
	}

	public void AddSpotInToSet(BE_BlockSpot CDLHGELKADB)
	{
	}

	public void RemoveFromSpotsSet(BE_BlockSpot CDLHGELKADB)
	{
	}

	public void RemoveHorizSpotFromSet(BE_SlotSpot CDLHGELKADB)
	{
	}

	private void IGHPCGFCOFM(MIGMKFGCHEN GKNPNICEEBK)
	{
	}

	private void EDEMDJKKION(GDCGCPPOMKJ NFDGLENJLIE)
	{
	}

	public void AddBlockSpot(BE_Base DMBHHAAGENB)
	{
	}

	public BE_BlockSpot FindSlotForBlockInAndOut(MIGMKFGCHEN GKNPNICEEBK)
	{
		return null;
	}

	public BE_BlockSpot FindClosestSpotForBlockInAndOut(MIGMKFGCHEN GKNPNICEEBK)
	{
		return null;
	}

	public BE_SlotSpot FindClosestSpotHoriz(BE_DataSpot OMMKIJFHGHG)
	{
		return null;
	}

	public void ShowHighLightSprite(bool BCAOMPNABFG, Vector3 HDFILHFDBKB, Vector3 GLPLIHEECAP)
	{
	}

	public void CloseHighLightSprite()
	{
	}

	public BE_Base FindDataBlockAncestorBlock(BE_DataBlock NFDGLENJLIE)
	{
		return null;
	}

	public MIGMKFGCHEN FindProcessBlockAncestor(MIGMKFGCHEN GKNPNICEEBK)
	{
		return null;
	}

	public void OnCopyBtn()
	{
	}

	public void CopyData()
	{
	}

	public void ExportUserBlockData()
	{
	}

	public void CacheClonedDefineDataForUI(BlockData POANKHIAKCN)
	{
	}

	public void PasteData(Vector3 HDFILHFDBKB)
	{
	}

	public void OnPasteBtn()
	{
	}

	public void ExportAllUserBlockData()
	{
	}

	public void ImportUserBlockData()
	{
	}

	private void BBIGDKHFGID(bool BFKLMGKBKAI)
	{
	}

	private void GDAJKGINGHL()
	{
	}

	public void GotoBlockDef()
	{
	}

	public ELLCOFPPKBH BuildPasteCommand(BlockData MEDJFOFAHPG, int NIBBKONKPHP)
	{
		return null;
	}

	public void ShowOptBtn()
	{
	}

	public void ShowPasteAndClearAllBtn()
	{
	}

	private void PAEGINLEONK()
	{
	}

	public void CancelMaskClick(bool MPJPHMJGBDI = true)
	{
	}

	private void FABFPALDKBL()
	{
	}

	public void ClearAllBlock()
	{
	}

	public void ClearGraphConfirmCallBack()
	{
	}

	public void ClearCurrentGraph()
	{
	}

	public BlockData GetHighLightBlockData()
	{
		return null;
	}

	public void SetCurrentHighLight(NCFBEOGFKCN GGAOLHDNKNJ, bool EOGOGFLCEHL, bool JJBODLEKMBP = false)
	{
	}

	public void CloseAllHighLight()
	{
	}

	public bool CheckAllGraphItemLimit(int LLKCBIFDLEC)
	{
		return false;
	}

	public bool CheckDataBlockNestLimit(BE_SlotSpot CDLHGELKADB, BE_DataBlock NFDGLENJLIE)
	{
		return false;
	}

	public int GetDataBlockDepth(GDCGCPPOMKJ NFDGLENJLIE)
	{
		return 0;
	}

	public void SetDraggingPanelDepth(BE_Base PHGIDALCPPO)
	{
	}

	public void AddRootBlockDataFacadePanel(BlockData POANKHIAKCN, bool MHFEMAKCKLP = false, bool JKDNIOKAHHJ = true)
	{
	}

	public void RemoveRootBlockDataFacadePanelAfterParentChanged(BlockData POANKHIAKCN)
	{
	}

	public void InitGraphBlockPanelDepth(BlockData POANKHIAKCN, int MDJKOCLLCHC)
	{
	}

	public void ResortBlockRootPanelDepth(BE_Base PHGIDALCPPO)
	{
	}

	public void UpdateClipboardPanelDepth()
	{
	}

	private void OnDestroy()
	{
	}

	private void LOHILHBMGDD()
	{
	}

	public void RefreshAdjustPanel()
	{
	}

	private void AIIACJLCJEB()
	{
	}

	private void KFJPHPIMAOO()
	{
	}

	private Vector2 FKANJLKIGFF(BE_Base HLDMPHPMBCG)
	{
		return default(Vector2);
	}

	private void AGONNFMEHPD(BE_Base PFJFADHEJLJ)
	{
	}

	private void JLDBLHKGJBC()
	{
	}

	private void CMDEPKHFKOO()
	{
	}

	private void CPJKPMCJGIA()
	{
	}

	private void LDJDMIHBIKE()
	{
	}

	public void DeleteCurrentBlock()
	{
	}

	private void JLKPNPEGGAN()
	{
	}

	private void CMCKJIONOKE()
	{
	}

	private IEnumerator CBMBCJHKFII()
	{
		return null;
	}

	private bool BPKPAAJCHGJ()
	{
		return false;
	}

	private void HGMLFNNOAFA()
	{
	}

	private void LKNMLJOGPMN()
	{
	}

	private bool CMIMGFMAOOH(BlockData DNNNJDJIBMP)
	{
		return false;
	}

	private void JABEGMPHKPF()
	{
	}
}
