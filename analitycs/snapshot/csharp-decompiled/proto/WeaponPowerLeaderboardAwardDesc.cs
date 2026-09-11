using ProtoBuf;

namespace proto;

public class WeaponPowerLeaderboardAwardDesc : IMessage
{
	public uint id;

	public uint rank_begin;

	public uint rank_end;

	public uint title_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
