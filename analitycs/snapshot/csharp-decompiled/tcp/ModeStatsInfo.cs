using ProtoBuf;

namespace tcp;

public class ModeStatsInfo : IMessage
{
	public uint score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
