using System.Collections.Generic;

namespace proto;

public class CSClanLeaderboardAreaChooseRes
{
	public uint area_id;

	public long choose_area_time;

	public List<ClanAreaLeaderboardInfo> leaderboards;
}
