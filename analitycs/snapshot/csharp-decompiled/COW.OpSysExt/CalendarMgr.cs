using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.OpSysExt;

public class CalendarMgr : OpSysExt
{
	[Serializable]
	public class Result
	{
		public int Code;

		public string Message;

		public bool Ok => false;
	}

	public static class ErrorCodes
	{
		public const int OK = 0;

		public const int MISSING_READ_PERMISSION = 1;

		public const int MISSING_WRITE_PERMISSION = 2;

		public const int EVENT_NOT_FOUND = 3;

		public const int APP_CALENDAR_NOT_FOUND = 4;

		public const int EMPTY_EVENT_ID = 5;

		public const int EMPTY_CALENDAR_ID = 6;

		public const int CALENDAR_ID_REQUIRED = 7;

		public const int DISPLAY_NAME_REQUIRED = 8;

		public const int INVALID_TIME_RANGE = 9;

		public const int NO_WRITABLE_CALENDAR = 10;

		public const int NO_CALENDAR_SOURCE = 11;

		public const int INVALID_PARAMETER = 12;

		public const int INVALID_JSON = 20;

		public const int SYSTEM_API_FAILED = 21;

		public const int INTERNAL_ERROR = 1000;
	}

	public static class ErrorMessages
	{
		public const string NOT_IMPLEMENTED = "not implemented";

		public const string INVALID_JSON = "invalid json";

		public const string INVALID_TIME_RANGE = "invalid time range";

		public const string INVALID_PARAMETER = "invalid parameter";

		public const string SYSTEM_API_FAILED = "system api failed";
	}

	[Serializable]
	public class Options
	{
		public string AndroidAppCalendarAccountIdentifier;

		public bool IOSPreferEnhancedEventId;

		public bool IOSLookupEnhancedEventId;
	}

	[Serializable]
	public enum RecurrencePeriod
	{
		None,
		Days,
		Weeks,
		Months,
		Years
	}

	[Serializable]
	public class CalendarEventParams
	{
		public string title;

		public string content;

		public string deeplink;

		public string deeplinkToApp;

		public long startEpochSec;

		public long endEpochSec;

		public int[] notifyBeforeMins;

		public int recurrenceInterval;

		public RecurrencePeriod recurrencePeriod;

		public long recurrenceUntilEpochSec;

		public int recurrenceCount;

		public string calendarId;

		public string eventId;
	}

	[Serializable]
	public class CalendarAccountParams
	{
		public string displayName;

		public string colorArgb;
	}

	[Serializable]
	public class CalendarAccountUpdateParams
	{
		public string calendarId;

		public string displayName;

		public string colorArgb;
	}

	[Serializable]
	public class AppCalendarInfo
	{
		public string calendarId;

		public string displayName;

		public string colorArgb;
	}

	[Serializable]
	public class AppCalendarEventInfo
	{
		public string eventId;

		public string calendarId;

		public string title;

		public string content;

		public string deeplink;

		public string deeplinkToApp;

		public long startEpochSec;

		public long endEpochSec;

		public int[] notifyBeforeMins;

		public int recurrenceInterval;

		public RecurrencePeriod recurrencePeriod;

		public long recurrenceUntilEpochSec;

		public int recurrenceCount;
	}

	[Serializable]
	public class AppCalendarEventOccurrenceInfo
	{
		public string eventId;

		public string instanceId;

		public string calendarId;

		public long instanceStartEpochSec;

		public long instanceEndEpochSec;
	}

	[Serializable]
	public class AppCalendarEventWithOccurrencesInfo
	{
		public AppCalendarEventInfo eventInfo;

		public AppCalendarEventOccurrenceInfo[] occurrences;
	}

	[Serializable]
	public class AppCalendarEventQueryParams
	{
		public string calendarId;

		public long startEpochSec;

		public long endEpochSec;
	}

	[Serializable]
	private class AppCalendarInfoList
	{
		public AppCalendarInfo[] items;
	}

	[Serializable]
	private class AppCalendarEventOccurrenceInfoList
	{
		public AppCalendarEventOccurrenceInfo[] items;
	}

	private class StringCallbackCall
	{
		public Action<string, Result> Callback;
	}

	private class EventCallbackCall
	{
		public Action<CalendarEventParams, Result> Callback;
	}

	private class AppCalendarListCallbackCall
	{
		public Action<AppCalendarInfo[], Result> Callback;
	}

	private class AppCalendarEventOccurrenceListCallbackCall
	{
		public Action<AppCalendarEventOccurrenceInfo[], Result> Callback;
	}

	private class VoidCallbackCall
	{
		public Action<Result> Callback;
	}

	private enum StringResultKind
	{
		RawString,
		AppCalendarList,
		AppCalendarEventOccurrenceList
	}

	private class StringResultDispatch
	{
		public StringResultKind Kind;

		public int ErrorCode;

		public string ErrorMessage;

		public long Id;

		public string Result;

		public AppCalendarInfo[] AppCalendars;

		public AppCalendarEventOccurrenceInfo[] Occurrences;
	}

	private class EventJsonResultDispatch
	{
		public int ErrorCode;

		public string ErrorMessage;

		public long Id;

		public CalendarEventParams EventParams;
	}

	private class AppCalendarEventOccurrenceGroup
	{
		public string EventId;

		public List<AppCalendarEventOccurrenceInfo> Occurrences;
	}

	private class Impl_Android : CalendarMgr
	{
		private class CalendarMgrCallback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public Impl_Android mgr;

				public StringResultDispatch dispatch;

				internal void _003ConStringResult_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass3_0
			{
				public Impl_Android mgr;

				public EventJsonResultDispatch dispatch;

				internal void _003ConGetCalendarEventResult_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public Impl_Android mgr;

				public int errorCode;

				public string messageCopy;

				public long id;

				internal void _003ConVoidResult_003Eb__0()
				{
				}
			}

			private Impl_Android _Mgr;

			public CalendarMgrCallback(Impl_Android mgr)
				: base((string)null)
			{
			}

			public void onStringResult(int errorCode, string errorMessage, long id, string result)
			{
			}

			public void onGetCalendarEventResult(int errorCode, string errorMessage, long id, string eventJson)
			{
			}

			public void onVoidResult(int errorCode, string errorMessage, long id)
			{
			}
		}

		private AndroidJavaClass _JavaClass;

		private CalendarMgrCallback _Callback;

		protected override void _AddCalendarEvent(long id, string json)
		{
		}

		protected override void _GetCalendarEvent(long id, string eventId)
		{
		}

		protected override void _UpdateCalendarEvent(long id, string eventId, string json)
		{
		}

		protected override void _DeleteCalendarEvent(long id, string eventId)
		{
		}

		protected override void _CreateAppCalendar(long id, string json)
		{
		}

		protected override void _UpdateAppCalendar(long id, string json)
		{
		}

		protected override void _DeleteAppCalendar(long id, string calendarId)
		{
		}

		protected override void _GetAllAppCalendars(long id)
		{
		}

		protected override void _GetAllEventsAndOccurrencesInAppCalendar(long id, string json)
		{
		}

		public override void SetDefaultCalendarColorArgb(string colorArgb)
		{
		}

		public override void SetAndroidAppCalendarAccountName(string accountName)
		{
		}

		public void _003C_003EiFixBaseProxy__AddCalendarEvent(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__GetCalendarEvent(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__UpdateCalendarEvent(long P0, string P1, string P2)
		{
		}

		public void _003C_003EiFixBaseProxy__DeleteCalendarEvent(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__CreateAppCalendar(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__UpdateAppCalendar(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__DeleteAppCalendar(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__GetAllAppCalendars(long P0)
		{
		}

		public void _003C_003EiFixBaseProxy__GetAllEventsAndOccurrencesInAppCalendar(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy_SetDefaultCalendarColorArgb(string P0)
		{
		}

		public void _003C_003EiFixBaseProxy_SetAndroidAppCalendarAccountName(string P0)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public CalendarMgr _003C_003E4__this;

		public StringResultDispatch dispatch;

		internal void _003CQueueStringResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public CalendarMgr _003C_003E4__this;

		public EventJsonResultDispatch dispatch;

		internal void _003CQueueEventResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public CalendarMgr _003C_003E4__this;

		public int errorCode;

		public string messageCopy;

		public long id;

		internal void _003CQueueVoidResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public CalendarMgr _003C_003E4__this;

		public StringResultDispatch dispatch;

		internal void _003CQueueAppCalendarListResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public CalendarMgr _003C_003E4__this;

		public StringResultDispatch dispatch;

		internal void _003CQueueAppCalendarEventOccurrenceListResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public Action<string, Result> callback;

		public CalendarMgr _003C_003E4__this;

		public long id;

		public CalendarEventParams parameters;

		internal void _003CAddCalendarEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_1
	{
		public Result resultCopy;

		public _003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals1;

		internal void _003CAddCalendarEvent_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		public string eventId;

		internal void _003CGetCalendarEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public Action<Result> callback;

		public CalendarMgr _003C_003E4__this;

		public long id;

		public string eventId;

		public CalendarEventParams parameters;

		internal void _003CUpdateCalendarEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_1
	{
		public Result resultCopy;

		public _003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals1;

		internal void _003CUpdateCalendarEvent_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		public string eventId;

		internal void _003CDeleteCalendarEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		public CalendarAccountParams parameters;

		internal void _003CCreateAppCalendar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		public CalendarAccountUpdateParams parameters;

		internal void _003CUpdateAppCalendar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		public string calendarId;

		internal void _003CDeleteAppCalendar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public CalendarMgr _003C_003E4__this;

		public long id;

		internal void _003CGetAllAppCalendars_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public CalendarMgr _003C_003E4__this;

		public Action<AppCalendarEventWithOccurrencesInfo[], Result> callback;

		public long id;

		public AppCalendarEventQueryParams parameters;

		internal void _003CGetAllEventsAndOccurrencesInAppCalendar_003Eb__0(AppCalendarEventOccurrenceInfo[] occurrences, Result result)
		{
		}

		internal void _003CGetAllEventsAndOccurrencesInAppCalendar_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public object syncRoot;

		public bool callbackSent;

		public Dictionary<string, bool> finishedPerEventId;

		public Dictionary<string, AppCalendarEventInfo> eventInfosPerEventIds;

		public List<AppCalendarEventOccurrenceGroup> groups;

		public CalendarMgr _003C_003E4__this;

		public Action<AppCalendarEventWithOccurrencesInfo[], Result> callback;
	}

	private sealed class _003C_003Ec__DisplayClass91_1
	{
		public string eventId;

		public _003C_003Ec__DisplayClass91_0 CS_0024_003C_003E8__locals1;

		internal void _003CFetchEventsForOccurrenceGroups_003Eb__0(CalendarEventParams eventParams, Result result)
		{
		}
	}

	private static CalendarMgr _I;

	private LongSeqPool<StringCallbackCall> _StringCallbacks;

	private LongSeqPool<EventCallbackCall> _EventCallbacks;

	private LongSeqPool<AppCalendarListCallbackCall> _AppCalendarListCallbacks;

	private LongSeqPool<AppCalendarEventOccurrenceListCallbackCall> _AppCalendarEventOccurrenceListCallbacks;

	private LongSeqPool<VoidCallbackCall> _VoidCallbacks;

	private static string _DefaultCalendarColorArgb;

	private static string _AndroidAppCalendarAccountName;

	public static CalendarMgr I => null;

	public static string DefaultCalendarColorArgb => null;

	public static string AndroidAppCalendarAccountName => null;

	protected CalendarMgr()
	{
	}

	public virtual void Init(Options options)
	{
	}

	private static string ToJson(CalendarEventParams p)
	{
		return null;
	}

	private static string ToJson(CalendarAccountParams p)
	{
		return null;
	}

	private static string ToJson(CalendarAccountUpdateParams p)
	{
		return null;
	}

	private static string ToJson(AppCalendarEventQueryParams p)
	{
		return null;
	}

	private static Result MakeResult(int code, string message)
	{
		return null;
	}

	private static bool TryValidateCalendarEventParams(CalendarEventParams p, out Result result)
	{
		result = null;
		return false;
	}

	private void QueueStringResult(int errorCode, string errorMessage, long id, string result)
	{
	}

	private void QueueEventResult(int errorCode, string errorMessage, long id, string eventJson)
	{
	}

	private void QueueVoidResult(int errorCode, string errorMessage, long id)
	{
	}

	private void QueueAppCalendarListResult(int errorCode, string errorMessage, long id, string resultJson)
	{
	}

	private void QueueAppCalendarEventOccurrenceListResult(int errorCode, string errorMessage, long id, string resultJson)
	{
	}

	private void RunStringRequest(long id, Action request)
	{
	}

	private void RunEventRequest(long id, Action request)
	{
	}

	private void RunVoidRequest(long id, Action request)
	{
	}

	private void RunAppCalendarListRequest(long id, Action request)
	{
	}

	private void RunAppCalendarEventOccurrenceListRequest(long id, Action request)
	{
	}

	public void AddCalendarEvent(CalendarEventParams parameters, Action<string, Result> callback)
	{
	}

	public void GetCalendarEvent(string eventId, Action<CalendarEventParams, Result> callback)
	{
	}

	public void UpdateCalendarEvent(string eventId, CalendarEventParams parameters, Action<Result> callback)
	{
	}

	public void DeleteCalendarEvent(string eventId, Action<Result> callback)
	{
	}

	public void CreateAppCalendar(CalendarAccountParams parameters, Action<string, Result> callback)
	{
	}

	public void UpdateAppCalendar(CalendarAccountUpdateParams parameters, Action<Result> callback)
	{
	}

	public void DeleteAppCalendar(string calendarId, Action<Result> callback)
	{
	}

	public void GetAllAppCalendars(Action<AppCalendarInfo[], Result> callback)
	{
	}

	public void GetAllEventsAndOccurrencesInAppCalendar(AppCalendarEventQueryParams parameters, Action<AppCalendarEventWithOccurrencesInfo[], Result> callback)
	{
	}

	public virtual void SetDefaultCalendarColorArgb(string colorArgb)
	{
	}

	public virtual void SetAndroidAppCalendarAccountName(string accountName)
	{
	}

	public virtual void SetIOSEnhancedEventIdOptions(bool preferEnhancedEventId, bool lookupEnhancedEventId)
	{
	}

	private static string NormalizeAndroidAppCalendarAccountName(string accountName)
	{
		return null;
	}

	protected virtual void _AddCalendarEvent(long id, string json)
	{
	}

	protected virtual void _GetCalendarEvent(long id, string eventId)
	{
	}

	protected virtual void _UpdateCalendarEvent(long id, string eventId, string json)
	{
	}

	protected virtual void _DeleteCalendarEvent(long id, string eventId)
	{
	}

	protected virtual void _CreateAppCalendar(long id, string json)
	{
	}

	protected virtual void _UpdateAppCalendar(long id, string json)
	{
	}

	protected virtual void _DeleteAppCalendar(long id, string calendarId)
	{
	}

	protected virtual void _GetAllAppCalendars(long id)
	{
	}

	protected virtual void _GetAllEventsAndOccurrencesInAppCalendar(long id, string json)
	{
	}

	private StringResultDispatch PrepareStringResult(int errorCode, string errorMessage, long id, string result)
	{
		return null;
	}

	private static EventJsonResultDispatch PrepareEventJsonResult(int errorCode, string errorMessage, long id, string eventJson)
	{
		return null;
	}

	private void DispatchPreparedStringResult(StringResultDispatch dispatch)
	{
	}

	private void DispatchRawStringResult(int errorCode, string errorMessage, long id, string result)
	{
	}

	private void DispatchPreparedEventJsonResult(EventJsonResultDispatch dispatch)
	{
	}

	private void DispatchCalendarEventResult(int errorCode, string errorMessage, long id, CalendarEventParams eventParams)
	{
	}

	private void DispatchAppCalendarListResult(int errorCode, string errorMessage, long id, AppCalendarInfo[] calendars)
	{
	}

	private void DispatchAppCalendarEventOccurrencesResult(int errorCode, string errorMessage, long id, AppCalendarEventOccurrenceInfo[] occurrences)
	{
	}

	private static CalendarEventParams ParseCalendarEventJson(string eventJson, ref int resultCode, ref string resultMessage)
	{
		return null;
	}

	private static AppCalendarInfo[] ParseAppCalendarListJson(string resultJson, ref int resultCode, ref string resultMessage)
	{
		return null;
	}

	private static AppCalendarEventOccurrenceInfo[] ParseAppCalendarEventOccurrenceListJson(string resultJson, ref int resultCode, ref string resultMessage)
	{
		return null;
	}

	private void BuildEventsAndOccurrences(AppCalendarEventOccurrenceInfo[] occurrences, Result occurrenceResult, Action<AppCalendarEventWithOccurrencesInfo[], Result> callback)
	{
	}

	private static List<AppCalendarEventOccurrenceGroup> GroupOccurrencesByEventId(AppCalendarEventOccurrenceInfo[] occurrences)
	{
		return null;
	}

	private void FetchEventsForOccurrenceGroups(List<AppCalendarEventOccurrenceGroup> groups, Action<AppCalendarEventWithOccurrencesInfo[], Result> callback)
	{
	}

	private void LogParentEventLookupFailure(string eventId, Result result)
	{
	}

	private static bool AreAllEventIdsFinished(Dictionary<string, bool> finishedEventIds)
	{
		return false;
	}

	private static Result BuildParentLookupFinalResult(Dictionary<string, AppCalendarEventInfo> eventInfos)
	{
		return null;
	}

	private static Dictionary<string, AppCalendarEventInfo> BuildPendingEventInfoById(List<AppCalendarEventOccurrenceGroup> groups)
	{
		return null;
	}

	private static AppCalendarEventWithOccurrencesInfo[] BuildCompletedEventOccurrenceOutput(List<AppCalendarEventOccurrenceGroup> groups, Dictionary<string, AppCalendarEventInfo> eventInfos)
	{
		return null;
	}

	private static AppCalendarEventInfo ToAppCalendarEventInfo(CalendarEventParams p, string fallbackEventId)
	{
		return null;
	}

	protected void DispatchVoidResult(int errorCode, string errorMessage, long id)
	{
	}

	private static string NormalizeNativeStringArg(string value)
	{
		return null;
	}
}
