using System;
using GCommon;

namespace COW;

public class UICommonErrorWndController : UIPopupWindowController
{
	private UICommonErrorWndView m_View;

	private Action m_callback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetInfo(string message, string title, Action callback)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
