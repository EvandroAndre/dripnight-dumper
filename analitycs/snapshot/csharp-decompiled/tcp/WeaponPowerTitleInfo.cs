using ProtoBuf;

namespace tcp;

public class WeaponPowerTitleInfo : IMessage
{
	public uint title_cfg_id;

	public ulong leaderboard_id;

	public uint weapon_id;

	public uint rank;

	public long expire_time;

	public string region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
