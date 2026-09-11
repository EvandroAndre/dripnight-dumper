using System.Collections.Generic;
using message;

namespace COW;

public static class BRMatchReviewKillMergeUtil
{
	public const string TeamEliminatedMapNameLocKey = "T_54_TSY_MATCHREVIEW_MAP_TEAM_WIPEOUT";

	private const float DEFAULT_KILL_MERGE_RANGE = 50f;

	private const float DEFAULT_KILL_MERGE_TIME_SEC = 60f;

	public static HJNFDCJPPDE GetKillMergeAnchorEvent(HJNFDCJPPDE evt)
	{
		return null;
	}

	public static List<HJNFDCJPPDE> BuildMapMergedKillDisplayEvents(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	public static List<HJNFDCJPPDE> BuildTimelineMergedKillDisplayEvents(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static List<HJNFDCJPPDE> BuildKillMergedDisplayEvents(List<HJNFDCJPPDE> events, bool requireSameKiller, bool mergeTeamEliminatedEvents, bool keepMergedTeamEliminatedEvent)
	{
		return null;
	}

	public static List<HJNFDCJPPDE> BuildBattleLogMergedKillDisplayEvents(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static int CompareBattleLogDisplayEvents(HJNFDCJPPDE a, HJNFDCJPPDE b)
	{
		return 0;
	}

	private static int CompareKillMergeDisplayEvents(BRMatchReviewDisplayEvent a, BRMatchReviewDisplayEvent b)
	{
		return 0;
	}

	private static int CompareDisplayEventOrder(BRMatchReviewDisplayEvent a, BRMatchReviewDisplayEvent b)
	{
		return 0;
	}

	private static int CompareEventIdentity(HJNFDCJPPDE a, HJNFDCJPPDE b)
	{
		return 0;
	}

	private static int CompareMapDisplayEvents(HJNFDCJPPDE a, HJNFDCJPPDE b)
	{
		return 0;
	}

	private static int GetMapDisplayEventPriority(HJNFDCJPPDE evt)
	{
		return 0;
	}

	private static bool IsMapKillMergeCandidate(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static BRMatchReviewDisplayEvent CreateMapKillDisplayEvent(HJNFDCJPPDE evt)
	{
		return null;
	}

	private static BRMatchReviewDisplayEvent CreateKillMergeUpdateEvent(HJNFDCJPPDE evt, BRMatchReviewDisplayEvent mergeRoot, int mergeCount, string mapEventNameLocKey)
	{
		return null;
	}

	private static BRMatchReviewDisplayEvent CloneDisplayEvent(HJNFDCJPPDE evt)
	{
		return null;
	}

	private static bool IsInKillMergeRange(HJNFDCJPPDE evt, HJNFDCJPPDE mergeRoot, long mergeRangeSqr)
	{
		return false;
	}

	private static bool CanMergeKillWithRoot(HJNFDCJPPDE evt, HJNFDCJPPDE mergeRoot, long mergeTimeMs, long mergeRangeSqr, bool requireSameKiller)
	{
		return false;
	}

	private static bool IsSameKiller(HJNFDCJPPDE evt, HJNFDCJPPDE mergeRoot)
	{
		return false;
	}

	private static ulong BuildMapEventKey(HJNFDCJPPDE evt)
	{
		return 0uL;
	}
}
