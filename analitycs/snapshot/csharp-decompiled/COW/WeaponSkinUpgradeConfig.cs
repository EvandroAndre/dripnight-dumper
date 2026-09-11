using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class WeaponSkinUpgradeConfig : CSVBaseData
{
	public uint weapon_skin_id;

	public uint next_id;

	public uint level;

	public uint weapon_set;

	public List<WeaponSkinUpdateItemDesc> items;

	public uint reward_item;

	public uint reward_item2;

	public WeaponSkinUpdateItemDesc exchange_item;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
