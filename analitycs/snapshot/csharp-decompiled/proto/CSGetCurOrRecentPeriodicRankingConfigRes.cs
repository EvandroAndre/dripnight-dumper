using System.Collections.Generic;

namespace proto;

public class CSGetCurOrRecentPeriodicRankingConfigRes
{
	public PeriodicRankingSeasonInfoDesc season_info;

	public List<PeriodicRankAwardsDesc> awards;

	public bool openingState;

	public List<PeriodicProtectionDesc> protections;
}
