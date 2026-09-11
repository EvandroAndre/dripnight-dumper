using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopMatchInfoRes
{
	public uint group_mode;

	public List<string> workshop_codes;

	public bool is_workshop_team_contest;

	public uint[] workshop_team_counts;
}
