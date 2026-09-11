using System.Collections.Generic;

namespace proto;

public class GetPlayerListCSRankingStatsReq
{
	public ulong[] account_ids;

	public uint season_id;

	public uint game_mode;

	public string lock_region;

	public List<string> lock_regions;
}
