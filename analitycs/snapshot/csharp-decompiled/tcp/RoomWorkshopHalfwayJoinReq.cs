using System.Collections.Generic;

namespace tcp;

public class RoomWorkshopHalfwayJoinReq
{
	public ulong target_room_id;

	public string code;

	public List<AccountIDCPingInfo> ping_list;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public uint[] available_maps;

	public List<MapVersionInfo> map_versions;

	public string language;

	public RoomPlatformDetail platform_detail;

	public ulong original_room_id;

	public ulong inviter_id;

	public string gp_player_id;

	public ulong target_account_id;

	public uint join_type;
}
