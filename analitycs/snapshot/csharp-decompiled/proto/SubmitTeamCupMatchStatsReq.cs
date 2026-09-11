namespace proto;

public class SubmitTeamCupMatchStatsReq
{
	public ulong match_id;

	public string lock_region;

	public string noti_region;

	public CupMatchStats stats;
}
