using ProtoBuf;

namespace proto;

public class GameCloseInfoDesc : IMessage
{
	public uint match_mode;

	public uint game_mode;

	public uint pre_close_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
