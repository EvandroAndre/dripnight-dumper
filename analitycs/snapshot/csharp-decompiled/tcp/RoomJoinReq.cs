using System.Collections.Generic;

namespace tcp;

public class RoomJoinReq
{
	public ulong room_id;

	public string code;

	public ulong group_id;

	public bool is_solo;

	public List<JoinRoomPlayerInfo> players;

	public string group_name;

	public ulong inviter_account_id;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public ERoom.Type room_type;

	public string group_abbr_name;

	public int[] filters;

	public uint join_type;

	public uint join_scene;

	public uint map_scene;

	public string language;

	public RoomPlatformDetail platform_detail;

	public ulong original_room_id;

	public ulong original_group_id;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public string room_qr_code;

	public List<MapVersionInfo> map_versions;

	public string recruit_code;

	public uint join_room_channel_type;

	public string gp_player_id;
}
