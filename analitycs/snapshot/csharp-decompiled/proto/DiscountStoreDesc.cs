using ProtoBuf;

namespace proto;

public class DiscountStoreDesc : IMessage
{
	public uint store_id;

	public uint loop_id;

	public uint refresh_id;

	public uint item_id;

	public uint coins_price;

	public uint gems_price;

	public float discount_value;

	public uint limited_purchase_times;

	public uint purchase_times;

	public uint award_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
