using ProtoBuf;

namespace proto;

public class DiscountMultiPrice : IMessage
{
	public uint[] prices;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
