using ProtoBuf;

namespace proto;

public class FullscreenItemDesc : IMessage
{
	public uint item_id;

	public bool is_open;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
