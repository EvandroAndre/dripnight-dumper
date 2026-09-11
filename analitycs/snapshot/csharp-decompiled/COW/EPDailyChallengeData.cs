using proto;

namespace COW;

internal class EPDailyChallengeData : EPChallengeData
{
	public uint ChallengeDate;

	public EInventory.AwardType AwardType2;

	public uint AwardID2;

	public uint AwardNum2;

	public uint AwardTime2;

	public EPDailyChallengeData(ChallengeDesc challengeDesc)
	{
	}

	protected override void DoCreateRewardList()
	{
	}

	protected BaseItemInfo CreateAwardInfo2()
	{
		return null;
	}

	public BaseItemInfo[] GetDailyRewardLst()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DoCreateRewardList()
	{
	}
}
