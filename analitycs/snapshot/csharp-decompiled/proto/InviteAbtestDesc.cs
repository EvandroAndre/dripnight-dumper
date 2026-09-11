using ProtoBuf;

namespace proto;

public class InviteAbtestDesc : IMessage
{
	public uint end_number;

	public long start_time;

	public long end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
