using ProtoBuf;

namespace proto;

public class PUint32KeyVal : IMessage
{
	public uint key;

	public uint val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
