using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudInGameShopItemDescController : UIBaseController
{
	private UIHudInGameShopItemDescView m_View;

	private List<UIHudInventoryTagController> m_TagCtrl;

	private UIHudWeaponPropertyListHelper m_PropertyListHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnItemSelect(object[] datas)
	{
	}

	private void ClearWeaponDetail(bool needClearItem)
	{
	}

	private void RefreshWeaponPropertyLayout()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
