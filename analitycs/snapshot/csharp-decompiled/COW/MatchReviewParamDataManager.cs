using GCommon;

namespace COW;

public class MatchReviewParamDataManager : SingletonModule<MatchReviewParamDataManager>
{
	private CSVAsyncDataMap<uint, MatchReviewParamData> m_ParamData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public MatchReviewParamData GetParamByUnlockRank(uint unlockRank)
	{
		return null;
	}

	public MatchReviewParamData GetData()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
