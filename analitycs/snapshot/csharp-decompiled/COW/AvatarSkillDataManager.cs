using System.Collections.Generic;
using GCommon;

namespace COW;

internal class AvatarSkillDataManager : SingletonModule<AvatarSkillDataManager>
{
	private Dictionary<uint, AvatarSkillData> m_SkillDict;

	private Dictionary<uint, AvatarSkillData> m_SkillDictPure;

	private Dictionary<uint, AvatarSkillData> m_SkillDictOriginal;

	private Dictionary<uint, AvatarSkillData> m_AvatarSkillDict;

	private CSVAsyncDataMap<uint, AvatarSkillVoiceData> m_AvatarSkillVoiceDict;

	public Dictionary<uint, List<uint>> Lv6SkillToLowLvSkills;

	public Dictionary<uint, uint> LowLvSkillToLv6Skill;

	public string[] AvatarSkillTableHeader;

	public string[] ActiveSkillTableHeader;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private bool m_HasCleanOverwriteAvatarSkillDataFromGS;

	private List<CSChooseSkillCustomData> m_ChooseSkillList;

	private AvatarSkillData m_ASData;

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	private void LoadLv6SkillToLowLevelSkillIds()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void OverwriteAvatarSkillData(AvatarSkillData data)
	{
	}

	public void ResetCleanOverwriteAvatarSkillDataFromGSFlag()
	{
	}

	public void CleanOverwriteAvatarSkillDataFromGSOnce()
	{
	}

	public void CleanOverwriteAvatarSkillData()
	{
	}

	public void UpdateAvatarSkillData(AvatarSkillData data)
	{
	}

	public AvatarSkillData GetAvatarSkillDataByAvatarID(uint avatarID)
	{
		return null;
	}

	public List<uint> GetAllSkillLevelIDsBySkillID(uint skillID)
	{
		return null;
	}

	public AvatarSkillData GetAvatarSkillDataBySkillID(uint skillID)
	{
		return null;
	}

	public Dictionary<uint, AvatarSkillData> GetSkillDict()
	{
		return null;
	}

	public List<CSChooseSkillCustomData> GetChooseSkillList()
	{
		return null;
	}

	public bool IsSkillSameOrigin(uint SkillId1, uint SkillId2)
	{
		return false;
	}

	public bool IsSameSkill(uint SkillId1, uint SkillId2)
	{
		return false;
	}

	public AvatarSkillVoiceData GetAvatarSkillVoiceDataByID(uint skillID)
	{
		return null;
	}

	public uint ForceMap2206To22016(uint skillId)
	{
		return 0u;
	}
}
