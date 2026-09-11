using ProtoBuf;

namespace proto;

public class InventoryItemExceedMaxNum : IMessage
{
	public uint id;

	public uint cnt;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
