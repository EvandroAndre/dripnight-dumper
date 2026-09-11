namespace tcp;

public class SocialLeaderbord
{
	public class LeaderboardData
	{
		public uint br_rank;

		public uint cs_rank;

		public float br_head_kill_rate;

		public uint br_streak_wins;

		public uint cs_streak_wins;

		public uint ep_level;

		public uint clan_weekly_activeness;

		public uint guild_war_points;

		public uint br_peak_rank_pos;

		public uint cs_peak_rank_pos;

		public uint br_ranking_points;

		public uint cs_ranking_points;

		public int prime_annually_points;
	}

	public enum LeaderboardType
	{
		NONE,
		BR_RANK,
		CS_RANK,
		BR_HEAD_KILL_RATE,
		BR_STREAK_WINS,
		CS_STREAK_WINS,
		EP_LEVEL,
		CLAN_WEEKLY_ACTIVENESS,
		GUILD_WAR_POINTS,
		PRIME
	}
}
