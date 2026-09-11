using ProtoBuf;

namespace proto;

public class DrawShopTowerRewardDesc : IMessage
{
	public uint draw_shop_id;

	public uint cdt_value;

	public uint rare_reward;

	public EInventory.AwardType award_type;

	public uint award_id;

	public uint award_num;

	public uint award_time;

	public EInventory.AwardType repeat_change_item_type;

	public uint repeat_change_item_id;

	public uint repeat_change_item_num;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
