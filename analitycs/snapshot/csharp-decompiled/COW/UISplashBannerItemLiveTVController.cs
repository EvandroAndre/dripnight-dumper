using System;
using GCommon;

namespace COW;

internal class UISplashBannerItemLiveTVController : UIWebViewWindowBaseController
{
	private UISplashBannerItemLiveTVView m_View;

	private SplashBannerInfo m_SplashBannerInfo;

	public Action<bool> m_UICloseCallBack;

	private bool m_WillGotoNavigation;

	public ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(SplashBannerInfo info)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnScaleTweenFinish()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnGotoNavigation()
	{
	}

	private void OnPlayFullScreen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
