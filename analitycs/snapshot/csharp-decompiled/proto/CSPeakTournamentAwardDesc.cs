using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSPeakTournamentAwardDesc : IMessage
{
	public uint season_id;

	public uint point;

	public List<AwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
