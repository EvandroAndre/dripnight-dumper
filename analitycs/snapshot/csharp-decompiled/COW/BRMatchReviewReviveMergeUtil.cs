using System.Collections.Generic;
using message;

namespace COW;

public static class BRMatchReviewReviveMergeUtil
{
	public static List<HJNFDCJPPDE> BuildMergedReviveDisplayEvents(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	public static HJNFDCJPPDE CreateMergedReviveEventIfNeeded(List<HJNFDCJPPDE> events, int eventIndex, HashSet<int> mergedReviveEventIndices, Dictionary<int, BRMatchReviewDisplayEvent> mergedReviveDisplayEvents)
	{
		return null;
	}

	public static bool ContainsVisibleRevivedPlayer(HJNFDCJPPDE evt, HashSet<uint> visiblePlayerFilter)
	{
		return false;
	}

	public static bool ContainsRevivedPlayer(HJNFDCJPPDE evt, uint playerId)
	{
		return false;
	}

	public static bool TryGetRevivedPlayerId(HJNFDCJPPDE evt, out uint revivedPlayerId)
	{
		revivedPlayerId = default(uint);
		return false;
	}

	private static bool IsReviveMergeCandidate(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsSameReviveMergeEvent(HJNFDCJPPDE root, HJNFDCJPPDE candidate)
	{
		return false;
	}

	private static bool IsSingleActorReviveSubType(HIMPICPLPMB subType)
	{
		return false;
	}

	private static void AddUniquePlayerId(List<uint> playerIds, uint playerId)
	{
	}
}
