using System.Collections.Generic;

namespace proto;

public class GuildWarInfo
{
	public uint last_round_guild_war_point;

	public uint current_round_guild_war_point;

	public List<GuildWarLeaderboardInfo> leaderboard_info;

	public uint total_guild_war_point;

	public bool is_guild_war_open;

	public List<GuildWarLeaderboardInfo> cur_leaderboard_info;

	public uint cs_wins;

	public uint cs_lose;

	public uint cs_participation_limit;
}
