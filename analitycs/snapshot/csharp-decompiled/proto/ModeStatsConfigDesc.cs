namespace proto;

public class ModeStatsConfigDesc
{
	public uint game_mode;

	public uint season_id;

	public bool cs_rank_display;

	public bool br_rank_display;

	public bool kill_display;

	public bool death_display;

	public bool assist_display;

	public bool kda_display;

	public bool matches_display;

	public uint gopos;

	public string sub_gopos;

	public uint order;

	public uint size;

	public uint[] score_keys;

	public uint[] score_params;

	public long start_time;

	public long end_time;

	public ELeaderboard.LeaderboardMainType main_type;
}
