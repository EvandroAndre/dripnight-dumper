using ProtoBuf;

namespace proto;

public class VirtualBrandTagDesc : IMessage
{
	public uint item_id;

	public uint brand_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
