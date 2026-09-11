using System.Collections.Generic;

namespace proto;

public class AreaLeaderboardInfoWithTitle
{
	public List<RankingPlayerTitleInfo> titles;

	public List<AreaLeaderboardInfo> leaderboards;

	public bool is_first_title_receive;
}
