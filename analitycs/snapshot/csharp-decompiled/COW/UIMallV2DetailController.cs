using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIMallV2DetailController
{
	protected UIMallV2Controller m_ParentController;

	protected UIMallV2View m_View;

	protected UIModelMall m_ModelMall;

	protected UIMallV2ItemType m_ItemType;

	protected UIMallV2FilterMenuType m_FilterMenuType;

	protected UIMallV2FilterMenuType m_SortMenuType;

	protected uint m_FilterType;

	protected uint m_SortType;

	protected uint m_FilterWeaponId;

	protected bool m_IsDescendOrder;

	protected HashSet<uint> m_ValidFilterType;

	protected HashSet<uint> m_ValidWeaponId;

	protected bool m_HasGemsSort;

	protected bool m_HasCoinsSort;

	protected bool m_HasWeaponProp;

	protected uint m_CurrentTabId;

	protected uint m_CurrentStoreId;

	protected uint m_CurrentItemId;

	public UIMallV2DetailController(UIMallV2Controller v2Controller, UIMallV2View mallV2View)
	{
	}

	public virtual void Init()
	{
	}

	public abstract List<uint> GetSecondTabList(uint firstTabID);

	protected void OnClickSecondTab(int index)
	{
	}

	public abstract List<UIMallV2SecondTabItemViewData> InitSecondTabData(uint firstTabID);

	public void UnSelectItem(uint itemID)
	{
	}

	public abstract void SetSecondtIndex(uint secondTabId);

	protected virtual void SetDetailViewModel(uint secondTabId)
	{
	}

	protected virtual void SetMallItemType(uint secondTabId)
	{
	}

	protected virtual void SetFilterMenuType(uint secondTabId)
	{
	}

	protected virtual void SetSortrMenuType(uint secondTabId)
	{
	}

	protected void DeleteValidSortType(List<PopMenuData> popMenuList)
	{
	}

	protected virtual void InitFilterAndSortView()
	{
	}

	protected void ResetFilterCondition()
	{
	}

	public void ResetFilterAndReloadList()
	{
	}

	public abstract void InitDetailListView();

	protected void HideAllContainer()
	{
	}

	protected virtual UIEasyList GetCurEasyList()
	{
		return null;
	}

	public abstract void Clear();

	public virtual void SelectMallItem(uint selectStoreID, uint selectedItemId)
	{
	}

	public void SetLabelLimitedCountText(uint limited_purchase_times, uint purchase_times)
	{
	}

	public abstract UIEasyListItemController GetMallItemController(Transform parent);

	public abstract List<PopMenuData> GetFilterPopMenuData();

	public abstract List<PopMenuData> GetSortPopMenuData();

	protected int WeanponPropIndex(uint rare)
	{
		return 0;
	}

	public virtual void ReloadListByWeaponIdFilter(uint filterWeaponId)
	{
	}

	internal virtual void ReloadListByFilterType(uint filterType)
	{
	}

	internal virtual void ReloadListBySortType(uint sortType)
	{
	}

	internal virtual void ReloadListByIsDescend(bool isDescend)
	{
	}

	protected abstract void FilterShowItemList();

	protected abstract void SortShowItemList();

	public virtual void ReloadListViewByFilterAndSort()
	{
	}

	protected abstract void CheckIsEmptyView();

	public virtual void ReloadListViewBySort()
	{
	}

	public abstract void OnlyRefreshList(bool resetScroll = false);

	public abstract void SelectItemIndex(int index);

	public abstract void SelectItemId(uint itemId);

	public virtual void RefreshMallItemView()
	{
	}

	public virtual void RefreshMallViewAndSelectItem()
	{
	}

	public virtual void NavigationToClothItem(int wardrobeType)
	{
	}

	public virtual MallV2ClothPreviewData GetClothPreviewData(bool isFemale)
	{
		return null;
	}

	public void CheckClothGenderFilter(bool isFemale)
	{
	}

	public virtual void ShowTopUpTips(Vector3 pos)
	{
	}
}
