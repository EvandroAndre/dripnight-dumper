using ProtoBuf;

namespace proto;

public class VirtualBrandCollectionValueDesc : IMessage
{
	public uint vb_set_id;

	public uint item_id;

	public uint collection_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
