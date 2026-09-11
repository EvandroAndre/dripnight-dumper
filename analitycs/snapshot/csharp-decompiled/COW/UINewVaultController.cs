using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewVaultController : UIPreviewNavigationController, IUIModelDataChangeObserver, INewVaultMultiSelectComponent
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<UIEasyListItemController, UINewVaultEmoteItemController> _003C_003E9__136_0;

		public static Action _003C_003E9__262_0;

		public static Action _003C_003E9__262_1;

		public static Action _003C_003E9__262_2;

		public static Action _003C_003E9__302_1;

		internal UINewVaultEmoteItemController _003CSelectEmoteItemInCurrentEasyList_003Eb__136_0(UIEasyListItemController item)
		{
			return null;
		}

		internal void _003CUpdateDataToServer_003Eb__262_0()
		{
		}

		internal void _003CUpdateDataToServer_003Eb__262_1()
		{
		}

		internal void _003CUpdateDataToServer_003Eb__262_2()
		{
		}

		internal void _003COnOpenAllBtnClick_003Eb__302_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public uint emoteID;

		internal bool _003CSelectEmoteItemInCurrentEasyList_003Eb__1(UINewVaultEmoteItemController item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public int index;

		public UINewVaultController _003C_003E4__this;

		internal void _003CInitFirstTabData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass321_0
	{
		public uint id;

		internal bool _003CLogItemsLoveChange_003Eb__0(EventLogger.EventTypeItemsLoveChange.ItemChangeInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass347_0
	{
		public uint firstSkinID;

		internal bool _003CSortItemViewDatasWithMultiSelectRandomToSingle_003Eb__0(UINewVaultItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003CCoHideFollowEmoteSelectTips_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewVaultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoHideFollowEmoteSelectTips_003Ed__153(int _003C_003E1__state)
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

	private sealed class _003CInitDelay_003Ed__180 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewVaultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelay_003Ed__180(int _003C_003E1__state)
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

	private sealed class _003CMovePanelShowClothesSet_003Ed__212 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewVaultController _003C_003E4__this;

		public int posY;

		private int _003CminDelta_003E5__2;

		private int _003CmoveSpeed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMovePanelShowClothesSet_003Ed__212(int _003C_003E1__state)
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

	private sealed class _003CMovePanelShowColor_003Ed__286 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewVaultController _003C_003E4__this;

		public int posY;

		private int _003CminDelta_003E5__2;

		private int _003CmoveSpeed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMovePanelShowColor_003Ed__286(int _003C_003E1__state)
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

	private UINewVaultView m_View;

	private UIModelNewVault m_modelNewVault;

	private UIModelCollection m_modelCollection;

	private UIModelRandomCollection m_modelRandomCollection;

	private UIModelInventory m_modelInventory;

	private UIModelLadderMatch m_modelLadder;

	private UIModelOptionalDownload m_modelOptionalDownload;

	private UIModelTailor m_ModelTailor;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelMall m_ModelMall;

	private UIModelHyperBook m_ModelHyperBook;

	private UIStandardTabController m_TabCtrl;

	private UINewVaultSecondTabController m_secondTabCtrl;

	private UIFrontEndPreviewController m_PreviewUIController;

	private List<int> m_listSortedFirstTabID;

	private uint[] m_curSortedItemIDs;

	private List<UINewVaultItemViewData> m_curSortedItemViewDatas;

	private int m_CurSortedTabEquipedItemIndex;

	private int m_CurSortedTabEquipedItem;

	private bool m_NeedScroll;

	private List<StandardTabItemViewData> m_listFirstTabViewData;

	private Dictionary<int, List<UINewVaultSecondTabItemViewData>> m_dicSecondTabViewData;

	private UINewVaultEmoteSlotController[] m_emoteSlotControllerArray;

	private UINewVaultEmoteSlotController m_curSelectEmoteSlot;

	private UINewVaultNormalContainerController m_normalContainer;

	private UINewVaultBannerContainerController m_bannerContainer;

	private UINewVaultEmoteContainerController m_emoteContainer;

	private UINewVaultHeadPicContainerController m_headPicContainer;

	private UINewVaultMusicContainerController m_musicContainer;

	private UINewVaultHeadPreviewController m_headPreviewCtrl;

	private UINewVaultClothSetRecommendController m_ClothSetRecommendCtrl;

	private UIColorPaletteController m_TailorColorPalette;

	private UIPopMenuSmallControler m_QualityFilterCtrl;

	private const string DressUpEffectKey = "DressUpFirstShowEffect";

	private uint m_TailorId;

	private bool m_bIsClickCloth;

	private bool m_DefaultMusicCheckState;

	private AvatarWardrobeData m_ClothesDataForHideBackpack;

	private List<EventLogger.EventTypeItemsLoveChange.ItemChangeInfo> m_listItemsLoveChange;

	private Coroutine m_CorShowEmote;

	private Coroutine m_CorShowFinishAnim;

	private Coroutine m_InitDelay;

	private bool m_InitOwnOptionalData;

	private int m_nTempEquipItemID;

	private int m_nCurFirstTabID;

	private int m_nCurFirstIndex;

	private int m_nCurSecondTabID;

	private int m_nCurSecondTabIndex;

	private int m_nCurSelectItemID;

	private int m_nCurSelectItemIndex;

	private uint m_nCurSelectClothesSetID;

	private bool m_IsUsingOwnClothesSetBg;

	private string m_CurrentOwnClothesSetBgUrl;

	private Dictionary<uint, uint> m_dicClothesSetSelection;

	private int m_nLastFirstTabID;

	private int m_nLastFirstIndex;

	private int m_nLastSecondTabID;

	private int m_nLastSecondTabIndex;

	private int m_nLastSelectItemID;

	private int m_nLastSelectItemIndex;

	private int m_nSelectEmoteSlotBagIndex;

	private bool m_isSelectingEmoteSlotFromRefresh;

	private bool m_bIsNewVaultModelInit;

	private bool m_bISNewVaultModel_LovedItemsInit;

	private bool m_bIsInventoryModelInit;

	private bool m_bIsShowNavigationInit;

	private bool m_bIsNewVaultModel_ClothesSetLovedItemsInit;

	private InitState m_InitState;

	private bool m_IsColorPanelShow;

	private bool m_IsClothesSetPanelShow;

	private Coroutine m_CoroutineMovePanelShowColor;

	private Coroutine m_CoroutineMovePanelShowClothesSet;

	private Coroutine m_CoroutineFollowEmoteSelectTips;

	private uint m_PendingAutoDefaultFollowEmoteID;

	private bool m_bIsNeedHandleJump;

	private int m_nJumpFirstTabId;

	private int m_nJumpSecondTabId;

	private int m_nJumpItemId;

	private int m_nLastNavigationCloseFirstTabID;

	private int m_nLastNavigationCloseSecondTabID;

	private int m_nLastNavigationCloseItemID;

	private uint m_GuideDelayCall;

	private const string DEFAULT_NEW_VAULT_GOTO_KEY = "T_32_LC_NEWVAULT_GOTO";

	private const string LOC_KEY_FOLLOWEMOTE_DEFAULT_TIPS = "T_54_SY_FOLLOWEMOTE_DEFAULT";

	private const string FINALSHOT_TAB_ENTERED = "FINALSHOT_TAB_ENTERED";

	private GameObject m_BGMPreview;

	private UISprite m_BMGRecordIcon;

	private List<UINewVaultClothItemController> m_CachedUINewVaultClothItems;

	private List<UINewVaultCommonItemController> m_CachedUINewVaultCommonItems;

	private List<UINewVaultClothesSetItemController> m_CachedNewVaultClothesSetItems;

	private UINewVaultConfigController m_Config;

	private bool m_NeedRefreshAvatar;

	private bool m_ExternalIconFriendSwitchShow;

	private uint m_LastAvatarId;

	private UINewVaultEmotePanelController m_NewVaultEmotePanelCtrl;

	private UINewVaultEmoteSlotItemController m_CurSelectEmoteSlotItemCtrl;

	private bool m_IsDraggingNewVaultEmote;

	private FrontendPreviewType m_CurPreviewUIType;

	private bool m_IsOpenMultiSelect;

	private bool m_IsMultiSelectSwitchOpen;

	private UIModelInventory m_ModelInventory;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private InventoryClothSeriesInfo m_curPreviewClothSeriesInfo;

	private int m_QualityFilterWidthLong;

	private int m_QualityFilterWidthShort;

	private int m_FilterTitleLeftAnchor;

	private Vector3 m_CollectionContainerWithFilterPos;

	private Vector3 m_QualityFilterCtrlPosForMusic;

	private float m_NewVaultItemContainerScrollViewSizeYWithFilter;

	private float m_NewVaultItemContainerScrollViewSizeYWithoutFilter;

	private EQualityFilterType m_currentQualityFilterType;

	private bool m_bIsWaitingHttp;

	private readonly uint[] m_DefaultSortIDs;

	private List<PopMenuData> m_QualityFilterPopDatas;

	private Dictionary<int, string> m_QualityFilterKeyDict;

	private Dictionary<int, uint> m_QualityFilterColorDict;

	private Dictionary<int, int> m_SecondTabCurrentSelectedQualityFilterDict;

	private HashSet<int> m_SecondTabCurrentQualityTypeSet;

	private UIModelAvatar m_modelAvatar;

	private uint m_unRefreshAvatarPos;

	private UINewVaultNormalContainerController NormalContainer => null;

	private UINewVaultBannerContainerController BannerContainer => null;

	private UINewVaultEmoteContainerController EmoteContainer => null;

	private UINewVaultHeadPicContainerController HeadPicContainer => null;

	private UINewVaultMusicContainerController MusicContainer => null;

	public int CurSecondTabID => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	private Transform GetSlotParentNodeByIndex(int index)
	{
		return null;
	}

	private void OnSwitchSecondTabModifyEasyContainer()
	{
	}

	private UIEasyList GetCurEasyList()
	{
		return null;
	}

	private void LoadEmoteSlots()
	{
	}

	private void RefreshEmoteBooyahCheck()
	{
	}

	private void RefreshEmoteBooyahCheckNew()
	{
	}

	private void OnClickEmoteSlot(int index, bool isSelectItem)
	{
	}

	public UINewVaultEmoteSlotItemController GetEmoteSlotItemViewByIndex(int index)
	{
		return null;
	}

	private void OnClickEmoteSlotNew(int index, bool isSelectItem)
	{
	}

	private void SelectEmoteSlotNew(int index, bool isSelectItem, bool needVibrate)
	{
	}

	private bool TrySelectEmoteItemFromSlot(uint emoteID)
	{
		return false;
	}

	private void SelectEmoteItemInCurrentEasyList(uint emoteID, int dataIndex)
	{
	}

	private int GetSelectableItemIndexForEmoteSlotItem(uint emoteID)
	{
		return 0;
	}

	private bool EnsureQualityFilterContainsItem(uint itemID)
	{
		return false;
	}

	private bool TryQuickEquipSelectedEmoteToCurrentSlot(bool isSelectItem, uint slotEmoteID, bool isReplaceClick)
	{
		return false;
	}

	private void RefreshEmoteEquipBtnAndUnEquipBtnState()
	{
	}

	private bool CurrentSelectItemCanSetDefaultFollowEmote()
	{
		return false;
	}

	private bool CanSetDefaultFollowEmote(EmoteData emoteData)
	{
		return false;
	}

	private bool IsFollowMoveEmote(uint emoteID)
	{
		return false;
	}

	private int GetEquippedFollowMoveEmoteCount()
	{
		return 0;
	}

	private bool HasValidDefaultFollowEmote()
	{
		return false;
	}

	private void PrepareAutoDefaultFollowEmote(uint emoteID)
	{
	}

	private bool IsPendingAutoDefaultFollowEmoteUpdate(object[] data, uint emoteID)
	{
		return false;
	}

	private void TryApplyPendingAutoDefaultFollowEmote(object[] data)
	{
	}

	private void RefreshSetDefaultFollowEmoteButtonIcons()
	{
	}

	private void OnSetDefaultFollowEmoteBtnClick()
	{
	}

	private void InitFollowEmoteSelectTips()
	{
	}

	private void ShowFollowEmoteSelectTipsBriefly()
	{
	}

	private IEnumerator CoHideFollowEmoteSelectTips()
	{
		return null;
	}

	private void TrySelectEquippedEmoteSlotNew()
	{
	}

	private void RefreshEmoteSlotOperationStateNew()
	{
	}

	private int GetFirstAvailableUnlockedEmptyEmoteSlotIndex()
	{
		return 0;
	}

	private void RefreshEmoteSlots()
	{
	}

	private void RefreshEmoteLabel()
	{
	}

	private void OnSlotStartDrag()
	{
	}

	private void OnSlotStartDragNew(Vector3 cloneObjectPos, ResourceID spriteResID)
	{
	}

	private void OnSlotEndDrag()
	{
	}

	private void OnSlotEndDragNew()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OnClothesUpdate(object[] data)
	{
	}

	private void OnAvatarPlayChangeClothAnim()
	{
	}

	private void OnAvatarFinishChangeClothAnim()
	{
	}

	private void BGMPreviewSetActive(bool active)
	{
	}

	private void OnBtnZoomInClick(object[] data)
	{
	}

	private void OnEmoteUpdate(object[] data)
	{
	}

	private void OnCallsignBtnToggled()
	{
	}

	private void OnHelpButtonClicked()
	{
	}

	private void OnExternalIconHelpButtonClicked()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnEmoteCheckClick()
	{
	}

	private void OnSuperEmoteCheckClick()
	{
	}

	private void OnClickBtnGoToDressUp()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void Init()
	{
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	private IEnumerator InitDelay()
	{
		return null;
	}

	private void GenerateFullJumpParam(bool IsDirectUse)
	{
	}

	private void NavigationByLastClostTab()
	{
	}

	private void NavigationByDataParm(UINavigationData navigationData)
	{
	}

	private void Update()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private bool IsHttpWaiting()
	{
		return false;
	}

	public override void OnNavigationClosed()
	{
	}

	private void InitFirstTabData()
	{
	}

	private List<UINewVaultSecondTabItemViewData> InitSecondTabData(int firstTabId)
	{
		return null;
	}

	private void SyncRefreshSecondViewDataByClothesBundle(int firstTabId)
	{
	}

	private void OnCloseTips(UIModelNewVault.eSecondTab obj)
	{
	}

	private void OnRefreshSecondIcon(UIModelNewVault.eSecondTab tab, UINewVaultSecondTabItemController ctrl)
	{
	}

	private void RefreshFinalShotTabNewTips()
	{
	}

	private void OnClickSecondTab(int index)
	{
	}

	private int ItemId2Index(int itemId)
	{
		return 0;
	}

	private int GetItemViewDataIndexByItemID(int itemId)
	{
		return 0;
	}

	private void OnClickItem(int index)
	{
	}

	private void RefreshSetRecommendBtnClickSameItem()
	{
	}

	private void ClearTempEquipID()
	{
	}

	private void RefreshLocalEquipState()
	{
	}

	private UINewVaultSecondTabItemViewData GetCurSecondTabViewData()
	{
		return null;
	}

	private void RecordTempEquipID(int selectItemID)
	{
	}

	private void OnItemEnter()
	{
	}

	private void OnItemExit()
	{
	}

	private bool CheckIsEquipedCurrentSelectClothesSet()
	{
		return false;
	}

	private void RefreshClothesSetEquipState()
	{
	}

	private void RefreshSetChangeContainer()
	{
	}

	private void OnBtnSetChangePanelClick()
	{
	}

	private void ScrollClothesSetPanel(bool show)
	{
	}

	private void SetPanelClothesSetShow(int posY)
	{
	}

	private IEnumerator MovePanelShowClothesSet(int posY)
	{
		return null;
	}

	private void OnClothesSetChangeClick(uint setID)
	{
	}

	private void RefreshOwnClothesSetBg(uint setID, uint likeItemID = 0u)
	{
	}

	private uint GetOwnClothesSetBgBundleID(uint setID, uint likeItemID = 0u)
	{
		return 0u;
	}

	private string GetOwnClothesSetBgUrl(uint bundleID)
	{
		return null;
	}

	private uint GetOwnClothesSetPreviewSetID(uint likeItemID)
	{
		return 0u;
	}

	private void RestoreOwnClothesSetBg()
	{
	}

	private void ClearUnequipedClothesSetSelection()
	{
	}

	private void RefreshCurrentSecondTabCount()
	{
	}

	private int GetSecondTabCount(uint secondTabId, uint firstTabId)
	{
		return 0;
	}

	private void OnlyShowItemToPreview(int index = 0, bool isNavigation = false)
	{
	}

	private void OnChooseItemInPage(int index = 0)
	{
	}

	private void OnEquipVehicle(int itemID)
	{
	}

	private void RequestChooseItem(UIModelNewVault.eSecondTab secondTab, int itemID, Action callback)
	{
	}

	private void RequestChooseItem(UIModelNewVault.eSecondTab secondTab, int itemID, UIModelNewVault.eFirstTab firstTab)
	{
	}

	private void OnlyRefreshTabRedPoint(object[] data)
	{
	}

	private void SyncRefreshOthersTabRedPointByClothesBundle(int othersID)
	{
	}

	private void OnClickItemByID(int itemID)
	{
	}

	private UISprite BMGRecordIcon()
	{
		return null;
	}

	private void RefreshBGMPreview(uint itemId)
	{
	}

	private void UpdateNewGet(int itemId)
	{
	}

	private void RefreshClothSecondTab()
	{
	}

	private bool RefreshGotoBtn()
	{
		return false;
	}

	private void RefreshClothItemEquipState()
	{
	}

	private void RefreshClothSetBtnState()
	{
	}

	private UIModelNewVault.eSecondTab GetCurSecondTab()
	{
		return UIModelNewVault.eSecondTab.None;
	}

	private int Index2ItemID(int index)
	{
		return 0;
	}

	private void SwitchSecondTab(int index, bool isForce = false)
	{
	}

	private void OnQualityFilterClick()
	{
	}

	private void OnQualityTypeSelected(object obj)
	{
	}

	public void CloseAllPreviewUI(bool isclear = false)
	{
	}

	private AvatarWardrobeData CurrentClothWardrobe(InventoryClothSeriesInfo clothSeriesInfo)
	{
		return null;
	}

	private void RefreshCurSortedItemData(bool select_more = false)
	{
	}

	private uint GetCurClothSeriesItemID(uint ClothItemID)
	{
		return 0u;
	}

	private void SetQualityFilter(bool isOpenQualityFilter, EQualityFilterType currentQualityFilterType)
	{
	}

	public EQualityFilterType GetItemQualityFilterType(byte quality)
	{
		return EQualityFilterType.All;
	}

	public void OnlyShowPreviewItem(bool needRefreshAvatar = true, uint showItemID = 0u)
	{
	}

	private void UpdateLocalAvatarCloth(List<uint> checkOptionalIds)
	{
	}

	private void ClickDefaultClothStyle(uint showItemID = 0u)
	{
	}

	public void OnOneKeySetClothBtnClick(object[] data)
	{
	}

	private void AdjustUIOnSecondTabEnter()
	{
	}

	private void OnSecondTabEnter()
	{
	}

	private void OnSecondTabExit()
	{
	}

	private void ClearUIOnSecondTabExit()
	{
	}

	private void UpdateDataToServer(UIModelNewVault.eSecondTab secondTab, int itemId, UIModelNewVault.eFirstTab firstTab)
	{
	}

	private void RequestChooseBagShow(bool isBagShowInGame, int itemID)
	{
	}

	private void CloseTipBySecondTabExit()
	{
	}

	private int SecondTabIndex2SecondTab(int secondIndex)
	{
		return 0;
	}

	private int SecondTabId2Index(int secondTabId)
	{
		return 0;
	}

	private int FirstTabIndex2FirstTabID(int index)
	{
		return 0;
	}

	private int FirstTabID2Index(int tabId)
	{
		return 0;
	}

	private void SwitchFirstTab(int index)
	{
	}

	private void OnFirstTabEnter()
	{
	}

	private void ClearAllRightNode()
	{
	}

	private void OnFirstTabExit()
	{
	}

	private void OnClickFirstTab(int index)
	{
	}

	private void OnlyRefreshFirstTab()
	{
	}

	private void OnlyRefreshSecondTab()
	{
	}

	private UIEasyList OnlyRefreshItemRenderer(bool reset_scroll = true)
	{
		return null;
	}

	private void RefreshPlatformHeadPic()
	{
	}

	private int GetDefualtHeadPicIndex()
	{
		return 0;
	}

	private void OnIfSeriesItemChosen(object[] data)
	{
	}

	private void OnSeriesItemChangeIndex(object[] data)
	{
	}

	private void OnBtnColorPanelClick()
	{
	}

	private void ScrollColorPanel(bool show)
	{
	}

	private void SetPanelColorShow(int posY)
	{
	}

	private IEnumerator MovePanelShowColor(int posY)
	{
		return null;
	}

	private void RefreshColorPanel(uint legendId)
	{
	}

	private void OnClothSetRecommendClick()
	{
	}

	private void RefreshSwitchBackpack(uint id)
	{
	}

	private void OnClothSetRecommendClose()
	{
	}

	private void OnGotoAvatarProfileBtn()
	{
	}

	private void OnOpenBtnClick()
	{
	}

	private void OnFinalShotGotoBtnClick()
	{
	}

	private void RefreshFinalShotGotoBtn()
	{
	}

	private bool CheckUseRank(uint id)
	{
		return false;
	}

	private void OnGotoBtnClick()
	{
	}

	private bool DefaultGotoHandler(uint itemId)
	{
		return false;
	}

	private int GetGachaIDByItemID(uint itemId)
	{
		return 0;
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnUnEquipBtnClick()
	{
	}

	private void OnSelectMoreBtnClick()
	{
	}

	private void OnOpenAllBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshAvatar()
	{
	}

	private void RefreshAllPage(int firstTabID, int secondTabID, int? selectItemID = null)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void RecycleItemController(UIEasyListItemController itemController)
	{
	}

	private UINewVaultClothItemController GetUINewVaultClothItemController(Transform parent)
	{
		return null;
	}

	private UINewVaultCommonItemController GetUINewVaultCommonItemController(Transform parent)
	{
		return null;
	}

	private UINewVaultClothesSetItemController GetUINewVaultClothesSetItemController(Transform parent)
	{
		return null;
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public FrontEndPreviewComponent_NewVault GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	private void OnTailorBtnClick()
	{
	}

	private IUINewVaultLovableItem GetCurLovableItemController(bool needScroll)
	{
		return null;
	}

	private void OnLoveBtnClick()
	{
	}

	private void RefreshLoveBtn(bool playVFX = false, bool forceHide = false)
	{
	}

	private void LogItemsLoveChange()
	{
	}

	private void LogClothesSetLoveChange()
	{
	}

	private void AddItemsLoveChangeLog(uint itemID, EventLogger.EventTypeItemsLoveChange.LoveChangeType change)
	{
	}

	private void OnNewVaultConfigClick()
	{
	}

	private void OnHyperBookClick()
	{
	}

	private void OnConfigClose()
	{
	}

	public void ShowExternalIconConfig(bool isShow)
	{
	}

	public void ShowLoveNode(bool isShow)
	{
	}

	private void ChangeAvatarRefresh()
	{
	}

	public void ChangePreviewType()
	{
	}

	private void RefreshCarolineSet()
	{
	}

	private FrontendPreviewType GetPreviewType()
	{
		return FrontendPreviewType.Lobby;
	}

	public GameObject GetDragDropCloneObject()
	{
		return null;
	}

	public void SetDragDropIcon(ResourceID resourceID)
	{
	}

	public void SetDragMove(Vector3 pos)
	{
	}

	public void SetDragDropConActive(bool show)
	{
	}

	public void SetDragPanelDepth()
	{
	}

	public void SetEmoteTrashContainerActive(bool show)
	{
	}

	private uint GetOwnedItemCntInThridTab()
	{
		return 0u;
	}

	private uint GetAllItemCntInSecondTab()
	{
		return 0u;
	}

	private void OnSkipAnimMaskBtnClick()
	{
	}

	private void OnClothesSetEquipBtnClick()
	{
	}

	private void RefreshMultiSelectSate(uint collectionSubType, uint uniqueID)
	{
	}

	public void RefreshRandomColletionMultiSelectLabel()
	{
	}

	private void OnClickRandomCheckBoxBtn()
	{
	}

	private uint GetMultiSelectEquipFirstItemID(int secondTab, int firstTab)
	{
		return 0u;
	}

	private void SortItemViewDatasWithMultiSelectRandomToSingle(uint firstSkinID)
	{
	}

	private bool IsMultiSelectOpenInCache(UIModelNewVault.eSecondTab secondTab)
	{
		return false;
	}

	private bool NeedRequestMultiSelectInRandomSkin(UIModelNewVault.eSecondTab secondTab)
	{
		return false;
	}

	private bool NeedRequestMultiSelectInRandomSlot(UIModelNewVault.eSecondTab secondTab)
	{
		return false;
	}

	private void SyncMultiSelectRandomCacheData()
	{
	}

	private void SetMultiSelectIsOpen()
	{
	}

	private void ShowRandomMultiSelectGuide()
	{
	}

	private void OnClickMultiTipsBtn()
	{
	}

	public bool IsMultiSelectOpen()
	{
		return false;
	}

	public void RefreshMultiSelectLabel()
	{
	}

	private void _003CRefreshSetChangeContainer_003Eb__208_0()
	{
	}

	private void _003CRefreshColorPanel_003Eb__287_0()
	{
	}

	private void _003COnOpenAllBtnClick_003Eb__302_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
