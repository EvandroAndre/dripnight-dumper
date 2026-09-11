using System.Collections.Generic;

namespace proto;

public class AreaLeaderboardInfo
{
	public class SubInfo
	{
		public ulong sub_key;

		public long next_award_time;
	}

	public ELeaderboard.LeaderboardMainType main_type;

	public List<SubInfo> subs;
}
