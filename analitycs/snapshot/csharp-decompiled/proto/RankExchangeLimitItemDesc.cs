using ProtoBuf;

namespace proto;

public class RankExchangeLimitItemDesc : IMessage
{
	public uint store_id;

	public uint commodity_id;

	public uint type;

	public uint suit_id;

	public uint br_award_rank;

	public uint cs_award_rank;

	public uint br_award_rank_sort_id;

	public uint cs_award_rank_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
