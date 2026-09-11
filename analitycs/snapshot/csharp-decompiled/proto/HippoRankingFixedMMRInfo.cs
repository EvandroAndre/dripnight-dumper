using System.Collections.Generic;

namespace proto;

public class HippoRankingFixedMMRInfo
{
	public List<HippoRankingMMRPerformanceFixInfo> performance_fix;

	public List<RankingMMRPreGroupFixInfo> pre_group_fix_info;

	public List<HippoRankingMMRMultiModeFixInfo> multi_mode_fix_info;
}
