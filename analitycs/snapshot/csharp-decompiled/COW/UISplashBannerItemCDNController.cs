using System;
using GCommon;

namespace COW;

internal class UISplashBannerItemCDNController : UISplashBannerItemPreviewBaseController
{
	private UISplashBannerItemCDNView m_View;

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

	protected override void OnUIInit()
	{
	}

	protected override void SuccessCallBack()
	{
	}

	public override string DontShowSplashBannnerCDNKey()
	{
		return null;
	}

	public override void SetSplashData(SplashBannerInfo info)
	{
	}

	private void OnDontShowBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SuccessCallBack()
	{
	}

	public string _003C_003EiFixBaseProxy_DontShowSplashBannnerCDNKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetSplashData(SplashBannerInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
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
