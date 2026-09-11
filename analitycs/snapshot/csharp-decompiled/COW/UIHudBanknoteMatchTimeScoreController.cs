using GCommon;

namespace COW;

public class UIHudBanknoteMatchTimeScoreController : UIBaseController
{
	private UIHudBanknoteMatchTimeScoreView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private UIModelMatch m_ModelMatch;

	private uint m_CurrentPointID;

	private int targetScore;

	private float m_LastOpenLBTime;

	private uint m_LocalScoreChangeCall;

	private uint m_OppScoreChangeCall;

	private const int OPEN_LB_CD = 5;

	private bool m_IsInScambleState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitScoreUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnPhaseTimeChange(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnLeaderBoardClick()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void OnPickupAmount(object[] data)
	{
	}

	private void OnControlPointChange(object[] data)
	{
	}

	private void ClearUIShow()
	{
	}

	private void OnOccupateTeamChange(object[] data)
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	private void OnRestAmountChange(object[] data)
	{
	}

	private void _003COnTeamScoreChange_003Eb__17_0()
	{
	}

	private void _003COnTeamScoreChange_003Eb__17_1()
	{
	}

	private void _003COnPickupAmount_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
