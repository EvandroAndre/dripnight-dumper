using System.Collections.Generic;

namespace proto;

public class TeamLeaderboardRes
{
	public List<TeamLeaderboardItem> items;

	public TeamLeaderboardItem self;

	public uint leaderboard_size;
}
