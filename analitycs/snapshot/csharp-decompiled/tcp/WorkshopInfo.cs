namespace tcp;

public class WorkshopInfo
{
	public string workshop_name;

	public ulong perf_cost;

	public byte[] workshop_settings;

	public ulong resource_statistics;

	public long last_update_time;

	public string workshop_code;

	public string author_name;

	public ulong like_count;

	public ulong subscribe_count;

	public string workshop_desc;

	public ulong author_id;

	public byte[] mode_settings;

	public EMatch.GroupMode group_mode;

	public uint[] tags;

	public byte[] object_attribute_settings;

	public EMatch.GameMode game_mode;

	public uint team_count;

	public byte[] mini_map_settings;

	public byte[] mini_map_object_settings;

	public string export_settings_url;

	public uint map_id;

	public uint mode_template_id;

	public bool allow_quick_join;

	public uint heat_value;

	public byte[] open_attributes;

	public string map_cover_url;

	public uint min_player_cnt;

	public uint min_est_play_time;

	public uint max_est_play_time;

	public float like_rate;

	public string sub_desc;

	public bool has_data_storage;

	public uint map_order;

	public uint[] time_limited_tags;

	public long notify_subscriber_time;

	public ShortWorkshopCodeInfo short_workshop_code_info;

	public uint resource_perm_mark;

	public uint area_id;

	public uint hide_mini_map;

	public uint[] label_id;

	public uint[] map_label_id;

	public uint genre_id;

	public uint show_in_game_friend_detail;

	public string original_workshop_code;

	public uint play_count;

	public bool use_heat_value;

	public uint creator_level;

	public CreatorPrivilegeSwitches creator_privilege_switches;
}
