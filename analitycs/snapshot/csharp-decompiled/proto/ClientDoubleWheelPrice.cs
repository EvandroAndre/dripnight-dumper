using ProtoBuf;

namespace proto;

public class ClientDoubleWheelPrice : IMessage
{
	public uint round;

	public uint[] prices;

	public uint[] discount_prices;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
