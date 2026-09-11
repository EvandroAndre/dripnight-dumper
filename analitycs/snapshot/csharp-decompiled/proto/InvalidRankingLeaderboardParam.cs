using ProtoBuf;

namespace proto;

public class InvalidRankingLeaderboardParam : IMessage
{
	public uint games_played;

	public float KD;

	public float win_rate;

	public uint min_games;

	public float combine_KD;

	public float combine_Headshot;

	public uint min_rank;

	public uint min_rank_sort_id;

	public uint new_sorting_season_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
