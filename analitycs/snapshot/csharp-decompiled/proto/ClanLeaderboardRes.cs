using System.Collections.Generic;

namespace proto;

public class ClanLeaderboardRes
{
	public List<ClanLeaderboardItem> items;

	public ClanLeaderboardItem self;

	public uint leaderboard_size;
}
