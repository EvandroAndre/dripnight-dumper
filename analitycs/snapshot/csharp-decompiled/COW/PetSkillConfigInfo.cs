namespace COW;

public class PetSkillConfigInfo
{
	public uint SkillID;

	public int Level;

	public uint PetID;

	public bool IsLock;

	public PetSkillLevelData CurrentLevelData;

	public PetSkillLevelData NextLevelData;

	public PetSkillConfigInfo(uint skill_id, uint pet_level, uint pet_id)
	{
	}
}
