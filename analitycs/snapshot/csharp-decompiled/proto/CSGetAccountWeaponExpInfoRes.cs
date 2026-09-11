using System.Collections.Generic;

namespace proto;

public class CSGetAccountWeaponExpInfoRes
{
	public List<WeaponExpInfo> weapon_exp_info_list;

	public List<WeaponAwardInfo> weapon_award_info_list;

	public uint[] pinned_weapons;

	public List<WeaponExpRank> weapon_exp_rank_list;
}
