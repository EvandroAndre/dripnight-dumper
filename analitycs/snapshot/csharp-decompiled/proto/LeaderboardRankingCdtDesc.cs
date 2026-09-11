using ProtoBuf;

namespace proto;

public class LeaderboardRankingCdtDesc : IMessage
{
	public uint leaderboard_main_type;

	public bool is_open;

	public uint level;

	public uint min_rank_sort_id;

	public uint kill;

	public uint games_played;

	public float kd;

	public float headshot_kill;

	public float bullet_headshot;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
