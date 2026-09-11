using System.Collections.Generic;

namespace proto;

public class GameServerRoomMatchStatsReq
{
	public ulong room_id;

	public ERoom.Type room_type;

	public List<RoomGroupMatchStats> groups;
}
