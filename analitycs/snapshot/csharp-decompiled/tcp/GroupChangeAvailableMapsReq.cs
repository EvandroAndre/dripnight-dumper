using System.Collections.Generic;

namespace tcp;

public class GroupChangeAvailableMapsReq
{
	public ulong group_id;

	public uint[] available_maps;

	public uint[] unavailable_game_modes;

	public List<MapVersionInfo> map_versions;
}
