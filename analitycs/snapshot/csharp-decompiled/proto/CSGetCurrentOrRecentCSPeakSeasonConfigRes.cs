using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCurrentOrRecentCSPeakSeasonConfigRes : IMessage
{
	public CSPeakTournamentSeasonInfoDesc season_info;

	public List<CSPeakTournamentAwardDesc> season_award;

	public CSPeakTournamentEnergyParamDesc energy_param;

	public List<CSPeakTournamentCDNDesc> cdn_desc;

	public CSPeakTournamentPointCalParamDesc cal_param;

	public uint next_season_id;

	public List<CSPeakPreTeamPointDesc> pre_team_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
