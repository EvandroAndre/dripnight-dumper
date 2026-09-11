using ProtoBuf;

namespace proto;

public class RewardStatus : IMessage
{
	public uint unlock_id;

	public EPTarget_Status status;

	public uint is_ep;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
