using System.Collections.Generic;

namespace proto;

public class PeriodicRankAwardsDesc
{
	public uint game_mode;

	public uint rank;

	public List<AwardDesc> level_awards;
}
