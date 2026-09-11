using System.Collections.Generic;

namespace proto;

public class CSGetVillainBSettingRes
{
	public List<BigEventProgressAwardDesc> progress_award;

	public List<VillainBSettingDesc> settings;

	public BigEventProgressCycleAwardDesc cycle_award;
}
