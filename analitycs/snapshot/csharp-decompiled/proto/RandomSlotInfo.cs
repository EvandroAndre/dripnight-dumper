using ProtoBuf;

namespace proto;

public class RandomSlotInfo : IMessage
{
	public uint slot;

	public uint[] skin_ids;

	public EInventory.SlotChooseType choose_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
