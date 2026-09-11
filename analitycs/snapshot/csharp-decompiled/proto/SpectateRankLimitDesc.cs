using ProtoBuf;

namespace proto;

public class SpectateRankLimitDesc : IMessage
{
	public uint match_mode;

	public uint rank;

	public uint rank_sort_id;

	public uint level_limit;

	public uint limit_rank_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
