using System.Collections.Generic;

namespace proto;

public class GuildWarDetail
{
	public uint team_guild_war_point;

	public uint personal_guild_war_point;

	public bool is_new_record;

	public bool affected_guild_war_total_point;

	public List<GuildWarPersonalPoint> personal_guild_war_points;
}
