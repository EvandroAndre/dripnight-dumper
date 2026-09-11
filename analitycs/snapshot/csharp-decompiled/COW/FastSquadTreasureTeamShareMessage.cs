using System.Collections.Generic;

namespace COW;

public class FastSquadTreasureTeamShareMessage : FastMessage
{
	public ulong TeamId;

	public ulong LeaderAccountId;

	public List<FastSquadTreasureTeamMemberInfo> MemberList;
}
