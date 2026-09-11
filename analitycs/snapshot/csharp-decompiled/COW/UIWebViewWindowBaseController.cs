using System;
using GCommon;

namespace COW;

internal class UIWebViewWindowBaseController : UIPopupSpecialWindowController
{
	public Action CloseCallBack;

	protected WebView m_WebView;

	protected string m_ActivityName;

	private ulong m_StartShowTime;

	private int m_ShowTime;

	private ulong m_StartPauseTime;

	private int m_PauseTime;

	protected virtual void OnWebViewErrorFallbackStatusChanging(WebView.FallbackStatus before, WebView.FallbackStatus after)
	{
	}

	protected void OpenNativeWebView(string url, WebView.Rect rect, bool forcePlay = false)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	public void SetEventLogInfo(string activityName)
	{
	}

	protected virtual void UpdateScreenshotInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
