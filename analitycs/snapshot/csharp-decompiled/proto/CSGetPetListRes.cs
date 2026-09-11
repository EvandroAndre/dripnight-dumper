using System.Collections.Generic;

namespace proto;

public class CSGetPetListRes
{
	public List<PetInfo> pets;

	public List<PetSkinInfo> skins;

	public List<PetActionInfo> actions;

	public List<PetSkillInfo> skills;
}
