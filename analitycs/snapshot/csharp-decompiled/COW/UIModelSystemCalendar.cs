using System;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;

namespace COW;

public class UIModelSystemCalendar : UIBaseModel
{
	[Serializable]
	public class SystemCalendarEventParams
	{
		public string ff_event_name;

		public string ff_event_id;

		public string title;

		public string content;

		public string deeplink;

		public string deeplinkToApp;

		public long startEpochSec;

		public long endEpochSec;

		public int[] notifyBeforeMins;

		public int recurrenceInterval;

		public CalendarMgr.RecurrencePeriod recurrencePeriod;

		public long recurrenceUntilEpochSec;

		public int recurrenceCount;
	}

	public class SystemCalendarEventInfo
	{
		public string ff_event_name;

		public string ff_event_id;

		public string nativeEventId;

		public CalendarMgr.CalendarEventParams calendarEvent;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string> _003C_003E9__25_5;

		internal string _003CRestoreOrCreateAppCalendar_003Eb__25_5()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public Action<string, CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public bool requestPermissionIfNeeded;

		internal void _003CEnsureAppCalendar_003Eb__0(CalendarMgr.Result readResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public SystemCalendarEventParams parameters;

		public Action<SystemCalendarEventInfo, CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public bool requestPermissionIfNeeded;

		internal string _003CCreateEvent_003Eb__0()
		{
			return null;
		}

		internal void _003CCreateEvent_003Eb__1(string calendarId, CalendarMgr.Result calendarResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public string calendarId;

		public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateEvent_003Eb__2(CalendarMgr.Result writeResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_2
	{
		public CalendarMgr.CalendarEventParams calendarParams;

		public _003C_003Ec__DisplayClass18_1 CS_0024_003C_003E8__locals2;

		internal string _003CCreateEvent_003Eb__3()
		{
			return null;
		}

		internal void _003CCreateEvent_003Eb__4(string nativeEventId, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_3
	{
		public string nativeEventId;

		internal string _003CCreateEvent_003Eb__5()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string ff_event_name;

		public string ff_event_id;

		public Action<SystemCalendarEventInfo, CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public long queryStartEpochSec;

		public long queryEndEpochSec;

		internal void _003CGetEvent_003Eb__0(string calendarId, CalendarMgr.Result calendarResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public SystemCalendarEventInfo eventInfo;

		public string nativeEventId;

		public Action<SystemCalendarEventInfo, CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public bool requestPermissionIfNeeded;

		public Func<string> _003C_003E9__2;

		public Func<string> _003C_003E9__6;

		public Action<CalendarMgr.Result> _003C_003E9__3;

		internal string _003CUpdateEvent_003Eb__0()
		{
			return null;
		}

		internal void _003CUpdateEvent_003Eb__1(CalendarMgr.Result ownershipResult)
		{
		}

		internal string _003CUpdateEvent_003Eb__2()
		{
			return null;
		}

		internal void _003CUpdateEvent_003Eb__3(CalendarMgr.Result writeResult)
		{
		}

		internal string _003CUpdateEvent_003Eb__6()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_1
	{
		public CalendarMgr.CalendarEventParams calendarParams;

		public _003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals1;

		internal string _003CUpdateEvent_003Eb__4()
		{
			return null;
		}

		internal void _003CUpdateEvent_003Eb__5(CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string nativeEventId;

		public Action<CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public bool requestPermissionIfNeeded;

		public Func<string> _003C_003E9__2;

		public Func<string> _003C_003E9__5;

		public Action<CalendarMgr.Result> _003C_003E9__4;

		public Action<CalendarMgr.Result> _003C_003E9__3;

		internal string _003CDeleteEvent_003Eb__0()
		{
			return null;
		}

		internal void _003CDeleteEvent_003Eb__1(CalendarMgr.Result ownershipResult)
		{
		}

		internal string _003CDeleteEvent_003Eb__2()
		{
			return null;
		}

		internal void _003CDeleteEvent_003Eb__3(CalendarMgr.Result writeResult)
		{
		}

		internal void _003CDeleteEvent_003Eb__4(CalendarMgr.Result result)
		{
		}

		internal string _003CDeleteEvent_003Eb__5()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public Action<CalendarMgr.Result> callback;

		public string nativeEventId;

		public string expectedEventName;

		public string expectedEventId;

		internal void _003CValidateOwnedNativeEvent_003Eb__0(string calendarId, CalendarMgr.Result calendarResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_1
	{
		public string calendarId;

		public _003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals1;

		internal void _003CValidateOwnedNativeEvent_003Eb__1(CalendarMgr.CalendarEventParams calendarEvent, CalendarMgr.Result eventResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_2
	{
		public CalendarMgr.CalendarEventParams calendarEvent;

		public _003C_003Ec__DisplayClass23_1 CS_0024_003C_003E8__locals2;

		internal string _003CValidateOwnedNativeEvent_003Eb__2()
		{
			return null;
		}

		internal string _003CValidateOwnedNativeEvent_003Eb__3()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIModelSystemCalendar _003C_003E4__this;

		public Action<string, CalendarMgr.Result> callback;

		public Func<string> _003C_003E9__4;

		public Action<CalendarMgr.AppCalendarInfo[], CalendarMgr.Result> _003C_003E9__2;

		internal string _003CFindExistingAppCalendar_003Eb__0()
		{
			return null;
		}

		internal void _003CFindExistingAppCalendar_003Eb__1(CalendarMgr.Result readResult)
		{
		}

		internal void _003CFindExistingAppCalendar_003Eb__2(CalendarMgr.AppCalendarInfo[] calendars, CalendarMgr.Result result)
		{
		}

		internal string _003CFindExistingAppCalendar_003Eb__4()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_1
	{
		public CalendarMgr.AppCalendarInfo[] calendars;

		internal string _003CFindExistingAppCalendar_003Eb__3()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIModelSystemCalendar _003C_003E4__this;

		public Action<string, CalendarMgr.Result> callback;

		public bool requestPermissionIfNeeded;

		public Func<string> _003C_003E9__3;

		public Action<string, CalendarMgr.Result> _003C_003E9__6;

		public Action<CalendarMgr.Result> _003C_003E9__4;

		internal string _003CRestoreOrCreateAppCalendar_003Eb__0()
		{
			return null;
		}

		internal void _003CRestoreOrCreateAppCalendar_003Eb__1(CalendarMgr.AppCalendarInfo[] calendars, CalendarMgr.Result result)
		{
		}

		internal string _003CRestoreOrCreateAppCalendar_003Eb__3()
		{
			return null;
		}

		internal void _003CRestoreOrCreateAppCalendar_003Eb__4(CalendarMgr.Result writeResult)
		{
		}

		internal void _003CRestoreOrCreateAppCalendar_003Eb__6(string calendarId, CalendarMgr.Result createResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_1
	{
		public CalendarMgr.AppCalendarInfo[] calendars;

		internal string _003CRestoreOrCreateAppCalendar_003Eb__2()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_2
	{
		public string calendarId;

		internal string _003CRestoreOrCreateAppCalendar_003Eb__7()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string cachedNativeEventId;

		public string ff_event_name;

		public string ff_event_id;

		public Action<SystemCalendarEventInfo, CalendarMgr.Result> callback;

		public UIModelSystemCalendar _003C_003E4__this;

		public long queryStartEpochSec;

		public long queryEndEpochSec;

		internal string _003CFindEvent_003Eb__0()
		{
			return null;
		}

		internal void _003CFindEvent_003Eb__1(CalendarMgr.CalendarEventParams calendarEvent, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_1
	{
		public CalendarMgr.CalendarEventParams calendarEvent;

		public _003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals1;

		internal string _003CFindEvent_003Eb__2()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIModelSystemCalendar _003C_003E4__this;

		public string ff_event_name;

		public string ff_event_id;

		public Action<SystemCalendarEventInfo, CalendarMgr.Result> callback;

		internal string _003CFindEventByQuery_003Eb__0()
		{
			return null;
		}

		internal void _003CFindEventByQuery_003Eb__1(CalendarMgr.AppCalendarEventWithOccurrencesInfo[] groups, CalendarMgr.Result result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_1
	{
		public CalendarMgr.AppCalendarEventWithOccurrencesInfo[] groups;

		internal string _003CFindEventByQuery_003Eb__2()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_2
	{
		public CalendarMgr.AppCalendarEventInfo eventInfo;

		internal string _003CFindEventByQuery_003Eb__3()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public Action<CalendarMgr.Result> callback;

		public bool requestPermissionIfNeeded;

		public PermissionUtility.Permission permission;

		public int[] permissions;

		public PermissionUtility.OnPermissionsResult _003C_003E9__1;

		internal void _003CEnsurePermission_003Eb__0(bool granted)
		{
		}

		internal void _003CEnsurePermission_003Eb__1(Dictionary<int, bool> results)
		{
		}
	}

	public const string FF_EVENT_NAME = "ff_event_name";

	public const string FF_EVENT_ID = "ff_event_id";

	private const string PLAYER_PREFS_KEY_APP_CALENDAR_ID = "SystemCalendar_AppCalendarId";

	private const string PLAYER_PREFS_KEY_EVENT_ID_PREFIX = "SystemCalendar_EventId_";

	private const string ANDROID_APP_CALENDAR_ACCOUNT_NAME = "com.garena.freefire";

	private const string APP_CALENDAR_COLOR_ARGB = "#FFBA00FF";

	private const int DEFAULT_QUERY_BEFORE_DAYS = 30;

	private const int DEFAULT_QUERY_AFTER_DAYS = 365;

	private const string LOG_PREFIX = "@UIModelSystemCalendar";

	private const string ERROR_CREATE_APP_CALENDAR_EMPTY_ID = "create app calendar returned empty calendar id";

	private static readonly DateTime EPOCH_UTC;

	private string _AppCalendarId;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public void OnDeepLink(string ff_event_name, string ff_event_id)
	{
	}

	public void EnsureAppCalendar(bool requestPermissionIfNeeded, Action<string, CalendarMgr.Result> callback)
	{
	}

	public void CreateEvent(SystemCalendarEventParams parameters, bool requestPermissionIfNeeded, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	public void GetEvent(string ff_event_name, string ff_event_id, bool requestPermissionIfNeeded, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	public void GetEvent(string ff_event_name, string ff_event_id, long queryStartEpochSec, long queryEndEpochSec, bool requestPermissionIfNeeded, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	public void UpdateEvent(SystemCalendarEventInfo eventInfo, bool requestPermissionIfNeeded, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	public void DeleteEvent(string nativeEventId, bool requestPermissionIfNeeded, Action<CalendarMgr.Result> callback)
	{
	}

	private void ValidateOwnedNativeEvent(string nativeEventId, string expectedEventName, string expectedEventId, bool requestPermissionIfNeeded, Action<CalendarMgr.Result> callback)
	{
	}

	private void FindExistingAppCalendar(bool requestPermissionIfNeeded, Action<string, CalendarMgr.Result> callback)
	{
	}

	private void RestoreOrCreateAppCalendar(bool requestPermissionIfNeeded, Action<string, CalendarMgr.Result> callback)
	{
	}

	private CalendarMgr.AppCalendarInfo FindAppCalendar(CalendarMgr.AppCalendarInfo[] calendars)
	{
		return null;
	}

	private void FindEvent(string ff_event_name, string ff_event_id, long queryStartEpochSec, long queryEndEpochSec, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	private void FindEventByQuery(string ff_event_name, string ff_event_id, long queryStartEpochSec, long queryEndEpochSec, Action<SystemCalendarEventInfo, CalendarMgr.Result> callback)
	{
	}

	private void EnsureReadPermission(bool requestPermissionIfNeeded, Action<CalendarMgr.Result> callback)
	{
	}

	private void EnsureWritePermission(bool requestPermissionIfNeeded, Action<CalendarMgr.Result> callback)
	{
	}

	private void EnsurePermission(PermissionUtility.Permission permission, bool requestPermissionIfNeeded, Action<CalendarMgr.Result> callback)
	{
	}

	private static bool ArePermissionsGranted(int[] permissions, Dictionary<int, bool> results)
	{
		return false;
	}

	private static CalendarMgr.Result MissingPermissionResult(PermissionUtility.Permission permission)
	{
		return null;
	}

	private CalendarMgr.CalendarEventParams ToCalendarEventParams(SystemCalendarEventParams p, string calendarId)
	{
		return null;
	}

	private static CalendarMgr.CalendarEventParams ToCalendarEventParams(SystemCalendarEventInfo eventInfo)
	{
		return null;
	}

	private static CalendarMgr.CalendarEventParams ToCalendarEventParams(CalendarMgr.AppCalendarEventInfo eventInfo)
	{
		return null;
	}

	private static SystemCalendarEventInfo ToSystemCalendarEventInfo(SystemCalendarEventParams p, CalendarMgr.CalendarEventParams calendarParams, string nativeEventId)
	{
		return null;
	}

	private static SystemCalendarEventInfo ToSystemCalendarEventInfo(string ff_event_name, string ff_event_id, string nativeEventId, CalendarMgr.CalendarEventParams calendarParams)
	{
		return null;
	}

	private static CalendarMgr.Result ValidateTrackingParams(SystemCalendarEventParams parameters)
	{
		return null;
	}

	private static CalendarMgr.Result ValidateSystemCalendarEventInfo(SystemCalendarEventInfo eventInfo, bool requireCalendarEvent)
	{
		return null;
	}

	private static bool HasTrackingParams(string ff_event_name, string ff_event_id)
	{
		return false;
	}

	private static void ResolveTrackingParamsForUpdate(SystemCalendarEventInfo eventInfo)
	{
	}

	private static CalendarMgr.Result ValidateTrackingParams(string ff_event_name, string ff_event_id)
	{
		return null;
	}

	private static bool IsTrackedEvent(CalendarMgr.CalendarEventParams eventParams, string ff_event_name, string ff_event_id)
	{
		return false;
	}

	private static bool IsOwnedCalendarEvent(CalendarMgr.CalendarEventParams eventParams, string appCalendarId, string expectedEventName, string expectedEventId)
	{
		return false;
	}

	public static bool TryGetTrackingParamsFromDeeplink(string deeplink, out string ff_event_name, out string ff_event_id)
	{
		ff_event_name = null;
		ff_event_id = null;
		return false;
	}

	private static bool IsTrackedDeeplink(string deeplink, string ff_event_name, string ff_event_id)
	{
		return false;
	}

	private static string BuildTrackedDeeplink(string deeplink, string ff_event_name, string ff_event_id)
	{
		return null;
	}

	private static string SetQueryParam(string url, string key, string value)
	{
		return null;
	}

	private static bool TryGetQueryParam(string url, string key, out string value)
	{
		value = null;
		return false;
	}

	private static void SplitUrl(string url, out string basePart, out string queryPart, out string fragmentPart)
	{
		basePart = null;
		queryPart = null;
		fragmentPart = null;
	}

	private static void NormalizeQueryRange(ref long queryStartEpochSec, ref long queryEndEpochSec)
	{
	}

	private static long ToEpochSec(DateTime utcTime)
	{
		return 0L;
	}

	private string GetCachedNativeEventId(string ff_event_name, string ff_event_id)
	{
		return null;
	}

	private void SaveCachedNativeEventId(string ff_event_name, string ff_event_id, string nativeEventId)
	{
	}

	private void ClearCachedNativeEventId(string ff_event_name, string ff_event_id)
	{
	}

	private static string GetEventCacheKey(string ff_event_name, string ff_event_id)
	{
		return null;
	}

	private void SetAppCalendarId(string calendarId)
	{
	}

	private void ClearAppCalendarId()
	{
	}

	private static string GetAppCalendarName()
	{
		return null;
	}

	private static string SafeEventName(SystemCalendarEventParams parameters)
	{
		return null;
	}

	private static string SafeEventId(SystemCalendarEventParams parameters)
	{
		return null;
	}

	private static string SafeEventName(SystemCalendarEventInfo eventInfo)
	{
		return null;
	}

	private static string SafeEventId(SystemCalendarEventInfo eventInfo)
	{
		return null;
	}

	private static bool ShouldLogCalendarDetails()
	{
		return false;
	}

	private static string CalendarLogDetail(Func<string> detailGetter)
	{
		return null;
	}

	private static void LogGeneral(string operation, string brief)
	{
	}

	private static void LogGeneral(string operation, string brief, string detail)
	{
	}

	private static void LogOperation(string operation, string ff_event_name, string ff_event_id, string brief, string detail)
	{
	}

	private static void LogResult(string operation, string ff_event_name, string ff_event_id, CalendarMgr.Result result, string brief)
	{
	}

	private static void LogResult(string operation, string ff_event_name, string ff_event_id, CalendarMgr.Result result, string brief, string detail)
	{
	}

	private static string FormatResult(CalendarMgr.Result result)
	{
		return null;
	}

	private static string FormatSystemCalendarEventParams(SystemCalendarEventParams parameters)
	{
		return null;
	}

	private static string FormatCalendarEventParams(CalendarMgr.CalendarEventParams parameters)
	{
		return null;
	}

	private static string FormatSystemCalendarEventInfo(SystemCalendarEventInfo eventInfo)
	{
		return null;
	}

	private static string FormatAppCalendars(CalendarMgr.AppCalendarInfo[] calendars)
	{
		return null;
	}

	private static string FormatEventGroups(CalendarMgr.AppCalendarEventWithOccurrencesInfo[] groups)
	{
		return null;
	}

	private static CalendarMgr.Result OkResult()
	{
		return null;
	}

	private static CalendarMgr.Result NewResult(int code, string message)
	{
		return null;
	}

	private static bool IsOk(CalendarMgr.Result result)
	{
		return false;
	}

	private static void Invoke(Action<CalendarMgr.Result> callback, CalendarMgr.Result result)
	{
	}

	private static void Invoke(Action<string, CalendarMgr.Result> callback, string value, CalendarMgr.Result result)
	{
	}

	private static void Invoke(Action<SystemCalendarEventInfo, CalendarMgr.Result> callback, SystemCalendarEventInfo value, CalendarMgr.Result result)
	{
	}

	private string _003CInit_003Eb__13_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
