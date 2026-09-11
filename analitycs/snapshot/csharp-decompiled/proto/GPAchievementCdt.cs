using System.Collections.Generic;

namespace proto;

public class GPAchievementCdt
{
	public EAchievement.CdtType cdt_type;

	public uint cdt_value;

	public uint[] match_modes;

	public uint[] game_modes;

	public uint[] map_ids;

	public uint[] group_modes;

	public List<AchievementPreCdt> pre_conditions;
}
