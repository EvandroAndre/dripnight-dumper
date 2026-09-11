using System;
using GCommon;

namespace COW;

public class UIRelayMartMainPageSplashBannerPopupWindowController : UIPopupWindowController
{
	private UIRelayMartMainPageSplashBannerPopupWindowView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private Action m_CloseAction;

	private uint m_BgLoopDelayCall;

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

	private void RefreshBGCDN()
	{
	}

	private void PlayAnimation()
	{
	}

	public void SetCloseAction(Action closeAction)
	{
	}

	private void _003CPlayAnimation_003Eb__9_0()
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
}
