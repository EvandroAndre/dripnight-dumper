using System.Collections.Generic;

namespace tcp;

public class BriefPresetSchema
{
	public uint entry_id;

	public List<AvatarSkillSlot> avatar_skills;

	public uint pet_skill;

	public string schema_name;

	public bool is_selected;
}
