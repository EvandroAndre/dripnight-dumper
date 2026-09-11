using System.Collections.Generic;

namespace proto;

public class AchievementCdt
{
	public EAchievement.CdtType cdt_type;

	public uint cdt_value;

	public uint achievement_points;

	public uint[] match_modes;

	public uint[] game_modes;

	public uint[] map_ids;

	public uint[] group_modes;

	public List<AchievementPreCdt> pre_conditions;

	public uint[] cdt_values;

	public uint[] ach_points;

	public uint season_year_id;
}
