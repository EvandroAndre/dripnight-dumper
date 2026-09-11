using System.Collections.Generic;
using proto;
using tcp;

namespace COW;

public static class GamePassFacade
{
	public enum GamePassType
	{
		ElitePass,
		BooyahPass
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public EPChallengesUpdateInfo item;

		internal bool _003CGetCurChallengeChangeInfo_003Eb__0(EPChallengeInfo d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_1
	{
		public EPChallengesUpdateInfo item;

		internal bool _003CGetCurChallengeChangeInfo_003Eb__1(EPWeeklyQuestInfo d)
		{
			return false;
		}
	}

	public static bool IsGamePassBooyahPass => false;

	public static ulong CurEventEndTime => 0uL;

	public static ulong DailyResetTime => 0uL;

	public static Dictionary<uint, uint> DailyProcessInfoDict => null;

	public static List<EPDailyProcessRewardDesc> DailyProcessDescList => null;

	public static EPProcess_Status DailyProcessStatus
	{
		get
		{
			return EPProcess_Status.PS_ONGOING;
		}
		set
		{
		}
	}

	public static List<MatchResultTaskInfo> CurFinishChallengeInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static List<MatchResultTaskInfo> CurGoingChallengeInfoList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool NeedGetEPInfoFromEPChallenge
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Dictionary<uint, ChallengeStatus> ChallengeStatus => null;

	public static uint HasFininshedDailyProcessNum
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private static void GetWeeklyDescByWeekID(uint weekId, ref List<EPWeeklyQuestInfo> weeklyDesc)
	{
	}

	public static uint GetCurGamePassEventID()
	{
		return 0u;
	}

	public static bool IsFreePass()
	{
		return false;
	}

	public static uint BadgeGrade()
	{
		return 0u;
	}

	public static List<EPChallengeInfo> GetChallengeInfoListByType(ChallengeType type)
	{
		return null;
	}

	public static void ClaimChallengeReward(List<uint> challengeIDs, ChallengeType challengeType, uint challengeGroup, uint nodeID = 0u)
	{
	}

	public static void GetCurChallengeChangeInfo(EPChallengesUpdateNtf updateInfo)
	{
	}

	public static List<EPWeeklyQuestInfo> GetAllWeekWeeklyQuestInfo()
	{
		return null;
	}

	private static void SetDailyChestGoingAndFinishedList(bool hasFinishBRDailyTaskThisMatch, bool hasFinishCSDailyTaskThisMatch)
	{
	}

	public static bool IsShowMatchResultChallengeWnd()
	{
		return false;
	}

	public static void ClearCurChallengeInfo()
	{
	}

	public static void RequestClaimChallengeRewardInMatchResult(List<uint> challengeIDs)
	{
	}

	public static int UpdateRelatedRedDot()
	{
		return 0;
	}
}
