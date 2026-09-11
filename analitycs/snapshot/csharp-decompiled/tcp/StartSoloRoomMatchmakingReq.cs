using System.Collections.Generic;

namespace tcp;

public class StartSoloRoomMatchmakingReq
{
	public EMatch.RoomMatchmakingType room_matchmaking_type;

	public string workshop_code;

	public uint[] workshop_tag_match_type_ids;

	public bool is_hot_map;

	public uint[] available_maps;

	public uint matchmaking_scene;

	public bool can_halfway_join;

	public string language;

	public uint topic_difficulty;

	public List<string> topic_workshop_codes;

	public bool send_gs_prepare_info_to_client;

	public ulong pre_match_id;

	public string pre_workshop_code;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<WsCodeWithWeight> weight_workshop_codes;

	public RoomPlatformDetail platform_detail;

	public string gp_player_id;

	public bool is_auto_leave_group;
}
