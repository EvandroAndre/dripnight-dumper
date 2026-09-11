using System.Collections.Generic;

namespace proto;

public class BooyahDayProcessRewardDesc
{
	public uint id;

	public ulong progress;

	public List<AwardDesc> award_items;
}
