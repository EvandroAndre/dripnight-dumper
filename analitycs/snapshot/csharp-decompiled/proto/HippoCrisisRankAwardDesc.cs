using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class HippoCrisisRankAwardDesc : IMessage
{
	public uint season_id;

	public uint rank;

	public string rank_desc;

	public List<AwardDesc> rank_awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
