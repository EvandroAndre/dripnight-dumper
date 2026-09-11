using ProtoBuf;

namespace proto;

public class CSPeakTournamentSeasonInfoDesc : IMessage
{
	public uint id;

	public string season_name;

	public long season_open_timestamp;

	public long season_end_timestamp;

	public string daily_open_time;

	public string daily_end_time;

	public uint starting_rp;

	public uint map_id;

	public uint[] season_award_preview_point;

	public uint end_countdown;

	public uint rank;

	public uint pre_rank;

	public long reward_end_timestamp;

	public long title_end_timestamp;

	public long leaderboard_award_offset_sec;

	public string name_id;

	public uint peak_point_display;

	public string season_open_time;

	public string season_end_time;

	public uint last_season_rank;

	public uint open_countdown;

	public uint pre_group_mode;

	public uint special_offseason;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
