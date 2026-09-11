using ProtoBuf;

namespace proto;

public class AwardExtraConfig : IMessage
{
	public uint probability;

	public bool is_super_reward;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
