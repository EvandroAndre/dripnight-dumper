using ProtoBuf;

namespace tcp;

public class PetSkillInfo : IMessage
{
	public uint skill_id;

	public uint skill_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
