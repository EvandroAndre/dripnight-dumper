namespace tcp;

public class RoomOwnerSwitchGroupReq
{
	public ulong room_id;

	public uint from_group_pos;

	public ulong from_group_id;

	public uint to_group_pos;

	public ulong to_group_id;

	public ERoom.Type room_type;
}
