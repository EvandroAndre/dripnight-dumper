using GCommon;

namespace COW;

internal class UILauncherWebViewLiteController : UIBaseController
{
	private UIWebViewWindowLiteView m_View;

	private WebView m_WebView;

	private long _BeginOpenTicks;

	private bool _Loading;

	private bool _Loaded;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnCloseButtonClick()
	{
	}

	private void Update()
	{
	}

	public void SetURL(string url)
	{
	}

	private void UpdateProgressBar()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
