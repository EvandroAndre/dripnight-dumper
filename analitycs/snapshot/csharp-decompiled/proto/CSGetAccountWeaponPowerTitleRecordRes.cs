using System.Collections.Generic;

namespace proto;

public class CSGetAccountWeaponPowerTitleRecordRes
{
	public WeaponPowerTitleRecords records;

	public List<WeaponExpInfo> weapon_exp_info_list;

	public SelectedItems items;

	public List<WeaponAwardInfo> weapon_award_info_list;
}
