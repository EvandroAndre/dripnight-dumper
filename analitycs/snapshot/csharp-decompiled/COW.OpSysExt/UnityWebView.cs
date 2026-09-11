using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace COW.OpSysExt;

public class UnityWebView : OpSysExt
{
	[Serializable]
	public class WebViewError
	{
		public int errorCode;

		public string errorMessage;

		public string failingUrl;

		public bool isMainFrame;

		public WebViewError(int errorCode, string errorMessage, string failingUrl, bool isMainFrame)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class WebViewHttpError
	{
		public int statusCode;

		public string reasonPhrase;

		public string failingUrl;

		public bool isMainFrame;

		public WebViewHttpError(int statusCode, string reasonPhrase, string failingUrl, bool isMainFrame)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class WebViewParameters
	{
		public string UnitySendMessageGameObjectName;

		public bool Scaling;

		public bool UseCookie;

		public bool DeferredDisplay;

		public bool AutoPlayMedia;

		public bool ExtraLog;

		public bool HardwareAcceleration;

		public bool AllowAudioCapture;

		public bool AllowVideoCapture;

		public bool AllowReadSystemCalendar;

		public bool AllowWriteSystemCalendar;
	}

	public static class Flags
	{
		public const string IGNORE_INSETS_ON_TOUCH = "ignore_insets_on_touch";

		public const string NORMALIZE_COORDS_ON_TOUCH = "normalize_coords_on_touch";

		public const string IGNORE_INSETS_DURING_LAYOUT_IF_WINDOWED = "ignore_insets_during_layout_if_windowed";

		public const string ENFORCE_TRANSPARENT_BACKGROUND_26 = "enforce_transparent_background_26";

		public const string PROCESS_PERMISSION_REQUESTS = "process_permission_requests";
	}

	private class JavaScriptMessageHandler
	{
		public string[] Parameters;

		public Action<string, string[], int, string> Handler;
	}

	[Serializable]
	public class JavaScriptResult
	{
		public string id;

		public string callback;

		public string error;

		public string value;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MatchEvaluator _003C_003E9__79_0;

		internal string _003CFromLiteral_003Eb__79_0(Match match)
		{
			return null;
		}
	}

	private static string _003CJavaScriptName_003Ek__BackingField;

	private new static Action<string> OnLog;

	private static Action<string> OnLogError;

	private static Action<int, WebViewError, long> OnWebViewError;

	private static Action<int, WebViewHttpError, long> OnWebViewHttpError;

	private static Action<string> OnForceCloseAll;

	private static bool _003CUseJavaScriptInjection_003Ek__BackingField;

	private static bool _003CUseMediaManipulationOnHideAndShowByJavaScript_003Ek__BackingField;

	private static Dictionary<string, JavaScriptMessageHandler> _JavaScriptMessageHandlers;

	private const string PROMISE_ID_KEY = "PromiseId";

	private static Dictionary<int, Dictionary<string, Action<int, JavaScriptResult>>> _JavaScriptCallbacks;

	private static int _JavaScriptEchoId;

	private static string _JavaScriptEchoMsg;

	public const string NATIVE_TO_JAVASCRIPT_PROMISE_THEN = "nativePromiseThen";

	public static string JavaScriptName
	{
		get
		{
			return _003CJavaScriptName_003Ek__BackingField;
		}
		private set
		{
			_003CJavaScriptName_003Ek__BackingField = value;
		}
	}

	public static bool UseJavaScriptInjection
	{
		get
		{
			return _003CUseJavaScriptInjection_003Ek__BackingField;
		}
		set
		{
			_003CUseJavaScriptInjection_003Ek__BackingField = value;
		}
	}

	public static bool UseMediaManipulationOnHideAndShowByJavaScript
	{
		get
		{
			return _003CUseMediaManipulationOnHideAndShowByJavaScript_003Ek__BackingField;
		}
		set
		{
			_003CUseMediaManipulationOnHideAndShowByJavaScript_003Ek__BackingField = value;
		}
	}

	protected UnityWebView()
	{
	}

	public static void Init()
	{
	}

	public static void SetLogCallbacks(Action<string> onLog, Action<string> onLogError)
	{
	}

	public static void SetWebViewErrorCallbacks(Action<int, WebViewError, long> onWebViewError, Action<int, WebViewHttpError, long> onWebViewHttpError)
	{
	}

	internal static void ReportWebViewError(int webViewId, WebViewError error, long timestamp)
	{
	}

	internal static void ReportWebViewHttpError(int webViewId, WebViewHttpError httpError, long timestamp)
	{
	}

	public static void SetForceCloseAllHandler(Action<string> closeAll)
	{
	}

	internal static void ForceCloseAll(string msg)
	{
	}

	internal static void Log(string log)
	{
	}

	internal static void LogError(string logError)
	{
	}

	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	public static void SetSendConsoleMessagesToUnity(bool send)
	{
	}

	public static bool SetFlag(string key, bool value)
	{
		return false;
	}

	public static int Open(string url, float x, float y, float width, float height, WebViewParameters parameters)
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

	public static string GetRuntimeVersion()
	{
		return null;
	}

	public static bool CanFix()
	{
		return false;
	}

	public static void Fix()
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

	internal static void OnGetUserAgentString(int webViewId, string userAgentString)
	{
	}

	public static void GetUserAgentString(int webViewId, Action<int, string> callback)
	{
	}

	public static void SetUserAgentString(int webViewId, string userAgentString)
	{
	}

	internal static void OnCanGoBackward(int webViewId, bool result)
	{
	}

	public static void CanGoBackward(int webViewId, Action<int, bool> callback)
	{
	}

	internal static void OnCanGoForward(int webViewId, bool result)
	{
	}

	public static void CanGoForward(int webViewId, Action<int, bool> callback)
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

	internal static void OnFetchWebViewURLResult(int webViewId, string result)
	{
	}

	public static void FetchWebViewURL(int webViewId, Action<int, string> callback)
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

	public static void RegisterJavaScriptMessageHandler(string msg, string[] parameters, Action<string, string[], int, string> handler)
	{
	}

	public static void UnregisterJavaScriptMessageHandler(string msg)
	{
	}

	public static void MessageHandlerReturnToJavaScript(int webViewId, string promiseId, string result, bool error = false)
	{
	}

	internal static void OnJavaScriptPostMessage(int webViewId, string msg)
	{
	}

	private static string JavaScriptResultCallbackString(int webViewId, Action<int, JavaScriptResult> callback)
	{
		return null;
	}

	private static string SetJavaScriptCallback(int webViewId, Action<int, JavaScriptResult> callback)
	{
		return null;
	}

	internal static void DoJavaScriptCallback(int webViewId, JavaScriptResult result)
	{
	}

	private static void ClearJavaScriptCallbacks(int webViewId)
	{
	}

	private static void ClearAllJavaScriptCallbacks()
	{
	}

	public static void RunJavaScript(int webViewId, string jsCode, string id, Action<int, JavaScriptResult> callback)
	{
	}

	public static void JavaScriptEcho(int webViewId, string msg)
	{
	}

	private static void OnJavaScriptEchoCallback(int webViewId, JavaScriptResult jsr)
	{
	}

	public static string ToLiteral(string input)
	{
		return null;
	}

	public static string FromLiteral(string input)
	{
		return null;
	}

	public static bool CanClearData()
	{
		return false;
	}

	public static void ClearData()
	{
	}

	public static void ShowWebView(int webViewId)
	{
	}

	public static void HideWebView(int webViewId)
	{
	}

	public static bool CanCaptureScreenshot()
	{
		return false;
	}

	public static bool CaptureScreenshot(int webViewId, string fileName, Action<string> onSuccess, Action<string> onFailure)
	{
		return false;
	}

	public static bool SupportWebPage()
	{
		return false;
	}

	public static void OpenWebPage(string url, bool animated)
	{
	}
}
