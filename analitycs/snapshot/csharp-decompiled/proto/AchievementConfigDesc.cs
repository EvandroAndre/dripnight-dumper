using System.Collections.Generic;

namespace proto;

public class AchievementConfigDesc
{
	public EAchievement.Type achievement_type;

	public uint level;

	public uint lower_bound;

	public string type_icon;

	public List<AwardDesc> awards;
}
