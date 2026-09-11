using ProtoBuf;

namespace proto;

public class EventMissionDesc : IMessage
{
	public string mission_name;

	public EActivity.EventMissionType mission_type;

	public uint mission_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
