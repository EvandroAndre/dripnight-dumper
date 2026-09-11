namespace proto;

public class ERanking
{
	public enum ActivityType
	{
		ActivityType_NONE,
		ActivityType_NO_DEDUCT,
		ActivityType_DOUBLE_RANKING_POINT,
		ActivityType_DOUBLE_TOKEN
	}

	public enum RankingType
	{
		RankingType_NONE,
		RankingType_NORMAL,
		RankingType_CS,
		RankingType_PERIODIC,
		RankingType_HIPPOCRISIS,
		RankingType_CSPEAK
	}

	public enum RankingCardType
	{
		CardType_DOUBLE_RANKING_POINT,
		CardType_NO_DEDUCT_PONIT,
		CardType_NO_DEDUCT_RANK,
		CardType_CLAN_BONUS,
		CardType_GROUP_NO_DEDUCT_PONIT,
		CardType_DOUBLE_BONUS
	}

	public enum RankingMedalType
	{
		RankingMedalType_NONE,
		RankingMedalType_GOLD,
		RankingMedalType_SILVER
	}

	public enum QuickUpgradeType
	{
		QuickUpgradeType_NONE,
		QuickUpgradeType_SMURF,
		QuickUpgradeType_GOLD_MEDAL,
		QuickUpgradeType_SILVER_MEDAL
	}

	public enum SeasonReplayEventType
	{
		SeasonReplayEventType_NONE,
		SeasonReplayEventType_MAX_DAMAGE,
		SeasonReplayEventType_MAX_KILLS,
		SeasonReplayEventType_MAX_BOOYAH,
		SeasonReplayEventType_MAX_SHORT_LIVED,
		SeasonReplayEventType_MAX_CS_STREAK_WIN,
		SeasonReplayEventType_MAX_CS_STREAK_LOSE,
		SeasonReplayEventType_FIRST_TIME_GM,
		SeasonReplayEventType_MAX_RESURRECT_TEAMMATE,
		SeasonReplayEventType_MAX_GAMES_PLAYED,
		SeasonReplayEventType_MAX_BR_STREAK_WIN,
		SeasonReplayEventType_MAX_MVP_COUNT,
		SeasonReplayEventType_MAX_VEHICLE_KILLS,
		SeasonReplayEventType_LATEST_GAME_TIME,
		SeasonReplayEventType_MAX_REVIVAL_COUNT,
		SeasonReplayEventType_MAX_THROWING_KILLS
	}

	public enum SeasonReplayWeaponTag
	{
		SeasonReplayWeaponTag_NONE,
		SeasonReplayWeaponTag_MOST_USED,
		SeasonReplayWeaponTag_MOST_DAMAGE,
		SeasonReplayWeaponTag_MOST_KILLS
	}

	public enum RankChangeReason
	{
		RankChangeReason_NONE,
		RankChangeReason_PROCESS_MATCH_STATS,
		RankChangeReason_GMTOOL_DELTA,
		RankChangeReason_GMTOOL_RESET
	}

	public enum WinPassType
	{
		WinPassType_COUNT_GAME,
		WinPassType_COUNT_WIN_GAME
	}

	public enum WinPassStatus
	{
		WinPassStatus_NONE,
		WinPassStatus_FINISHED,
		WinPassStatus_CLAIMED
	}

	public enum MultiPointScoreType
	{
		MultiPointScoreType_NONE,
		MultiPointScoreType_BOOYAH,
		MultiPointScoreType_RANK,
		MultiPointScoreType_BATTLE,
		MultiPointScoreType_REVIVE,
		MultiPointScoreType_RELIF,
		MultiPointScoreType_HEAL_TEAMMATE,
		MultiPointScoreType_RP_GAP_BONUS,
		MultiPointScoreType_DAILY_TASK,
		MultiPointScoreType_SPECIAL_TASK,
		MultiPointScoreType_VETERAN
	}
}
