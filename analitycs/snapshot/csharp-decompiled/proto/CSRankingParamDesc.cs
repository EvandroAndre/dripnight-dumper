using ProtoBuf;

namespace proto;

public class CSRankingParamDesc : IMessage
{
	public uint games_played;

	public float win_rate;

	public uint min_games;

	public uint mail_warning;

	public uint ban_cs_ranking;

	public float combine_KD;

	public float combine_Headshot;

	public uint min_rank_show;

	public uint protect_point_compensation_limit;

	public float cs_multi_map_buff_ratio;

	public float KD;

	public uint min_rank;

	public uint cs_multi_map_buff_protection_point_max;

	public uint max_protection_point;

	public uint max_quick_upgrade_rank_point;

	public uint min_rank_sort_id_show;

	public uint min_rank_sort_id;

	public uint grandmaster_show_rank_timeout_limit;

	public uint cs_max_keep_season_count;

	public uint recent_performance_match_count;

	public uint recent_performance_min_match_count;

	public uint max_bot_point;

	public uint new_sorting_season_id;

	public uint supreme_sword_king_kill_asst_protect_point;

	public uint supreme_sword_king_kill_asst_protect_point_limit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
