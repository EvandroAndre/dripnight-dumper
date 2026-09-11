using System;
using GCommon;

namespace COW;

public class UIGachaIchisNormalNoBigPrizeWndController : UIPopupWindowController
{
	private UIGachaIchisNormalNoBigPrizeWndView m_View;

	private Action m_OnClose;

	private bool m_HasInvokedOnClose;

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

	public void SetCloseAction(Action onClose)
	{
	}

	private void OnClickMask()
	{
	}

	private void InvokeOnCloseOnce()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
