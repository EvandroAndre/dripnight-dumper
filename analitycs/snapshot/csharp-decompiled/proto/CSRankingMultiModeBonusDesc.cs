using ProtoBuf;

namespace proto;

public class CSRankingMultiModeBonusDesc : IMessage
{
	public uint cs_rank;

	public uint auxiliary_mode_rank;

	public uint bonus_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
