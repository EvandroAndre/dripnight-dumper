using System.Collections.Generic;

namespace proto;

public class CSSetWeaponSkinCustomReq
{
	public uint weapon_id;

	public uint unique_id;

	public uint skin_id;

	public uint power_id;

	public uint skill_id;

	public bool is_selected;

	public uint[] slots;

	public uint[] shows;

	public ulong group_id;

	public ulong room_id;

	public List<PveSlotInfo> pve_slots;

	public uint[] random_skin_ids;

	public ulong shard_key;

	public uint game_mode;
}
