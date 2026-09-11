using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2DiscountDetailController : UIMallV2DetailController
{
	protected UIMallV2DiscountContainerController m_containerCtrl;

	private List<DiscountStoreDesc> m_ShowItems;

	private List<DiscountStoreDesc> m_FreeItems;

	public UIMallV2DiscountDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
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

	public int SortDiscountItem(DiscountStoreDesc x, DiscountStoreDesc y)
	{
		return 0;
	}

	protected override void CheckIsEmptyView()
	{
	}

	protected override void SortShowItemList()
	{
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override void SetSecondtIndex(uint secondTabId)
	{
	}

	protected override void InitFilterAndSortView()
	{
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID)
	{
		return null;
	}

	public override void ReloadListViewByFilterAndSort()
	{
	}

	public override void RefreshMallViewAndSelectItem()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	protected override UIEasyList GetCurEasyList()
	{
		return null;
	}

	public override void SelectItemIndex(int index)
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	protected override void SetFilterMenuType(uint secondTabId)
	{
	}

	protected override void SetMallItemType(uint secondTabId)
	{
	}

	protected override void SetSortrMenuType(uint secondTabId)
	{
	}

	internal override void ReloadListBySortType(uint sortType)
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

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	public override List<uint> GetSecondTabList(uint firstTabID)
	{
		return null;
	}

	internal override void ReloadListByFilterType(uint filterType)
	{
	}

	internal override void ReloadListByIsDescend(bool isDescend)
	{
	}

	protected override void FilterShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}

	public void _003C_003EiFixBaseProxy_ReloadListViewByFilterAndSort()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMallViewAndSelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public UIEasyList _003C_003EiFixBaseProxy_GetCurEasyList()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetFilterMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetMallItemType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortrMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ReloadListBySortType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ReloadListByFilterType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ReloadListByIsDescend(bool P0)
	{
	}
}
