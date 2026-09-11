namespace tcp;

public class GroupGetNewbieRecruitTeamReq
{
	public ulong group_id;

	public string language;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatch.GroupMode group_mode;

	public uint br_rank;

	public uint cs_rank;

	public uint special_mode_event_id;

	public uint hippo_rank;

	public uint cs_peak_points;

	public bool map_pool_bonus;

	public uint max_rank;
}
