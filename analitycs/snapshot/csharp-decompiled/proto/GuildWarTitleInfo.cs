using ProtoBuf;

namespace proto;

public class GuildWarTitleInfo : IMessage
{
	public string region;

	public ulong clan_id;

	public uint title_cfg_id;

	public ulong leaderboard_id;

	public uint rank;

	public long expire_time;

	public long reward_time;

	public bool is_equipped;

	public string clan_name;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
