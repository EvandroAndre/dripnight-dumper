using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class WebView
{
	public class Rect
	{
		public float x;

		public float y;

		public float width;

		public float height;

		public Rect()
		{
		}

		public Rect(UIWidget widget)
		{
		}
	}

	private class AndroidWebViewUserAgentStringModification
	{
		public Func<string, string> Mod;
	}

	public enum FallbackStatus
	{
		None,
		Url,
		Hide
	}

	[Serializable]
	private class QualityLevel
	{
		public int level;

		public string name;
	}

	[Serializable]
	private class WebViewCaptureScreenshotResult
	{
		public string Error;

		public int[] Platforms;
	}

	private static class DownloadImageToAlbumFlag
	{
		public const int OK = 0;

		public const int NO_URL = 1;

		public const int MALFORMED_URL = 2;

		public const int NO_PARAMS = 3;

		public const int FAIL_NETWORK = 4;

		public const int FAIL_ALBUM = 5;
	}

	[Serializable]
	private class DownloadImageToAlbumResult
	{
		public int Flag;

		public string Msg;
	}

	private class WebViewNotifyExtras
	{
		public string DeepLink;

		public int Times;

		public int Interval_S;
	}

	[Serializable]
	private class WebViewSystemCalendarEvent
	{
		public string EventName;

		public string EventId;

		public string NativeEventId;

		public string Title;

		public string Content;

		public string DeepLink;

		public string DeepLinkToApp;

		public long StartEpochSec;

		public long EndEpochSec;

		public int[] NotifyBeforeMins;

		public int RecurrenceInterval;

		public int RecurrencePeriod;

		public long RecurrenceUntilEpochSec;

		public int RecurrenceCount;
	}

	public static class WebPage
	{
		public static bool AnimateOpenClose => false;

		public static bool IsSupported()
		{
			return false;
		}

		public static void OpenWebPage(string url)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<int, string> _003C_003E9__115_3;

		internal string _003C_002Ecctor_003Eb__1_0(string userAgentString)
		{
			return null;
		}

		internal string _003COnCaptureAndShareScreenshot_003Eb__115_3(int i)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public string promiseId;

		internal void _003COnGetUserAgent_003Eb__0(int _webViewId, string userAgent)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public int webViewId;

		public string promiseId;

		public Action _003C_003E9__2;

		internal void _003COnCaptureAndShareScreenshot_003Eb__0(string filePath)
		{
		}

		internal void _003COnCaptureAndShareScreenshot_003Eb__2()
		{
		}

		internal void _003COnCaptureAndShareScreenshot_003Eb__1(string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003C_DownloadImageAndSaveToAlbum_003Eb__0(byte[] data, string nativeId, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnScheduleNotify_003Eb__0(bool result, string msg)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnUnscheduleNotify_003Eb__0(bool result, string msg)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public int webViewId;

		public string promiseId;

		public PermissionUtility.Permission permission;

		public PermissionUtility.OnPermissionsResult _003C_003E9__1;

		internal void _003CRequestPermission_003Eb__1(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_1
	{
		public int[] permissions;

		public _003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals1;

		internal void _003CRequestPermission_003Eb__0(bool granted)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnCreateSystemCalendarEvent_003Eb__0(UIModelSystemCalendar.SystemCalendarEventInfo eventInfo, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnGetSystemCalendarEvent_003Eb__0(UIModelSystemCalendar.SystemCalendarEventInfo eventInfo, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnUpdateSystemCalendarEvent_003Eb__0(UIModelSystemCalendar.SystemCalendarEventInfo updatedEventInfo, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public int webViewId;

		public string promiseId;

		internal void _003COnDeleteSystemCalendarEvent_003Eb__0(CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Action<bool> callback;

		internal void _003CCheckForFaulty_003Eb__0(bool b)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public Action onContinue;

		public string text;

		internal void _003CCheck_003Eb__0(bool faulty)
		{
		}
	}

	private sealed class _003C_DownloadImageAndSaveToAlbum_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int webViewId;

		public string promiseId;

		public string url;

		private _003C_003Ec__DisplayClass119_0 _003C_003E8__1;

		public string title;

		public string desc;

		private UnityWebRequest _003CunityWebRequest_003E5__2;

		private DownloadHandlerBuffer _003CdownloadHandlerBuffer_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003C_DownloadImageAndSaveToAlbum_003Ed__119(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static bool _AndroidWebViewUsingActivity;

	private static readonly string[] MOD_USER_AGENTS_SEPARATORS;

	private int m_Handler;

	private static Dictionary<int, WebView> _HandlerToInstances;

	public bool IsShow;

	private static bool _003CFaulty_003Ek__BackingField;

	private static bool _003CCheckedForFaulty_003Ek__BackingField;

	private static Color _ProgressTextLaunchColor;

	private static Color _ProgressTextLoadColor;

	private static bool promptedFaulty;

	private static readonly Dictionary<string, AndroidWebViewUserAgentStringModification> _AndroidWebViewUserAgentStringModifications;

	private UIBaseController _UIBaseController;

	private Action _OnForceClose;

	private string _Url;

	private string _FallbackUrl;

	private FallbackStatus _ErrorFallbackStatus;

	private Action<FallbackStatus, FallbackStatus> _ErrorFallbackStatusCallback;

	private const string WEBVIEW_CAPTURE_SCREENSHOT_FILE_NAME = "WebViewScreenshot";

	private List<int> _SharedPlatforms;

	private const string WEBVIEW_SYSTEM_CALENDAR_EVENT_NAME_PREFIX = "WebView_";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_PARAMS = "PARAMS";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_TIME = "TIME";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_PERMISSION = "PERMISSION";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_NOT_FOUND = "NOT_FOUND";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_FAILED = "FAILED";

	private const string WEBVIEW_SYSTEM_CALENDAR_ERROR_EVENT = "EVENT";

	public static bool PromptFaulty => false;

	public static bool FallbackToBrowser => false;

	private static bool ShouldCheckForFaulty => false;

	public static bool Faulty
	{
		get
		{
			return _003CFaulty_003Ek__BackingField;
		}
		private set
		{
			_003CFaulty_003Ek__BackingField = value;
		}
	}

	private static bool CheckedForFaulty
	{
		get
		{
			return _003CCheckedForFaulty_003Ek__BackingField;
		}
		set
		{
			_003CCheckedForFaulty_003Ek__BackingField = value;
		}
	}

	public static string NameInJavaScript => null;

	public static bool RunJavaScriptAllowed => false;

	public static bool DeferredDisplay => false;

	public static float ProgressBarLaunchPercentage => 0f;

	public static float ProgressBarLaunchDuration => 0f;

	public static Color ProgressTextLaunchColor => default(Color);

	public static Color ProgressTextLoadColor => default(Color);

	public static bool DisableJavaScriptInjection => false;

	public static bool DisableMediaManipulationOnHideAndShow => false;

	public FallbackStatus ErrorFallbackStatus
	{
		get
		{
			return FallbackStatus.None;
		}
		set
		{
		}
	}

	static WebView()
	{
	}

	private static void OnWebViewError(int webViewId, UnityWebView.WebViewError error, long timestamp)
	{
	}

	private static void OnWebViewHttpError(int webViewId, UnityWebView.WebViewHttpError httpError, long timestamp)
	{
	}

	private void OnError(UnityWebView.WebViewError error, long timestamp)
	{
	}

	private void OnHttpError(UnityWebView.WebViewHttpError httpError, long timestamp)
	{
	}

	private void TryFallback(string failingUrl)
	{
	}

	private static void ForceCloseAll(string msg)
	{
	}

	private static string[] GetUserAgentModsFromSettingData(string url)
	{
		return null;
	}

	public static WebViewSettingDesc GetSettingData(string url)
	{
		return null;
	}

	private static void CheckForFaulty(Action<bool> callback)
	{
	}

	public static void ConfigureForStartup()
	{
	}

	public static void ConfigureForFrontEnd()
	{
	}

	private static bool IsAndroidWebViewUseActivityEnabled()
	{
		return false;
	}

	private static bool ResolveSystemCalendarCrudRequestPermission(bool requestPermission)
	{
		return false;
	}

	private static bool ShouldIgnorePermissionRequests()
	{
		return false;
	}

	public static void Configure(bool useActivity)
	{
	}

	public static string StripAutoPlayLinkTailURL(string url, out bool autoplay)
	{
		autoplay = default(bool);
		return null;
	}

	public static bool AutoPlayMedia(string networkType)
	{
		return false;
	}

	public static void Check(string text, Action onContinue)
	{
	}

	private static void OnDeepLink(string deepLinkUrl, string[] parameters, int webViewId, string promiseId)
	{
	}

	private void ApplyAndroidWebViewUserAgentStringModifications(int webViewId, string url)
	{
	}

	private void OnGetAndroidWebViewUserAgentStringForModifications(int webViewId, string userAgentString)
	{
	}

	public WebView(UIBaseController controller)
	{
	}

	public void OverrideOnForceClose(Action action)
	{
	}

	public void RegisterFallbackStatusListener(Action<FallbackStatus, FallbackStatus> callback)
	{
	}

	public void UnregisterFallbackStatusListener(Action<FallbackStatus, FallbackStatus> callback)
	{
	}

	private static bool IsDomainBlacklisted(string url)
	{
		return false;
	}

	private static string GetFallbackUrlForBlacklistedDomain(string url)
	{
		return null;
	}

	public void Open(string url, Rect rect, bool? scaling = null, bool? cookie = null, bool needCheck = true, bool forcePlay = false, string fallbackUrl = "")
	{
	}

	public void ShowWebView()
	{
	}

	public void HideWebView()
	{
	}

	private void _UpdateVisibility()
	{
	}

	public static bool HasWebViewShowNow()
	{
		return false;
	}

	public void RunJavaScript(string jsCode, string id, Action<int, UnityWebView.JavaScriptResult> callback)
	{
	}

	public void Close()
	{
	}

	public static void CloseAll()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsLoading()
	{
		return false;
	}

	public float GetLoadingProgress()
	{
		return 0f;
	}

	public void Reload()
	{
	}

	public void RedirectTo(string url)
	{
	}

	public string GetURL()
	{
		return null;
	}

	public void FetchURL(Action<int, string> callback)
	{
	}

	public void CanGoBackward(Action<int, bool> callback)
	{
	}

	public void CanGoForward(Action<int, bool> callback)
	{
	}

	public void GoBackward()
	{
	}

	public void GoForward()
	{
	}

	private static void OnGetAudioVolume(string channel, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetUserAgent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetNetworkType(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetMailAppealInfo(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetQuality(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetLiveTvEsportsReserve(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGoToInternalBrowser(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGotoSocialMedia(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnEsportsAnnouncement(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnCanCaptureScreenshot(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	public void OnShareImage(bool success, int platform)
	{
	}

	private static void OnCaptureAndShareScreenshot(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnDownloadImageToAlbum(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static IEnumerator _DownloadImageAndSaveToAlbum(string url, string title, string desc, int webViewId, string promiseId)
	{
		return null;
	}

	private static void OnScheduleNotify(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnUnscheduleNotify(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnRequestPermission(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void RequestPermission(PermissionUtility.Permission permission, int webViewId, string promiseId)
	{
	}

	private static bool IsPermissionGranted(PermissionUtility.Permission permission, Dictionary<int, bool> results)
	{
		return false;
	}

	private static bool IsSystemCalendarUseAllowed(int webViewId, PermissionUtility.Permission permission)
	{
		return false;
	}

	private static void OnCreateSystemCalendarEvent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnGetSystemCalendarEvent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnUpdateSystemCalendarEvent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static void OnDeleteSystemCalendarEvent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	private static bool TryBuildSystemCalendarEventParams(string[] parameters, out UIModelSystemCalendar.SystemCalendarEventParams eventParams, out WebViewSystemCalendarEvent calendarEvent, out string error)
	{
		eventParams = null;
		calendarEvent = null;
		error = null;
		return false;
	}

	private static bool TryBuildSystemCalendarEventParamsFromEvent(string eventName, string eventId, WebViewSystemCalendarEvent calendarEvent, bool requireTrackingParams, out UIModelSystemCalendar.SystemCalendarEventParams eventParams, out string error)
	{
		eventParams = null;
		error = null;
		return false;
	}

	private static bool TryBuildSystemCalendarEventInfoForUpdate(string[] parameters, out UIModelSystemCalendar.SystemCalendarEventInfo eventInfo, out WebViewSystemCalendarEvent calendarEvent, out string error)
	{
		eventInfo = null;
		calendarEvent = null;
		error = null;
		return false;
	}

	private static bool TryBuildSystemCalendarEventDeleteParams(string[] parameters, out string nativeEventId, out string error)
	{
		nativeEventId = null;
		error = null;
		return false;
	}

	private static bool TryBuildSystemCalendarEventLookupParams(string[] parameters, out string ffEventName, out string ffEventId, out string error)
	{
		ffEventName = null;
		ffEventId = null;
		error = null;
		return false;
	}

	private static bool TryBuildSystemCalendarEventQueryParams(string[] parameters, out string ffEventName, out string ffEventId, out long queryStartEpochSec, out long queryEndEpochSec, out string error)
	{
		ffEventName = null;
		ffEventId = null;
		queryStartEpochSec = default(long);
		queryEndEpochSec = default(long);
		error = null;
		return false;
	}

	private static bool TryParseOptionalSystemCalendarEpochSec(string value, out long epochSec)
	{
		epochSec = default(long);
		return false;
	}

	private static UIModelSystemCalendar.SystemCalendarEventInfo ToSystemCalendarEventInfo(UIModelSystemCalendar.SystemCalendarEventParams eventParams, string nativeEventId)
	{
		return null;
	}

	private static CalendarMgr.CalendarEventParams ToCalendarEventParams(UIModelSystemCalendar.SystemCalendarEventParams eventParams)
	{
		return null;
	}

	private static bool TryParseSystemCalendarEvent(string eventJson, out WebViewSystemCalendarEvent calendarEvent, out string error)
	{
		calendarEvent = null;
		error = null;
		return false;
	}

	private static bool TryParseSystemCalendarRequestPermission(string param, out bool requestPermission, out string error)
	{
		requestPermission = default(bool);
		error = null;
		return false;
	}

	private static string BuildWebViewSystemCalendarEventName(string eventName)
	{
		return null;
	}

	private static bool TryResolveSystemCalendarTrackingParams(WebViewSystemCalendarEvent calendarEvent, out string ffEventName, out string ffEventId)
	{
		ffEventName = null;
		ffEventId = null;
		return false;
	}

	private static bool ShouldLogSystemCalendarEventDetails()
	{
		return false;
	}

	private static void LogSystemCalendarEventRawParameters(string operation, string[] parameters)
	{
	}

	private static void LogSystemCalendarEventParsed(string operation, bool requestPermission, string ffEventName, string ffEventId, long queryStartEpochSec, long queryEndEpochSec, WebViewSystemCalendarEvent calendarEvent, object eventPayload)
	{
	}

	private static string FormatSystemCalendarEventPayload(object eventPayload)
	{
		return null;
	}

	private static void LogSystemCalendarEventParseFailure(string operation, string error)
	{
	}

	private static string FormatSystemCalendarEventRawParameters(string operation, string[] parameters)
	{
		return null;
	}

	private static string GetSystemCalendarEventParameterName(string operation, int index)
	{
		return null;
	}

	private static void ReturnSystemCalendarEventResult(int webViewId, string promiseId, UIModelSystemCalendar.SystemCalendarEventInfo eventInfo, CalendarMgr.Result result)
	{
	}

	private static void ReturnSystemCalendarResult(int webViewId, string promiseId, CalendarMgr.Result result, string success)
	{
	}

	private static void ReturnSystemCalendarExceptionResult(string operation, int webViewId, string promiseId, Exception e)
	{
	}

	private static bool IsSystemCalendarResultOk(CalendarMgr.Result result)
	{
		return false;
	}

	private static string ToWebViewSystemCalendarError(CalendarMgr.Result result)
	{
		return null;
	}

	private static WebViewSystemCalendarEvent ToWebViewSystemCalendarEventResult(UIModelSystemCalendar.SystemCalendarEventInfo eventInfo)
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
}
