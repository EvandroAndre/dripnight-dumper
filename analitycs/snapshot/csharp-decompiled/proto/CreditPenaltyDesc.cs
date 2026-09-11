using ProtoBuf;

namespace proto;

public class CreditPenaltyDesc : IMessage
{
	public uint key;

	public string name;

	public uint punish_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
