using System.Collections.Generic;
using proto;

namespace COW;

public class UIMallV2PrimeGiftDetailController : UIMallV2PrimeBaseDetailController
{
	private List<PrimeStoreItemDesc> m_PrimeGiftStoreItemDesc;

	protected UIMallV2PrimeGiftContainerController m_PrimeGiftContainerController;

	public UIMallV2PrimeGiftDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	protected override void SortShowItemList()
	{
	}

	public int SortPrimeStoreItem(PrimeStoreItemDesc x, PrimeStoreItemDesc y)
	{
		return 0;
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override List<uint> GetSecondTabList(uint firstTabID)
	{
		return null;
	}

	public override void InitDetailListView()
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID)
	{
		return null;
	}

	protected override void CheckIsEmptyView()
	{
	}

	public override void SelectItemIndex(int index)
	{
	}

	public new void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_SortShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnlyRefreshList(bool P0)
	{
	}

	public List<uint> _003C_003EiFixBaseProxy_GetSecondTabList(uint P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitDetailListView()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectItemId(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public List<UIMallV2SecondTabItemViewData> _003C_003EiFixBaseProxy_InitSecondTabData(uint P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_CheckIsEmptyView()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectItemIndex(int P0)
	{
	}
}
