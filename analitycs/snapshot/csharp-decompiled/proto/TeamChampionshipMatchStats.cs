namespace proto;

public class TeamChampionshipMatchStats
{
	public ulong team_id;

	public uint championship_type;

	public uint championship_id;

	public ulong match_id;

	public uint create_time;

	public uint end_time;

	public int score;

	public EChampionship.ChampionshipPhase phase;

	public bool is_invalid;

	public TeamMatchStats team_match_stats;
}
