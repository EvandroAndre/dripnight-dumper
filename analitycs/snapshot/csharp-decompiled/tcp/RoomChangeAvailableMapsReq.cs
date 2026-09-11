using System.Collections.Generic;

namespace tcp;

public class RoomChangeAvailableMapsReq
{
	public ulong room_id;

	public uint[] available_maps;

	public ERoom.Type room_type;

	public List<MapVersionInfo> map_versions;
}
