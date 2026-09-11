using GCommon;

namespace COW;

public class UILiveTvMainController : UINavigationController
{
	private UILiveTvView m_View;

	private WebView m_WebViewTournament;

	private WebView m_WebViewLiveTV;

	private WebView m_WebViewBooyahTv;

	private WebView.Rect m_WebViewRect;

	private UIModelLiveTv m_ModelLiveTv;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnTournamentClick()
	{
	}

	private void OnBooyahTVBtnClick()
	{
	}

	private void OnLiveBtnClick()
	{
	}

	private WebView.Rect WebViewRect()
	{
		return null;
	}

	private void RefreshWebView()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private WebView CurrentWebView()
	{
		return null;
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
