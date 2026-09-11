namespace tcp;

public class GroupRecruitReq
{
	public ulong group_id;

	public uint min_rank;

	public uint max_rank;

	public bool map_pool_bonus;

	public uint[] tags;

	public uint special_mode_event_id;

	public bool send_world;

	public bool send_guild;

	public uint[] limit_occupations;

	public uint source;

	public bool send_newbie;
}
