namespace proto;

public class WorkshopInfo
{
	public byte[] workshop_settings;

	public string workshop_code;

	public WorkshopBasicInfo workshop_basic_info;

	public byte[] object_attribute_settings;

	public string project_settings_url;

	public string export_settings_url;

	public WorkshopRoomFreeInfo workshop_room_free_info;

	public bool allow_quick_join;

	public WorkshopTagMatchInfo tag_match_info;

	public byte[] open_attributes;

	public WorkshopLocalization localization;

	public WorkshopMatchmakingRule matchmaking_rule;

	public ShortWorkshopCodeInfo short_workshop_code_info;

	public uint resource_perm_mark;
}
