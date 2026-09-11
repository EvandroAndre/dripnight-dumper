using System;
using GCommon;
using proto;

namespace COW;

internal class UIWebViewWindowController : UIWebViewWindowBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<WebExternalBrowserLimit, string> _003C_003E9__27_0;

		public static Action<int, string> _003C_003E9__33_0;

		internal string _003CSetData_003Eb__27_0(WebExternalBrowserLimit t)
		{
			return null;
		}

		internal void _003COnExternalButtonClick_003Eb__33_0(int id, string url)
		{
		}
	}

	private UIWebViewWindowView m_View;

	private uint m_UpdateDelayCallId;

	private float _LastProgress;

	private float _NextProgress;

	private long _LastProgressTicks;

	private long _LastLoadTicks;

	private long _BeginLoadTicks;

	private long _TotalLoadingTime;

	private long _BeginOpenTicks;

	private long _TotalOpenTime;

	private bool _Loading;

	private bool _Loaded;

	private uint _ReloadBtnClickedCnt;

	private uint _CloseBtnClickedCnt;

	private uint _ExternalBtnClickedCnt;

	private string _url;

	private float ProgressAnimationDuration => 0f;

	private float PromptReloadDuration => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void _UpdateProgress(float progress)
	{
	}

	private float _SmoothProgress()
	{
		return 0f;
	}

	private void ToggleReturnButton(bool enabled)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void HandleURL(string url)
	{
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

	private void ResetEventTypeKellyRunWebPageLogInfo()
	{
	}

	private void OnReloadButtonClick()
	{
	}

	private void OnExternalButtonClick()
	{
	}

	private void OnReturnButtonClick()
	{
	}

	private void SendEventTypeKellyRunWebPageLog()
	{
	}

	protected override void OnWebViewErrorFallbackStatusChanging(WebView.FallbackStatus before, WebView.FallbackStatus after)
	{
	}

	private void _003COnUIInit_003Eb__24_0()
	{
	}

	private void _003COnUIInit_003Eb__24_1(int id, bool canGoBackward)
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

	public void _003C_003EiFixBaseProxy_OnWebViewErrorFallbackStatusChanging(WebView.FallbackStatus P0, WebView.FallbackStatus P1)
	{
	}
}
