using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisPreStartController : UINavigationController, IEasyList, IUIHippoCrisisDragResponseController, IUIModelDataChangeObserver
{
	public enum HippoCrisisPreStartTemplate
	{
		Source,
		InventoryItem,
		BlackMarketItem,
		BlackMarketFilterItem
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public HippoCrisisOutGameItemUIData removeData;

		internal bool _003COnDragToOtherAreaSuccess_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public HippoCrisisOutGameItemUIData item;

		internal bool _003COnSplitItemInInventory_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}

		internal bool _003COnSplitItemInInventory_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private UIHippoCrisisPreStartView m_View;

	private UIHippoCrisisItemBriefBoxController m_ItemBriefBoxController;

	private List<HippoCrisisInventoryTabData> m_TabDataList;

	private List<HippoCrisisInventorySubTabData> m_SubTabDataList;

	private HippoCrisisInventoryTab m_CurrentTab;

	private HippoCrisisInventorySubTab m_CurrentSubTab;

	private UIPopMenuSmallControler m_InventoryPopMenuCtrl;

	private HippoCrisisPopMenuSort m_CurrentPopMenuSort;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private List<HippoCrisisOutGameItemUIData> m_CurrentInventoryShowItems;

	private List<HippoCrisisStoreItemData> m_CurrentStoreShowItems;

	private bool m_CurrentStoreHasItems;

	private UIHippoCrisisDragResponseContainer m_DragResponseContainer;

	private ulong m_CurrentSelectID;

	private bool m_CurrentSelectIsInventoryItem;

	private UIHippoCrisisInventoryItemBigController m_SelectedItem;

	private bool m_EnableEscape;

	private HippoCrisisDragSourceInfo m_CurDragSourceInfo;

	private IHippoCrisisBackPackItemUIData m_CurrentDragingItem;

	private EDragReleaseResponseAreaType m_CurrentDragingItemFromArea;

	private Transform m_EquipmentBriefBoxTransform;

	private UIHippoCrisisCommonTopCurrencyController m_CurrencyCtrl;

	public static Color NORMAL_COLOR;

	public static Color HILIGHT_COLOR;

	public static Color HILIGHT_COLOR_RED;

	public static Color PROGRESS_COLOR_RED;

	public static Color PROGRESS_COLOR_YELOW;

	private bool m_NeedEnterRecommendPreset;

	private UIHudHippoCrisisEquipmentContainerController m_EquipmentCtrl;

	private uint m_CurrentDragItemWeight;

	private uint m_CurrentDragItemValue;

	private uint m_CurrentQualityFilter;

	private Vector2 SourceItemSize;

	private Vector2 ItemSize;

	private Vector4 SourceItemMargin;

	private Vector4 ItemMargin;

	private Vector4 FilterItemSize;

	private Vector4 FilterItemMargin;

	public ulong CurrentSelectID => 0uL;

	public bool CurrentSelectIsInventoryItem => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void StartGuide()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void InitRightTabAndInventoryItems()
	{
	}

	private void OnTabClick(HippoCrisisInventoryTab tab)
	{
	}

	private void SetSubTabView(HippoCrisisInventoryTab tab, bool needShowSubTab = true)
	{
	}

	private void ShowSubTab(HippoCrisisInventoryTab parentTab)
	{
	}

	private void OnSubTabClick(HippoCrisisInventorySubTab tab)
	{
	}

	private void InitTable2Template()
	{
	}

	private void InitMarginData()
	{
	}

	private void UpdateInventoryShow()
	{
	}

	private void ShowInventoryItemsFilterByCurrentSubTab()
	{
	}

	private void ShowInventoryItemsFilterByCurrentTab()
	{
	}

	private void UpdateInventoryItems(bool resetPos = true)
	{
	}

	public int MarketItemDefaultSort(HippoCrisisStoreItemData a, HippoCrisisStoreItemData b)
	{
		return 0;
	}

	private bool CheckIsConsumable(PIJKGPDBNJC type)
	{
		return false;
	}

	public void RefreshItemSelectState(bool isInventoryItem, ulong instIdOrStoreId, uint itemId)
	{
	}

	public void RefreshAllItemUnSelectState()
	{
	}

	private void BtnReponse(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo info)
	{
	}

	private void CheckAndCloseBriefBox(HippoCrisisDragOperationResult dragOperationResult)
	{
	}

	private void HideBriefBox()
	{
	}

	public void EquipAfterPurchase()
	{
	}

	public void PutInBagAfterPurchase()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnPutInBagBtnClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	private void OnClosePurchaseSuccessWnd()
	{
	}

	private void OnClosePurchaseSuccessWndFastEquip()
	{
	}

	private void TrySelectInventoryItem(object[] param)
	{
	}

	private void OnClickEquipment(object[] param)
	{
	}

	private void OnClickCostItem(bool isEmpty)
	{
	}

	private void OnClickAttach(object[] param)
	{
	}

	private void OnNaviToSpecifiedTab(HippoCrisisInventoryTab naviTab, HippoCrisisInventorySubTab naviSubTab)
	{
	}

	private void OnBlackMarketFilterSelect(uint currentFilterSelect)
	{
	}

	private void InitTopRightBar()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void ShowItemBriefBox(object[] param)
	{
	}

	private void InitDragContainerInfo()
	{
	}

	public HippoCrisisDragOperationResult HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	private void UpdateCurrentShowItems(HippoCrisisOutGameItemUIData data, bool isAdd)
	{
	}

	private void OnDragStart(object[] param)
	{
	}

	private void ShowInventoryWhenStartDrag()
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDragOver(object[] param)
	{
	}

	private void OnDragOut(object[] param)
	{
	}

	private void OnDragToOtherAreaSuccess(object[] param)
	{
	}

	private void OnDragToInventorySuccess(object[] param)
	{
	}

	private void OnSplitItemInInventory(object[] param)
	{
	}

	private void OnConfirmPreStartClick()
	{
	}

	private void OnRecommendLoadoutBtnClick()
	{
	}

	private void RefreshFreeBuyTips()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__50_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__50_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__50_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__50_3()
	{
		return null;
	}

	private void _003COnPurchaseSuccess_003Eb__74_0()
	{
	}

	private void _003COnPurchaseSuccess_003Eb__74_1()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
