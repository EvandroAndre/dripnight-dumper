using System;

namespace proto;

public class GuildWarMemberStats : IComparable<GuildWarMemberStats>
{
	public uint rank;

	public uint player_count;

	public uint kills;

	public uint start_time;

	public uint personal_point;

	public uint[] teams_game_point;

	public bool has_quit_clan;

	public int CompareTo(GuildWarMemberStats other)
	{
		return 0;
	}
}
