namespace tcp;

public class GroupSpectateRoomReq
{
	public ulong room_id;

	public string code;

	public ulong group_id;

	public bool is_solo;

	public EGroup.RoomType room_type;
}
