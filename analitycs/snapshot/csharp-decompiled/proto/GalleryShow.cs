namespace proto;

public class GalleryShow
{
	public enum InfoType
	{
		InfoType_NONE,
		InfoType_ITEM,
		InfoType_BATTLEPASS,
		InfoType_ACHIEVEMENT,
		InfoType_WEAPONEXP,
		InfoType_SIGNATURE,
		InfoType_BUDDYINFO,
		InfoType_RANKINGSTATS,
		InfoType_LEADERBOARDTITLE,
		InfoType_CLANINFO,
		InfoType_CLANHISOTRYLEADERBOARD,
		InfoType_ACHIEVEMENT_STATS,
		InfoType_BADGE,
		InfoType_SOCIALMEDIA
	}

	public enum RankingStatsType
	{
		RankingStatsType_NONE,
		RankingStatsType_BR,
		RankingStatsType_CS,
		RankingStatsType_CS_PEAK
	}

	public enum LeaderboardTitleType
	{
		LeaderboardTitleType_NONE,
		LeaderboardTitleType_WEAPONPOWER,
		LeaderboardTitleType_BRRANK,
		LeaderboardTitleType_CSRANK,
		LeaderboardTitleType_CLAN,
		LeaderboardTitleType_CSPEAK
	}

	public enum SocialMediaType
	{
		SocialMediaType_NONE = 0,
		SocialMediaType_FB = 3,
		SocialMediaType_VK = 5,
		SocialMediaType_TT = 15,
		SocialMediaType_YTB = 16
	}
}
