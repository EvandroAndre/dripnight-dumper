using ProtoBuf;

namespace proto;

public class BPGoods : IMessage
{
	public uint ep_event_id;

	public uint level;

	public AwardDesc fp_award;

	public uint show_fp_award;

	public AwardDesc bp_award1;

	public uint show_bp_award1;

	public AwardDesc bp_award2;

	public uint show_bp_award2;

	public string show_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
