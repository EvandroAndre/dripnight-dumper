using ProtoBuf;

namespace tcp;

public class BadgeInfo : IMessage
{
	public uint badge_type;

	public uint sub_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
