using System.Collections.Generic;

namespace tcp;

public class ReceiveGuildWarTitleReq
{
	public ulong clan_id;

	public List<GuildWarPlayerTitleInfo> guild_war_title_info;

	public List<GuildTitleLeaderboardInfo> leaderboard_info;
}
