using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopRulesPopUpDropRateV2ItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaRulesPopUpDropRateV2ItemView m_View;

	private UIStandardItemMiniController m_MiniItem;

	private BaseItemInfo m_ItemInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIGachaRulesPopUpRateItemData itemData, bool isDoubleWheelGrandPrize = false)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
