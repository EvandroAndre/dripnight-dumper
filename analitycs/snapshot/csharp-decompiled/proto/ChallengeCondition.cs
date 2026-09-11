using ProtoBuf;

namespace proto;

public class ChallengeCondition : IMessage
{
	public uint condition;

	public uint target_value;

	public uint[] sub_condition;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
