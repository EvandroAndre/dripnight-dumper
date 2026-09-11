using System.Collections.Generic;

namespace proto;

public class CSGetLevelRewardsRes
{
	public List<LevelRewardsDesc> level_rewards;

	public List<LevelRewardsDesc> fresh_level_rewards;

	public ulong fresh_gacha_start_timestamp;
}
