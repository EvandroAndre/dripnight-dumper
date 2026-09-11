using System.Collections.Generic;

namespace proto;

public class PVELeaderboardRewardDesc
{
	public uint leaderboard_id;

	public uint main_type;

	public uint game_mode;

	public List<string> regions;

	public uint lower_rank;

	public uint higher_rank;

	public List<AwardDesc> awards;
}
