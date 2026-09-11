using System;
using GCommon;

namespace COW;

public class UIGachaIchisDrawFailedWndController : UIPopupWindowController
{
	private UIGachaIchisDrawFailedWndView m_View;

	private Action m_OnConfirm;

	private bool m_HasInvokedConfirm;

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

	public void SetConfirmCallback(Action onConfirm)
	{
	}

	private void OnConfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
