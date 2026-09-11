using ProtoBuf;

namespace proto;

public class RankingMatchParam : IMessage
{
	public int solo_chicken_points;

	public int dual_chicken_points;

	public int squad_chicken_points;

	public int knockdown_points;

	public int revive_points;

	public uint solo_battle_score_limit;

	public uint solo_kill_add;

	public uint solo_kill_multi;

	public uint group_battle_score_limit;

	public uint group_kill_add;

	public uint group_kill_multi;

	public uint damage_per_score;

	public int down_points;

	public int fratricide_points;

	public uint first_win_rank;

	public uint first_win_kill;

	public uint ranking_token_id;

	public uint most_token_given;

	public float ranking_extra_coins;

	public float ranking_extra_exp;

	public int birth_island_quit_deduct;

	public uint rp_range_add_bp_lower;

	public uint rp_range_add_bp_upper;

	public int relife_teammate_points;

	public int be_relife_points;

	public uint min_rank_show;

	public int revive_points_max;

	public int relife_points_max;

	public int heal_per_score;

	public int heal_score_max;

	public float br_multi_map_buff_ratio;

	public uint br_multi_map_buff_rank_point_max;

	public string region;

	public int death_points;

	public uint min_rank_sort_id_show;

	public uint grandmaster_show_rank_timeout_limit;

	public uint br_max_keep_season_count;

	public uint bot_knockdown_points;

	public uint bot_solo_kill_add;

	public uint bot_group_kill_add;

	public uint solo_king_points;

	public uint dual_king_points;

	public uint squad_king_points;

	public uint recent_performance_match_count;

	public uint recent_performance_min_match_count;

	public uint ob44_dragon_boss_points;

	public uint max_bot_point;

	public uint default_player_count;

	public double br_ranking_score_power;

	public uint min_player_count;

	public uint max_player_count;

	public uint supreme_sword_king_kill_point;

	public uint supreme_sword_king_kill_point_limit;

	public uint supreme_sword_kill_king_point;

	public uint smurf_upgrade_min_rank;

	public uint smurf_upgrade_max_rp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
