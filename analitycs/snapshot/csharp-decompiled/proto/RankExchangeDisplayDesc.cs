using ProtoBuf;

namespace proto;

public class RankExchangeDisplayDesc : IMessage
{
	public uint exchange_award_id;

	public uint exchange_award_rank;

	public string exchange_store_bg_url;

	public uint[] available_type;

	public string exchange_store_reward_url;

	public uint exchange_award_rank_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
