using System.Collections.Generic;

namespace proto;

public class CSGetChaos24BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public Chaos24BSettingDesc settings;

	public List<Chaos24BEventDesc> events;

	public List<Chaos24BPeriodDesc> periods;

	public List<BigEventShowAwardDesc> show_rewards;
}
