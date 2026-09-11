using System.Collections.Generic;

namespace proto;

public class CSGetCSPeakSeasonInfoRes
{
	public CSPeakTournamentSeasonInfoDesc season_info;

	public List<CSPeakTournamentAwardDesc> season_award;

	public CSPeakTournamentEnergyParamDesc energy_param;
}
