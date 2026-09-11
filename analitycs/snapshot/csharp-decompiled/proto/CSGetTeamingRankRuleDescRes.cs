using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetTeamingRankRuleDescRes : IMessage
{
	public List<TeamingRankRuleDesc> descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
