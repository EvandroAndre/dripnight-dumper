using ProtoBuf;

namespace proto;

public class RankingCardDesc : IMessage
{
	public uint card_id;

	public uint ranking_point_times;

	public uint token_times;

	public bool is_no_deduct;

	public uint lower_rank;

	public uint upper_rank;

	public uint card_type;

	public uint lower_rank_sort_id;

	public uint upper_rank_sort_id;

	public int award_rank_point;

	public int min_point;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
