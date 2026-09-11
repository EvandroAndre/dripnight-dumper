using ProtoBuf;

namespace proto;

public class ItemNumLimitDesc : IMessage
{
	public uint id;

	public uint max_num;

	public uint max_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
