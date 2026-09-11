using ProtoBuf;

namespace proto;

public class RankingItemRank : IMessage
{
	public uint item_id;

	public uint buy_rank;

	public uint use_rank;

	public RankingItemRankAffectedSeason which_season;

	public uint buy_rank_sort_id;

	public uint use_rank_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
