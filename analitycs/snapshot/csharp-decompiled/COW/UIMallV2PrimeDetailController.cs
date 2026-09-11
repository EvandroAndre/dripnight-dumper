using System.Collections.Generic;
using proto;

namespace COW;

public class UIMallV2PrimeDetailController : UIMallV2PrimeBaseDetailController
{
	private List<PrimeStoreItemDesc> m_PrimeStoreItems;

	private UIMallV2PrimeContainerController m_PrimeContainerController;

	public UIMallV2PrimeDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Clear()
	{
	}

	public override List<uint> GetSecondTabList(uint firstTabID)
	{
		return null;
	}

	protected override void SetFilterMenuType(uint secondTabId)
	{
	}

	protected override void SetSortrMenuType(uint secondTabId)
	{
	}

	protected override void SetMallItemType(uint secondTabId)
	{
	}

	public override void InitDetailListView()
	{
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID)
	{
		return null;
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	protected override void InitFilterAndSortView()
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void SelectItemIndex(int index)
	{
	}

	public override void SetSecondtIndex(uint secondTabId)
	{
	}

	protected override void CheckIsEmptyView()
	{
	}

	protected override void FilterShowItemList()
	{
	}

	public int SortPrimeStoreItem(PrimeStoreItemDesc x, PrimeStoreItemDesc y)
	{
		return 0;
	}

	protected override void SortShowItemList()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}

	public List<uint> _003C_003EiFixBaseProxy_GetSecondTabList(uint P0)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_SetFilterMenuType(uint P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetSortrMenuType(uint P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetMallItemType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitDetailListView()
	{
	}

	public List<UIMallV2SecondTabItemViewData> _003C_003EiFixBaseProxy_InitSecondTabData(uint P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnlyRefreshList(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectItemId(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SelectItemIndex(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSecondtIndex(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CheckIsEmptyView()
	{
	}

	public void _003C_003EiFixBaseProxy_FilterShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_SortShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}
}
