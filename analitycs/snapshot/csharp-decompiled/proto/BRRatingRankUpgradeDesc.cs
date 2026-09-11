using ProtoBuf;

namespace proto;

public class BRRatingRankUpgradeDesc : IMessage
{
	public uint rank_bound;

	public uint gold_streak;

	public uint silver_streak;

	public uint extra_rank;

	public uint rank_upgrade_cd;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
