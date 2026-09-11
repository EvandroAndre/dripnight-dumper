using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCurrentOrRecentHippoRankingSeasonConfigRes : IMessage
{
	public HippoCrisisSeasonInfoDesc season_info;

	public List<HippoCrisisRankAwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
