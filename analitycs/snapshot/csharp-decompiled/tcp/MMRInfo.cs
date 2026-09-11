using ProtoBuf;

namespace tcp;

public class MMRInfo : IMessage
{
	public EMatch.GameMode game_mode;

	public uint mmr;

	public uint bot_point;

	public uint streak_wins;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
