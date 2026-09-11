using System.Collections.Generic;

namespace proto;

public class CSChooseSlotsAndShowReq
{
	public uint[] slots;

	public uint[] shows;

	public ulong group_id;

	public ulong room_id;

	public List<PveSlotInfo> pve_slots;

	public List<WeaponSkinCustom> changed_weapon_skin_custom;

	public List<RandomSkinInfo> random_shows;

	public ulong shard_key;

	public uint game_mode;
}
