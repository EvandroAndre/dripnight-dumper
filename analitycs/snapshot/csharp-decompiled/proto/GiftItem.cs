using ProtoBuf;

namespace proto;

public class GiftItem : IMessage
{
	public uint commodity_id;

	public uint sort_id;

	public uint item_id;

	public uint coins_price;

	public uint gems_price;

	public uint tag_type;

	public uint tag_value;

	public uint type_override;

	public bool is_original_type_remain;

	public bool is_exclusive;

	public string image_url;

	public bool is_quick_gift_recommended;

	public uint award_time;

	public long expire_timestamp;

	public uint display_rare;

	public uint discount_price;

	public long discount_start;

	public long discount_end;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
