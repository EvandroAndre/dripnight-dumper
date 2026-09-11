using GCommon;

namespace COW;

public class UIHudControlMatchTimeScoreController : UIBaseController
{
	private UIHudControlMatchTimeScoreView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private UIModelMatch m_ModelMatch;

	private uint m_CurrentPointID;

	private byte m_OccuTeamID;

	private int targetScore;

	private float m_LastOpenLBTime;

	private const int OPEN_LB_CD = 5;

	private const uint NO_OCCUPY_COLOR = 4289440683u;

	private const uint LOCAL_OCCUPY_COLOR = 4279274166u;

	private const uint OPP_OCCUPY_COLOR = 4290989341u;

	private const uint NO_OCCUPY_LIGHT = 4278190080u;

	private const uint LOCAL_OCCYPY_LIGHT = 4284004299u;

	private const uint OPP_OCCUPY_LIGHT = 4294946304u;

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

	private void PlayLocalOccupyEffect()
	{
	}

	private void PlayOppOccupyEffect()
	{
	}

	private void OnFactionIDChanged(object[] data)
	{
	}

	private void _003CPlayLocalOccupyEffect_003Eb__26_0()
	{
	}

	private void _003CPlayOppOccupyEffect_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
