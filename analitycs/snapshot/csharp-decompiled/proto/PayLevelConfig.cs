using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PayLevelConfig : IMessage
{
	public PayLevelPoolDesc pool;

	public List<PayLevelRewardDesc> rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
