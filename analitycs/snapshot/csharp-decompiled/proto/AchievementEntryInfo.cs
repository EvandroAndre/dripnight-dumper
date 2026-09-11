using System.Collections.Generic;

namespace proto;

public class AchievementEntryInfo
{
	public uint id;

	public uint data;

	public uint[] awarded_level;

	public List<AchievementLevelInfo> completed_level;
}
