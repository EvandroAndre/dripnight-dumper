using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class WeaponPowerLeaderboardAreaListDesc : IMessage
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

	public void ParseFrom(ProtoReader reader)
	{
	}
}
