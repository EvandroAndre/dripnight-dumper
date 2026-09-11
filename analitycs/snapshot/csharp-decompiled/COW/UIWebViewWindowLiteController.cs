using GCommon;

namespace COW;

internal class UIWebViewWindowLiteController : UIWebViewWindowBaseController
{
	private UIWebViewWindowLiteView m_View;

	private uint m_UpdateDelayCallId;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetData(string url)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCloseButtonClick()
	{
	}

	private void _003COnUIInit_003Eb__6_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
