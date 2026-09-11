using ProtoBuf;

namespace proto;

public class VipCardDailyAwardDesc : IMessage
{
	public uint id;

	public EVipCard.VipCardType type;

	public uint day_time;

	public uint gems;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
