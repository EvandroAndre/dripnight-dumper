using System.Collections.Generic;

namespace proto;

public class CSGetIIVSYSSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public IIVSettingDesc settings;

	public List<IIVRateControlDesc> rate_settings;

	public List<IIVSpellsDesc> spells_settings;
}
