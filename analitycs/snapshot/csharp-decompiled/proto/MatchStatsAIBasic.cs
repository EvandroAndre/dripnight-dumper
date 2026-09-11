namespace proto;

public class MatchStatsAIBasic
{
	public class Summary
	{
		public string lock_region;

		public string noti_region;

		public ulong account_id;

		public ulong last_match_id;

		public bool is_login_first_game;

		public bool is_bot;

		public uint thirty_login_days;

		public uint account_level;

		public uint account_register_days;

		public int account_is_real_newbie;

		public ulong match_id;

		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public uint map_id;

		public uint create_time;

		public uint game_times;

		public uint end_time;

		public uint offline_cnt;

		public uint reconnect_cnt;

		public bool cs_is_win;

		public int br_score;

		public uint use_ice_wall;

		public uint medkit_use;

		public uint grenade_use;

		public uint active_skill_use_count;

		public uint mushroom_use;

		public uint avatar_id;
	}

	public class CsResult
	{
		public uint pre_star_protect_points;

		public uint cur_star_protect_points;

		public uint star_protect_extra_score;

		public uint pre_rank_group;

		public uint cur_rank_group;

		public uint pre_rank;

		public uint cur_rank;

		public uint pre_ranking_points;

		public uint cur_ranking_points;

		public uint battle_protect_points;

		public uint pre_battle_points;

		public uint survival_time;

		public uint total_rounds;

		public uint kill_cnt;

		public uint double_kills;

		public uint triple_kills;

		public uint quadra_kills;
	}

	public Summary summary;

	public CsResult cs_result;
}
