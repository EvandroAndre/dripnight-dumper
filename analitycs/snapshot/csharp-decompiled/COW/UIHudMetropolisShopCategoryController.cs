using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudMetropolisShopCategoryController : UIHudCSEquipCategoryController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIHudCSEquipItemController CreateItem(Transform container)
	{
		return null;
	}

	public override void SetUIData(uint filter, List<CSShopItemData> itemList)
	{
	}

	public override void RefreshUIData(uint filter, List<CSShopItemData> itemList, bool isPurchaseRefresh = false)
	{
	}

	public UIHudCSEquipItemController _003C_003EiFixBaseProxy_CreateItem(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetUIData(uint P0, List<CSShopItemData> P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(uint P0, List<CSShopItemData> P1, bool P2)
	{
	}
}
