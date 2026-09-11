using System.Collections.Generic;

namespace proto;

public class WorkshopReviewResult
{
	public WorkshopDirtyWords dirty_words;

	public WorkshopDirtyPictures dirty_pictures;

	public EWorkshop.ReviewResult result;

	public WorkshopDirtyPictures dirty_screenshots;

	public List<WorkshopWebAuditInfo> web_audit_infos;

	public long update_time;

	public bool is_map_cover_detect_failed;
}
