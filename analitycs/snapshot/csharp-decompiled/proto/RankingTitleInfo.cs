using COW;
using ProtoBuf;

namespace proto;

public class RankingTitleInfo : IMessage
{
	public string region;

	public uint title_cfg_id;

	public ulong leaderboard_id;

	public uint rank;

	public long expire_time;

	public long reward_time;

	public string RegionName;

	public ELeaderBoardTitleRegionType RegionType;

	public bool IsBr;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
