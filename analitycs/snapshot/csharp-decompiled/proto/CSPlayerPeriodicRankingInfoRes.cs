namespace proto;

public class CSPlayerPeriodicRankingInfoRes
{
	public ulong account_id;

	public uint season_id;

	public uint rank;

	public uint max_rank;

	public uint ranking_points;

	public uint cur_rank_points;

	public uint ranking_protect_points;

	public uint games_played;

	public uint game_round_played;

	public PeriodicRankingInfo last_season_info;

	public uint wins;

	public uint kills;

	public uint damage;

	public uint head_shot_kills;

	public uint assists;

	public uint deaths;

	public uint double_kills;

	public uint four_kills;

	public bool reset_reward;

	public uint season_reset_rank;

	public uint ranking_bot_points;
}
