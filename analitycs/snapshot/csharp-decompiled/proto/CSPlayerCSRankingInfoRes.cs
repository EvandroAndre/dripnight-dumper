using System.Collections.Generic;

namespace proto;

public class CSPlayerCSRankingInfoRes
{
	public ulong account_id;

	public uint season_id;

	public uint rank;

	public uint max_rank;

	public uint ranking_points;

	public bool show_rank;

	public uint star;

	public uint hang_ups;

	public bool is_hang_up_ban;

	public uint star_protect_points;

	public uint games_played;

	public CSRankingInfo last_season_info;

	public uint peak_rank_pos;

	public uint cs_ranking_bot_points;

	public bool reset_reward;

	public uint season_reset_rank;

	public uint battle_points;

	public uint streak_wins;

	public uint actual_battle_points;

	public bool use_battle_points;

	public uint rank_sort_id;

	public uint max_rank_sort;

	public bool show_cs_rank;

	public uint heroic_count;

	public uint rewarded_rank_sort;

	public uint battle_point_lower;

	public uint battle_point_upper;

	public int streak_result_total;

	public bool can_show_season_replay;

	public VeteranCSRankingMMDecayInfo veteran_cs_ranking_mm_decay_infos;

	public uint mmr;

	public uint rank_master_level;

	public bool can_show_season_replay_btn;

	public RankingWinPass win_pass;

	public uint rank_group;

	public uint star_protect_extra_score;

	public bool have_protect_card;

	public bool possible_upgrade_rank;

	public bool possible_upgrade_rank_group;

	public bool possible_lower_rank;

	public bool have_full_pre_group_protect;

	public List<MapProtectionCnt> map_protection_cnt;

	public uint max_ranking_points;

	public uint last_season_max_rp;
}
