using System.Collections.Generic;

namespace tcp;

public class RoomLeaveNtf
{
	public RoomInfo room_info;

	public List<RoomPlayerInfo> leave_players;
}
