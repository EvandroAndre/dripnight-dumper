using ProtoBuf;

namespace proto;

public class CustomEventOpenInfoDesc : IMessage
{
	public uint custom_event_id;

	public uint template_id;

	public ECustomEvent.EventState event_state;

	public string start_time;

	public string end_time;

	public uint start_timestamp;

	public uint end_timestamp;

	public string cdn_url;

	public uint type;

	public string effect_res;

	public string mask_cdn_url;

	public string event_mission_url;

	public string est_start_time;

	public uint est_start_timestamp;

	public uint LocateType;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
