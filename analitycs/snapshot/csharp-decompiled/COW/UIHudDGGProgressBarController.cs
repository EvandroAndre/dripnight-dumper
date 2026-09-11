using System.Text;
using GCommon;

namespace COW;

public class UIHudDGGProgressBarController : UIBaseController
{
	protected UIHudDGGProgressBarView m_View;

	protected int m_WinScore;

	protected int m_WinTime;

	private int m_MatchEndTime;

	private int m_CurLeftTime;

	private StringBuilder m_Timer;

	protected int m_MyScore;

	private int m_LeadingTeamID;

	protected int m_LeadingScore;

	protected int m_2ndScore;

	private int m_1stDepth;

	private int m_2ndDepth;

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

	private void OnScoreChange(object[] data)
	{
	}

	private void OnLeadingTeamIDChange(object[] data)
	{
	}

	private void OnLeadingScoreChange(object[] data)
	{
	}

	private void On2ndTeamIDChange(object[] data)
	{
	}

	private void On2ndScoreChange(object[] data)
	{
	}

	public void OnFirstSecondInfoChange(int firstTeamdID, int firstScore, int secondTeamID, int secondScore)
	{
	}

	public void OnWinScoreChange(object[] data)
	{
	}

	private void OnWinTimeChange(object[] data)
	{
	}

	private void OnShowScoreTutorial(object[] data)
	{
	}

	public void OnMatchEndTimeChange(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void UpdateBar()
	{
	}

	protected virtual void UpdateBarDetail(bool isLocalLeading)
	{
	}

	private void Update()
	{
	}

	private void _003COnShowScoreTutorial_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
