using System.Collections.Generic;

namespace proto;

public class WorkshopBasicInfo
{
	public string workshop_name;

	public ulong author_id;

	public ulong perf_cost;

	public long update_time;

	public ulong resource_statistics;

	public string author_name;

	public ulong like_count;

	public ulong subscribe_count;

	public string workshop_desc;

	public uint game_mode;

	public uint group_mode;

	public uint[] tags;

	public byte[] mode_settings;

	public uint team_count;

	public byte[] mini_map_settings;

	public byte[] mini_map_object_settings;

	public uint map_id;

	public EWorkshop.EditorType editor_type;

	public WorkshopCommentInfo comment_info;

	public uint mode_template_id;

	public bool allow_recreation;

	public uint heat_value;

	public string map_cover_url;

	public long notify_subscriber_time;

	public uint ob_version;

	public long create_time;

	public float like_rate;

	public uint min_est_play_time;

	public uint max_est_play_time;

	public ulong dislike_count;

	public bool has_data_storage;

	public string sub_desc;

	public uint map_order;

	public uint[] time_limited_tags;

	public WorkshopMatchmakingRule matchmaking_rule;

	public uint area_id;

	public uint hide_mini_map;

	public long lock_start_time;

	public long lock_end_time;

	public uint pass_audit;

	public uint[] label_id;

	public uint[] map_label_id;

	public bool is_map_cover_auditing;

	public string workshop_code;

	public bool enable_preview;

	public WorkshopReferenceIndicators reference_indicators;

	public WorkshopMapContentInfo workshop_name_content;

	public WorkshopMapContentInfo workshop_desc_content;

	public List<string> platform_leaderboard_names;

	public List<WorkshopLabelEffectiveTimeInfo> label_ids_info;

	public List<WorkshopLabelEffectiveTimeInfo> map_label_ids_info;

	public WorkshopCoverPermission cover_permission;

	public uint[] genre_ids;

	public bool is_map_translation_enabled;

	public uint show_in_game_friend_detail;

	public string original_workshop_code;

	public uint play_count;

	public bool use_heat_value;

	public uint map_cover_pass_audit;

	public bool is_global;

	public string map_region;

	public string map_center_region;

	public uint creator_level;

	public CreatorPrivilegeSwitches creator_privilege_switches;
}
