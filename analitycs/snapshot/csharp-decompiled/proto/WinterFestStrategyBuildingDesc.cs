using System.Collections.Generic;

namespace proto;

public class WinterFestStrategyBuildingDesc
{
	public uint building_id;

	public uint building_level;

	public string building_name;

	public uint product_id;

	public uint building_eff;

	public uint building_capacity;

	public uint main_building_unlock;

	public List<MiniGameItem> upgrade_require_items;

	public uint appearance_level;
}
