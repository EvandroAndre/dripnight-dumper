using System.Collections.Generic;

namespace proto;

public class AccountLeaderboardRes
{
	public List<AccountLeaderboardItem> items;

	public AccountLeaderboardItem self;

	public uint leaderboard_size;
}
