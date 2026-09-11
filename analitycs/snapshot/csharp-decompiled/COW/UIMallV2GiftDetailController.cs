using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2GiftDetailController : UIMallV2DetailController
{
	private UIModelGift m_ModelGift;

	private List<GiftItem> m_OriginGiftItems;

	private List<GiftItem> m_ShowItems;

	protected UIEasyList m_CurrentItemEasyList;

	protected Dictionary<int, uint> m_ClothToTabIdDict;

	private MallV2ClothPreviewData m_MaleClothPreviewData;

	private MallV2ClothPreviewData m_FemaleClothPreviewData;

	public UIMallV2GiftDetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
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

	public override void RefreshMallViewAndSelectItem()
	{
	}

	public override void SelectMallItem(uint selectStoreID, uint selectedItemId)
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

	public override void Clear()
	{
	}

	public override List<PopMenuData> GetSortPopMenuData()
	{
		return null;
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

	public override void NavigationToClothItem(int wardrobeType)
	{
	}

	public override MallV2ClothPreviewData GetClothPreviewData(bool isFemale)
	{
		return null;
	}

	private int StoreItemSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	private int StoreItemDefaultSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	private int StoreItemIdSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	private int StoreItemDiamondSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	private int StoreItemGoldSort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	private int StoreItemQualitySort(GiftItem x, GiftItem y)
	{
		return 0;
	}

	protected override void FilterShowItemList()
	{
	}

	private void FilterShowListByAvatar()
	{
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

	private void GenerateValidSortType()
	{
	}

	protected void GenerateValidFilterList()
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

	public void _003C_003EiFixBaseProxy_RefreshMallViewAndSelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_SelectMallItem(uint P0, uint P1)
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

	public void _003C_003EiFixBaseProxy_NavigationToClothItem(int P0)
	{
	}

	public MallV2ClothPreviewData _003C_003EiFixBaseProxy_GetClothPreviewData(bool P0)
	{
		return null;
	}
}
