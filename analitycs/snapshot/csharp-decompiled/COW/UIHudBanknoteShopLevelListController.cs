using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudBanknoteShopLevelListController : UIBaseController
{
	private UIHudBanknoteShopLevelListView m_View;

	private UIOneLevelEquipList m_equipView;

	private List<UIHudBanknoteShopItemController> m_ItemList;

	private int m_SelectedIndex;

	public int SelectedIndex => 0;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void InitItems(List<uint> items, int level, bool isMaxLevel, int OneLevelSetCount)
	{
	}

	public void InitOneItem(int itemid, int index)
	{
	}

	public void OnItemSelected(int selectedIndex)
	{
	}

	public void RefreshItemsSelectedState()
	{
	}

	public void UpdateUnlockInfo(bool isUnlocked, int unlockItemIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
