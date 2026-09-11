using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAllCupConfigRes : IMessage
{
	public List<CSGetCupConfigRes> settings;

	public CupTeamDesc team_setting;

	public List<CupRuleDesc> rules;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
