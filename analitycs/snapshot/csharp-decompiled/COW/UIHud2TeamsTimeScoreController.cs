using GCommon;

namespace COW;

public class UIHud2TeamsTimeScoreController : UIBaseController
{
	private UIHud2TeamsTimeScoreView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private uint m_ScoreEffectDelayCallIDTeam1;

	private uint m_ScoreEffectDelayCallIDTeam2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void OnTDMPhaseChange(object[] data)
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

	private void OnTargetScoreChange(object[] data)
	{
	}

	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	private void OnADSBonusTeamScoreStart(object[] data)
	{
	}

	private void _003CUpdateTeamScore_003Eb__13_0()
	{
	}

	private void _003CUpdateTeamScore_003Eb__13_1()
	{
	}

	private void _003COnADSBonusTeamScoreStart_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
