using System.Collections.Generic;
using GCommon;

namespace COW;

public class CollectionSkillDataManager : SingletonModule<CollectionSkillDataManager>
{
	public enum CollectionSkills
	{
		None = 0,
		Wukong = 1206,
		Homer = 5506,
		Tasuya = 5806,
		Sonia = 6506,
		Alok = 2206,
		Orion = 6206,
		Skyler = 4006
	}

	public enum SkinType
	{
		skin,
		isDefault
	}

	private Dictionary<uint, CollectionSkillData> m_CollectionSkillDic;

	private List<uint> m_Skills;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CollectionSkillData GetSkillDataByItemid(uint id)
	{
		return null;
	}

	public List<uint> GetSkills()
	{
		return null;
	}

	public CollectionSkillData[] GetAllSkillDatas()
	{
		return null;
	}
}
