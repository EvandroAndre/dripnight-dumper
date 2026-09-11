using ProtoBuf;

namespace proto;

public class PetSkillInfo : IMessage
{
	public uint pet_id;

	public uint skill_id;

	public uint skill_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
