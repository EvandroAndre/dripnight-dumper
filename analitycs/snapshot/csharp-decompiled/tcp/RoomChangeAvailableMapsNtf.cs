using System.Collections.Generic;

namespace tcp;

public class RoomChangeAvailableMapsNtf
{
	public ulong account_id;

	public uint[] available_maps;

	public ulong room_id;

	public List<MapVersionInfo> map_versions;
}
