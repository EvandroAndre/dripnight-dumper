using ProtoBuf;

namespace proto;

public class QuitControlDesc : IMessage
{
	public uint match_mode;

	public uint game_mode;

	public bool delayed_exit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
