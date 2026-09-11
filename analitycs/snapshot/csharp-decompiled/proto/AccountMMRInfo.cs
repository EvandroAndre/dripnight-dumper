using ProtoBuf;

namespace proto;

public class AccountMMRInfo : IMessage
{
	public uint game_mode;

	public uint mmr;

	public uint bot_point;

	public uint streak_wins;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
