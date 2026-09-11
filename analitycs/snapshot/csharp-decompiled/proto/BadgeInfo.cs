using ProtoBuf;

namespace proto;

public class BadgeInfo : IMessage
{
	public BadgeType badge_type;

	public uint sub_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
