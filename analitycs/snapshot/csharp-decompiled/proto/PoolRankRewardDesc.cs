using System.Collections.Generic;

namespace proto;

public class PoolRankRewardDesc
{
	public uint id;

	public uint rank_upper;

	public uint rank_lower;

	public List<AwardDesc> awards;
}
