using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PetInfo : IMessage
{
	public uint id;

	public string name;

	public uint level;

	public uint exp;

	public bool is_selected;

	public uint skin_id;

	public uint[] actions;

	public List<PetSkillInfo> skills;

	public uint selected_skill_id;

	public bool is_marked_star;

	public uint end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
