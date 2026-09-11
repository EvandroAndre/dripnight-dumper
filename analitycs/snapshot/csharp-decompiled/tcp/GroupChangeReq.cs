namespace tcp;

public class GroupChangeReq
{
	public ulong group_id;

	public bool auto_group;

	public uint group_mode;

	public uint game_mode;

	public uint[] map_ids;

	public uint difficulty;

	public uint match_mode;

	public uint required_rank;

	public string group_tag;

	public string workshop_code;

	public string workshop_name;

	public uint max_required_rank;

	public EMatch.RoomMatchmakingType room_matchmaking_type;

	public uint[] workshop_tag_match_type_ids;

	public bool set_not_ready;

	public bool need_resource_download;

	public uint special_mode_event_id;

	public bool is_intra_team_battle;
}
