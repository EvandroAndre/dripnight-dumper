using System.Collections.Generic;

namespace tcp;

public class AchievementUpdateNtf
{
	public List<AchievementStatsUpdateInfo> ach_stats;

	public List<AchievementEntryUpdateInfo> ach_entries;

	public bool sync_history;
}
