using ProtoBuf;

namespace proto;

public class PrivilegeConfigDesc : IMessage
{
	public uint item_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
