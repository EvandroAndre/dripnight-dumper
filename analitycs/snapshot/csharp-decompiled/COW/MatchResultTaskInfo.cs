using System.Collections.Generic;
using proto;
using tcp;

namespace COW;

public class MatchResultTaskInfo
{
	public uint claimReqID;

	public uint status;

	public uint currentValue;

	public uint currentValue2;

	public uint beforeValue;

	public uint beforeValue2;

	public int targetValue;

	public int targetValue2;

	public string challengeDesc;

	public byte countType;

	public byte displayType;

	public bool isTeamWork;

	public bool needTransTime;

	public bool needTransTime2;

	public MatchResultTaskType taskType;

	public string titleText;

	public List<BaseItemInfo> awardList;

	public uint activeness;

	public uint weekId;

	public ChallengeType challengeType;

	public bool isHasProgressInMatch;

	public bool isRankTask;

	public string avatarName;

	public string iconCdnUrl;

	public bool subGroup;

	public ulong CountDownTime;

	public MatchResultTaskInfo(uint claimReqID, uint status, uint currentValue, uint currentValue2, uint beforeValue, uint beforeValue2, int targetValue, int targetValue2, string challengeDesc, byte countType, byte displayType, bool isTeamWork, bool needTransTime, bool needTransTime2, MatchResultTaskType taskType, List<BaseItemInfo> awardList, ChallengeType challengeType, bool isRankTask)
	{
	}

	public MatchResultTaskInfo(uint awardID, uint state, uint curValue, uint beforeVal, int targetVal, string desc, MatchResultTaskType taskType, List<BaseItemInfo> awardList, uint activeness)
	{
	}

	public MatchResultTaskInfo(uint awardID, uint state, uint curValue, uint beforeVal, int targetVal, string desc, MatchResultTaskType taskType, List<BaseItemInfo> awardList)
	{
	}

	public MatchResultTaskInfo(uint state, uint curValue, uint beforeVal, int targetVal, string desc, MatchResultTaskType taskType, List<BaseItemInfo> awardList, ChallengeType challengeType)
	{
	}

	public MatchResultTaskInfo(uint state, uint curValue, uint beforeVal, int targetVal, string desc, MatchResultTaskType taskType, List<BaseItemInfo> awardList, string avatarName)
	{
	}

	public MatchResultTaskInfo(ClientActivityDesc desc, ActivityClientInfo oldInfo, tcp.ActivityUpdateInfo newInfo, MatchResultTaskType taskType, bool isHasProgressInMatch)
	{
	}

	public MatchResultTaskInfo()
	{
	}
}
