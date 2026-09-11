using System.Collections.Generic;

namespace proto;

public class WinterFestStrategyResourceDesc
{
	public uint id;

	public List<MiniGameItem> cost_items;

	public MiniGameItem product;

	public uint unlock_level;

	public uint[] unlock_last_digits;
}
