using ProtoBuf;

namespace proto;

public class RelayMartShopDesc : IMessage
{
	public uint relay_mart_id;

	public uint item_id;

	public uint item_num;

	public uint item_duration;

	public uint item_price;

	public uint sort_id;

	public string big_reward_vfx;

	public uint mart_goods_id;

	public bool if_big_reward;

	public string big_reward_cdn_icon_small;

	public string big_reward_cdn_icon_big_bg;

	public string big_reward_cdn_icon_big_item;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
