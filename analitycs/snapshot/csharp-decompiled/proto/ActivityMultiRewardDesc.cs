using System.Collections.Generic;

namespace proto;

public class ActivityMultiRewardDesc
{
	public uint activity_id;

	public uint[] cdt_value_range;

	public List<AwardDesc> awards;
}
