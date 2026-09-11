using GCommon;

namespace COW;

public class MatchReviewParamData : CSVBaseData, IGetId
{
	public uint UnlockRank;

	public float GuideMaxTimePerDay;

	public float GuideMinRankIngame;

	public float GuideMinTime;

	public float KillNodeMergeTime;

	public float KillNodeMergeRange;

	public float PlaySpeed;

	public float AutoScaleSwitchTime;

	public float MaxScaleRate;

	public float AutoScaleStopThreshold;

	public float AutoScaleThreshold;

	public float AutoScaleSafeMargin;

	public float AutoScaleCheckTime;

	public float GroupRadius;

	public uint MinNeighborInRadius;

	public uint LogIntegrateTime;

	public float SemiAIRandomRadius;

	public float AIHideDistance;

	public uint FullAIThreshold;

	public float HeatMapPosTimeInterval;

	public float PrecisePosTimeInterval;

	public float PrecisePosDistance;

	public float PosCheckMinDistance;

	public float PosCheckTimeInterval;

	public float PlaySlowSpeedTime;

	public float SpeedSwitchTime;

	public float PlaySlowSpeed;

	public bool IsHiddenAfterDeath;

	public bool IsTeammatesKillShow;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
