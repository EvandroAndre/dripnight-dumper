namespace tcp;

public class RoomGetRecruitListReq
{
	public ERoom.Type room_type;

	public uint level;

	public ulong[] room_id_list;

	public ERoom.RecruitListType list_type;

	public bool is_all_mode;
}
