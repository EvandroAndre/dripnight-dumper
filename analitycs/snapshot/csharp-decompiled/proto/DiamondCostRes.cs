using ProtoBuf;

namespace proto;

public class DiamondCostRes : IMessage
{
	public uint diamond_cost;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
