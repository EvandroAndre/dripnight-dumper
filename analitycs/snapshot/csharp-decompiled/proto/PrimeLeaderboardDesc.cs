using ProtoBuf;

namespace proto;

public class PrimeLeaderboardDesc : IMessage
{
	public uint leaderboard_type;

	public string region;

	public uint leaderboard_switch;

	public uint min_points;

	public uint friend_min_points;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
