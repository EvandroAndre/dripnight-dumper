using System.Collections.Generic;

namespace proto;

public class CSGetUploadWorkshopURLReq
{
	public string workshop_name;

	public ulong performance_cost;

	public uint slot_id;

	public ulong resource_statistics;

	public string workshop_desc;

	public uint game_mode;

	public byte[] mode_settings;

	public uint group_mode;

	public uint[] tags;

	public uint team_count;

	public byte[] mini_map_settings;

	public byte[] mini_map_object_settings;

	public ulong project_settings_size;

	public ulong export_settings_size;

	public uint map_id;

	public List<WorkshopWordFilter> filter_contents;

	public uint mode_template_id;

	public EWorkshop.SlotType slot_type;

	public uint ob_version;

	public string original_workshop_code;

	public byte[] open_attributes;

	public ulong open_attributes_ext_size;

	public ulong map_cover_size;

	public string map_cover_ext;

	public string language;

	public bool notify_subscriber;

	public WorkshopMatchmakingRule matchmaking_rule;

	public List<WorkshopDataStorage> data_storage;

	public List<WorkshopLeaderboard> leader_board;

	public WorkshopReferenceIndicators reference_indicators;

	public uint area_id;

	public uint hide_mini_map;

	public string map_screenshot_ext;

	public ulong[] map_screenshot_sizes;

	public bool enable_preview;

	public List<WorkshopChecklistScoreDetail> checklist_detail;

	public uint checklist_score;

	public byte[] map_extra_settings;

	public List<string> platform_leaderboard_names;

	public bool allow_recreation;

	public bool is_default_map_name;

	public bool is_default_map_description;

	public uint[] genre_ids;

	public bool update_map_cover;

	public bool is_map_translation_enabled;

	public uint show_in_game_friend_detail;

	public bool is_auto_save_enabled;

	public ulong project_original_creator_id;

	public long project_create_ts;

	public List<string> project_modification_records;
}
