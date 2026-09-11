using ProtoBuf;

namespace proto;

public class CupRuleDesc : IMessage
{
	public uint limited_level;

	public uint limited_rank;

	public uint upper_limited_level;

	public uint upper_limited_rank;

	public uint player_count_limit;

	public uint cup_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
