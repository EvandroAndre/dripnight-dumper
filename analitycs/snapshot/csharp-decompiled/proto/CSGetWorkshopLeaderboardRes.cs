using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopLeaderboardRes
{
	public string workshop_code;

	public List<WorkshopLeaderboard> leaderboard;

	public uint size;
}
