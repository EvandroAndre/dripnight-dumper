using System;
using GCommon;

namespace COW;

public class UINewReleaseVersionPopupController : UIPopupWindowController
{
	private UINewReleaseVersionPopupView m_View;

	public Action OnClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnConfirm()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
