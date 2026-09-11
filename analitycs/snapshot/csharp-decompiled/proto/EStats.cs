namespace proto;

public class EStats
{
	public enum MissionType
	{
		MissionType_NONE,
		MissionType_UPGRADE_LEVEL
	}

	public enum DailyMatchRewardConfigID
	{
		DailyMatchRewardConfigID_NONE,
		DailyMatchRewardConfigID_SOLO_TOPN,
		DailyMatchRewardConfigID_DUO_TOPN,
		DailyMatchRewardConfigID_QUAD_TOPN,
		DailyMatchRewardConfigID_FIRST_MATCH
	}

	public enum DailyMatchRewardType
	{
		DailyMatchRewardType_NONE,
		DailyMatchRewardType_OUTSTANDING,
		DailyMatchRewardType_FIRST_MATCH
	}

	public enum RelationMaskPos
	{
		RelationMaskPos_FRIEND = 0,
		RelationMaskPos_CONDFIDANT = 1,
		RelationMaskPos_MENTOR = 2,
		RelationMaskPos_STUDENT = 3,
		RelationMaskPos_MAX = 32
	}

	public enum CSRankingDrawType
	{
		CSRankingDrawType_NONE,
		CSRankingDrawType_NORMAL,
		CSRankingDrawType_INVALID_GAMETIME,
		CSRankingDrawType_HACKER,
		CSRankingDrawType_HACKER_TEAMMATE,
		CSRankingDrawType_HACKER_OPPONENT,
		CSRankingDrawType_HACKER_PREGROUP_TEAMMATE,
		CSRankingDrawType_HACKER_2,
		CSRankingDrawType_HACKER_2_TEAMMATE,
		CSRankingDrawType_HACKER_2_OPPONENT,
		CSRankingDrawType_HACKER_2_PREGROUP_TEAMMATE,
		CSRankingDrawType_HACKER_3,
		CSRankingDrawType_HACKER_3_OTHERS
	}

	public enum SpectateRewardType
	{
		SpectateRewardType_NONE,
		SpectateRewardType_COIN,
		SpectateRewardType_GEM
	}

	public enum SpectateRewardSource
	{
		SpectateRewardSource_FRIEND,
		SpectateRewardSource_DEAD_PLAYER
	}
}
