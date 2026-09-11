using System.Collections.Generic;

namespace tcp;

public class ClanInfo
{
	public ulong clan_id;

	public string clan_name;

	public uint badge_id;

	public uint frame_id;

	public string custom_badge;

	public bool use_custom_badge;

	public List<GuildWarLeaderboardInfo> guild_war_leaderboard_info;

	public uint total_guild_war_point;

	public uint current_round_guild_war_point;

	public string region;

	public List<GuildWarLeaderboardInfo> cur_guild_war_leaderboard_info;
}
