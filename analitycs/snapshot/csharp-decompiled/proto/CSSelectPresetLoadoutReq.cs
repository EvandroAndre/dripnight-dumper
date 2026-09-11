using System.Collections.Generic;

namespace proto;

public class CSSelectPresetLoadoutReq
{
	public class SelectProfile
	{
		public uint avatar_id;
	}

	public class EquipSkill
	{
		public uint avatar_id;

		public uint[] slot_ids;

		public uint[] skill_ids;

		public List<EProfile.EquipSource> equip_sources;
	}

	public class ChooseLoadout
	{
		public uint[] loadouts;
	}

	public class SelectPet
	{
		public uint pet_id;

		public bool is_selected;
	}

	public class SelectPetSkill
	{
		public uint pet_id;

		public uint skill_id;
	}

	public class UpdatePresetLoadout
	{
		public List<PresetLoadoutSchema> preset_schema;
	}

	public class ChooseLoadOutV2
	{
		public uint load_out_v2;
	}

	public SelectProfile select_profile;

	public EquipSkill equip_skill;

	public ChooseLoadout choose_loadout;

	public SelectPet select_pet;

	public SelectPetSkill select_pet_skill;

	public UpdatePresetLoadout update_preset_loadout;

	public ChooseLoadOutV2 choose_load_out_v2;

	public uint build_id;

	public ulong group_id;

	public ulong room_id;

	public ulong shard_key;

	public uint game_mode;
}
