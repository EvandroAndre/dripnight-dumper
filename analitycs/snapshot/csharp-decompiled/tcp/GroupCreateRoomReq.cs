using System.Collections.Generic;

namespace tcp;

public class GroupCreateRoomReq
{
	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public string room_name;

	public string code;

	public uint max_member_num;

	public uint max_spectator_num;

	public bool enable_death_spectate;

	public EGroup.RoomType room_type;

	public ulong group_id;

	public bool enable_group_icon;

	public uint level_visual_style;

	public uint room_setting;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public ulong reopen_id;

	public uint room_setting2;

	public bool enable_emulator_check;

	public uint creater_role;

	public bool is_cs_advanced;

	public byte[] cs_advanced_setting;

	public uint werewolves_room_param;

	public uint werewolves_room_param2;

	public uint language;

	public bool contestant_role_check;

	public bool room_data_inherit;

	public uint werewolves_room_param3;

	public string workshop_code;

	public long workshop_update_time;

	public uint workshop_map_source;

	public byte[] spectate_settings;

	public uint workshop_map_scene;

	public bool is_solo;

	public uint min_player_level;

	public byte[] workshop_room_settings;

	public bool is_room_afk_open;

	public RoomPlatformDetail platform_detail;

	public bool is_sole_active_skill;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public uint room_setting3;

	public uint room_class;

	public bool enable_score_board;

	public List<MapVersionInfo> map_versions;

	public byte[] room_preview_setting;

	public bool enable_limited_event_gameplay;

	public bool enable_skill_bp;

	public bool enable_cs_zone_select;

	public byte[] cs_zone_select;
}
