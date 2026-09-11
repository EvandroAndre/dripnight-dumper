namespace tcp;

public class RoomSwitchSeatReq
{
	public ulong room_id;

	public ulong account_id;

	public ERoom.PlayerRole to_role;

	public uint to_room_pos;

	public uint to_group_pos;

	public ERoom.Type room_type;
}
