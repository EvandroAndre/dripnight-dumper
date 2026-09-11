using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public static class LocalNotificationManager
{
	private class StatsRecord
	{
		public ulong LastSend;

		public bool Enabled;

		public Dictionary<string, bool> Channels;

		public static string ToJSON(StatsRecord value)
		{
			return null;
		}

		public static StatsRecord FromJSON(string str)
		{
			return null;
		}
	}

	public enum NotifyType
	{
		RebateCardRedeeming = 1,
		IAPBundleCountdown = 2,
		FreeGachaCooldown_0 = 10,
		FreeGachaCooldown_1 = 11,
		FreeGachaCooldown_2 = 12,
		FreeGachaCooldown_Max = 13,
		Retention_0 = 20,
		Retention_1 = 21,
		Retention_2 = 22,
		Retention_3 = 23,
		Retention_4 = 24,
		Retention_Max = 25,
		Veteran_Activate = 30,
		Veteran_Reminder = 31,
		NewPlayerActivity = 32,
		BooyahDayActivity = 33,
		WebView = 34,
		LiveTvEsport = 35,
		EsportsAnnouncement = 36,
		ActivityStart_0 = 40,
		ActivityStart_1 = 41,
		ActivityStart_2 = 42,
		ActivityStart_3 = 43,
		ActivityStart_4 = 44,
		ActivityStart_5 = 45,
		ActivityStart_6 = 46,
		ActivityStart_7 = 47,
		ActivityStart_MAX = 48,
		BackGroundDownloadEnd = 50,
		BackGroundDownloadStart = 51,
		BackGroundDonwloadFailed = 52,
		ClanWarNotify = 53,
		ActivityTemplateStart_0 = 60,
		ActivityTemplateStart_1 = 61,
		ActivityTemplateStart_2 = 62,
		ActivityTemplateStart_3 = 63,
		ActivityTemplateStart_4 = 64,
		ActivityTemplateStart_5 = 65,
		ActivityTemplateStart_6 = 66,
		ActivityTemplateStart_7 = 67,
		ActivityTemplateStart_MAX = 68,
		NB2_Collect1 = 70,
		NB2_Collect2 = 71,
		NB2_Collect3 = 72,
		NB2_Collect4 = 73,
		NB2_Collect5 = 74,
		NB2_Collect6 = 75,
		NewbieRetention_Day2 = 80,
		NewbieRetention_Day3 = 81,
		ClanWarNotify_0 = 100,
		ClanWarNotify_1 = 101,
		ClanWarNotify_2 = 102,
		ClanWarNotify_3 = 103,
		ClanWarNotify_4 = 104,
		ClanWarNotify_5 = 105,
		ClanWarNotify_6 = 106,
		ClanWarNotify_7 = 107,
		ClanWarNotify_8 = 108,
		ClanWarNotify_9 = 109,
		ClanWarNotify_10 = 110,
		ClanWarNotify_11 = 111,
		ClanWarNotify_12 = 112,
		ClanWarNotify_13 = 113,
		ClanWarNotify_14 = 114,
		ClanWarNotify_15 = 115,
		ClanWarNotify_Max = 116,
		SparkPet_Dormant = 117,
		SparkPet_Extinguished = 118
	}

	public class NotifyInfo
	{
		public delegate string ReturnUrl(object[] parameters);

		public string ChannelId;

		public string LocKey_ChannelName;

		public string LocKey_ChannelDescription;

		public Func<string> Title;

		public Func<string> Content;

		public PlatformUtility.LocalNotificationImportance ChannelImportance;

		public Func<int> MaxRandomDelay_MS;

		public ReturnUrl Url;

		public Func<string> DisableRegions;
	}

	private class NotifyChannel
	{
		public string NameKey;

		public string DescKey;

		public PlatformUtility.LocalNotificationImportance Importance;
	}

	public class NotifyConfiguration
	{
		public bool DefaultNotify;
	}

	[Serializable]
	private class NotifyData
	{
		public bool DoNotify;
	}

	private enum Action
	{
		UnscheduleAll,
		Unschedule,
		Schedule
	}

	private class _Task
	{
		public Action Action;

		public NotifyType Type;

		public long TimeMS;

		public int Times;

		public int IntervalMS;

		public string Title;

		public string Content;

		public string DeepLink;

		public string Channel;

		public string GUID;

		public Action<bool, string> Callback;

		private _Task()
		{
		}

		public static _Task Schedule(NotifyType type, long time_ms, int times, int interval_ms, string title = "", string content = "", string deeplink = "")
		{
			return null;
		}

		public static _Task Unschedule(NotifyType type)
		{
			return null;
		}

		public static _Task ScheduleWithCallback(NotifyType type, long time_utc_ms, int times, int interval_ms, string title, string content, string deeplink, string channel, Action<bool, string> callback)
		{
			return null;
		}

		public static _Task UnscheduleWithCallback(NotifyType type, string guid, Action<bool, string> callback)
		{
			return null;
		}

		public static _Task UnscheduleAll()
		{
			return null;
		}
	}

	private enum AuthroizationPhase
	{
		None,
		Getting,
		Authorizing,
		Done
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<KeyValuePair<string, bool>, EventLogger.EventLocalNotificationStats.Channel> _003C_003E9__18_1;

		public static Converter<KeyValuePair<int, int>, EventLogger.EventLocalNotificationStats.TypeCount> _003C_003E9__18_2;

		public static Converter<KeyValuePair<int, int>, EventLogger.EventLocalNotificationStats.TypeCount> _003C_003E9__18_3;

		public static PermissionUtility.OnPermissionsResult _003C_003E9__61_1;

		public static Action<bool> _003C_003E9__61_0;

		public static Action<bool, string> _003C_003E9__68_0;

		public static Action<bool, string> _003C_003E9__72_0;

		internal EventLogger.EventLocalNotificationStats.Channel _003C_SendStatsEventLog_003Eb__18_1(KeyValuePair<string, bool> c)
		{
			return null;
		}

		internal EventLogger.EventLocalNotificationStats.TypeCount _003C_SendStatsEventLog_003Eb__18_2(KeyValuePair<int, int> r)
		{
			return null;
		}

		internal EventLogger.EventLocalNotificationStats.TypeCount _003C_SendStatsEventLog_003Eb__18_3(KeyValuePair<int, int> r)
		{
			return null;
		}

		internal void _003C_AuthorizeAndExecute_003Eb__61_0(bool hasPermission)
		{
		}

		internal void _003C_AuthorizeAndExecute_003Eb__61_1(Dictionary<int, bool> results)
		{
		}

		internal void _003C_Schedule_003Eb__68_0(bool result, string msg)
		{
		}

		internal void _003C_Unschedule_003Eb__72_0(bool result, string msg)
		{
		}

		internal string _003C_002Ecctor_003Eb__77_0()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_1()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_2(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_3()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_4()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_5()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_6()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_7(object[] parameters)
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_8()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_9()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_10()
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_11()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_12()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_13()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_14()
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_15()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_16()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_17()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_18()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_19(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_20()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_21()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_22()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_23()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_24(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_25()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_26()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_27()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_28()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_29(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_30()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_31()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_32()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_33()
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_34()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_35()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_36()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_37()
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_38()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_39()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_40()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_41()
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_42()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_43()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_44()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_45()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_46(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_47()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_48()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_49()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_50()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_51(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_52()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_53()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_54()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_55()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_56(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_57()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_58()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_59()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_60()
		{
			return null;
		}

		internal string _003C_002Ecctor_003Eb__77_61(object[] parameters)
		{
			return null;
		}

		internal int _003C_002Ecctor_003Eb__77_62()
		{
			return 0;
		}

		internal string _003C_002Ecctor_003Eb__77_63()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public StatsRecord now;

		internal bool _003C_SendStatsEventLog_003Eb__0(KeyValuePair<string, bool> lastPair)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public _Task task;

		internal void _003C_Schedule_003Eb__0(bool result, string msg)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public _Task task;

		internal void _003C_Unschedule_003Eb__0(bool result, string msg)
		{
		}
	}

	private static readonly DateTime APOCH_UTC;

	public static readonly int MSPerDay;

	private const string PLAYER_PREFS_KEY_STATS_RECORD = "LocalNotifyStatsRecord";

	private static bool _ShouldSendStatsEventLog;

	public const string DEFAULT_CHANNEL_ID = "FF_DEFAULT_CHANNEL_ID";

	public const string DEFAULT_CHANNEL_NAME = "T_48_HQ_NOTICE";

	public const string DEFAULT_CHANNEL_DESC = "T_48_HQ_NOTICE_DESC";

	private static readonly Dictionary<string, NotifyChannel> _NotifyChannels;

	private const bool DEFAULT_NOTIFY = true;

	private static readonly Dictionary<int, NotifyConfiguration> _NotifyConfigurations;

	private static readonly Dictionary<int, NotifyInfo> _NotifyInfos;

	private static readonly int[] _AuthorizationPermissions;

	private static AuthroizationPhase _AuthorizationPhase;

	private static PlatformUtility.LocalNotificationAuthorizationStatus _AuthorizationStatus;

	private static Queue<_Task> _PendingTasks;

	private static _Task _ExecutingTask;

	private static readonly char[] DISABLE_BY_REGION_SEPARATORS;

	public static long CurrentUTCTimeStampMS => 0L;

	private static long SendStatsEventLogInterval => 0L;

	private static StatsRecord LastSentStatsRecord
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void Init()
	{
	}

	public static void AfterLoginServer()
	{
	}

	private static void LogDelayRecords()
	{
	}

	private static void SetupTimeout()
	{
	}

	public static void CheckSendStatsEventLog()
	{
	}

	private static string IntToNotifyType(int notifyType)
	{
		return null;
	}

	private static void _SendStatsEventLog(PlatformUtility.LocalNotificationAuthorizationStatus status)
	{
	}

	private static void Log(string log)
	{
	}

	private static void LogError(string log)
	{
	}

	public static TimeSpan UTC_To_Local()
	{
		return default(TimeSpan);
	}

	private static long TimeStampMS(DateTime dateTime)
	{
		return 0L;
	}

	public static long NextTimeStampMS_Local(long notifyTimeOfDay_Local_MS)
	{
		return 0L;
	}

	public static long NextTimeStampMS_UTC(long notifyTimeOfDay_UTC_MS)
	{
		return 0L;
	}

	private static bool IsMultiTask(NotifyType notifyType)
	{
		return false;
	}

	public static string GetPrefKey(NotifyType notifyType)
	{
		return null;
	}

	public static bool IsSupported()
	{
		return false;
	}

	public static NotifyConfiguration GetNotifyConfiguration(NotifyType type)
	{
		return null;
	}

	public static void SetNotifyConfiguration(NotifyType type, NotifyConfiguration configuration)
	{
	}

	public static NotifyInfo GetNotifyInfo(NotifyType type)
	{
		return null;
	}

	public static void SetNotifyInfo(NotifyType type, NotifyInfo info)
	{
	}

	private static NotifyData GetNotifyData(NotifyType notifyType)
	{
		return null;
	}

	private static void SetNotifyData(NotifyType notifyType, NotifyData notifyData)
	{
	}

	public static void ScheduleDailyWithLocalTimeOfDay(NotifyType notifyType, int hour, int minute, int second, int times, int firstDay = 0)
	{
	}

	public static void ScheduleDailyWithLocalTimeOfDay_MS(NotifyType notifyType, long timeOfDayMS, int times, int firstDay = 0)
	{
	}

	public static long PositiveRemainder(long a, long b)
	{
		return 0L;
	}

	public static bool GetShouldNotify(NotifyType notifyType)
	{
		return false;
	}

	public static void SetShouldNotify(NotifyType notifyType, bool shouldNotify)
	{
	}

	private static void _AddToPendingTasks(_Task task)
	{
	}

	private static void _ProcessPendingTasks()
	{
	}

	private static void _AuthorizeAndExecute()
	{
	}

	public static void ScheduleMultiTask(NotifyType notifyType, string channel, long time_utc_ms, int times, int interval_ms, string title, string content, string deeplink, Action<bool, string> callback)
	{
	}

	public static void UnscheduleMultiTask(NotifyType notifyType, string guid, Action<bool, string> callback)
	{
	}

	public static void Schedule(NotifyType notifyType, long time_ms, int times, int interval_ms, bool isUTC = true, string overrideTitle = "", string overrideContent = "")
	{
	}

	private static bool _DisabledByRegion(NotifyType notifyType)
	{
		return false;
	}

	private static void _Schedule(_Task task)
	{
	}

	private static void _Schedule(NotifyType notifyType, long time_ms, int times, int interval_ms, string overrideTitle = "", string overrideContent = "")
	{
	}

	private static void _Scheduled()
	{
	}

	public static void Unschedule(NotifyType notifyType)
	{
	}

	private static void _Unschedule(_Task task)
	{
	}

	private static void _Unschedule(NotifyType notifyType)
	{
	}

	private static void _Unscheduled()
	{
	}

	public static void UnscheduleAll()
	{
	}

	private static void _UnscheduleAll()
	{
	}

	public static void LocalNotifyPlayTest()
	{
	}
}
