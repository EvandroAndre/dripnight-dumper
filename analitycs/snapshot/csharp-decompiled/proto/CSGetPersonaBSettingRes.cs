using System.Collections.Generic;

namespace proto;

public class CSGetPersonaBSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public PersonaBSettingDesc settings;
}
