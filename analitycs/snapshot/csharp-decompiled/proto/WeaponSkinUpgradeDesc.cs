using System.Collections.Generic;

namespace proto;

public class WeaponSkinUpgradeDesc
{
	public uint weapon_skin_id;

	public uint next_id;

	public uint level;

	public List<WeaponSkinUpdateItemDesc> items;

	public uint reward_item;

	public uint weapon_set;

	public WeaponSkinUpdateItemDesc exchange_item;

	public uint reward_item2;
}
