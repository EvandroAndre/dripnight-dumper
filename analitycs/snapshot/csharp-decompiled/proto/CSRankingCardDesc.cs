using ProtoBuf;

namespace proto;

public class CSRankingCardDesc : IMessage
{
	public uint card_id;

	public bool is_no_deduct;

	public string use_desc;

	public uint lower_rank;

	public uint upper_rank;

	public uint card_type;

	public uint lower_rank_sort_id;

	public uint upper_rank_sort_id;

	public int award_protect_point;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
