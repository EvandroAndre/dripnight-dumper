using ProtoBuf;

namespace proto;

public class CustomEventMatchResultTaskDesc : IMessage
{
	public uint custom_event_id;

	public EActivity.SubType sub_type;

	public string event_mission_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
