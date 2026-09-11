using System.Collections.Generic;

namespace tcp;

public class AchievementEntryUpdateInfo
{
	public uint id;

	public uint data;

	public bool level_up;

	public List<AchLevelInfo> completed_level;
}
