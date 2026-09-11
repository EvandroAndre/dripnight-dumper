using System.Collections.Generic;

namespace proto;

public class AchievementEntryDesc
{
	public uint id;

	public EAchievement.Type ach_type;

	public uint level;

	public uint achievement_sub_type;

	public string name;

	public string desc;

	public string icon_cdn;

	public List<AwardDesc> awards;

	public uint rarity;

	public uint sort;

	public AchievementCdt conditions;

	public uint icon_uifx_type;

	public string event_start_time;

	public string logo_cdn;

	public uint big_event_award_id;

	public long start_time;

	public long end_time;
}
