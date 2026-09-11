using System.Collections.Generic;

namespace proto;

public class CSTeamLifeSeasonStats
{
	public ulong team_id;

	public uint championship_type;

	public List<TeamSeasonStats> stats;
}
