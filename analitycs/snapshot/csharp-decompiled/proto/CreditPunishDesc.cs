using ProtoBuf;

namespace proto;

public class CreditPunishDesc : IMessage
{
	public uint credit_score;

	public ECreditScore.CreditCdtType credit_cdt_type;

	public uint credit_cdt_value1;

	public uint credit_cdt_value2;

	public uint credit_cdt_value3;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
