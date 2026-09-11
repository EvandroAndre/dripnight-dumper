using ProtoBuf;

namespace proto;

public class RandomSkinInfo : IMessage
{
	public EInventory.CollectionType collection_type;

	public uint unique_id;

	public uint[] skin_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
