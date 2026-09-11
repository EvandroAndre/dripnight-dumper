using System;

namespace proto;

public class GuildWarRoundInfo : IComparable<GuildWarRoundInfo>
{
	public uint round_id;

	public uint point;

	public int CompareTo(GuildWarRoundInfo other)
	{
		return 0;
	}
}
