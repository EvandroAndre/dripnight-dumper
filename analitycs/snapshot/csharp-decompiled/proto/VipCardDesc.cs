using ProtoBuf;

namespace proto;

public class VipCardDesc : IMessage
{
	public uint id;

	public EVipCard.VipCardType type;

	public uint percent;

	public uint card_worth;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
