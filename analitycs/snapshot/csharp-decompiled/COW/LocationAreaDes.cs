using System.Collections.Generic;
using proto;

namespace COW;

public class LocationAreaDes
{
	public enum AreaLevel
	{
		None,
		AreaLevelCountry,
		AreaLevelArea,
		AreaLevelCity,
		AreaLevelMax
	}

	public uint id;

	public uint from;

	public string name;

	public List<string> geos;

	public string desc;

	public uint level;

	public static implicit operator LocationAreaDes(LeaderboardAreaListDesc target)
	{
		return null;
	}

	public static implicit operator LocationAreaDes(ClanLeaderboardAreaListDesc target)
	{
		return null;
	}
}
