using System.Collections.Generic;

namespace proto;

public class TournamentInfo
{
	public uint last_round_tournament_point;

	public uint current_round_tournament_point;

	public uint total_tournament_point;

	public bool is_qualified;

	public List<GuildWarLeaderboardInfo> leaderboard_info;
}
