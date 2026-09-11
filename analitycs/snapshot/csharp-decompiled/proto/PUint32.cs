using ProtoBuf;

namespace proto;

public class PUint32 : IMessage
{
	public uint val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
