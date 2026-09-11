using System.Collections.Generic;

namespace proto;

public class BigEventProgressAwardDesc
{
	public uint event_id;

	public uint event_part_id;

	public uint progress;

	public List<AwardDesc> award_items;

	public uint cdnid;

	public uint open_cdnid;
}
