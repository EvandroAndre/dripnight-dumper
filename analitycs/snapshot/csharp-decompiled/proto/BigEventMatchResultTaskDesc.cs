using ProtoBuf;

namespace proto;

public class BigEventMatchResultTaskDesc : IMessage
{
	public ELimitedEvent.EventID event_id;

	public EActivity.SubType sub_type;

	public string event_mission_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
