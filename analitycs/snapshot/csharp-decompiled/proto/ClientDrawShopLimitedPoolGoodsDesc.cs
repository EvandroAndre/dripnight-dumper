using ProtoBuf;

namespace proto;

public class ClientDrawShopLimitedPoolGoodsDesc : IMessage
{
	public uint draw_shop_id;

	public uint pool_item_id;

	public EInventory.AwardType reward_item_type;

	public uint item_id;

	public uint item_num;

	public uint item_duration;

	public EDrawShop.RareType rare_item;

	public uint owned_change_item_type;

	public uint owned_change_item_id;

	public uint owned_change_item_num;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
