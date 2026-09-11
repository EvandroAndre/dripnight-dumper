using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2ExchangeDetailController : UIMallV2DetailController
{
	private List<ExchangeStoreItemDesc> m_OriginExchangeItems;

	private List<ExchangeStoreItemDesc> m_ShowItems;

	protected UIEasyList m_CurrentItemEasyList;

	public UIMallV2ExchangeDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
		: base(null, null)
	{
	}

	public override void Init()
	{
	}

	public override List<uint> GetSecondTabList(uint m_CurFirstTabID)
	{
		return null;
	}

	public override List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabId)
	{
		return null;
	}

	public override void SetSecondtIndex(uint secondTabId)
	{
	}

	private void GenerateValidSortType()
	{
	}

	public override void InitDetailListView()
	{
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	public override void RefreshMallViewAndSelectItem()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	private void RefreshExchangeNum(uint currentId)
	{
	}

	public override void ShowTopUpTips(Vector3 pos)
	{
	}

	protected override void FilterShowItemList()
	{
	}

	protected override void CheckIsEmptyView()
	{
	}

	protected override void SortShowItemList()
	{
	}

	private int StoreItemDefaultSort(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	private int StoreItemIdSort(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	private int StoreItemQualitySort(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	public override List<PopMenuData> GetFilterPopMenuData()
	{
		return null;
	}

	public override List<PopMenuData> GetSortPopMenuData()
	{
		return null;
	}

	protected override void SetMallItemType(uint secondTabId)
	{
	}

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	public override void SelectItemIndex(int index)
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMallViewAndSelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowTopUpTips(Vector3 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetMallItemType(uint P0)
	{
	}
}
