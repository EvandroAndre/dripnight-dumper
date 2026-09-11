using System.Collections.Generic;

namespace proto;

public class PresetLoadoutSchema
{
	public enum AutoMode
	{
		None,
		CsMode,
		BrMode
	}

	public uint entry_id;

	public uint avatar_id;

	public List<AvatarSkillSlot> avatar_skills;

	public uint pet_skill;

	public uint loadout_id;

	public string schema_name;

	public bool is_selected;

	public uint auto_mode;

	public uint pet_id;

	public uint load_out_v2;
}
