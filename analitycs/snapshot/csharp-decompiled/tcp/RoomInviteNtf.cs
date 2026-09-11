namespace tcp;

public class RoomInviteNtf
{
	public ulong room_id;

	public RoomPlayerInfo inviter_info;

	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public ulong owner_id;

	public ERoom.Type room_type;

	public bool auto_accept;

	public string room_name;

	public uint round_id;

	public string esports_icon;
}
