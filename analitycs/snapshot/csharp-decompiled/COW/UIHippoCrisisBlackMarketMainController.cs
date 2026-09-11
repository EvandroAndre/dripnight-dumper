using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisBlackMarketMainController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	private UIHippoCrisisBlackMarketMainView m_View;

	private List<HippoCrisisInventoryTabData> m_TabDataList;

	private List<HippoCrisisInventorySubTabData> m_SubTabDataList;

	private HippoCrisisInventoryTab m_CurrentTab;

	private HippoCrisisInventorySubTab m_CurrentSubTab;

	private UIPopMenuSmallControler m_MarketPopMenuCtrl;

	private UIHippoCrisisCommonTopCurrencyController m_CurrencyCtrl;

	private UIHippoCrisisItemBriefBoxController m_ItemBriefBoxCtrl;

	private HippoCrisisMarketPopMenuSort m_CurrentPopMenuSort;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private List<HippoCrisisStoreItemData> m_CurrentShowItems;

	private bool m_IsDecending;

	private uint m_CurSelectStoreId;

	private uint m_CurSelectItemId;

	private HippoCrisisStoreItemData m_CurStoreItemData;

	private Dictionary<uint, string> m_PopMenuToKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnVaultBtnClick()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnSortFilterBtnClick()
	{
	}

	private void OnSelectStoreItem(object[] data)
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	private void ShowItemBriefBox(bool show)
	{
	}

	private void InitCurrencyView()
	{
	}

	private void InitCdnView()
	{
	}

	private void InitRightTab()
	{
	}

	private void OnTabClick(HippoCrisisInventoryTab tab)
	{
	}

	private void SetSubTabView(HippoCrisisInventoryTab tab)
	{
	}

	private void ShowSubTab(HippoCrisisInventoryTab parentTab)
	{
	}

	private void OnSubTabClick(HippoCrisisInventorySubTab tab)
	{
	}

	private void ShowMarketItemsFilterByCurrentTab()
	{
	}

	private void ShowMarketItemsFilterByCurrentSubTab()
	{
	}

	private void UpdateMarketItems(bool byPurchase = false)
	{
	}

	private void SortByPopMenu()
	{
	}

	private void InitSortPopMenu()
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnPopMenuSelect(object data)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public int MarketItemDefaultSort(HippoCrisisStoreItemData a, HippoCrisisStoreItemData b)
	{
		return 0;
	}

	public int MarketItemSortByLevel(HippoCrisisStoreItemData a, HippoCrisisStoreItemData b)
	{
		return 0;
	}

	public int MarketItemSortByPrice(HippoCrisisStoreItemData a, HippoCrisisStoreItemData b)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
