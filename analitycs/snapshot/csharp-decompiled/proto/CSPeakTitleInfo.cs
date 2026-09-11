using COW;
using ProtoBuf;

namespace proto;

public class CSPeakTitleInfo : IMessage
{
	public string region;

	public uint title_cfg_id;

	public ulong leaderboard_id;

	public uint rank;

	public long expire_time;

	public long reward_time;

	public string RegionName;

	public bool IsBr;

	public ELeaderBoardTitleRegionType RegionType;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
