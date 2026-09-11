using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class LeaderBoardRankConditionManager : SingletonModule<LeaderBoardRankConditionManager>
{
	public enum ELeaderBoardRankCdtType
	{
		NONE,
		LEVEL,
		RANK,
		KILL,
		MATCH,
		KD,
		HEADSHOTKILL,
		HEADSHOT
	}

	public enum ELeaderboardRankType
	{
		BRRank,
		CSRank,
		Other
	}

	private Dictionary<int, LeaderboardRankingCdtDesc> m_LeaderBoardRankCdtDict;

	private bool m_IsInWhiteList;

	protected override void OnInit()
	{
	}

	public void ProcessData(List<LeaderboardRankingCdtDesc> cdtList)
	{
	}

	protected override void OnCleanup()
	{
	}

	public void SetIsInWhiteList(bool isInWhiteList)
	{
	}

	public LeaderboardRankingCdtDesc GetLeaderBoardRankCdt(int boardID)
	{
		return null;
	}

	public ELeaderBoardRankCdtType CheckLeaderBoardListRule(int boardID, LeaderBoardInfo playerInfo, ELeaderboardRankType rankType, uint weaponID = 0u, ulong leaderBoardID = 0uL)
	{
		return ELeaderBoardRankCdtType.NONE;
	}

	private uint GetMinScoreInLeaderBoard(List<LeaderBoardInfo> list)
	{
		return 0u;
	}

	private uint GetMinCSScoreInLeaderBoard(List<LeaderBoardInfo> list)
	{
		return 0u;
	}
}
