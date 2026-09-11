using ProtoBuf;

namespace proto;

public class DrawShopWheelExchangeDesc : IMessage
{
	public uint draw_shop_id;

	public uint id;

	public uint item_id;

	public uint item_num;

	public uint item_duration;

	public uint sort_id;

	public uint limited_purchase_times;

	public uint each_token_diamonds;

	public uint exchange_item;

	public uint exchange_num;

	public uint quick_show;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
