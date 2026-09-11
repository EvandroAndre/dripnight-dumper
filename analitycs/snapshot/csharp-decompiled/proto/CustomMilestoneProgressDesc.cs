using System.Collections.Generic;

namespace proto;

public class CustomMilestoneProgressDesc
{
	public enum StageType
	{
		StageTypeNormal,
		StageTypeJackpot,
		StageTypeCircle
	}

	public uint custom_event_id;

	public uint stage_id;

	public uint stage_type;

	public string unlock_time;

	public uint stage_distance;

	public uint share_id;

	public List<AwardDesc> award_items;

	public uint icon_lock_cdn_id;

	public uint icon_cdn_id;

	public uint icon_claimed_cdn_id;

	public uint num_loc_id;

	public uint line_bg_cdn_id;

	public uint line_progress_cdn_id;

	public string effect_id;

	public uint unlock_timestamp;

	public uint progress_bg_cdn_id;

	public uint num_lock_loc_id;
}
