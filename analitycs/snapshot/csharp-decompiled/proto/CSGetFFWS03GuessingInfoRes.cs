using System.Collections.Generic;

namespace proto;

public class CSGetFFWS03GuessingInfoRes
{
	public List<FFWSTeamInfoDesc> team_infos;

	public List<FFWSWeaponInfoDesc> weapon_info;

	public List<FFWSGuessingAwardDesc> awards;

	public List<FFWSTeamResultsDesc> team_results;

	public List<FFWSWeaponResultsDesc> weapon_results;

	public List<FFWS03GuessingEntry> guess_entries;
}
