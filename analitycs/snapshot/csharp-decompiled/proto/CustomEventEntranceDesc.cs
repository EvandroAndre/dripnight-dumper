using ProtoBuf;

namespace proto;

public class CustomEventEntranceDesc : IMessage
{
	public uint custom_event_id;

	public uint priority;

	public uint entrance_type;

	public uint start_timestamp;

	public uint end_timestamp;

	public bool display;

	public bool is_open;

	public uint cdn_id;

	public uint disable_cdn_id;

	public uint go_pos;

	public string param;

	public uint entrance_name_loc_id;

	public string effect_res_id;

	public string language;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
