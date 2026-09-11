using System.Collections.Generic;

namespace tcp;

public class CSRankingFixedMMRInfo
{
	public int win_rate_fix;

	public int streak_fix;

	public int performance_fix;

	public List<RankingMMRPreGroupFixInfo> pre_group_fix_info;

	public List<CSRankingMMRMultiModeFixInfo> multi_mode_fix_info;

	public List<PlayerLevelMMRFixInfo> level_fix_info;
}
