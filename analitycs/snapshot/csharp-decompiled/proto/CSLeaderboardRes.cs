using System.Collections.Generic;

namespace proto;

public class CSLeaderboardRes
{
	public List<LeaderboardItem> items;

	public LeaderboardItem self;

	public uint leaderboard_size;
}
