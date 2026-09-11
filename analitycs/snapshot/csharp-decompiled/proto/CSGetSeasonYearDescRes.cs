using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetSeasonYearDescRes : IMessage
{
	public List<SeasonYearDesc> season_year_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
