using ProtoBuf;

namespace proto;

public class CSFirstRankRewardsDesc : IMessage
{
	public uint rank_sort;

	public AwardDesc award;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
