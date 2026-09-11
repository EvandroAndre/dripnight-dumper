using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RankAwardsDesc : IMessage
{
	public uint rank;

	public List<AwardDesc> level_awards;

	public uint rank_master_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
