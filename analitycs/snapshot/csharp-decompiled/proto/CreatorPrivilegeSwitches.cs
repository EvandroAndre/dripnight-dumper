using ProtoBuf;

namespace proto;

public class CreatorPrivilegeSwitches : IMessage
{
	public bool disable_name_color;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
