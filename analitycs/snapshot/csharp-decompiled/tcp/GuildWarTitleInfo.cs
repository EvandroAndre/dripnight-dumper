using ProtoBuf;

namespace tcp;

public class GuildWarTitleInfo : IMessage
{
	public uint title_cfg_id;

	public ulong leaderboard_id;

	public ulong clan_id;

	public uint rank;

	public long expire_time;

	public string region;

	public string clan_name;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
