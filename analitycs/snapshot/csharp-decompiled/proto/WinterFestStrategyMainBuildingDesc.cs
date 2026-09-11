using System.Collections.Generic;

namespace proto;

public class WinterFestStrategyMainBuildingDesc
{
	public uint level;

	public uint order_pool;

	public uint order_cnt;

	public uint other_order_pool;

	public List<MiniGameItem> upgrade_require_items;

	public uint appearance_level;
}
