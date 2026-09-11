using ProtoBuf;

namespace proto;

public class ModeStatsSummaryInfo : IMessage
{
	public uint reached_heroic_cnt;

	public uint max_score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
