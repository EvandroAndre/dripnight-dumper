using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHyperBookContentNavigationController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	public struct HyperBookContentNavigationData
	{
		public uint BookID;

		public int SortID;

		public bool WaitForOpenAnim;
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public uint tokenItemID;

		public uint generaltokenID;

		internal void _003CRefreshTopToken_003Eb__0()
		{
		}

		internal void _003CRefreshTopToken_003Eb__1()
		{
		}

		internal void _003CRefreshTopToken_003Eb__2()
		{
		}
	}

	private sealed class _003CDelayEnumerator_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentNavigationController _003C_003E4__this;

		public UINavigationData navigationData;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayEnumerator_003Ed__92(int _003C_003E1__state)
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

	private sealed class _003CDelayOnShowContentCoroutine_003Ed__160 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentNavigationController _003C_003E4__this;

		public int selectPageIdx;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayOnShowContentCoroutine_003Ed__160(int _003C_003E1__state)
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

	private sealed class _003CPlayVFXAndDelayPopupCoroutine_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentNavigationController _003C_003E4__this;

		public uint bookID;

		public int pageIdx;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayVFXAndDelayPopupCoroutine_003Ed__165(int _003C_003E1__state)
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

	private sealed class _003CUnlockFailProcedureCoroutine_003Ed__167 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUnlockFailProcedureCoroutine_003Ed__167(int _003C_003E1__state)
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

	private sealed class _003CUnlockSuccessProcedureCoroutine_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHyperBookContentNavigationController _003C_003E4__this;

		public uint bookID;

		public int pageIdx;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUnlockSuccessProcedureCoroutine_003Ed__166(int _003C_003E1__state)
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

	private const string NORMAL_PAGE_DESC_KEY = "T_34_XY_HYPERBOOK_PAGEDEC";

	private const string HIDDEN_PAGE_DESC_KEY = "T_34_XY_HYPERBOOK_HIDDENPAGEDEC";

	private const string HIDDEN_PAGE_HELP_TIPS_KEY = "T_34_XY_HYPERBOOK_HIDDENHELP";

	private const string HIDDEN_PAGE_SPIN_CHANCE_KEY = "T_34_XY_HYPERBOOK_BRTIPS";

	private const string TOKEN_NOT_SELL_TIPS_KEY = "T_34_XY_HYPERBOOK_TOKENNOTSELL";

	private const string NO_GOPOS_CONFIG_KEY = "T_34_XY_HYPERBOOK_NOGOPOS";

	private const string PAGE_INDEX_KEY = "T_34_XY_HYPERBOOK_PAGENUM";

	private const string GOTO_LOCKED_PAGE_KEY = "T_34_XY_HYPERBOOK_PAGEREQUIRE";

	private const string HIDDEN_PAGE_SPIN_NUM_KEY = "T_34_XY_HYPERBOOK_SPINNUM";

	private const string UNLOCK_HIDDEN_PAGE_FAIL_KEY = "T_34_XY_HYPERBOOK_UNLOCKFAIL";

	private const string UNLOCK_HIDDEN_PAGE_SUCCESS_KEY = "T_34_XY_HYPERBOOK_UNLOCKSUCCESS";

	private const string NORMAL_PAGE_BG_NAME = "FF_UI_HyperBook_Brd";

	private const string HIDDEN_PAGE_BG_NAME = "FF_UI_HyperBook_Brd_Hidden";

	private const string UNLOCK_TOKEN_ENOUGH_FORMAT_STR = "{0}/{1}";

	private const string UNLOCK_TOKEN_NOT_ENOUGH_FORMAT_STR = "[FF0032]{0}[-]/{1}";

	private const string CLAIM_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE2";

	private const string Second_PAGE_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE3";

	private const string HIDDEN_PAGE_GUIDE_KEY = "T_34_XY_HYPERBOOK_GUIDE4";

	private const string ANIMATOR_TRIGGER_TURN_PREVIOUS = "PreviousPage";

	private const string ANIMATOR_TRIGGER_TURN_NEXT = "NextPage";

	private const string NAVI_ON_SHOW_ANIM_NAME = "VFX_UIHyperBookContentNavigation_into01";

	private const string TURN_PREVIOUS_PAGE_ANIM_EVT_NAME = "TURN_PREVIOUS_PAGE_FINISHED";

	private const string TURN_NEXT_PAGE_ANIM_EVT_NAME = "TURN_NEXT_PAGE_FINISHED";

	private const string HIDDEN_PAGE_NO_SPIN_TIME_DESC_KEY = "T_37_FH_HYPERBOOK_HIDDENHELP1";

	private const string HIDDEN_PAGE_HAS_SPIN_TIME_DESC_KEY = "T_37_FH_HYPERBOOK_HIDDENHELP2";

	private const string HYPERBOOK_PROBABILITY_KEY = "T_37_FH_HYPERBOOK_PROBABILITY";

	private const string HIDDEN_PAGE_GOTO_LOCKED_PAGE_KEY = "T_22_D_CHARTRIAL_OBTAIN_BTN";

	private const string BIGREWARD_INDEX_KEY = "T_39_FH_HYPERBOOK_PAGE8_TITLE";

	public const string HIDDEN_PAGE_MASK_DRAW_VFX_NAME = "Draw";

	private const float ENTRANCE_BOOK_OPEN_ANIM_TRANSITION = 0.8f;

	private const float PARTICLE_GATHERING_ENTITY_OTHERS_VFX_DURATION = 2.1f;

	private const float PARTICLE_GATHERING_VFX_SUCCESS_DURATION = 2.15f;

	private const float PARTICLE_GATHERING_VFX_FAILED_DURATION = 2.5f;

	private const float PAGE_ITEM_RECEIVED_VFX_PLAY_CAMERA_DEPTH = 4f;

	private const float PAGE_ITEM_RECEIVED_VFX_STOP_CAMERA_DEPTH = 2f;

	private const float PREVIEW_ITEM_DESC_HIDE_LOCAL_POS_X = -721.5f;

	private static readonly Vector3 PREVIEW_ITEM_CAMERA_VFX_OFFSET;

	private static readonly Vector3 PREVIEW_MIX_CAMERA_VFX_OFFSET;

	private readonly Vector3 PREVIEW_ITEM_DES_POSITION;

	private readonly Vector3 PREVIEW_ITEM_DES_ABOVE_PROPERTY_CONTAINER;

	private readonly Vector3 PREVIEW_PROPERTY_CONTAINER;

	private const uint FFWS_HyperBook_Id = 1803400003u;

	private readonly Vector3 FFWSBOOK_ITEMCAMERA_CIRCLE_ROTAION;

	private readonly Vector3 FFWSBOOK_AVATARCAMERA_CIRCLE_ROTAION;

	private readonly Vector3 FFWSBOOK_HIDDEN_UNLOCK_CIRCLE_POS;

	private readonly Vector3 FFWSBOOK_HIDDEN_UNLOCK_CIRCLE_ROTAION;

	private readonly Vector3 FFWSBOOK_HIDDEN_UNLOCK_CIRCLE_SCALE;

	private bool m_IsBookPurchasedDuringDisabled;

	private bool m_IsAllBookModelMatReady;

	private uint m_PreviewBookID;

	private int m_PreviewPageIdx;

	private int m_DefaultPreviewConfigIndex;

	private uint m_CurrentSelectItemID;

	private uint m_LastPreviewBookID;

	private ResourceID m_HiddenPageMaskVFXResID;

	private GameObject m_HiddenPageMaskVFX;

	private GameObject m_HiddenPageMaskDrawVFX;

	private GameObject m_ParticleGatheringEntityOthersVFX;

	private Transform m_3DContentRoot;

	private GameObject m_BookModelContent;

	private GameObject m_NormalPageBackgroundVFX;

	private GameObject m_HiddenPageBackgroundVFX;

	private GameObject m_NormalPageDecorationVFX;

	private GameObject m_HiddenPageDecorationVFX;

	private GameObject m_NormalBookModelVFXLeft;

	private GameObject m_HiddenBookModelVFXLeft;

	private GameObject m_NormalBookModelVFXRight;

	private GameObject m_HiddenBookModelVFXRight;

	private Animator m_BookModelAnimator;

	private SkinnedMeshRenderer m_BookModelMeshRenderer;

	private Coroutine m_OnShowContentDisplayCoroutine;

	private Coroutine m_PlayVFXAndDelayPopupCoroutine;

	private Coroutine m_UnlockSuccessProcedureCoroutine;

	private Coroutine m_UnlockFailProcedureCoroutine;

	private UIEvoGunTokenChangeSecondConfirm m_TokenChangeSecondConfirmCtrl;

	private bool m_Is3DContentRootHiddenByGachaFeature;

	private bool m_3DContentRootActiveBeforeGachaFeature;

	private UIHyperBookContentNavigationView m_View;

	private UIModelHyperBook m_ModelHyperBook;

	private UIModelInventory m_ModelInventory;

	private Material[] m_NormalPageMatArray;

	private Material[] m_HiddenPageMatArray;

	private readonly List<UIHyperBookContentPageItemController> m_PageItemCtrlList;

	private BitArrayBoolean m_StoreBtnState;

	private uint StoreBtnStateFlag_ItemInStore;

	private uint StoreBtnStateFlag_BookNotOwned;

	private bool m_IsStoreDataReady;

	private ItemChannelInfo m_BookChannelInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private IEnumerator DelayEnumerator(UINavigationData navigationData)
	{
		return null;
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void SetStoreBtnItemInStoreFlag()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	private void ShowSucessEquipTips()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnHyperBookPageStateChanged(uint bookID, int pageIdx)
	{
	}

	private void OnHyperBookNormalPageUnlocked(uint bookID, int pageIdx)
	{
	}

	private void OnCurrentBookPurchaseSuccess(uint bookID)
	{
	}

	private void OnAnimEvtOccured(object[] data)
	{
	}

	private void OnTurnPageAnimEvtOccured(bool nextPage)
	{
	}

	private void SetHidderPageMaskVFXState(bool show)
	{
	}

	private void OnCommonRewardWndFinish(object[] data)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void ClearBookPageItemList()
	{
	}

	private void RefreshBookPageItemList()
	{
	}

	private void RefreshPageDetailsPanel(int pageIdx, CollectionBookItemDesc pageItemDesc)
	{
	}

	private void RefreshPreviewComponent(int pageIdx, bool isInteraction, CollectionBookItemDesc pageDesc)
	{
	}

	private void RefreshPreviewItemDescPosition()
	{
	}

	private void RefreshUnlockFailedlProbabilityUPVFXShining()
	{
	}

	private void ResetToEnterAnimFirstFrame()
	{
	}

	private void ResetToEnterAnimLastFrame()
	{
	}

	private void PlayEnterAnim(bool reverse = false)
	{
	}

	private void PlayTurnPageAnimation(int previousPageIdx, int curPageIdx)
	{
	}

	private void PlayPreviewChangedVFX()
	{
	}

	private void RefreshBookModelMeshRenderMaterials(bool isHiddenPage)
	{
	}

	private void RefreshDecorationVFX(bool isHiddenPage, int pageIdx)
	{
	}

	private void RefreshBackgroundVFX(bool isHiddenPage)
	{
	}

	private void RefreshBookModelVFX(bool isHiddenPage)
	{
	}

	private void Refresh3DContent(bool active)
	{
	}

	private void OnGachaFeatureShowChanged(bool show)
	{
	}

	private static void OnPageHelpBtnClick()
	{
	}

	private void OnGotoLockedPageBtnClick()
	{
	}

	private void OnGotoStoreBtnClick()
	{
	}

	private void OnFunctionBtnClick()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void NavigateToEquipLocation(CSSharedItemDataManager.ItemType itemType, CSSharedItemDataManager.CollectionSubType collectionSubType, uint itemId)
	{
	}

	private void NavigateToNewVaultWithItem(uint itemId)
	{
	}

	private void AddEventDelegate()
	{
	}

	private static HyperBookContentNavigationData GetNavigationData(List<object> windowParam)
	{
		return default(HyperBookContentNavigationData);
	}

	private int GetSelectPageIdxOnShowed(HyperBookContentNavigationData navData, bool isPopBack)
	{
		return 0;
	}

	private CollectionBookItemDesc GetPageItemDesc(int pageIdx)
	{
		return null;
	}

	private void RefreshTitleAndPages(uint bookID)
	{
	}

	private void SetPreviewPage(int pageIdx, bool isInteraction, bool force = false)
	{
	}

	private void RefreshPageItemSelectState(int pageIdx)
	{
	}

	private void HideAllFunctionPanelContent()
	{
	}

	private void OnUnlockTokenNotEnough()
	{
	}

	private bool PopSelfIfCurrentBookPurchased(UINavigationData navigationData)
	{
		return false;
	}

	private void LoadHiddenPageMaskVFX(uint bookID)
	{
	}

	private void LoadBookModelContent(uint bookID)
	{
	}

	private void LoadBookBackgroundVFX(uint bookID)
	{
	}

	private void LoadBookDecorationVFX(uint bookID)
	{
	}

	private void LoadBookModelMaterials(uint bookID)
	{
	}

	private void Load3DContentRoot()
	{
	}

	private void LoadPageItemReceivedVFX()
	{
	}

	private void Destroy3DContentRoot()
	{
	}

	private void DestroyPageItemReceivedVFX()
	{
	}

	private void SetupPreviewItemCameraClearFlags()
	{
	}

	private Camera TryGetContent3DCamera()
	{
		return null;
	}

	private void RegisterPostEffectExtraCameras()
	{
	}

	private void UnRegisterPostEffectExtraCameras()
	{
	}

	private void SetPreviewCameraDepth(float depth)
	{
	}

	private void SetPreviewCameraActive(bool active)
	{
	}

	private IEnumerator DelayOnShowContentCoroutine(int selectPageIdx)
	{
		return null;
	}

	private void DelayOnShowContent(int selectPageIdx)
	{
	}

	private void SetStoreBtnState(uint flag, bool v)
	{
	}

	private void ShowCommandRewardWndOnReceived(uint bookID, int pageIdx)
	{
	}

	private bool AdjustItemReceivedVFXPos()
	{
		return false;
	}

	private IEnumerator PlayVFXAndDelayPopupCoroutine(uint bookID, int pageIdx)
	{
		return null;
	}

	private IEnumerator UnlockSuccessProcedureCoroutine(uint bookID, int pageIdx)
	{
		return null;
	}

	private IEnumerator UnlockFailProcedureCoroutine()
	{
		return null;
	}

	private void ShowUnlockFailCommonRewardWnd()
	{
	}

	private void PlayItemReceivedVFXAndDelayPopup(uint bookID, int pageIdx)
	{
	}

	private void StartUnlockSuccessProcedure(uint bookID, int pageIdx)
	{
	}

	private void StartUnlockFailProcedure()
	{
	}

	private void OnBtnExchangeRemainToken()
	{
	}

	private void RefreshTopToken()
	{
	}

	public void NotifyPageItemSelected(int pageIdx)
	{
	}

	public static HyperBookContentNavigationData GetNavigationDataExposed(List<object> windowParam)
	{
		return default(HyperBookContentNavigationData);
	}

	private bool IsSpecialBook(uint bookID)
	{
		return false;
	}

	private bool CheckNeedShowFirstPageGuide(uint bookID)
	{
		return false;
	}

	public void ShowFirstPageClaimGuide()
	{
	}

	public void ShowSecondPageGuide()
	{
	}

	public void ShowHiddenPageGuide()
	{
	}

	public void ShowGuideMask()
	{
	}

	private bool _003CDelayEnumerator_003Eb__92_0()
	{
		return false;
	}

	private void _003CShowFirstPageClaimGuide_003Eb__178_0()
	{
	}

	private void _003CShowSecondPageGuide_003Eb__179_0()
	{
	}

	private void _003CShowHiddenPageGuide_003Eb__180_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public FrontEndPreviewConfigData _003C_003EiFixBaseProxy_GetFrontEndPreviewData()
	{
		return null;
	}
}
