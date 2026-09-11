using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2VeteranDiscountDetailController : UIMallV2DetailController
{
	protected UIMallV2VeteranDiscountStoreContainerController m_containerCtrl;

	private List<VeteranStoreDesc> m_ShowItems;

	public UIMallV2VeteranDiscountDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	public override List<uint> GetSecondTabList(uint firstTabID)
	{
		return null;
	}

	protected override void FilterShowItemList()
	{
	}

	public override void SelectItemIndex(int index)
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

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void SetSecondtIndex(uint secondTabId)
	{
	}

	public override void InitDetailListView()
	{
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID)
	{
		return null;
	}

	protected override void CheckIsEmptyView()
	{
	}

	protected override void SortShowItemList()
	{
	}

	public int SortVeteranDiscountItem(VeteranStoreDesc x, VeteranStoreDesc y)
	{
		return 0;
	}

	protected override void InitFilterAndSortView()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public override void RefreshMallViewAndSelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMallViewAndSelectItem()
	{
	}
}
