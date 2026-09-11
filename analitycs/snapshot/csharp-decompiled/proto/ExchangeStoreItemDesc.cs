using ProtoBuf;

namespace proto;

public class ExchangeStoreItemDesc : IMessage
{
	public uint store_id;

	public uint commodity_id;

	public uint sort_id;

	public string name;

	public uint item_id;

	public uint currency_id;

	public string currency_name;

	public uint currency_price;

	public uint tag_type;

	public uint tag_value;

	public uint limited_purchase_times;

	public uint purchase_times;

	public string added_time;

	public string expire_time;

	public string language;

	public string image_url;

	public string real_image_url;

	public uint gems_cost;

	public uint min_clan_level;

	public uint award_time;

	public long expire_timestamp;

	public uint limited_purchase_type;

	public long added_timestamp;

	public long prime_start_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
