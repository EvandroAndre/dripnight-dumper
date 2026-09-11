using System.Collections.Generic;

namespace proto;

public class RankingFixedMMRInfo
{
	public uint scaled_mmr;

	public int streak_fix;

	public int performance_fix;

	public List<RankingMMRPreGroupFixInfo> pre_group_fix_info;

	public List<RankingMMRMultiModeFixInfo> multi_mode_fix_info;
}
