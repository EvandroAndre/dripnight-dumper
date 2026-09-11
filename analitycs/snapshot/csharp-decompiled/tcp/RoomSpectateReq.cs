using System.Collections.Generic;

namespace tcp;

public class RoomSpectateReq
{
	public ulong room_id;

	public string code;

	public ulong group_id;

	public bool is_solo;

	public List<JoinRoomPlayerInfo> players;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public ERoom.Type room_type;

	public string language;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<MapVersionInfo> map_versions;
}
