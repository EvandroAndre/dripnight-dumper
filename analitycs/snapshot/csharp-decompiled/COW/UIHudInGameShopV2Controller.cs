using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudInGameShopV2Controller : UIBaseController
{
	private enum TemplateType
	{
		Headline,
		ShopItem
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__52_0;

		public static Action _003C_003E9__52_1;

		internal void _003CSetControllerCursorEvent_003Eb__52_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__52_1()
		{
		}
	}

	private sealed class _003CDelayFocusedCategoryItemVisualEffect_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInGameShopV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayFocusedCategoryItemVisualEffect_003Ed__130(int _003C_003E1__state)
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

	private const string m_DescGroupExpandAnimationName = "UIFX_UIHudInGameShopV2_DescriptionGroup_In";

	private const string m_DescGroupCollapseAnimationName = "UIFX_UIHudInGameShopV2_DescriptionGroup_Out";

	private const int m_ShopItemsCreatedPerFrame = 2;

	private static readonly Vector2 m_DefaultHeadlineSize;

	private static readonly Vector2 m_DefaultShopItemSize;

	private static readonly UITable2.Margin m_DefaultHeadlineMargin;

	private static readonly UITable2.Margin m_DefaultShopItemMargin;

	private bool m_ShopTypeAssigned;

	protected bool m_IsHideTemporary;

	private bool m_ReceivedChangeWhileHidden;

	private int m_SelectedTabIndex;

	private int m_SelectedShopItemCategory;

	protected int m_SelectedShopItemID;

	private int m_CurrentFocusCategoryTable2ItemIdx;

	private uint m_HideDropCandidateTipsDelayCallID;

	private HEOJAGLBHLJ m_ShopType;

	protected UIHudInGameShopV2View m_View;

	private UITable2VirtualBoundsHelper m_Table2VirtualBoundsHelper;

	private IPlayerFundStatsController m_FundStatsCtrl;

	private UIHudMinimalBackpackStatsController m_BackpackStatsCtrl;

	private UIHudInGameShopV2DropCandidateTipsController m_DropCandidateTipsCtrl;

	private readonly List<int> m_ViewDataIndices;

	private readonly List<object> m_ViewDataList;

	private readonly List<BGMFPPDLCBB> m_SharedSortedItemsUnderCategory;

	private readonly List<UIHudInGameShopV2TabEntryController> m_TabEntries;

	private UIHudInGameShopV2POIMissionController m_POIMissionContentCtrl;

	protected string m_CloseBtnIconNameDefault;

	protected string m_BuyBtnIconNameDefault;

	protected string m_DisableBuyBtnIconNameDefault;

	protected Color m_SkinTitleBgColorDefault;

	protected Color m_CloseBtnIconColorDefault;

	protected Color m_BuyBtnIconColorDefault;

	protected Color m_DisableBuyBtnIconColorDefault;

	protected bool m_BuyBtnLabelApplyGradientDefault;

	protected Color m_BuyBtnLabelColorDefault;

	protected Color m_BuyBtnLabelGradientTopDefault;

	protected Color m_BuyBtnLabelGradientBottomDefault;

	protected bool m_DisabledBuyBtnLabelApplyGradientDefault;

	protected Color m_DisabledBuyBtnLabelColorDefault;

	protected Color m_DisabledBuyBtnLabelGradientTopDefault;

	protected Color m_DisabledBuyBtnLabelGradientBottomDefault;

	protected HEOJAGLBHLJ ShopType
	{
		get
		{
			return HEOJAGLBHLJ.EShopType_Common;
		}
		private set
		{
		}
	}

	private bool IsShopItemSelected => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void SetControllerCursorEvent(Action OnShowOrOnCreate, Action OnHideOrDestroy)
	{
	}

	protected void RebuildContentAndLayout()
	{
	}

	protected virtual void OnInGameShopHideTemporary()
	{
	}

	protected virtual void OnInGameShopShow()
	{
	}

	protected virtual void OnInGameShopHide()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected void MarkReceivedChangeWhileHidden()
	{
	}

	private void ResetReceivedChangeWhileHiddenFlag()
	{
	}

	private void OnShowHud(object[] data)
	{
	}

	protected void OnInGameShopItemsRefresh(bool itemCountChanged)
	{
	}

	protected void OnRefreshShopExtraItems(uint shopId)
	{
	}

	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	private void OnBuyResultReceived(int ret)
	{
	}

	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerKnockDown(object[] data)
	{
	}

	private void OnShopDiscountStarted()
	{
	}

	private void OnPlayerFundsChanged(int data)
	{
	}

	private void OnReviveCardDiscountChanged(object[] param)
	{
	}

	private void UpdateSelectedShopItemPurchaseBtnState()
	{
	}

	private void UpdateSelectedShopItemDropCandidateTips()
	{
	}

	private void OnBagCapacityChanged(bool ignoreFullPopup)
	{
	}

	private void UpdateSelectedShopItemLimitationOnChanged()
	{
	}

	private void OnGlobalAvailableNumChanged(object[] data)
	{
	}

	private void OnPersonalBoughtCountChanged(object[] data)
	{
	}

	private void OnTeamBoughtCountChanged(object[] data)
	{
	}

	private void OnAirDropShopAvailableChanged(object[] data)
	{
	}

	private void CheckMissionCardState()
	{
	}

	private void OnPOIMissionStateChanged(uint poimissionId)
	{
	}

	private void OnBattleStylePlayerLevelChange(uint level)
	{
	}

	private void OnShopItemNewTagChanged(uint itemID)
	{
	}

	protected virtual void RegisterTypeSpecificContainerEvents()
	{
	}

	protected virtual void RegisterTypeSpecificShopItemsEvents()
	{
	}

	private void RegisterEvents()
	{
	}

	private void AddEventDelegates()
	{
	}

	protected virtual void AddTypeSpecificEventDelegates()
	{
	}

	protected virtual void OnExitShopMaskClicked()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private bool OnEscapeHandlerInvoked()
	{
		return false;
	}

	private void OnPurchaseBtnClick()
	{
	}

	private void OnCollapseShopItemDescBtnClicked()
	{
	}

	private void OnExpandShopItemDescBtnClicked()
	{
	}

	private static string GetBuyButtonTextWithResult(JMHFAMKMIOB buyResult, bool freeItem)
	{
		return null;
	}

	private void DeviceInputTuning()
	{
	}

	private void DeviceInputTuningOnDestroy()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void RecordDefaultSkinInfo()
	{
	}

	private void OnInGameShopRefreshSkin(uint shopId)
	{
	}

	private void SetSkin(uint skinType)
	{
	}

	private uint GetCurrentInGameShopBRSkinType()
	{
		return 0u;
	}

	private void SetSkinElement(UISprite sprite, string name, string defaultName, Color defaultColor, bool resetToDefault)
	{
	}

	private void SetBuyBtnLabelColor(uint skinType, bool resetToDefault)
	{
	}

	private void SetDisabledBuyBtnLabelColor(uint skinType, bool resetToDefault)
	{
	}

	private void SetSkinLabelColor(UILabel label, Color color)
	{
	}

	private void RestoreSkinLabelColor(UILabel label, bool applyGradient, Color color, Color gradientTop, Color gradientBottom)
	{
	}

	protected virtual void SetupTypeSpecificStaticContent()
	{
	}

	private IPlayerFundStatsController PrepareFundStatsController(CLLLDGMKBHK.FCLKCIFNJBD payMethod)
	{
		return null;
	}

	private void PrepareStatsControllers()
	{
	}

	private void PrepareTypeSpecificStatsControllers()
	{
	}

	private void InitTable2Templates()
	{
	}

	private void InitVirtualBoundsHelper()
	{
	}

	private void BuildViewDataList(List<KPEGFKFLFDO> categories, List<object> viewDataList, List<int> viewDataIndices)
	{
	}

	private void PopulateTabs(List<KPEGFKFLFDO> categories)
	{
	}

	private void PopulateShopItems(List<object> viewDataList)
	{
	}

	protected virtual void UpdateShopBackground()
	{
	}

	protected void UpdateShopTitleGroup(string titleContent, bool showGameMissionIcon, bool showTitleHelpBtn)
	{
	}

	private void UpdateStatsControllers()
	{
	}

	private void UpdateTabsHighlightState()
	{
	}

	private void UpdatePurchaseBtnGroupContent(bool enable, string content)
	{
	}

	private void OnShopItemStartSale()
	{
	}

	private void UpdatePOIMissionContent(BGMFPPDLCBB selectedShopItemInfo)
	{
	}

	private void UpdatePurchaseBtnState(BGMFPPDLCBB selectedShopItemInfo, JMHFAMKMIOB result)
	{
	}

	private BGMFPPDLCBB GetShopItemInfoWithSelection(int category, int shopItemID)
	{
		return null;
	}

	private JMHFAMKMIOB GetShopItemPreCheckResult(BGMFPPDLCBB itemInfo, out GBFCHMLNOOC dropCandidate)
	{
		dropCandidate = default(GBFCHMLNOOC);
		return (JMHFAMKMIOB)0u;
	}

	private UIHudInGameShopV2ItemController GetValidControllerWithMatchedItemID(int shopItemID)
	{
		return null;
	}

	private void SelectAndFocusTabWithCategory(byte categoryType)
	{
	}

	private void SelectAndFocusTabWithIndex(int index)
	{
	}

	private void FocusOnShopItemCategory(byte categoryType)
	{
	}

	private void OnScrollToCategoryItemTweenFinished()
	{
	}

	private IEnumerator DelayFocusedCategoryItemVisualEffect()
	{
		return null;
	}

	private void SelectShopItemWithID(int selectedShopItemID)
	{
	}

	private void UpdateShopItemSelection(int selectedShopItemCategory, int selectedShopItemID)
	{
	}

	private void CancelShopItemSelection(bool skipDropCandidateTips)
	{
	}

	private void PlayDescGroupCollapseExpandAnimation(bool collapse)
	{
	}

	private void SampleDescGroupWithAnimation(bool collapse)
	{
	}

	private void HideShopItemDescriptionGroup()
	{
	}

	private void CollapseExpandShopItemDescGroup(bool collapse, bool playAnimation)
	{
	}

	private void UpdateShopItemLimitationDetails(BGMFPPDLCBB shopItemInfo)
	{
	}

	private void UpdateShopItemDescriptionGroupDetails(BGMFPPDLCBB shopItemInfo)
	{
	}

	private void UpdateShopItemDescriptionGroup(BGMFPPDLCBB selectedShopItemInfo)
	{
	}

	private bool IsDropCandidateTipsPresent()
	{
		return false;
	}

	private bool IsDropCandidateTipsAnimationPlaying()
	{
		return false;
	}

	private void TryCancelHideDropCandidateTipsDelayCall()
	{
	}

	private void HideDropCandidateTips()
	{
	}

	private void PlayTipsDropAnimationAndDelayHide()
	{
	}

	private UIHudInGameShopV2DropCandidateTipsController EnsureDropCandidateTipsCtrl()
	{
		return null;
	}

	private void UpdateDropCandidateTips(BGMFPPDLCBB selectedShopItemInfo, JMHFAMKMIOB result, GBFCHMLNOOC dropCandidate)
	{
	}

	internal virtual EDPFGIMHEPM BuildInGameShopBuyReqMessage()
	{
		return null;
	}

	private void SendBuyRequest()
	{
	}

	private bool TrySendBuyWithDroppingRequest(GBFCHMLNOOC dropCandidate)
	{
		return false;
	}

	public void OnTabEntryClicked(byte categoryType)
	{
	}

	public void OnShopItemSelected(int selectedShopItemCategory, int selectedShopItemID)
	{
	}

	public void OpenWithShopType(HEOJAGLBHLJ shopType)
	{
	}

	public void EnsureFullRebuildOnTheFirstShow()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__110_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__110_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
