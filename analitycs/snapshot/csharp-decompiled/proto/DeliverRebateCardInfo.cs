using ProtoBuf;

namespace proto;

public class DeliverRebateCardInfo : IMessage
{
	public uint rebate_card_id;

	public uint deliver_time;

	public AwardData rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
