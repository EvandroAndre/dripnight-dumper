using ProtoBuf;

namespace proto;

public class ExchangeStoreDesc : IMessage
{
	public uint store_id;

	public string store_name;

	public string open_time;

	public string close_time;

	public uint open_time_stamp;

	public uint close_time_stamp;

	public bool is_show_time;

	public bool check_bundle_switch;

	public bool need_clan;

	public string token_box;

	public uint style_type;

	public string store_cdn_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
