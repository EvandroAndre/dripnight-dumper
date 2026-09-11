using proto;

namespace COW;

public class SortedTeamInfo
{
	public TopUpTeam team;

	public ESquadTreasureTeamType teamType;

	public ESquadTreasureTeamState teamState;

	public uint progress;

	public ulong teamId;

	public ulong invitationAccountId;

	public SortedTeamInfo(TopUpTeam teamInfo, ESquadTreasureTeamType type, ESquadTreasureTeamState state, uint prog, ulong inviterId = 0uL)
	{
	}
}
