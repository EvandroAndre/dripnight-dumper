using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudFightClubRoundTransitionController : UIBaseController
{
	private UIHudRoundTransitionView m_View;

	private UIModelMatch m_ModelMatch;

	private KOFCHBDBMFD mGame;

	private int m_ScoreCached;

	private float m_Time;

	private float m_ScoreAnimTime;

	private bool m_ScoreAnimTick;

	private bool m_ShowVicotry;

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

	private void SetFeedbackView()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void HideVicotryRoot()
	{
	}

	private void Update()
	{
	}

	private void SetUIData()
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void ShowScores()
	{
	}

	private void ResetScoreAnimation()
	{
	}

	private void OnLocalPlayerJoin(object[] data)
	{
	}

	private void OnFactionIDChanged(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnMatchPoint(object[] data)
	{
	}

	private void RefreshMatchPointNode()
	{
	}

	private void OnAnimEventGridReposition(object[] data)
	{
	}

	private void OnAnimEventShowMatchPoint(object[] data)
	{
	}

	private void OnAnimEventShowLastRound(object[] data)
	{
	}

	private void OnTransitionAppear(object[] data)
	{
	}

	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
