using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class AvatarSkillDataManagerZombieMode : SingletonModule<AvatarSkillDataManagerZombieMode>
{
	private Dictionary<uint, AvatarSkillData> m_SkillDict;

	private Dictionary<uint, List<AvatarSkillData>> m_AvatarSkillDict;

	private Dictionary<int, string> m_Level2SkillBgName;

	private Dictionary<int, uint> m_Level2SkillLabelColor;

	public const uint DynamicOrEnhancedSkillInitialLevel = 7u;

	public string GetSkillBgName(int level)
	{
		return null;
	}

	public Color GetSkillLabelColor(int level)
	{
		return default(Color);
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<AvatarSkillData> GetAvatarSkillList(uint avatarID)
	{
		return null;
	}

	public List<AvatarSkillData> GetAvatarSkillListBySkillId(uint skillid)
	{
		return null;
	}

	public AvatarSkillData GetAvatarSkillDataByLevel(uint avatarID, uint level = 1u)
	{
		return null;
	}

	public AvatarSkillData GetAvatarSkillDataBySkillID(uint skillID)
	{
		return null;
	}
}
