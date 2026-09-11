using System.Collections.Generic;

namespace proto;

public class CSGetFFWSAccountGuessingInfoRes
{
	public List<FFWSTeamResultsDesc> team_results;

	public uint[] ai_guess_results;

	public uint[] player_guess_results;

	public List<ELimitedEvent.FFWSGuessingAwardStatus> award_status;
}
