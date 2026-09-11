using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class LeaderboardTitleInfo : IMessage
{
	public List<WeaponPowerTitleInfo> weapon_power_title_info;

	public List<GuildWarTitleInfo> guild_war_title_info;

	public List<RankingTitleInfo> ranking_title_info;

	public bool title_first_receive;

	public List<CSPeakTitleInfo> cs_peak_title_info;

	public bool peak_title_first_receive;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
