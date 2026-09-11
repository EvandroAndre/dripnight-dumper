using System.Collections.Generic;

namespace proto;

public class BigEventProgressCycleAwardDesc
{
	public uint event_id;

	public uint event_part_id;

	public uint cycle_progress;

	public List<AwardDesc> award_items;

	public uint max_num;

	public uint cdnid;
}
