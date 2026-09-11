using ProtoBuf;

namespace tcp;

public class ItemTagInfo : IMessage
{
	public uint item_id;

	public uint series_id;

	public uint num_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
