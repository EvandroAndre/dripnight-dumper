using System.Collections.Generic;

namespace proto;

public class UGCMatchStats
{
	public bool is_draw;

	public int mode_template_id;

	public ulong self_account_id;

	public ulong self_team_index;

	public int[] score_type_to_show;

	public List<UGCTeamStats> all_team_stats;

	public string map_name;

	public int[] rank_to_score_rule;

	public bool use_custom_result;

	public long vip_survival_time;
}
