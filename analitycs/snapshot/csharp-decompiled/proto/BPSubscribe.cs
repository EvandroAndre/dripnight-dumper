using ProtoBuf;

namespace proto;

public class BPSubscribe : IMessage
{
	public uint ep_event_id;

	public bool is_subscribe_open;

	public long start_time;

	public long end_time;

	public uint item_id;

	public uint rebate_id;

	public uint bundle_item_id;

	public uint bundle_rebate_id;

	public uint subscribe_bonus;

	public string bundle_cdn_setting;

	public uint rebate_percentage;

	public uint bundle_rebate_percentage;

	public string price;

	public string bundle_price;

	public uint discount_item_id;

	public uint discount_bundle_item_id;

	public uint subscribe_pp1_unlock_extra_level;

	public uint subscribe_pp2_unlock_extra_level;

	public bool is_ios_close;

	public string discount_price;

	public string bundle_discount_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
