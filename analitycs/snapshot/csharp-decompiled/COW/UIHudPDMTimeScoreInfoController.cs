using GCommon;

namespace COW;

public class UIHudPDMTimeScoreInfoController : UIBaseController
{
	private UIHudPDMTimeScoreInfoView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private bool m_IsShowVfx;

	protected MutableString m_RankLabelTextBuilder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void OnPhaseTimeChange(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	private void OnLocalPlayerSetRank(uint data)
	{
	}

	private void OnFirstPlacePlayerSetKillCnt(int data)
	{
	}

	private void OnShowGuide(object[] data)
	{
	}

	protected void OnTargetScoreChange(object[] data)
	{
	}

	public void ShowOvertimeVFX(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
