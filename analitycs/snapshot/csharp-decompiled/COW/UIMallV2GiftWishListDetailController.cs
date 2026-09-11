using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2GiftWishListDetailController : UIMallV2DetailController
{
	private List<GiftItem> m_ShowItems;

	private UIEasyList m_CurrentItemEasyList;

	public void SetShowItems(List<GiftItem> wishListGiftItems)
	{
	}

	private void RefreshListView()
	{
	}

	private int StoreItemOwnedSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	public UIMallV2GiftWishListDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	public override void InitDetailListView()
	{
	}

	protected override UIEasyList GetCurEasyList()
	{
		return null;
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	protected override void CheckIsEmptyView()
	{
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override void SelectItemIndex(int index)
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	protected override void SortShowItemList()
	{
	}

	public override List<uint> GetSecondTabList(uint firstTabID)
	{
		return null;
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID)
	{
		return null;
	}

	public override void SetSecondtIndex(uint secondTabId)
	{
	}

	protected override void InitFilterAndSortView()
	{
	}

	protected override void SetFilterMenuType(uint secondTabId)
	{
	}

	protected override void SetSortrMenuType(uint secondTabId)
	{
	}

	public override List<PopMenuData> GetFilterPopMenuData()
	{
		return null;
	}

	public override List<PopMenuData> GetSortPopMenuData()
	{
		return null;
	}

	protected override void FilterShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public UIEasyList _003C_003EiFixBaseProxy_GetCurEasyList()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetFilterMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortrMenuType(uint P0)
	{
	}
}
