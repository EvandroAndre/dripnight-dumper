using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RankTopAwardsDesc : IMessage
{
	public uint rank;

	public List<AwardDesc> season_awards;

	public uint rank_master_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
