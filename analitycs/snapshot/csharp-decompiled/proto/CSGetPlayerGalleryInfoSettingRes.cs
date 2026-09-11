using System.Collections.Generic;

namespace proto;

public class CSGetPlayerGalleryInfoSettingRes
{
	public uint version;

	public List<GalleryShowInfo> left_info_items;

	public List<GalleryShowInfo> right_info_items;

	public List<BasicEPInfo> bp_list;

	public CSPlayerRankingSeasonStatsRes br_ranking_stats;

	public CSPlayerCSRankingSeasonStatsRes cs_ranking_stats;

	public CSGetAccountWeaponExpInfoRes weapon_exp;

	public List<AchievementEntryInfo> ach_entries_info;

	public PlayerCSPeakSeasonStats cs_peak_stats;

	public GallerySocialMediaInfo social_media_info;
}
