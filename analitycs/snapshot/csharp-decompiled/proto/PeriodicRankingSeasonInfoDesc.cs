namespace proto;

public class PeriodicRankingSeasonInfoDesc
{
	public uint game_mode;

	public uint id;

	public long open_time;

	public long end_time;

	public string season_name;

	public uint starting_ranking_point;

	public string map_id;

	public uint season_award_id;

	public uint season_award_rank;

	public string season_award_url;

	public string season_bg_url;

	public uint season_peak_award_id;

	public uint season_peak_award_rank;

	public long pre_dict_time;

	public string new_season_tip;

	public string season_reward_bg_url;

	public uint award_sessions;

	public uint[] season_award_preview_rank;

	public uint map_limit_num;

	public bool if_new_inherit;

	public string season_name_bg_url;

	public string season_label_gradient_top;

	public string season_label_gradient_bottom;

	public string game_mode_entrance_icon;

	public string game_mode_season_entrance_bg_url;

	public string BriefSeasonName => null;

	public string DetailedSeasonName => null;

	public bool IsThemeTitleUsed()
	{
		return false;
	}

	public string GetPreferredSeasonNameThanDetailed()
	{
		return null;
	}

	public string GetPreferredSeasonNameThanBrief()
	{
		return null;
	}
}
