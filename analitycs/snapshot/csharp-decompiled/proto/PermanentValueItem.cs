using ProtoBuf;

namespace proto;

public class PermanentValueItem : IMessage
{
	public uint id;

	public uint permanent_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
