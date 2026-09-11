namespace tcp;

public class RoomDismissNtf
{
	public ulong leaver_id;

	public ulong room_id;

	public ERoom.DismissReason reason;
}
