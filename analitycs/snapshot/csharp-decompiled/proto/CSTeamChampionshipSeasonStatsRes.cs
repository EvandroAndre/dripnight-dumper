namespace proto;

public class CSTeamChampionshipSeasonStatsRes
{
	public ulong team_id;

	public uint championship_type;

	public uint championship_id;

	public ulong[] members;

	public uint games_played;

	public int max_score;

	public uint wins;

	public uint top_10_percent_times;

	public uint top_50_percent_times;

	public uint survival_time;

	public uint moving_distance;

	public uint kills;

	public uint damage;

	public uint one_game_most_kills;

	public uint one_game_most_damage;

	public uint headshot_kills;

	public AccountInfoBasicBundleRes members_info;
}
