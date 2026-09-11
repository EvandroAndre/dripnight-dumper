using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudGiantMatchInfoController : UIBaseController
{
	private UIHudGiantMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private BPKGNCEDKAL mGame;

	private UIModelMatch m_ModelMatch;

	private const uint TEAMCOUNT = 4u;

	private const string EMPTY_DIST = "---";

	private const string ZERO_DIST = "0m";

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

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeTxt(int seconds)
	{
	}

	private void OnCurrentRoundChanged(object[] data)
	{
	}

	private void UpdateTeamScore()
	{
	}

	private void OnTeamIconChanged(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnLastTeamScoreChanged(object[] data)
	{
	}

	private void OnCurrentMoveDistanceChanged(object[] data)
	{
	}

	private void OnTotalDistanceChanged(object[] data)
	{
	}

	private void SetRoundInfoUI()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetUIData(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
