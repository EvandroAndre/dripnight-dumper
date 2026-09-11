using ProtoBuf;

namespace proto;

public class RankingMultiModeBonusDesc : IMessage
{
	public uint rank;

	public uint auxiliary_mode_rank;

	public float bonus_ratio;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
