using System.Collections.Generic;

namespace proto;

public class SeventhBMatchStats
{
	public class SeventhBWeaponPurchaseInfo
	{
		public uint weapon_id;

		public uint purchase_cnt;

		public bool pre_cdt_triggered;
	}

	public uint enter_oldff_cnt;

	public uint interact_hologram_cnt;

	public uint battle_zone_kills;

	public uint battle_zone_damage;

	public uint enter_winner_palace_cnt;

	public uint glider_use_cnt;

	public List<SeventhBWeaponPurchaseInfo> weapon_purchase_infos;

	public ulong[] seventhb_oldff_teammate_ids;
}
