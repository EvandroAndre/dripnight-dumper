using System.Collections.Generic;

namespace proto;

public class AreaLeaderboardDescRes
{
	public List<RegionAreaLeaderboardDesc> region_leaderboard_desc;

	public List<AreaLeaderboardAwardDesc> awards;

	public List<AreaLeaderboardTitleDesc> titles;

	public List<RegionLeaderboardAwardDesc> region_awards;
}
