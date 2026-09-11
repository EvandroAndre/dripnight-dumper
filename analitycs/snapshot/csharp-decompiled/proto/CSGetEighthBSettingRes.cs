using System.Collections.Generic;

namespace proto;

public class CSGetEighthBSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public EighthBSettingDesc settings;

	public List<EighthBAIBlackListDesc> blacklist;

	public List<BigEventShowAwardDesc> show_rewards;
}
