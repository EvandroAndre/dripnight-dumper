using ProtoBuf;

namespace proto;

public class ModeStatsInfo : IMessage
{
	public uint game_mode;

	public uint score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
