using System.Collections.Generic;

namespace proto;

public class CSGetPVELeaderboardSettingRes
{
	public List<PVEDifficultyAttributeRuleDesc> difficulty_attr_rules;

	public List<PVELeaderboardRewardDesc> leaderboard_rewards;
}
