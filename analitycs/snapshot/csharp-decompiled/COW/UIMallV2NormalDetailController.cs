using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2NormalDetailController : UIMallV2DetailController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIMallV2NormalDetailController _003C_003E4__this;

		public ulong curTime;

		internal bool _003CRemovePreItemNotOwnedStoreItem_003Eb__0(StoreDesc item)
		{
			return false;
		}
	}

	private List<StoreDesc> m_OriginStoreItems;

	private List<StoreDesc> m_ShowItems;

	protected UIEasyList m_CurrentItemEasyList;

	public UIMallV2NormalDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
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

	private void InitOriginStoreItems()
	{
	}

	private void RemovePreItemNotOwnedStoreItem()
	{
	}

	protected override void SetMallItemType(uint secondTabId)
	{
	}

	protected override void SetFilterMenuType(uint secondTabId)
	{
	}

	protected override void SetSortrMenuType(uint secondTabId)
	{
	}

	public override void InitDetailListView()
	{
	}

	public override void OnlyRefreshList(bool resetScroll = false)
	{
	}

	protected override void CheckIsEmptyView()
	{
	}

	protected override void SortShowItemList()
	{
	}

	public override UIEasyListItemController GetMallItemController(Transform parent)
	{
		return null;
	}

	public override void Clear()
	{
	}

	public override void SelectItemIndex(int index)
	{
	}

	public override void SelectItemId(uint itemId)
	{
	}

	public override void RefreshMallViewAndSelectItem()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public override List<PopMenuData> GetSortPopMenuData()
	{
		return null;
	}

	private int StoreItemDefaultSort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private int StoreItemIdSort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private int StoreItemDiamondSort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private int StoreItemGoldSort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private int StoreItemQualitySort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private int StoreItemWeaponAttributeSort(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	private void FilterShowListByWeaponToken()
	{
	}

	private void FilterShowListByWeapon()
	{
	}

	private void FilterShowListByGender()
	{
	}

	private void FilterShowListByAvatar()
	{
	}

	protected override void FilterShowItemList()
	{
	}

	private void GenerateValidSortType()
	{
	}

	private void GenerateValidFilterList()
	{
	}

	private void GenerateValidAvatarFilter()
	{
	}

	private void GenerateValidWeaponTokenFilter()
	{
	}

	private void GenerateValidWeaponFilter()
	{
	}

	private void GenerateValidGnederFilter()
	{
	}

	public override List<PopMenuData> GetFilterPopMenuData()
	{
		return null;
	}

	private void SetFilterTypePopMenu(List<PopMenuData> popMenuList)
	{
	}

	private void SetWeaponIdPopMenu(List<PopMenuData> popMenuList)
	{
	}

	private void SetWeaponFilterPopMenu(List<PopMenuData> popMenuList)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_SetMallItemType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetFilterMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortrMenuType(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshMallViewAndSelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
	{
	}
}
