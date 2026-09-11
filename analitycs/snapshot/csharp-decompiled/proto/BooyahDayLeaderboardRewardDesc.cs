using System.Collections.Generic;

namespace proto;

public class BooyahDayLeaderboardRewardDesc
{
	public uint id;

	public uint rank_type;

	public uint rank_lower;

	public uint rank_upper;

	public List<AwardDesc> awards;
}
