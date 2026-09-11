namespace tcp;

public class RoomBasicInfo
{
	public ulong id;

	public string name;

	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public uint cur_member_num;

	public uint max_member_num;

	public uint cur_spectator_num;

	public uint max_spectator_num;

	public uint state;

	public bool need_code;

	public uint banner;

	public uint color;

	public uint icon;

	public ERoom.Type room_type;

	public uint level_visual_style;

	public bool enable_emulator_check;

	public uint owner_role;

	public bool is_cs_advanced;

	public uint language;

	public bool contestant_role_check;

	public uint room_setting;

	public uint[] workshop_tags;

	public string workshop_name;

	public uint mode_template_id;

	public string workshop_code;

	public uint min_player_level;

	public string workshop_map_cover_url;

	public string sub_desc;

	public bool has_workshop_room_settings;

	public uint[] workshop_time_limited_tags;

	public long notify_subscriber_time;

	public ulong clan_id;

	public bool is_room_afk_open;

	public ERoom.Class room_class;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint room_setting2;

	public uint room_setting3;

	public byte[] room_preview_setting;

	public bool enable_score_board;

	public bool enable_skill_bp;
}
