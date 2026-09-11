using ProtoBuf;

namespace proto;

public class VipCardInitAwardDesc : IMessage
{
	public uint id;

	public EVipCard.VipCardType type;

	public uint init_award_gems;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
