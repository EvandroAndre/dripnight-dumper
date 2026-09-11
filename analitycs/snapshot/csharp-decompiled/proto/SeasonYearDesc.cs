using ProtoBuf;

namespace proto;

public class SeasonYearDesc : IMessage
{
	public uint season_year_id;

	public string season_year_start;

	public string season_year_end;

	public uint[] br_index;

	public uint[] cs_index;

	public string season_year_cdn;

	public string season_year_name;

	public uint group_id;

	public uint sharing_activity_id;

	public uint SeasonRuleWebType;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
