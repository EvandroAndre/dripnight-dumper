using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GetRankingItemRankConfigRes : IMessage
{
	public List<RankingItemRank> items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
