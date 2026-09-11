namespace proto;

public class SubmitChampionshipTeamMatchStatsReq
{
	public ulong match_id;

	public uint championship_type;

	public uint team_count;

	public TeamMatchStats team_stats;

	public uint create_time;

	public uint end_time;

	public string noti_region;

	public string lock_region;

	public bool is_fake;
}
