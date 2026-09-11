using ProtoBuf;

namespace proto;

public class AbTestChoice : IMessage
{
	public uint type;

	public uint val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
