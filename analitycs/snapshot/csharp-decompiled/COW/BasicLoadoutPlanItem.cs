namespace COW;

public class BasicLoadoutPlanItem
{
	public uint TabID;

	public uint PlanID;

	public uint LoadoutID;

	public uint LoadoutV2ID;

	public uint AvatarID;

	public uint PetSkill;

	public string PlanName;

	private uint[] m_EquippedSkills;

	public uint[] EquippedSkills => null;
}
