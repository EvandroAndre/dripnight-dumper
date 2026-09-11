using ProtoBuf;

namespace proto;

public class VeteranRankBuffTimeDesc : IMessage
{
	public uint match_mode;

	public uint rank;

	public uint protect_times;

	public uint rank_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
