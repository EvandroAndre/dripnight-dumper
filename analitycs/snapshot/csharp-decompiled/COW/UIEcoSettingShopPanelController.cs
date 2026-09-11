using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIEcoSettingShopPanelController : UIBaseController
{
	private UIEcoSettingShopPanelView m_View;

	private List<UIEcoSettingShopItemController> m_CachedShopItemCtrls;

	private Action m_RefreshCB;

	private int m_OriHeight;

	private int m_CellWidth;

	private LHFNKEDKCBK m_ShopEditor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(CShopData data, Action refreshCB, float width)
	{
	}

	private void RefreshShop(object[] data)
	{
	}

	public UIEcoSettingShopItemController GetShopItemByID(string shopID)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
