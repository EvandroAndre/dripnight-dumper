using ProtoBuf;

namespace proto;

public class ChampionshipScoreBaseDesc : IMessage
{
	public uint championship_type;

	public uint first_ranking_point;

	public uint knock_down_points;

	public uint revive_points;

	public uint damage_per_get;

	public uint damage_score;

	public uint alive_per_get;

	public uint alive_score;

	public float ranking_extra_coins;

	public float ranking_extra_exps;

	public int birth_island_quit_deduct;

	public uint kill_points;

	public uint game_mode;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
