using ProtoBuf;

namespace proto;

public class DrawShopWheelDiscountDesc : IMessage
{
	public uint draw_shop_id;

	public EDrawShop.DiscountType discount_type;

	public long discount_start_time;

	public long discount_end_time;

	public uint[] discount_price_one;

	public uint[] discount_price_batch;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
