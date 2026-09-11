namespace tcp;

public class GroupJoinRoomReq
{
	public ulong room_id;

	public string code;

	public ulong group_id;

	public bool is_solo;

	public string group_name;

	public EGroup.RoomType room_type;

	public string group_abbr_name;

	public int[] filters;

	public uint join_type;

	public uint join_scene;

	public ulong original_room_id;

	public uint workshop_map_scene;

	public RoomPlatformDetail platform_detail;

	public string room_qr_code;

	public string recruit_code;

	public uint join_room_channel_type;
}
