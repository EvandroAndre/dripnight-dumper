namespace tcp;

public class GroupRecruitNtf
{
	public ulong group_id;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatch.GroupMode group_mode;

	public uint min_rank;

	public uint max_rank;

	public bool map_pool_bonus;

	public uint[] tags;

	public uint special_mode_event_id;

	public bool send_world;

	public bool send_guild;

	public string recruit_code;

	public GroupRecruitTeamInfo team_info;
}
