using ProtoBuf;

namespace proto;

public class StarterStoreItemDesc : IMessage
{
	public uint store_id;

	public uint item_id;

	public uint item_cnt;

	public string name;

	public uint award_time;

	public uint sort_id;

	public uint limited_purchase_times;

	public uint go_pos;

	public uint diamond_price;

	public uint original_diamond_price;

	public uint gold_price;

	public string language;

	public string image_url;

	public uint recommend;

	public uint sub_type;

	public uint purchase_times;

	public long added_timestamp;

	public long expire_timestamp;

	public uint go_system;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
