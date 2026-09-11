using ProtoBuf;

namespace proto;

public class VeteranStoreDesc : IMessage
{
	public uint pool;

	public uint sort;

	public uint award_id;

	public uint award_num;

	public uint coins_price;

	public uint gems_price;

	public uint limited_purchase_times;

	public uint purchase_times;

	public uint award_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
