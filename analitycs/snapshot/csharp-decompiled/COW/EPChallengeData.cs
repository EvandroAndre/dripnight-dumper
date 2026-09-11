using proto;

namespace COW;

public class EPChallengeData
{
	protected BaseItemInfo[] RewardLst;

	public string ChallengeDesc;

	public uint EPEventID;

	public uint ChallengeId;

	public int TargetValue;

	public int TargetValue2;

	public uint AwardID;

	public int AwardNum;

	public uint AwardTime;

	public int SpecialChallenge;

	public uint Group;

	public EInventory.AwardType AwardType;

	public ChallengeType ChallengeType;

	public byte CountType;

	public byte DisplayType;

	public bool isTeamWork;

	public bool isEPOnly;

	public string GoPos;

	public uint condition1Type;

	public uint condition2Type;

	protected bool hasProcessRewardList;

	public bool IsRankTask;

	protected virtual void DoCreateRewardList()
	{
	}

	protected BaseItemInfo CreateAwardInfo()
	{
		return null;
	}

	public BaseItemInfo[] GetRewardLst()
	{
		return null;
	}

	public static implicit operator EPChallengeData(EPWeeklyQuestData weekData)
	{
		return null;
	}
}
