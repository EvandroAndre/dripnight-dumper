using System.Collections.Generic;

namespace proto;

public class CSAccountLifeSeasonStats
{
	public ulong account_id;

	public uint championship_type;

	public List<AccountSeasonStats> stats;
}
