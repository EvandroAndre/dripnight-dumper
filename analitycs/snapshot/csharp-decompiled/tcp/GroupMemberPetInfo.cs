using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class GroupMemberPetInfo : IMessage
{
	public uint id;

	public string name;

	public uint level;

	public uint skin_id;

	public List<PetSkillInfo> skills;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
