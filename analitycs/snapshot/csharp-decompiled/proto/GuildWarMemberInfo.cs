using System;

namespace proto;

public class GuildWarMemberInfo : IComparable<GuildWarMemberInfo>
{
	public ulong member_id;

	public uint round_id;

	public uint guild_war_point;

	public int CompareTo(GuildWarMemberInfo other)
	{
		return 0;
	}
}
