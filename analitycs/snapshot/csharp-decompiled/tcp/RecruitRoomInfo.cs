namespace tcp;

public class RecruitRoomInfo
{
	public ulong room_id;

	public ERoom.Type room_type;

	public uint game_mode;

	public uint group_mode;

	public uint map_id;

	public uint cur_member_num;

	public uint max_member_num;

	public string recruit_code;

	public bool send_world;

	public bool send_guild;

	public string owner_nickname;
}
