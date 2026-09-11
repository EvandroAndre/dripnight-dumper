using ProtoBuf;

namespace proto;

public class ClanDiamondAwardSettingDesc : IMessage
{
	public uint diamond_cost;

	public long duration;

	public long buy_limit;

	public uint item_id;

	public uint get_reward_activity;

	public long expired_remind;

	public bool clan_diamond_award_switch;

	public string store_cdn_small;

	public string claim_cdn_big;

	public string share_cdn_big;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
