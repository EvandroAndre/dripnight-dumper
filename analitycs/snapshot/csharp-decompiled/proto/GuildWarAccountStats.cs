using System.Collections.Generic;

namespace proto;

public class GuildWarAccountStats
{
	public ulong account_id;

	public List<GuildWarMemberStats> member_stats;
}
