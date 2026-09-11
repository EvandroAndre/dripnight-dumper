using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIFlashStoreNavigation : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	public enum NavigationType
	{
		NotSpecific,
		ToStore,
		ToActivity
	}

	public class FlashStoreNavigationData
	{
		public uint FlashStoreActivityID;

		public NavigationType NavType;

		public uint SelectIemID;

		public uint SelectGroupID;

		public uint SelectActivityID;
	}

	private struct UICommonGuideData
	{
		public string PlayerPrefKey;

		public CommonGuideSetting Setting;

		public UIButton FinishGuideBtn;

		public UIWidget GuideWidget;

		public UIAnchor.Side Side;

		public Action OnInitAction;

		public Action OnCloseAction;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<FlashStoreGoodsDesc> _003C_003E9__87_0;

		public static Predicate<FlashStoreGoodsDesc> _003C_003E9__87_1;

		internal bool _003CUpdateGuideItemIndex_003Eb__87_0(FlashStoreGoodsDesc t)
		{
			return false;
		}

		internal bool _003CUpdateGuideItemIndex_003Eb__87_1(FlashStoreGoodsDesc t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public uint itemID;

		internal bool _003CNavigationToItem_003Eb__0(FlashStoreGoodsDesc t)
		{
			return false;
		}
	}

	private sealed class _003CGotoFlashStoreActivity_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FlashStoreNavigationData navData;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGotoFlashStoreActivity_003Ed__82(int _003C_003E1__state)
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

	public const string FLASH_STORE_FREE_ACCESS_GUIDE = "FLASH_STORE_FREE_ACCESS_GUIDE_{0}";

	public const string FLASH_STORE_FLASH_GEMS_ITEM_LIST_GUIDE = "FLASH_STORE_FLASH_GEMS_ITEM_LIST_GUIDE_{0}";

	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	private const string RULE_POPUP_TITLE_KEY = "TXT_CLAN_GENERAL";

	private const float GET_STORE_RES_COOLDOWN = 3600f;

	private UIModelFlashStore m_ModelFlashStore;

	private UIFlashStoreNavigationView m_View;

	private UICountDownController m_CountDownCtrl;

	private UICountDownController m_CountDownCtrlTitle;

	private EventLogger.EventNaviTabViewTime m_EventTypeFlashStoreTabInfo;

	private uint m_FlashStoreActivityID;

	private uint m_GuideDelayCallTid;

	private UIWidget m_FlashGemsOnlyItemWidget;

	private UIWidget m_FlashGemsAndGemsItemWidget;

	private int m_FlashGemsOnlyItemIndex;

	private int m_FlashGemsAndGemsItemIndex;

	private bool m_CanGuideShow;

	private Dictionary<uint, UIToggleButton> m_ToggleButtonDict;

	private Dictionary<uint, EventDelegate.Callback> m_MallTabClickDelegateDict;

	private List<UIToggleButton> m_TabToggleList;

	private UIToggleButtonGroup m_UIToggleButtonGroup;

	private UIModelFlashStore.UILimitedStoreTabType m_CurrentSelectedTab;

	private UIModelFlashStore.UILimitedStoreTabType m_PreviousSelectedTab;

	private readonly ulong[] m_TabViewTimeArr;

	private ulong m_TabStartShowTime;

	private ulong m_TabEndShowTime;

	private Dictionary<uint, int> m_TabOrderDict;

	private Dictionary<uint, string> m_MallTabNameDict;

	private UIModelInventory m_ModelInventory;

	private List<FlashStoreGoodsDesc> m_CurrentTabItemList;

	private FlashStoreGoodsDesc m_CurrentSelectItem;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	private UIModelFlashStore.ECurrentSelectItemAvailableState m_CurrentSelectItemAvailableState;

	private UIModelFlashStore.EFlashStoreItemPriceState m_CurrentSelectItemGemsPriceState;

	public UIModelFlashStore.UILimitedStoreTabType CurrentSelectedTab
	{
		get
		{
			return UIModelFlashStore.UILimitedStoreTabType.MallTabTypeRecommend;
		}
		set
		{
		}
	}

	private void InitMallTabClickDelegateDict()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
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

	private void OnFlashStoreItemClickEventReceive(object[] data)
	{
	}

	private void BindTabTogglesDelegate()
	{
	}

	private void OnTopBarFlashGemsTokenClick()
	{
	}

	private void OnTopBarGemsTokenClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnFreeAccessBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnRecommendToggleSelected()
	{
	}

	private void OnOtherToggleSelected()
	{
	}

	private void OnWeaponToggleSelected()
	{
	}

	private void OnPetToggleSelected()
	{
	}

	private void OnCollectionToggleSelected()
	{
	}

	private void OnCharacterToggleSelected()
	{
	}

	private void OnFashionToggleSelected()
	{
	}

	private int GetCurrentSelectItemIndex(FlashStoreGoodsDesc item)
	{
		return 0;
	}

	private bool IsNavigateToActivityNecessary()
	{
		return false;
	}

	private void AddFlashStoreTabInfoToList(string tabName, ulong viewTime)
	{
	}

	private void UpdateLastSelectTabViewTime(UIModelFlashStore.UILimitedStoreTabType lastSelectTab)
	{
	}

	private static FlashStoreNavigationData GetNavigationData(List<object> rawData)
	{
		return null;
	}

	private string GetMallTabName(uint type)
	{
		return null;
	}

	private void UpdateMallTab()
	{
	}

	private void RefreshCurrentTabView(UIModelFlashStore.UILimitedStoreTabType mallTabType, bool isFromClick = true, int defaultSelectItemIndex = 0)
	{
	}

	private void PrepareTopBarTokens()
	{
	}

	private void InitDataAndUI()
	{
	}

	private void InitPeriodAndTitleViewData()
	{
	}

	private void RefreshCurrentViewData(FlashStoreGoodsDesc desc)
	{
	}

	private void UpdateActivityEntranceCountdown()
	{
	}

	private void UpdateActivityTips()
	{
	}

	private void UpdateLimitedCountLabel(FlashStoreGoodsDesc exchangeItemDesc)
	{
	}

	private void UpdateItemAvailableState(FlashStoreGoodsDesc desc)
	{
	}

	private void UpdatePurchaseBtnView(FlashStoreGoodsDesc desc)
	{
	}

	private IEnumerator GotoFlashStoreActivity(FlashStoreNavigationData navData)
	{
		return null;
	}

	private void LoadFlashStoreTabData()
	{
	}

	private bool IsShowFlashStoreGuide()
	{
		return false;
	}

	private void PopGuideDataFromQueueAndExecute()
	{
	}

	private void UpdateGuideDataAndEnqueue()
	{
	}

	private void UpdateGuideItemIndex(List<FlashStoreGoodsDesc> itemShowList)
	{
	}

	private UICommonGuideData CreateFreeAccessGuideData()
	{
		return default(UICommonGuideData);
	}

	private UICommonGuideData CreateItemListGuideData(UIWidget itemListWidget)
	{
		return default(UICommonGuideData);
	}

	public static FlashStoreNavigationData GetNavigationDataExposed(List<object> rawData)
	{
		return null;
	}

	public void NavigationToItem(uint itemID)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshStoreItemEasyList(List<FlashStoreGoodsDesc> dataList, int defaultSelectItemIndex = 0)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private bool _003CGetCurrentSelectItemIndex_003Eb__65_0(FlashStoreGoodsDesc t)
	{
		return false;
	}

	private bool _003CUpdateMallTab_003Eb__71_0(uint t)
	{
		return false;
	}

	private int _003CUpdateMallTab_003Eb__71_1(uint x, uint y)
	{
		return 0;
	}

	private void _003CInitPeriodAndTitleViewData_003Eb__75_0()
	{
	}

	private void _003CUpdateActivityEntranceCountdown_003Eb__77_0()
	{
	}

	private void _003CCreateFreeAccessGuideData_003Eb__88_0()
	{
	}

	private void _003CCreateFreeAccessGuideData_003Eb__88_1()
	{
	}

	private void _003CCreateItemListGuideData_003Eb__89_0()
	{
	}

	private void _003CCreateItemListGuideData_003Eb__89_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
