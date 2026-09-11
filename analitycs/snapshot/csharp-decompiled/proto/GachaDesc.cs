using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GachaDesc : IMessage
{
	public uint chest_id;

	public ClientChestType chest_type;

	public List<GachaShowItemsWithJackpot> item_list_with_jackpot;

	public List<ExtraRewardDesc> extra_rewards;

	public List<ChestRuleDesc> chest_rules;

	public SharedGachaSettingDesc shared_gacha_settings;

	public List<SharedGachaCollectRewardDesc> shared_gacha_collect_rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
