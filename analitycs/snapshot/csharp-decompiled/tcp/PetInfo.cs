using System.Collections.Generic;

namespace tcp;

public class PetInfo
{
	public uint id;

	public string name;

	public uint level;

	public uint exp;

	public uint skin_id;

	public uint[] actions;

	public List<PetSkillInfo> skills;

	public uint end_time;
}
