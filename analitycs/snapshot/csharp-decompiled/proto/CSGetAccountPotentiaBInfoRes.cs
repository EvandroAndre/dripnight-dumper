using System.Collections.Generic;

namespace proto;

public class CSGetAccountPotentiaBInfoRes
{
	public uint pool_leaderboard_id;

	public List<PotentiaBDimension> five_dimensional_value;

	public uint[] claimed_star_process_ids;

	public bool friend_leaderboard_claimed;
}
