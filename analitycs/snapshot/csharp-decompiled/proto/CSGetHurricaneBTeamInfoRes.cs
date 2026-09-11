using System.Collections.Generic;

namespace proto;

public class CSGetHurricaneBTeamInfoRes
{
	public List<HurricaneBTeamMemberInfo> members;

	public uint member_count;

	public uint team_process;

	public uint claimed_process;
}
