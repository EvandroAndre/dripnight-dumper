using System.Collections.Generic;

namespace proto;

public class CSGetRamadan25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public Ramadan25BSettingDesc setting;

	public List<Ramadan25BFoodDesc> foods;
}
