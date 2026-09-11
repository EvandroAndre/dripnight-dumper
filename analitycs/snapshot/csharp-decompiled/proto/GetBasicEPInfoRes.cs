using ProtoBuf;

namespace proto;

public class GetBasicEPInfoRes : IMessage
{
	public bool owned_pass;

	public uint ep_event_id;

	public long start_time;

	public long end_time;

	public uint ep_badge;

	public uint gold_limit_improved;

	public bool owned_fp_challenge;

	public uint badge_cnt;

	public TicketPriceDesc ep_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
