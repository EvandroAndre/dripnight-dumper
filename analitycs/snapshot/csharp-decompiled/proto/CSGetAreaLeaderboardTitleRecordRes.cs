using System.Collections.Generic;

namespace proto;

public class CSGetAreaLeaderboardTitleRecordRes
{
	public CSGetAccountWeaponPowerTitleRecordRes weapon_power_title_record;

	public RankingTitleRecords rank_title_record;

	public List<WeaponPowerPlayerTitleInfo> weapon_power_title_own;

	public List<RankingPlayerTitleInfo> ranking_title_own;

	public List<GuildWarPlayerTitleInfo> guild_war_title_own;

	public CSPeakTitleRecords cs_peak_title_record;

	public List<CSPeakPlayerTitleInfo> cs_peak_title_own;
}
