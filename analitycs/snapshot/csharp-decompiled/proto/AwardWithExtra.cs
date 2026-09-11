using ProtoBuf;

namespace proto;

public class AwardWithExtra : IMessage
{
	public AwardDesc award;

	public AwardExtraConfig extra;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
