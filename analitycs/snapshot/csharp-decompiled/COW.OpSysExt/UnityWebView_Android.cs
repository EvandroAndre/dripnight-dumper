using System;
using UnityEngine;

namespace COW.OpSysExt;

public static class UnityWebView_Android
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public bool result;

		internal void _003COnTestResult_003Eb__0()
		{
		}
	}

	private static AndroidJavaClass _WebViewManager;

	private static AndroidJavaClass _CustomTabsManager;

	private static bool _003CDisabledWebView_003Ek__BackingField;

	private static Action<bool> _OnTestResult;

	private static AndroidJavaClass WebViewManager => null;

	private static AndroidJavaClass CustomTabsManager => null;

	public static bool DisabledWebView
	{
		get
		{
			return _003CDisabledWebView_003Ek__BackingField;
		}
		private set
		{
			_003CDisabledWebView_003Ek__BackingField = value;
		}
	}

	public static void Configure(bool useActivity)
	{
	}

	public static bool CanDisableWebView()
	{
		return false;
	}

	public static bool TryDisableWebView()
	{
		return false;
	}

	public static void SetWebViewActivityDebugLog(bool debugLog)
	{
	}

	public static void SetWebContentDebuggingEnabled(bool enabled)
	{
	}

	public static void SetUnitySendMessageGameObjectName(string name)
	{
	}

	public static void SetSendConsoleMessagesToUnity(bool send)
	{
	}

	public static bool SetFlag(string key, bool value)
	{
		return false;
	}

	public static int Open(string url, float x, float y, float width, float height, UnityWebView.WebViewParameters parameters)
	{
		return 0;
	}

	public static bool ThisProcessCanUseWebView()
	{
		return false;
	}

	public static void Test(Action<bool> onTestResult)
	{
	}

	internal static void OnTestResult(bool result)
	{
	}

	public static void Close(int webViewId)
	{
	}

	public static void CloseAll()
	{
	}

	public static void Reload(int webViewId)
	{
	}

	public static void RedirectTo(int webViewId, string url)
	{
	}

	public static void CanGoBackward(int webViewId)
	{
	}

	public static void CanGoForward(int webViewId)
	{
	}

	public static void GoBackward(int webViewId)
	{
	}

	public static void GoForward(int webViewId)
	{
	}

	public static string GetURL(int webViewId)
	{
		return null;
	}

	public static void FetchWebViewURL(int webViewId)
	{
	}

	public static float GetLoadingProgress(int webViewId)
	{
		return 0f;
	}

	public static bool IsLoading(int webViewId)
	{
		return false;
	}

	public static void SetNameInJavaScript(string name)
	{
	}

	public static void RunJavaScript(int webViewId, string jsCode, string callback, string id)
	{
	}

	public static void ClearData()
	{
	}

	public static void Show(int webViewId)
	{
	}

	public static void Hide(int webViewId)
	{
	}

	public static bool CanCaptureScreenshot()
	{
		return false;
	}

	public static bool CaptureScreenshot(int webViewId, string fileName)
	{
		return false;
	}

	public static void GetUserAgentString(int webViewId)
	{
	}

	public static void SetUserAgentString(int webViewId, string userAgentString)
	{
	}

	public static bool SupportCustomTabs()
	{
		return false;
	}

	public static void OpenCustomTabs(string url)
	{
	}
}
