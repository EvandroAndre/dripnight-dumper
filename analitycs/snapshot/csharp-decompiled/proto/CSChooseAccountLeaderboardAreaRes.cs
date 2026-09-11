using System.Collections.Generic;

namespace proto;

public class CSChooseAccountLeaderboardAreaRes
{
	public uint area_id;

	public long choose_area_time;

	public List<AreaLeaderboardInfo> leaderboard_info;
}
