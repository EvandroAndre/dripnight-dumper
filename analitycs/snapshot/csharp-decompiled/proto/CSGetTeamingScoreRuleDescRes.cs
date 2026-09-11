using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetTeamingScoreRuleDescRes : IMessage
{
	public List<TeamingScoreRuleDesc> descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
