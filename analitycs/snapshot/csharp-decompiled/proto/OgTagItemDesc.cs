using ProtoBuf;

namespace proto;

public class OgTagItemDesc : IMessage
{
	public uint item_id;

	public uint num_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
