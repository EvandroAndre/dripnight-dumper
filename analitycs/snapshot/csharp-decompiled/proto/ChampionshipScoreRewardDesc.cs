using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ChampionshipScoreRewardDesc : IMessage
{
	public uint championship_type;

	public uint championship_id;

	public uint lower_bound;

	public uint upper_bound;

	public List<AwardDesc> end_award;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
