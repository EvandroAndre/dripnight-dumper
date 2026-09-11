using System.Collections.Generic;

namespace COW;

internal struct PetConfigInfo(uint pet_id, uint Lv)
{
	public uint Pet_ID = 0u;

	public int Exp = 0;

	public int RareType = 0;

	public uint Level = 0u;

	public PetData Pet_Data = null;

	public List<PetActionData> PetAction_data_List = null;

	public List<PetSkinData> PetSkin_Data_List = null;

	public List<PetSkillInfoData> PetSkill_Data_list = null;

	public PetLevelExpData Pet_Exp_Data = null;
}
