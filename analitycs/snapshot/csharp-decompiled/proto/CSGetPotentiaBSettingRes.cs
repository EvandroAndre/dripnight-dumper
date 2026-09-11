using System.Collections.Generic;

namespace proto;

public class CSGetPotentiaBSettingRes
{
	public List<PotentiaBFiveDimensionalDesc> five_dimensional;

	public PotentiaBSettingDesc setting;

	public List<PotentiaBStarRewardDesc> star_reward;

	public List<PoolRankRewardDesc> pool_rank_reward;

	public List<ClientPotentiaBBooyahRuleDesc> booyah_point_rule;
}
