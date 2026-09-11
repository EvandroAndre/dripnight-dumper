using ProtoBuf;

namespace proto;

public class CSRankingSeasonInfoDesc : IMessage
{
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

	public bool heroic_mark_switch;

	public string new_season_tip;

	public string season_reward_bg_url;

	public uint award_sessions;

	public uint[] season_award_preview_rank;

	public uint big_reward_id;

	public string season_name_url;

	public bool show_season_theme;

	public string season_theme_name;

	public uint end_count_down;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
