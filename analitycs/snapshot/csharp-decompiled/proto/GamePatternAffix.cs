using ProtoBuf;

namespace proto;

public class GamePatternAffix : IMessage
{
	public uint game_pattern;

	public uint[] affixes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
