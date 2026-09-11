using System.Collections.Generic;

namespace proto;

public class CSSelectPresetLoadoutRes
{
	public class SelectProfile
	{
		public AvatarProfile profile;
	}

	public class EquipSkill
	{
		public List<AvatarProfile> profiles;
	}

	public class ChooseLoadout
	{
		public SelectedItems items;
	}

	public class SelectPet
	{
	}

	public class SelectPetSkill
	{
	}

	public class UpdatePresetLoadout
	{
	}

	public class ChooseLoadOutV2
	{
		public uint load_out_v2;
	}

	public bool is_success;

	public SelectProfile select_profile;

	public EquipSkill equip_skill;

	public ChooseLoadout choose_loadout;

	public SelectPet select_pet;

	public SelectPetSkill select_pet_skill;

	public UpdatePresetLoadout update_preset_loadout;

	public ChooseLoadOutV2 choose_load_out_v2;
}
