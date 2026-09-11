using System;
using GCommon;

namespace COW;

public class UILaunchTagShowPopupWndController : UIPopupWindowController
{
	private UILaunchTagFrameView m_View;

	private uint m_AutoCloseDelayCall;

	private Action m_AfterClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetShowContentByTagID(uint tagID, uint serialNumber, Action afterClose = null, bool isCommonLaunchTag = false)
	{
	}

	private void AutoClose()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
