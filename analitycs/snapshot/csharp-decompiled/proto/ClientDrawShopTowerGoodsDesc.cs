using ProtoBuf;

namespace proto;

public class ClientDrawShopTowerGoodsDesc : IMessage
{
	public uint draw_shop_id;

	public uint id;

	public EInventory.AwardType reward_item_type;

	public uint item_id;

	public uint item_num;

	public uint item_duration;

	public bool rare_item;

	public bool is_remove;

	public uint drop_limit;

	public uint repeat_change_item_id;

	public uint repeat_change_item_num;

	public uint repeat_change_item_id_2;

	public uint repeat_change_item_num_2;

	public bool token_flag;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
