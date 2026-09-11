namespace tcp;

public class GroupGetRecruitListReq
{
	public string language;

	public bool map_pool_bonus;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatch.GroupMode group_mode;

	public uint br_rank;

	public uint cs_rank;

	public ulong[] group_ids;

	public uint special_mode_event_id;

	public EGroup.RecruitListType list_type;

	public uint min_rank;

	public bool is_all_mode;

	public uint[] limit_occupations_br;

	public uint[] limit_occupations_cs;

	public ulong group_id;

	public uint hippo_rank;

	public uint cs_peak_points;

	public RecruitPlayerBasicInfo recruit_player_basic_info;
}
