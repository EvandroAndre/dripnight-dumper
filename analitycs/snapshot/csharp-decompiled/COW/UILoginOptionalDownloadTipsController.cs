using GCommon;

namespace COW;

public class UILoginOptionalDownloadTipsController : UIBaseController
{
	private UILoginOptionalDownloadTipsView m_View;

	private bool m_ShowDownload;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public static bool ShowVNLink()
	{
		return false;
	}

	public static bool ShowDataHint()
	{
		return false;
	}

	public static bool NeedShow()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void OnVNLinkClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
