using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopBasicInfoRes
{
	public List<WorkshopSubscribeSlotInfo> subscribe_slots_info;

	public bool workshop_banned;

	public bool is_manager;

	public List<WorkshopAuthorSlotInfo> author_slots_info;

	public WorkshopAdvancedEditorAccountDesc workshop_advanced_editor_account_desc;

	public uint author_tag;

	public uint max_author_slot_id;

	public uint[] unlock_author_slot_ids;

	public ulong editor_max_cost;

	public ResourceStoreLimit resource_store_limit;

	public bool enable_publish_monetization_map;

	public WorkshopCreatorStats creator_stats;

	public uint creator_add_slots;

	public CreatorPrivilegeSwitches privilege_switches;

	public uint creator_slots_id_from;

	public GalleryShow.SocialMediaType show_media;

	public GallerySocialMediaInfo media_info;
}
