using System.Collections.Generic;

namespace proto;

public class CSGetWinterFestStrategyInfoRes
{
	public WinterFestStrategyAccountInfo game_info;

	public List<MiniGameItem> all_items;

	public List<WinterFestStrategyHelpLog> history;

	public bool is_first_enter;
}
