using System.Collections.Generic;

namespace proto;

public class CSGetWinterFestStrategySettings
{
	public List<WinterFestStrategyMainBuildingDesc> main_buiding_setting;

	public List<WinterFestStrategyOrderDesc> order_setting;

	public List<WinterFestStrategyBuildingDesc> building_setting;

	public List<WinterFestStrategyResourceDesc> resource_setting;

	public WinterFestStrategySettingDesc other_setting;

	public List<WinterFestStrategyItemDesc> item_setting;
}
