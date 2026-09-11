using GCommon;

public class ClanConfigData : CSVBaseData
{
	public const string PRIMARYKEY = "KEY";

	public int ClanMaxPendingApplications;

	public int RequestTimeout;

	public int PlayerMaxRequestsPerDay;

	public int MaxInviteNum;

	public int MaxInviteNumMember;

	public int ClanLogTimeMax;

	public int ClanLogCntMax;

	public uint[] ClanPresetLevels;

	public uint[] ClanPresetRanks;

	public uint[] ClanPresetRankSortID;

	public uint[] ClanPresetCSRanks;

	public uint[] ClanPresetCSRankSortID;

	public int CaptainOfflineDays;

	public int JoinDaysBeforeApplyForDeputy;

	public int DeputyOfflineDays;

	public int HonorFilter;

	public int ActiveMinNum;

	public int ActiveTime;

	public int ActiveJoinTime;

	public int ActivePopupTime;

	public int EmojiLimit;

	public int PlayGuildWarTime;

	public int ActiveDecreaseTimes;

	public int RecruitPromotionFirstTimeCost;

	public int RecruitPromotionCost;

	public int HomePageActiveShowMin;

	public int FriendClanRecommendNumber;

	public float ActiveMemberRatio;

	public uint NewNoticeHomepageDuration;

	public uint ExitCd;

	public uint MaxGuildMember;

	public uint TeamClanRecommendCd;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
