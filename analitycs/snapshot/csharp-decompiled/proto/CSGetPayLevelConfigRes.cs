using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetPayLevelConfigRes : IMessage
{
	public List<PayLevelConfig> pay_level_config;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
