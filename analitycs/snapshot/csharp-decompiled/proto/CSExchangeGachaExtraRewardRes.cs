using System.Collections.Generic;

namespace proto;

public class CSExchangeGachaExtraRewardRes
{
	public uint[] exchanged_reward_list;

	public List<ExchangedAward> extra_rewards;

	public List<ItemTagInfo> new_tag_items;
}
