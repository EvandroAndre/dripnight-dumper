using ProtoBuf;

namespace proto;

public class TicketPriceDesc : IMessage
{
	public uint ep_event_id;

	public string region;

	public EInventory.CurrencyType cost_type;

	public uint cost_value;

	public uint bundle_value;

	public uint bundle_badge;

	public uint bundle_reward_item1;

	public uint bundle_reward_num1;

	public uint bundle_reward_time1;

	public bool is_customized;

	public string customize_start_time;

	public string customize_end_time;

	public long customize_start_timestamp;

	public long customize_end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
