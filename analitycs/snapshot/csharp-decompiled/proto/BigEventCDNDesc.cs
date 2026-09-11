using ProtoBuf;

namespace proto;

public class BigEventCDNDesc : IMessage
{
	public ELimitedEvent.EventID event_id;

	public string lanuage;

	public uint cdn_type;

	public string url;

	public string event_mission_url;

	public bool is_preload;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
