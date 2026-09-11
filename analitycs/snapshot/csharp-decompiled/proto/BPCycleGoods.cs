using ProtoBuf;

namespace proto;

public class BPCycleGoods : IMessage
{
	public uint ep_event_id;

	public uint cycle_level;

	public AwardDesc award;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
