using ProtoBuf;

namespace proto;

public class RankingTipsABTestDesc : IMessage
{
	public string region;

	public long start_timestamp;

	public long end_timestamp;

	public ulong[] category_ids;

	public uint show_rules_id;

	public uint group_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
