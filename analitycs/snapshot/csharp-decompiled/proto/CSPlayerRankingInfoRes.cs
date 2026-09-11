using System.Collections.Generic;

namespace proto;

public class CSPlayerRankingInfoRes
{
	public ulong account_id;

	public uint season_id;

	public uint rank;

	public uint max_rank;

	public uint ranking_points;

	public bool show_rank;

	public RankingInfo last_season_info;

	public uint match_token_num;

	public uint ranking_bot_points;

	public uint peak_rank_pos;

	public bool reset_reward;

	public uint season_reset_rank;

	public uint games_played;

	public uint streak_wins;

	public uint rank_sort_id;

	public uint max_rank_sort;

	public bool show_br_rank;

	public uint heroic_count;

	public uint rewarded_rank_sort;

	public bool can_show_season_replay;

	public uint mmr;

	public VeteranRankingMMDecayInfo veteran_ranking_mm_decay_infos;

	public uint rank_master_level;

	public bool can_show_season_replay_btn;

	public int streak_result_total;

	public RankingWinPass win_pass;

	public uint rank_group;

	public bool have_protect_card;

	public bool possible_upgrade_rank_group;

	public bool possible_upgrade_rank;

	public bool possible_lower_rank;

	public bool have_full_pre_group_protect;

	public List<MapProtectionCnt> map_protection_cnt;
}
