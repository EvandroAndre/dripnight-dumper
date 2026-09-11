using ProtoBuf;

namespace proto;

public class PVERewardHistory : IMessage
{
	public uint difficulty;

	public uint reward_round;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
