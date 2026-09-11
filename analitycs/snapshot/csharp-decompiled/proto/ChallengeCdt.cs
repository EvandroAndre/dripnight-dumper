using ProtoBuf;

namespace proto;

public class ChallengeCdt : IMessage
{
	public EPChallenge_Condition_Type condition_type;

	public uint current_value;

	public uint target_value;

	public uint[] sub_condition;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
