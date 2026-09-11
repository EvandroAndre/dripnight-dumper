using System.Collections.Generic;

namespace proto;

public class CSBatchSetWeaponSkinCustomReq
{
	public List<CSSetWeaponSkinCustomReq> skin_custom;

	public uint[] slots;

	public uint[] shows;

	public ulong group_id;

	public ulong room_id;

	public List<PveSlotInfo> pve_slots;

	public ulong shard_key;

	public uint game_mode;
}
