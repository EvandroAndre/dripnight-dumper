using System.Collections.Generic;

namespace proto;

public class CSGetAllAchievementDescRes
{
	public List<AchievementEntryDesc> ach_entries_desc;

	public List<AchievementConfigDesc> total_ach_level_config;

	public List<AchievementConfigDesc> battle_ach_level_config;

	public List<AchievementConfigDesc> career_ach_level_config;

	public List<AchievementConfigDesc> collection_ach_level_config;

	public List<AchievementSeasonYearDesc> season_year_config;
}
