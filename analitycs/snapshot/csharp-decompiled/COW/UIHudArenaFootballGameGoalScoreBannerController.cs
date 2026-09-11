using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudArenaFootballGameGoalScoreBannerController : UIBaseController
{
	protected UIHudArenaFootballGameGoalScoreBannerView m_View;

	protected BHGGAEEHJCO m_RecentScorerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRecentScorerIDChange(object[] data)
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
