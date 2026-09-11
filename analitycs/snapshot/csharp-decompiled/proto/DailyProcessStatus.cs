using ProtoBuf;

namespace proto;

public class DailyProcessStatus : IMessage
{
	public uint node_id;

	public EPProcess_Status status;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
