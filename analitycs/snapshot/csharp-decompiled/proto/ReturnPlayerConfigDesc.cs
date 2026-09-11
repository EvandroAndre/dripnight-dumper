using ProtoBuf;

namespace proto;

public class ReturnPlayerConfigDesc : IMessage
{
	public long return_player_time_secs;

	public long return_playerKeep_time_secs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
