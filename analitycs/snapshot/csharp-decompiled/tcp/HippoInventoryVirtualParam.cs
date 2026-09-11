using ProtoBuf;

namespace tcp;

public class HippoInventoryVirtualParam : IMessage
{
	public uint type;

	public uint val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
