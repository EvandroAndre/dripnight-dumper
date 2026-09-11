using System.Collections.Generic;

namespace COW;

internal class ResultTeamData
{
	public byte id;

	public uint rank;

	public string name;

	public uint icon;

	public uint killCount;

	public uint killScore;

	public uint rankScore;

	public uint totalScore;

	public uint winNum;

	public List<ResultPlayerData> players;
}
