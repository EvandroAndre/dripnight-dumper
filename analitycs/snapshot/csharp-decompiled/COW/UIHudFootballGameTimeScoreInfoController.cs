using GCommon;

namespace COW;

public class UIHudFootballGameTimeScoreInfoController : UIBaseController
{
	protected UIHudFootballGameTimeScoreInfoView m_View;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void ShowHud(bool show, bool active = true)
	{
	}

	private void OnBtnLeaderBoardClick()
	{
	}

	private void OnPhaseTimeChange(object[] data)
	{
	}

	public void ShowOvertimeVFX()
	{
	}

	protected virtual void OnTeamScoreChange(object[] data)
	{
	}

	private void OnLeaderBoardGuideShow(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
