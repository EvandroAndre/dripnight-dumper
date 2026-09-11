using System.Collections.Generic;

namespace proto;

public class ClanMemberWithAccountInfo
{
	public AccountInfoBasic basic_info;

	public ulong clan_id;

	public uint member_type;

	public ulong join_at;

	public string region;

	public uint honor_point;

	public uint race_point;

	public ulong last_gain_rp_at;

	public uint week_activeness;

	public uint total_activeness;

	public uint guild_war_total_point;

	public uint personal_week_activeness;

	public List<TimeRange> privilege_time_ranges;
}
