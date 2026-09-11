namespace tcp;

public class RoomChangeReq
{
	public ulong room_id;

	public string room_name;

	public string code;

	public uint map_id;

	public uint game_mode;

	public uint max_member_num;

	public uint max_spectator_num;

	public bool enable_death_spectate;

	public bool enable_group_icon;

	public uint level_visual_style;

	public uint room_setting;

	public uint room_setting2;

	public ERoom.Type room_type;

	public byte[] cs_advanced_setting;

	public uint werewolves_room_param;

	public uint werewolves_room_param2;

	public uint werewolves_room_param3;

	public byte[] spectate_settings;

	public string workshop_code;

	public long workshop_update_time;

	public uint workshop_map_source;

	public uint workshop_map_scene;

	public byte[] workshop_room_settings;

	public uint min_player_level;

	public bool is_cs_advanced;

	public bool is_room_afk_open;

	public bool is_sole_active_skill;

	public uint room_setting3;

	public ERoom.Class room_class;

	public bool enable_score_board;

	public bool enable_limited_event_gameplay;

	public bool enable_skill_bp;

	public bool enable_cs_zone_select;

	public byte[] cs_zone_select;

	public bool show_win_rate;
}
