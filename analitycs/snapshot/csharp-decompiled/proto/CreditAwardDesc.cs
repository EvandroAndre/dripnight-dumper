using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CreditAwardDesc : IMessage
{
	public uint index;

	public ECreditScore.AwardType award_type;

	public uint need_credit_score;

	public List<AwardDesc> rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
