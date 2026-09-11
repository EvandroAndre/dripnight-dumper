using System;
using UnityEngine;

namespace GCommon;

public static class DateTimeUtil
{
	private static bool s_GetDateTimeNowInStartUp;

	private static readonly object s_AndroidTicksOffsetLock;

	private static bool s_HasAndroidTicksOffset;

	private static long s_AndroidTicksOffset;

	private static bool s_CurrentThreadAttachedToJvm;

	public static readonly int SECONDS_DAILY;

	public static readonly int SECONDS_HOUR;

	public static readonly int SECONDS_MINUTE;

	public static readonly int MICROSECONDS_PER_SECOND;

	public static readonly int MILLISECONDS_PER_SECOND;

	private const string TIME_FORMAT_MD = "{0:D2}.{1:D2}";

	private const string TIME_FORMAT_YMD = "{0:D2}.{1:D2}.{2:D2}";

	private const string TIME_FORMAT_HMS = "{0:D2}:{1:D2}:{2:D2}";

	private const string TIME_FORMAT_HM = "{0:D2}:{1:D2}";

	private const string TIME_FORMAT_MS = "{0:D2}:{1:D2}";

	private const string DAY_STRING = "TXT_IVENTORY_OUTEXPIRE_TIME_3";

	private const string MINUTES_AGO_STRING = "TXT_OB5_TIME_MINUTE";

	private const string HOURS_AGO_STRING = "TXT_OB5_TIME_HOUR";

	private const string DAYS_AGO_STRING = "TXT_OB5_TIME_WEEK";

	private const string ONE_WEEKS_AGO_STRING = "TXT_OB5_TIME_LONGTIME";

	private const string TODAY_STRING = "TXT_CHAT_TIME_TODAY";

	private const string YESTERDAY_STRING = "TXT_CHAT_TIME_YESTERDAY";

	private const string BEFORE_STRING = "TXT_CHAT_TIME_BEFORE";

	private const string TIME_DAYFORMAT = "{0}/{1} {2:D2}:{3:D2}";

	private static DateTime utcStartDataTime;

	private static long serverTimeDelta;

	private static ulong baseServerRealTime;

	private static long timezone_offset_secs;

	private static bool reportedHttpDate;

	public static DateTime UTCStartDateTime => default(DateTime);

	public static void InvalidateAndroidTimeZoneCache()
	{
	}

	private static bool EnsureAndroidJniThreadAttached()
	{
		return false;
	}

	private static TimeSpan GetAndroidNowUtcOffsetFromUtcNow(DateTime utcNow)
	{
		return default(TimeSpan);
	}

	private static DateTime ConvertDateTimeToUtcByAndroidOffset(DateTime dateTime)
	{
		return default(DateTime);
	}

	private static DateTime ConvertUtcDateTimeToLocalByAndroidOffset(DateTime utcTime)
	{
		return default(DateTime);
	}

	public static ulong GetCurrentLocalTimeStampSeconds()
	{
		return 0uL;
	}

	public static double GetCurrentLocalTimeStampMilliseconds()
	{
		return 0.0;
	}

	public static ulong GetCurrentTimeStamp()
	{
		return 0uL;
	}

	public static ulong GetCurrentServerRealTime()
	{
		return 0uL;
	}

	public static ulong GetNextDaysHourTimeStamp(int days, int hour, bool hasLimit)
	{
		return 0uL;
	}

	public static ulong GetToday4AMTimeStamp()
	{
		return 0uL;
	}

	public static ulong GetNext4AMTimeStamp()
	{
		return 0uL;
	}

	public static ulong GetCertain4AMTimeStamp(ulong timeStamp)
	{
		return 0uL;
	}

	public static ulong GetTodayTargetHourTimeStamp(int hour)
	{
		return 0uL;
	}

	public static double GetCurrentTimeStampMilliseconds()
	{
		return 0.0;
	}

	public static DateTime GetCurrentDateTime()
	{
		return default(DateTime);
	}

	public static DateTime GetDateTime(ulong timestamp)
	{
		return default(DateTime);
	}

	public static DateTime GetDateTimeMs(ulong timestamp)
	{
		return default(DateTime);
	}

	public static DateTime GetDateTimeNowInStartUp()
	{
		return default(DateTime);
	}

	public static DateTime GetDateTimeNow()
	{
		return default(DateTime);
	}

	public static DateTime GetCurrentChinaStandardDateTime()
	{
		return default(DateTime);
	}

	public static DateTime GetRegionServerDateTime(long region_timezone_offset_secs)
	{
		return default(DateTime);
	}

	public static ulong GetRegionServerDateTimeStamp(long region_timezone_offset_secs, DateTime dateTime)
	{
		return 0uL;
	}

	public static void SetServerTimeDelta(ulong serverTime)
	{
	}

	public static void TryReportFirstHttpDate(WWW www)
	{
	}

	public static void SetTimezoneOffset(long timezone_offset_secs)
	{
	}

	public static int ConvertDateTimeToTimeStamp(DateTime dateTime)
	{
		return 0;
	}

	public static int ConvertDateTimeToTimeStampWithServerTimezone(DateTime dateTime)
	{
		return 0;
	}

	public static long ConvertDateTimeToLongTimeStamp(DateTime dateTime)
	{
		return 0L;
	}

	public static double ConvertDataTimeToTimsStampMilliseconds(DateTime dateTime)
	{
		return 0.0;
	}

	public static DateTime CovertUtcDateTimeToCurrentTimeZoneDateTime(DateTime utcTime)
	{
		return default(DateTime);
	}

	public static string ConvertDateTimeToYMD(DateTime time)
	{
		return null;
	}

	public static string ConvertDateTimeToYM(DateTime time)
	{
		return null;
	}

	public static string ConvertDateTimeToMD(DateTime time)
	{
		return null;
	}

	public static string ConvertDateTimeToHM(DateTime time)
	{
		return null;
	}

	public static string ConvertRecordTimeBySecond(ulong totalSecond)
	{
		return null;
	}

	public static void ConvertRecordTimeBySecondToDHMS(ulong totalSecond, out ulong day, out ulong hour, out ulong minute, out ulong second)
	{
		day = default(ulong);
		hour = default(ulong);
		minute = default(ulong);
		second = default(ulong);
	}

	public static DateTime CovertChinaStandardDateTimeToCurrentTimeZoneDateTime(DateTime chinaTime)
	{
		return default(DateTime);
	}

	public static DateTime CovertUtcDateTimeToChinaStandardDateTime(DateTime utcTime)
	{
		return default(DateTime);
	}

	public static DateTime CovertChinaStandardDateTimeToUtcDateTime(DateTime chinaTime)
	{
		return default(DateTime);
	}

	public static DateTime CovertTimeSpanToChinaStandardDateTime(double timeSpan)
	{
		return default(DateTime);
	}

	public static DateTime CovertTimeSpanToDateTime(double timeSpan)
	{
		return default(DateTime);
	}

	public static string FormatTimeStampItem(double timeStamp, bool isBefore = false)
	{
		return null;
	}

	public static string FormatTimeStampCD(double timeStamp, bool isBefore = false, bool needSec = true)
	{
		return null;
	}

	public static string FormatShortTimeStampCDMSOnly(double timeStamp, bool showHour = false)
	{
		return null;
	}

	public static string FormatShortTimeStampCDBySeconds(ulong seconds, bool showHour = false)
	{
		return null;
	}

	public static string FormatSquadTreasureTimeStamp(double timeStamp)
	{
		return null;
	}

	public static string FormatShortTimeStampCD(double timeStamp, bool showHour = false)
	{
		return null;
	}

	public static string FormatShortTimeHMStampCD(double timeStamp, bool showHour = false)
	{
		return null;
	}

	public static string FormatFuzzyTimeStampCD(double timeStamp, bool showHour = false)
	{
		return null;
	}

	public static int GetCurrentWeekNum()
	{
		return 0;
	}

	public static string TimeStampCD(double timeStamp)
	{
		return null;
	}

	public static string ChatSendTime(ulong timeStamp)
	{
		return null;
	}

	public static string ClanTrendSendTime(ulong timeStamp)
	{
		return null;
	}

	public static bool IsBetweenStartEndTime(ulong startStamp, ulong endStamp, bool both0 = true)
	{
		return false;
	}

	public static bool IsBetweenStartEndTime(ulong curStamp, ulong startStamp, ulong endStamp, bool both0 = true)
	{
		return false;
	}

	public static string ToString(DateTime dateTime, string formatStr)
	{
		return null;
	}

	public static DateTime ConverToDateTime(string formatStr)
	{
		return default(DateTime);
	}

	public static uint GetTomorrowServerTimeOffset(int hour, bool adjust = false)
	{
		return 0u;
	}

	public static bool IsSameDay(ulong timeStamp1, ulong timeStamp2)
	{
		return false;
	}

	public static bool IsSameYear(long timeStamp1, long timeStamp2)
	{
		return false;
	}

	public static int GetDaysNumByDateTime(DateTime dateTime)
	{
		return 0;
	}

	public static void RecordKeyShowedToday(string key)
	{
	}

	public static bool CheckKeyShowedToday(string key)
	{
		return false;
	}

	public static uint GetDaysLeftInThisMonth()
	{
		return 0u;
	}

	public static bool IsTimestampExpired(ulong timestamp, ulong intervalSeconds, ulong lastTimestamp)
	{
		return false;
	}

	public static bool IsTimestampExpiredByDays(ulong timestamp, ulong intervalDays, ulong lastTimestamp)
	{
		return false;
	}
}
