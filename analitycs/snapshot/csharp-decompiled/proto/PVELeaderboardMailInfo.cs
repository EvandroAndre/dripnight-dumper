using ProtoBuf;

namespace proto;

public class PVELeaderboardMailInfo : IMessage
{
	public string start_time;

	public string end_time;

	public uint game_mode;

	public uint position;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
