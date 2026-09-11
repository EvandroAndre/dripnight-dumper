using ProtoBuf;

namespace proto;

public class BPPrice : IMessage
{
	public uint ep_event_id;

	public uint cost_value;

	public uint discount_value;

	public uint bundle_value;

	public uint bundle_discount_value;

	public uint bundle_exp;

	public uint exp_value;

	public uint exp_discount_value;

	public uint exp_bundle_id;

	public AwardDesc bundle_award1;

	public long exp_discount_start_time;

	public long exp_discount_end_time;

	public string premium_show_award_levels;

	public uint extra_exp;

	public uint veteran_task_bonus;

	public uint exp_id;

	public uint discount_level;

	public uint repurchase_value;

	public uint bundle_repurchase_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
