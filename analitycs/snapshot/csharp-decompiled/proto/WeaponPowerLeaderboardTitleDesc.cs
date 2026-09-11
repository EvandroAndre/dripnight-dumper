using ProtoBuf;

namespace proto;

public class WeaponPowerLeaderboardTitleDesc : IMessage
{
	public uint id;

	public uint leaderboard_type;

	public uint title_type;

	public string name;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
