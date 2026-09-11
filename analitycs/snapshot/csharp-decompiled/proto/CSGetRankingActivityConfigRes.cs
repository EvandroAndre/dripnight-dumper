using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetRankingActivityConfigRes : IMessage
{
	public List<RankingActivityConfig> ranking_activity_configs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
