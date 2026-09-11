using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopAuthorInfoRes
{
	public List<WorkshopAuthorSlotInfo> author_slots_info;

	public WorkshopAccountInfo account_info;

	public ulong author_id;

	public uint[] label_ids;

	public string workshop_kol_content;

	public WorkshopCreatorStats creator_stats;

	public GalleryShow.SocialMediaType show_media;

	public GallerySocialMediaInfo media_info;
}
