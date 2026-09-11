using ProtoBuf;

namespace proto;

public class PveSlotInfo : IMessage
{
	public uint index;

	public uint skin_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
