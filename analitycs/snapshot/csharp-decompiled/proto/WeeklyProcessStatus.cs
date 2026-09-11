using ProtoBuf;

namespace proto;

public class WeeklyProcessStatus : IMessage
{
	public uint node_id;

	public EPProcess_Status status;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
