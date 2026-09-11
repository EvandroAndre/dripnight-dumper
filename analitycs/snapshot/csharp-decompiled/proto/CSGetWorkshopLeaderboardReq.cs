using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopLeaderboardReq
{
	public string workshop_code;

	public List<string> leaderboard_name;

	public string language;
}
