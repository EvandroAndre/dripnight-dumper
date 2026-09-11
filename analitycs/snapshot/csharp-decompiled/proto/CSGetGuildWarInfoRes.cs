using System.Collections.Generic;

namespace proto;

public class CSGetGuildWarInfoRes
{
	public List<GuildWarMemberInfo> members_info;

	public uint guild_war_total_point;

	public List<GuildWarRoundInfo> rounds_info;
}
