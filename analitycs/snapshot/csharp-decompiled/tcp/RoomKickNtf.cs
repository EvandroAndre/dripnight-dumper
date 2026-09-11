using System.Collections.Generic;

namespace tcp;

public class RoomKickNtf
{
	public RoomPlayerInfo kick_player_info;

	public RoomInfo room_info;

	public List<RoomPlayerInfo> kick_player_infos;
}
