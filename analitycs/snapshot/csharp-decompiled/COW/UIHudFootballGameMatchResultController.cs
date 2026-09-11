using GCommon;

namespace COW;

public class UIHudFootballGameMatchResultController : UIBaseController
{
	private UIHudFootballGameMatchResultView m_View;

	private UIHudFootballGameLeaderBoardController m_LeaderBoardCtrl;

	private uint m_Scores;

	private float m_EndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected void OnBtnShareClick()
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
