using System.Collections.Generic;

namespace proto;

public class WinterFest21BBuildMissionDesc
{
	public uint id;

	public string title;

	public string desc;

	public uint pre_mission_id;

	public uint building_id;

	public uint unlock_level;

	public List<AwardDesc> award;

	public string target_cdn;
}
