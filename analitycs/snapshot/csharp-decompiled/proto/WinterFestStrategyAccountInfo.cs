using System.Collections.Generic;

namespace proto;

public class WinterFestStrategyAccountInfo
{
	public List<WinterFestStrategyBuildingInfo> buildings;

	public uint devote_points;

	public uint[] pending_orders;

	public uint[] finished_orders;

	public uint orders_expire_time;

	public List<WinterFestStrategyHelpLog> history;

	public uint order_help_num;
}
