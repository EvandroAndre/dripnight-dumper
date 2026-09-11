using System;
using proto;

namespace COW;

public class EPWeeklyQuestData
{
	public BaseItemInfo[] AwardList;

	public string ChallengeName;

	public string ChallengeDesc;

	public DateTime StartTime;

	public uint QuestGroup;

	public uint QuestId;

	public uint EPEventId;

	public uint TargetValue;

	public uint TargetValue2;

	public uint AwardType;

	public uint AwardId;

	public uint AwardNum;

	public uint AwardTime;

	public uint AwardType2;

	public uint AwardId2;

	public uint AwardNum2;

	public uint AwardTime2;

	public uint AwardType3;

	public uint AwardId3;

	public uint AwardNum3;

	public uint AwardTime3;

	public byte CountType;

	public byte ConditionType;

	public bool IsEPOnly;

	public bool IsTeamWork;

	public string GoPos;

	public uint condition1Type;

	public uint condition2Type;

	private bool hasProcessAwardList;

	public bool IsRankTask;

	public EPWeeklyQuestData(ChallengeDesc challengeDesc)
	{
	}

	public BaseItemInfo[] GetRewardList()
	{
		return null;
	}

	private void CreatRewardList()
	{
	}
}
