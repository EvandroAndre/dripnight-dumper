using System.Collections.Generic;

namespace proto;

public class CSGetPony25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public Pony25BSettingDesc settings;

	public List<Pony25BPOIBaseDesc> poi_bases;

	public List<Pony25BPOIExploreDesc> poi_explores;
}
