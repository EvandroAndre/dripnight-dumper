using ProtoBuf;

namespace proto;

public class BRFirstRankRewardsDesc : IMessage
{
	public uint rank_sort;

	public AwardDesc award;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
