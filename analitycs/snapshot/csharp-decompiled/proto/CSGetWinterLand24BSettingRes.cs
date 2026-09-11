using System.Collections.Generic;

namespace proto;

public class CSGetWinterLand24BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public WinterLand24BSettingDesc settings;

	public List<WinterLand24BWeatherDesc> weathers;

	public List<WinterLand24BWeatherDateDesc> weather_date;
}
