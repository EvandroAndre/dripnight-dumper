using System.Collections.Generic;

namespace proto;

public class WinterFestStrategyOrderDesc
{
	public uint pool;

	public uint id;

	public List<MiniGameItem> request_items;

	public AwardDesc reward_items;

	public uint building_material;

	public uint devote_points;

	public bool is_other;
}
