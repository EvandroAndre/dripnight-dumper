using ProtoBuf;

namespace proto;

public class RevenueEntranceShowDesc : IMessage
{
	public uint entrance_type;

	public uint priority;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
