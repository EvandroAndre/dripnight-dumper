using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class PetConfigDataManager : SingletonModule<PetConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PetSkinData> _003C_003E9__17_0;

		internal bool _003CGetPetDefaultSkinID_003Eb__17_0(PetSkinData temp)
		{
			return false;
		}
	}

	private Dictionary<uint, List<PetSkillInfoData>> m_skillInfo_list;

	private Dictionary<uint, PetSkillInfoData> m_skillMap;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<PetSkillInfoData> GetPetSkillDataByPetID(uint pet_id)
	{
		return null;
	}

	public PetOpenTimeData GetOpenTimeData(uint petID, string region)
	{
		return null;
	}

	public List<PetSkillInfoData> GetSkillInfoDataList(uint pet_id)
	{
		return null;
	}

	public PetSkillInfoData GetSkillInfoData(uint skillID)
	{
		return null;
	}

	public PetSkillLevelData GetCurrentSkillLevelData(uint skillID, uint level)
	{
		return null;
	}

	public List<PetSkillLevelData> GetSkillLevelDataListBySkillID(uint skill_id)
	{
		return null;
	}

	public List<PetSkillLevelData> GetAllSkillLevelDataListByPetID(uint pet_id)
	{
		return null;
	}

	public PetSkillLevelData GetSkillLevelData(uint skillID, uint skillLevel)
	{
		return null;
	}

	public List<PetActionData> GetPetActionDataByPetID(uint pet_id)
	{
		return null;
	}

	public List<PetSkinData> GetPetSkinDataByPetID(uint pet_id)
	{
		return null;
	}

	public List<PetActionData> GetNewUnlockPetActionDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	public List<PetSkinData> GetNewUnlockPetSkinDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	public List<PetSkillInfoData> GetNewUnlockPetSkillDataByLvUp(uint pet_id, uint level_old, uint level_new)
	{
		return null;
	}

	public uint GetPetDefaultSkinID(uint pet_id)
	{
		return 0u;
	}

	public ResourceID GetPetLobbyBasicActionResByID(uint pet_id)
	{
		return default(ResourceID);
	}
}
