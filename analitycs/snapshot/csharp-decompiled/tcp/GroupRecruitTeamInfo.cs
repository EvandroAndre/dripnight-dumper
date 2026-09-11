using System.Collections.Generic;

namespace tcp;

public class GroupRecruitTeamInfo
{
	public ulong group_id;

	public bool map_pool_bonus;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatch.GroupMode group_mode;

	public uint[] tags;

	public uint special_mode_event_id;

	public List<GroupRecruitTeamMemberInfo> members;

	public long last_update_time;

	public string recruit_code;

	public uint min_rank;

	public uint max_rank;

	public uint[] limit_occupations;
}
