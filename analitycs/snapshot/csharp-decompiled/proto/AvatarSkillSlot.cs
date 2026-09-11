using ProtoBuf;

namespace proto;

public class AvatarSkillSlot : IMessage
{
	public uint slot_id;

	public uint skill_id;

	public EProfile.EquipSource equip_source;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
