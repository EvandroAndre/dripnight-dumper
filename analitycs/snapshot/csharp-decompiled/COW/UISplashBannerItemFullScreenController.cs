using System;
using GCommon;

namespace COW;

internal class UISplashBannerItemFullScreenController : UISplashBannerItemPreviewBaseController
{
	private UISplashBannerFullScreenView m_View;

	public Action<bool> m_UICloseCallBack;

	public ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override SplashType GetSplashType()
	{
		return SplashType.CDN;
	}

	public override string DontShowSplashBannnerCDNKey()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnDontShowBtnClick()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override void SetSplashData(SplashBannerInfo info)
	{
	}

	protected override void SuccessCallBack()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override UILabel GetDontShowLabel()
	{
		return null;
	}

	public SplashType _003C_003EiFixBaseProxy_GetSplashType()
	{
		return SplashType.CDN;
	}

	public string _003C_003EiFixBaseProxy_DontShowSplashBannnerCDNKey()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetSplashData(SplashBannerInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SuccessCallBack()
	{
	}

	public UIWidget _003C_003EiFixBaseProxy_GetFrontEndPreviewBorder()
	{
		return null;
	}

	public UILabel _003C_003EiFixBaseProxy_GetDontShowLabel()
	{
		return null;
	}
}
