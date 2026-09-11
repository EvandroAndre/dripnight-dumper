using System.Collections.Generic;

namespace proto;

public class CSGetWinterLand23BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public WinterLand23BSettingDesc settings;

	public List<WinterLand23BDrawInfo> draw_awards;

	public List<AwardDesc> basic_awards;

	public List<AwardDesc> random_awards;

	public List<AwardDesc> big_prize_awards;
}
