using System.Collections.Generic;

namespace COW;

internal class TeamData
{
	public string teamName;

	public string teamNameAbbr;

	public byte gsTeamId;

	public byte scTeamId;

	public uint teamIcon;

	public uint winNum;

	public List<PlayerData> playerList;
}
