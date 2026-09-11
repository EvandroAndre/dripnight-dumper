using System.Collections.Generic;

namespace tcp;

public class GroupStartRoomMatchmakingReq
{
	public EMatch.RoomMatchmakingType room_matchmaking_type;

	public ulong group_id;

	public string workshop_code;

	public uint[] workshop_tag_match_type_ids;

	public bool is_hot_map;

	public string workshop_name;

	public uint matchmaking_scene;

	public bool can_halfway_join;

	public uint topic_difficulty;

	public List<string> topic_workshop_codes;

	public bool send_gs_prepare_info_to_client;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<WsCodeWithWeight> weight_workshop_codes;

	public RoomPlatformDetail platform_detail;
}
