using System;
using GCommon;

namespace COW;

public class UILauncherMaxController : UIPopupSpecialWindowController
{
	private UILauncherMaxView m_View;

	private string m_MaxStore;

	private string m_MaxWebsite;

	private string m_MaxVideo;

	protected Action m_OnClose;

	private const string BG_CDN_URL = "https://freefiremobile-a.akamaihd.net/common/OB23/version/Patch_Max_Bg_<FF_LANGUAGE>.png";

	protected override void OnUIInit()
	{
	}

	private void OnGotoVideoBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public void SetOnClose(Action onclose)
	{
	}

	public void SetInfo(string max_store, string max_web, string max_video)
	{
	}

	private void OnGotoWebsiteBtnClick()
	{
	}

	private void OnNormalUpdateBtnClick()
	{
	}

	private void OnMaxDownloadBtnClick()
	{
	}

	private UILauncherWebViewLiteController CreateVideoWebView()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
