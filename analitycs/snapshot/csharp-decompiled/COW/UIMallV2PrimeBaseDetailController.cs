using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2PrimeBaseDetailController : UIMallV2DetailController
{
	public UIModelPrime m_ModelPrime;

	public UIMallV2PrimeBaseDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Init()
	{
	}

	public override void Clear()
	{
	}

	public override List<PopMenuData> GetFilterPopMenuData()
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

	public override List<PopMenuData> GetSortPopMenuData()
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

	protected override void SortShowItemList()
	{
	}

	public override void InitDetailListView()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_SetFilterMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortrMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetMallItemType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitFilterAndSortView()
	{
	}
}
