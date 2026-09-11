using System.Collections.Generic;

namespace proto;

public class UGCTeamStats
{
	public ulong team_index;

	public int team_score;

	public uint team_rank;

	public bool is_quit;

	public List<UGCPlayerStats> all_teammates;
}
