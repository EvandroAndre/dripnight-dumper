using ProtoBuf;

namespace tcp;

public class HippoInventoryEquipItem : IMessage
{
	public uint equip_type;

	public uint equip_slot;

	public HippoInventoryItem item;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
