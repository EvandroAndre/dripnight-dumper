namespace proto;

public class ELeaderboard
{
	public enum LeaderboardMainType
	{
		Leaderboard_REGULAR = 0,
		Leaderboard_RANKING_SCORE = 1,
		Leaderboard_RANKING_KILLS = 2,
		Leaderboard_RANKING_WIN_COUNT = 3,
		Leaderboard_CASUAL_KILLS = 4,
		Leaderboard_CASUAL_WIN_COUNT = 5,
		Leaderboard_ELITEPASS_BADGE = 6,
		Leaderboard_GIFT_STORE = 7,
		Leaderboard_CHAMPIONSHIP_TRIAL_SCORE = 8,
		Leaderboard_CHAMPIONSHIP_TRIAL_KILLS = 9,
		Leaderboard_LIMITED_EVENT = 10,
		Leaderboard_CS_RANKING_KILLS = 11,
		Leaderboard_CS_RANKING_WINS = 12,
		Leaderboard_CS_RANKING_SCORE = 13,
		Leaderboard_PERIODIC_RANKING_SCORE = 14,
		Leaderboard_AREA_BR_WEAPON_POWER = 15,
		Leaderboard_AREA_CS_WEAPON_POWER = 16,
		Leaderboard_HUNTINGGROUND_DAMAGE = 17,
		Leaderboard_HUNTINGGROUND_PASS_TIME = 18,
		Leaderboard_RANKING_KD = 19,
		Leaderboard_CS_RANKING_KD = 20,
		Leaderboard_PVE_EVERLASTING_ROUNDS = 21,
		Leaderboard_PVE_TOTAL_SCORE = 22,
		Leaderboard_PVE_HIGHEST_STAGE_CLEAR_SCORE = 23,
		Leaderboard_HIPPO_CRISIS_RANKING_SCORE = 24,
		Leaderboard_HIPPO_CRISIS_PLAYER_WORTH = 25,
		Leaderboard_HIPPO_CRISIS_PLAYER_PROFIT = 26,
		Leaderboard_MODE_STATS_SCORE = 27,
		Leaderboard_PRIME_TOTAL = 28,
		Leaderboard_PRIME_ANNUAL = 29,
		Leaderboard_PRIME_MONTHLY = 30,
		Leaderboard_CS_PEAK_SCORE = 31,
		Leaderboard_AREA_CS_PEAK_SCORE = 32,
		Leaderboard_CS_PEAK_SCORE_WEEK = 33,
		Leaderboard_CLAN_HONOR = 1001,
		Leaderboard_CLAN_RACE = 1003,
		Leaderboard_CLAN_WAR = 1004,
		Leaderboard_AREA_CLAN_ACTIVENESS = 1005,
		Leaderboard_AREA_GUILD_WAR = 1006,
		Leaderboard_CLAN_ACTIVENESS = 1007,
		Leaderboard_CLAN_ACTIVENESS_WEEK = 1008,
		Leaderboard_AREA_RANKING_SCORE = 1009,
		Leaderboard_AREA_CS_RANKING_SCORE = 1010,
		Leaderboard_AREA_GUILD_WAR_TOURNAMENT = 1011,
		Leaderboard_REGION_GUILD_WAR = 1012
	}

	public enum LeaderboardBanType
	{
		BanType_NONE = 0,
		BanType_RANKING = 1,
		BanType_WEAPON = 2,
		BanType_PVE = 3,
		BanType_CLAN_ACTIVENESS = 4,
		BanType_GUILD_WAR = 5,
		BanType_AREA_CLAN_ACTIVENESS = 6,
		BanType_GUILD_WAR_TOURNAMENT = 8,
		BanType_HIPPO_CRISIS_RANKING = 9,
		BanType_MODE_STATS = 10,
		BanType_HIPPO_CRISIS_PLAYER_PROFIT = 11,
		BanType_HIPPO_CRISIS_PLAYER_WORTH = 12,
		BanType_CS_PEAK_SCORE = 13,
		BanType_PRIME = 14
	}

	public enum LeaderboardUnrankedReasonType
	{
		UnrankedReason_NONE,
		UnrankedReason_NOT_OPEN,
		UnrankedReason_LOW_LEVEL,
		UnrankedReason_LOW_KILLS,
		UnrankedReason_HIGH_KD,
		UnrankedReason_HIGH_HEADSHOTRATE,
		UnrankedReason_HIGH_BULLETHEADSHOTRATE,
		UnrankedReason_LOW_GAMESPLAYED
	}
}
