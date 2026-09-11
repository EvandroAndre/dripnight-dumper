using System.Collections.Generic;

namespace proto;

public class FreshRewardItem
{
	public uint day;

	public bool if_signed;

	public List<AwardDesc> signin_awards;

	public string tab_cdn_url;

	public uint achievement_id;

	public bool IsAllMissionRewardsFinished;

	public bool IsAllRewardsClaimed;

	public bool HasMissionRewardsToClaim;

	public int NormalMissionHasFinishedCount;
}
