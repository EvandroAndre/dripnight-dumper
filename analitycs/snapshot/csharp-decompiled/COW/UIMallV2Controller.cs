using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2Controller : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__152_0;

		public static Predicate<AdvertDesc> _003C_003E9__212_0;

		public static Predicate<AdvertDesc> _003C_003E9__212_1;

		public static Predicate<AdvertDesc> _003C_003E9__212_2;

		internal int _003CGenerateWeaponFilterData_003Eb__152_0(uint a, uint b)
		{
			return 0;
		}

		internal bool _003CInitProcessCdnBg_003Eb__212_0(AdvertDesc x)
		{
			return false;
		}

		internal bool _003CInitProcessCdnBg_003Eb__212_1(AdvertDesc x)
		{
			return false;
		}

		internal bool _003CInitProcessCdnBg_003Eb__212_2(AdvertDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass216_0
	{
		public int index;

		public UIMallV2Controller _003C_003E4__this;

		internal void _003CInitFirstTabData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass216_1
	{
		public int index;

		public UIMallV2Controller _003C_003E4__this;

		internal void _003CInitFirstTabData_003Eb__1()
		{
		}
	}

	private sealed class _003CInitDelay_003Ed__215 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMallV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelay_003Ed__215(int _003C_003E1__state)
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

	private UIMallV2View m_View;

	private UIModelMall m_ModelMall;

	private UIModelGift m_ModelGift;

	private UIModelAvatar m_ModelAvatar;

	private UIModelTailor m_ModelTailor;

	private UIModelVeteran m_ModelVeteran;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelShoppingMall m_ModelShoppingMall;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UIModelHyperBook m_ModelHyperBook;

	private UIModelWishList m_ModelWishList;

	private bool m_DataInitialized;

	private bool m_GiftDataInitialized;

	private bool m_ExchangeDataInitialized;

	private bool m_DiscountDataInitialized;

	private bool m_StoreMultipleStuffReady;

	private bool m_ShoppingMallDataInitialized;

	private bool m_PrimeMallDetailInitialized;

	private bool m_InitMall;

	private bool m_InitDelayFinished;

	private UINavigationData m_PendingNavigationData;

	private bool m_IsInMall;

	private bool m_NeedReturnToNewBieStore;

	private UINavigationData m_LastNavigationData;

	private uint navMallType;

	private uint navFirstTabID;

	private uint navSecondTabID;

	private uint navMallItemId;

	private List<uint> navMallItemIdList;

	private uint navWeaponPageFilterType;

	private uint navWeaponFilterId;

	private uint m_CurrentMallType;

	private uint m_CurFirstTabID;

	private int m_CurFirstIndex;

	private uint m_CurSecondTabID;

	private int m_CurSecondTabIndex;

	private uint m_CurSelectStoreID;

	private uint m_CurSelectItemID;

	private uint m_SelectedPageID;

	private EMallV2ItemSelectType m_CurrentPrimeSelectType;

	private uint m_CurSelectPrimeCommdityId;

	private bool m_IsHyperBookAndNotBookItem;

	private EGiftStore_BuddyType m_FriendType;

	private EGiftSendSource m_GiftSource;

	private UINavigationUtil.UINavigationFrom m_From;

	protected const string BUYBTNICON = "UI_Store_Btn_Buy";

	protected const string EXCHANGEBTNICON = "UI_Store_Btn_Exchange";

	protected const string GIFTBTNICON = "Icon_Chat_SendGift";

	private const string CLOSE_BTN_NAME = "UI_Common_Window_Close_Icon";

	private const string RETURN_BTN_NME = "UI_Icon_Return";

	private const uint MALLCDNBGNEARSUBTYPE = 4u;

	private const uint MALLCDNBGMIDDLESUBTYPE = 5u;

	private const uint MALLCDNBGFARSUBTYPE = 6u;

	protected const uint CURRENCY_GREY = 2139062271u;

	protected const uint CLOTHPREVIEW_ICON_GREY = 1650615039u;

	protected Dictionary<int, BuyBtnInfo> m_BuyBtnInfoDict;

	private UIMallV2PopMenuSmallControler m_LeftFilterPopMenu;

	private UIMallV2PopMenuSmallControler m_RightFilterPopMenu;

	private UIMallV2PopMenuSmallControler m_FullFilterPopMenu;

	private List<StandardTabItemViewData> m_storeFirstTabViewData;

	private List<StandardTabItemViewData> m_giftFirstTabViewData;

	private Dictionary<uint, List<UIMallV2SecondTabItemViewData>> m_dicSecondTabViewData;

	private UIMallV2DetailController m_CurrentDetailCtrl;

	private UIMallV2ViewType m_LastViewType;

	private Dictionary<int, UIMallV2DetailController> m_DetailCtrlDict;

	private Dictionary<Type, Queue<UIEasyListItemController>> m_CachedUIMallItems;

	private UIStandardTabController m_FirstTabCtrl;

	private UIMallV2SecondTabController m_secondTabCtrl;

	private List<uint> m_SortedFirstTabIds;

	private List<uint> m_SortedSecondTabIds;

	private bool m_PurchaseSuccess;

	private bool m_RefreshListOnVisible;

	private Dictionary<string, EventLogger.EventTypeItemExposed> m_ItemExposedCache;

	private List<string> m_URLList;

	private Dictionary<uint, KeyValuePair<string, uint>> m_MallCdnDic;

	private uint m_LastAvatarId;

	private bool m_ChangeAvatar;

	private BuyBtnInfo m_BuyBtnInfo;

	private float m_EnterTime;

	private bool m_LoggedWaitNetTime;

	private bool m_IsBgChange;

	private bool m_IsPreviewClose;

	private bool m_IsSubBGOpen;

	private uint m_NewBieOfferRemindDelayCall;

	private string m_SubBgCdnCache;

	private bool m_IsPrimeShopOpen;

	private bool m_IsShowGiftWishListTab;

	private UIMallV2IntimacyProfileInfoController m_IntimacyProfileController;

	private FriendInfo m_SelectFriendInfo;

	private bool m_IsWishListDataReady;

	private bool m_IsOwnedDataReady;

	private bool m_IsPrimeOwnedDataReady;

	private bool m_IsShowMysteryMallDiscountLink;

	private bool m_IsShowLuckyWheelDiscountLink;

	private UIMallV2NormalContainerController m_NormalContainer;

	private UIMallV2BoxCDNContainerController m_BoxCDNContainer;

	private UIMallV2WeaponCDNContainerController m_WeaponCDNContainer;

	private UIMallV2DiscountContainerController m_DiscountContainer;

	private UIMallV2PrimeContainerController m_PrimeContainer;

	private UIMallV2PrimeGiftContainerController m_PrimeGiftContainer;

	private UIMallV2NewBieOfferContainerController m_NewBieOfferContainer;

	private UIMallV2VeteranDiscountStoreContainerController m_VeteranDiscountContainer;

	private UIMallV2ShoppingMallContainerController m_ShoppingMallContianer;

	private UIMallV2GiftWishListContainerController m_GiftWishListContainer;

	public static List<Type> InterestedModels;

	private Dictionary<int, List<PopMenuData>> m_FilterPopMenuDict;

	private Dictionary<uint, string> m_DictWeaponType2Text;

	private Dictionary<uint, string> UIMallV2SortType2Text;

	private Dictionary<uint, string> UIMallV2GenderType2Text;

	private Dictionary<uint, string> UIMallV2AvatarType2Text;

	private Dictionary<uint, string> UIMallV2WeaponTokenType2Text;

	private bool m_IsDescendOrder;

	protected Dictionary<int, PreviewTabInfo> m_ClothPreviewToggleDict;

	protected Dictionary<int, uint> m_ClothToTabIdDict;

	protected Dictionary<int, SlotClothInfo> m_SelectedClothDict;

	protected Dictionary<int, SlotClothInfo> m_ViceSelectedClothDict;

	private MallV2ClothPreviewData m_MaleClothPreviewData;

	private MallV2ClothPreviewData m_FemaleClothPreviewData;

	private bool m_IsFamel;

	protected UIGrid m_PreviewIconGrid;

	public UIMallV2PopMenuSmallControler LeftFilterPopMenu => null;

	public UIMallV2PopMenuSmallControler RightFilterPopMenu => null;

	public UIMallV2PopMenuSmallControler FullFilterPopMenu => null;

	public UIMallV2IntimacyProfileInfoController IntimacyProfileController => null;

	public FriendInfo SelectFriendInfo => null;

	public UIMallV2NormalContainerController NormalContainer => null;

	public UIMallV2BoxCDNContainerController BoxCDNContainer => null;

	public UIMallV2WeaponCDNContainerController WeaponCDNContainer => null;

	public UIMallV2DiscountContainerController DiscountContainer => null;

	public UIMallV2PrimeContainerController PrimeContainer => null;

	public UIMallV2PrimeGiftContainerController PrimeGiftContainer => null;

	public UIMallV2NewBieOfferContainerController NewBieOfferContainer => null;

	public UIMallV2VeteranDiscountStoreContainerController VeteranDiscountContainer => null;

	public UIMallV2ShoppingMallContainerController ShoppingMallContianer => null;

	public UIMallV2GiftWishListContainerController GiftWishListContainer => null;

	public Dictionary<int, uint> ClothToTabIdDict => null;

	private MallV2ClothPreviewData CurrentPreviewData => null;

	public bool IsLobbyAvatar => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public static void BeforeInit()
	{
	}

	private void InitFilterMenu()
	{
	}

	public void HideAllContainer()
	{
	}

	public string GetPopMenuNameByType(UIMallV2FilterMenuType type, uint filterType)
	{
		return null;
	}

	public List<PopMenuData> GetPopMenuDatasByType(UIMallV2FilterMenuType type)
	{
		return null;
	}

	private void OnSortFilterBtnClick()
	{
	}

	private void SwitchSortOrde(bool isDescendOrder)
	{
	}

	public void SetDescendBtnState(bool isDescendOrder)
	{
	}

	private List<PopMenuData> GenerateWeaponFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateMeleeWeaponFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateGrenadeeWeaponFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateGnederFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateWeaponTokenFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateAvatarFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateNormalSortFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateNoneQualitySortFilterData()
	{
		return null;
	}

	private List<PopMenuData> GenerateWeaponSortFilterData()
	{
		return null;
	}

	private int SortPopMenuSort(PopMenuData x, PopMenuData y)
	{
		return 0;
	}

	private uint GetPopMenuSortPriority(uint sortType)
	{
		return 0u;
	}

	private void RefreshLeftFilterPopMenu()
	{
	}

	private void RefreshRightFilterPopMenu()
	{
	}

	private void RefreshFullFilterPopMenu()
	{
	}

	private void ConductFilterByIsDescend()
	{
	}

	private void ConductFilterByFilterType(object data)
	{
	}

	private void ConductFilterByWeaponId(object data)
	{
	}

	private void ConductFilterBySortId(object data)
	{
	}

	protected void InitClothPreviewToggles()
	{
	}

	protected void OnClothPreviewToggleClick()
	{
	}

	private void OnUnDressBtnClick()
	{
	}

	private uint GetCurrentTabClotId()
	{
		return 0u;
	}

	public MallV2ClothPreviewData GetClothPreviewData(bool isFemale)
	{
		return null;
	}

	private void RefreshClothPreviewTab(object[] data)
	{
	}

	private void RefreshClothPreview(uint storeID, uint itemID, MallV2ClothPreviewData previewData)
	{
	}

	private PreviewTabInfo GetPreviewTab(string slotName)
	{
		return null;
	}

	public void OnHideClothesSlot(object[] data)
	{
	}

	protected void ReSetClothPreviewTabSprite(PreviewTabInfo tabInfo)
	{
	}

	protected void SetMallController()
	{
	}

	protected void SetSwitchClothPreviewBtnGroupVisible(bool visible)
	{
	}

	private void RefreshClothPreviewTabOnSwith()
	{
	}

	protected void SetClothPreviewTogglesInfo(Dictionary<int, SlotClothInfo> selectedClothDict, bool isSelectedSet)
	{
	}

	protected virtual void SetClothPreviewTabInfo(PreviewTabInfo tabInfo, CSSharedItemData itemData)
	{
	}

	protected void OnSwitchClothPreviewBtnClick()
	{
	}

	protected void SetSwithClothGenderBtnState(bool isSelfFemale)
	{
	}

	protected void RefreshClothPreviewToggleState(Dictionary<int, SlotClothInfo> selectedClothDict, bool isSelectedSet = false, UIToggleButton tb = null)
	{
	}

	protected void FadeClothPreviewTabSprite(PreviewTabInfo tabInfo)
	{
	}

	public void UpdateCloth(uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId)
	{
	}

	public List<uint> GetCurrentSelectedClothList(bool ingoreSet = false)
	{
		return null;
	}

	private void ResetPreviewTabInfo(PreviewTabInfo tabInfo)
	{
	}

	protected void UnSelectItem(uint itemID)
	{
	}

	protected void OnCommonWndFinish(object[] data)
	{
	}

	public void RefreshListOnStateChange()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public UIEasyListItemController GetMallItemController(Type itemType, Transform parent)
	{
		return null;
	}

	public void RecycleItemController(UIEasyListItemController itemController)
	{
	}

	private void InitProcessCdnBg()
	{
	}

	private void DownLoadCDNTexture()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private IEnumerator InitDelay()
	{
		return null;
	}

	private void InitFirstTabData()
	{
	}

	private void OnClickFirstTab(int index)
	{
	}

	private UIMallV2DetailController GetCurrentDetailController(UIMallV2ViewType type)
	{
		return null;
	}

	private void SwitchMallType(uint mallType, bool autoSelect = true, bool isForce = false)
	{
	}

	private void LogLobbyPerformanceWaitNetTime()
	{
	}

	public void ReloadAndRefreshFirstTab()
	{
	}

	private void OnlyRefreshFirstTab()
	{
	}

	private void SwitchFirstTabId(uint firstTabId, bool autoSelect = true, bool isForce = false)
	{
	}

	private void SwitchFirstTabIndex(int index, bool autoSelect = true, bool isForce = false)
	{
	}

	private void SwitchTopBarData(UIMallV2ViewType Type)
	{
	}

	private static void GotoVeteranPage()
	{
	}

	public void SetBtnGroupContainerState(bool state)
	{
	}

	private void OnlyRefreshSecondTab()
	{
	}

	public void SwitchSecondTabId(uint secondTabId, bool autoSelect = true, bool isForce = false)
	{
	}

	public void SwitchSecondTabIndex(int index, bool autoSelect = true, bool isForce = false)
	{
	}

	private int SecondTabId2Index(uint secondTabId)
	{
		return 0;
	}

	private int FirstTabId2Index(uint tabId)
	{
		return 0;
	}

	private uint FirstTabIndex2ID(int index)
	{
		return 0u;
	}

	private uint SecondIndex2Id(int secondIndex)
	{
		return 0u;
	}

	public void CheckIsEmptyView(bool isEmpty)
	{
	}

	private bool SetNavigationData(UINavigationData navigationData, bool force = false)
	{
		return false;
	}

	private void ResetNavogation()
	{
	}

	private void GenerateNavigation()
	{
	}

	public void NavigationToItem(uint mallType = 0u, uint firstTabID = 0u, uint secondTabID = 0u, uint storeID = 0u)
	{
	}

	private void ApplyNavigationDataToCurrentMall()
	{
	}

	private void SyncMallTypeToggle(uint mallType)
	{
	}

	public void NavigationToSecondTab(object[] data)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void SendMallEventLog()
	{
	}

	private void OnItemExposed(object[] data)
	{
	}

	public void AddExposedItemLog(string firstTab, uint item_id)
	{
	}

	public void AddExposedItemClickLog(uint item_id)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnExchangeCurrencyBtnClick(object[] data)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void RefreshPreview()
	{
	}

	protected void InitBuyBtnStyle()
	{
	}

	public void SetBuyBtnStyle(BuyBtnStyle buyBtnStyle, bool enable, bool reachLimit = false)
	{
	}

	private void SetVoucherVisual()
	{
	}

	private void OnBuyClick()
	{
	}

	private void OnGoToDiscountBtnClick()
	{
	}

	private void OnBuyDiscountBtnClick()
	{
	}

	private void OnPrimeBuyClick()
	{
	}

	private void OnPrimeGiftSend()
	{
	}

	private void OnVeteranBuyClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnSendGiftBtnClick()
	{
	}

	private void SendGift(bool isPrime = false)
	{
	}

	private void OnExchangeBuyBtnClick()
	{
	}

	private void ExchangeItem()
	{
	}

	private void ShowExchangePurchasePopupWnd(ExchangeStoreItemDesc itemDesc)
	{
	}

	private void OnFreeBtnClick()
	{
	}

	public void BuyStoreItem(uint storeID)
	{
	}

	private void OnAvatarUpdate(object[] data)
	{
	}

	private void ShowMallItemTypeError(object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void InitMallView()
	{
	}

	private bool IsDataReady()
	{
		return false;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void SetCloseButtonSprite(string spriteName)
	{
	}

	private void OnNormalMallToggleClick()
	{
	}

	private void OnGiftMallToggleClick()
	{
	}

	public void SetTopBarActive(bool show)
	{
	}

	public void TopbarUpdateTokenByIndex(int index, ResourceID id, int num, bool timeLimit = false, uint itemID = 0u)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnHairUpdate(object[] data)
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

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	public FrontEndPreviewComponent GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override void SetBgByCameraType(object[] param)
	{
	}

	private void ClickHyperBookItem(object[] data)
	{
	}

	private void OnHyperBookGoBtnClick()
	{
	}

	public void RefreshBtnBookState()
	{
	}

	public void InitBtnBookState()
	{
	}

	public void RefreshBtnGoExchangeState()
	{
	}

	public void RefreshEvopassBtn()
	{
	}

	private void OnBtnGotoEvopassClick()
	{
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	protected override bool NeedRecoverSubBgActivOnNavigationShowed()
	{
		return false;
	}

	public void OnBtnGoExchangeClick()
	{
	}

	public void RefreshBtnSendGift()
	{
	}

	public void OnBtnSelectPlayerClick()
	{
	}

	private void RefreshBtnDiscountLink()
	{
	}

	public void HideDiscountLink()
	{
	}

	public void OnDiscountLinkBtnClick()
	{
	}

	private void TryLogBtnNewBieOfferPageClick()
	{
	}

	private void CheckIsNewbieOfferStoreOpen()
	{
	}

	private void CheckPrimeShowState()
	{
	}

	private void OnWishListReady(ulong accountID)
	{
	}

	private void OnOwnedGiftListReady(bool isPrime, ulong accountID)
	{
	}

	private void CheckIsWishListDataAndOwnedDataReady()
	{
	}

	private void OnWishListDataAndOwnedDataReady()
	{
	}

	public void RefreshGiftWishListTab(bool isShow)
	{
	}

	private void InitPlayerInfoView()
	{
	}

	public void OnSelectPlayerChange(object[] data)
	{
	}

	public void SetSelectedPlayerInfo(FriendInfo friendInfo, bool force = false)
	{
	}

	public void RefreshPlayerInfoView()
	{
	}

	public void RefreshPlayerIntimacyValue()
	{
	}

	private void RefreshHelpButtonView()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnGiftRuleBtnClick()
	{
	}

	private void _003COnUIInit_003Eb__135_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetBgByCameraType(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverSubBgActivOnNavigationShowed()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
