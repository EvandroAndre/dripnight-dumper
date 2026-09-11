using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudFootballGameGoalScoreBannerController : UIBaseController
{
	protected UIHudFootballGameGoalScoreBannerView m_View;

	protected BHGGAEEHJCO m_RecentScorerID;

	private uint m_AutoHideDelay;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnRecentScorerIDChange(object[] data)
	{
	}

	protected virtual void OnTeamScoreChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
