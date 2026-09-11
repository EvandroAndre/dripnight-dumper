using System.Collections.Generic;

namespace tcp;

public class RoomSetReadyNtf
{
	public ulong room_id;

	public List<RoomPlayerInfo> players;
}
