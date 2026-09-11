using System;
using proto;

namespace COW;

internal static class NewBieDailyQuizUtility
{
	private const int RefreshHour = 4;

	private static readonly DateTime RegionUtcStartTime;

	private const int RewardTypeItem = 1;

	private const int RewardTypeCoins = 2;

	public static EInventory.AwardType GetRewardAwardType(RookieAnswer quizData)
	{
		return EInventory.AwardType.AwardType_NONE;
	}

	public static uint GetRewardItemId(RookieAnswer quizData)
	{
		return 0u;
	}

	public static BaseItemInfo CreateRewardItem(RookieAnswer quizData)
	{
		return null;
	}

	public static string GetDisplayText(string content)
	{
		return null;
	}

	public static int GetCurrentQuestionDay()
	{
		return 0;
	}

	public static string GetCurrentQuestionDate()
	{
		return null;
	}

	private static DateTime GetQuestionDateTime(ulong timestamp)
	{
		return default(DateTime);
	}

	public static ulong GetRefreshTimestamp(ulong timestamp)
	{
		return 0uL;
	}

	public static long GetServerTimezoneOffset()
	{
		return 0L;
	}

	private static ulong GetRefreshTimestamp(ulong timestamp, long serverTimezoneOffset)
	{
		return 0uL;
	}
}
