using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2ShoppingMallDetailController : UIMallV2DetailController
{
	protected UIMallV2ShoppingMallContainerController m_containerCtrl;

	private UIModelShoppingMall m_ModelShoppingMall;

	private List<ShoppingMallScreenDesc> m_ShowItems;

	private ShoppingMallScreenDesc m_TopShowItem;

	public UIMallV2ShoppingMallDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
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

	public override void InitDetailListView()
	{
	}

	protected override void CheckIsEmptyView()
	{
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void SelectMallItem(uint selectIndexID, uint selectedItemId)
	{
	}

	public override void SelectItemIndex(int index)
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

	protected override void SortShowItemList()
	{
	}

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	public override List<PopMenuData> GetSortPopMenuData()
	{
		return null;
	}

	public override List<PopMenuData> GetFilterPopMenuData()
	{
		return null;
	}

	protected override void FilterShowItemList()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}
}
