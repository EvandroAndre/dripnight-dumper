using ProtoBuf;

namespace proto;

public class PayLevelPoolDesc : IMessage
{
	public uint id;

	public uint unique_id;

	public uint start_time;

	public uint end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
