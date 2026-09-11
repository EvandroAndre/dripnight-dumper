using ProtoBuf;

namespace proto;

public class CupTierDesc : IMessage
{
	public uint cup_type;

	public uint tier;

	public uint tier_lower_bound;

	public bool is_pure_tier;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
