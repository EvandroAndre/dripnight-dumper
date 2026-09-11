using System.Collections.Generic;

namespace proto;

public class CSGetGlooWorldSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public List<GlooWorldModuleDesc> modules;
}
