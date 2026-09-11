using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIWeaponUpgradeTokenExchangeController : UIPopupWindowController
{
	private UIWeaponUpgradeTokenExchangeView m_View;

	private Action m_ConfirmAction;

	private Action m_CloseAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(List<BaseItemInfo> beforeItems, List<BaseItemInfo> afterItems)
	{
	}

	private void OnConversionBtnClick()
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetCloseCallback(Action action)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
