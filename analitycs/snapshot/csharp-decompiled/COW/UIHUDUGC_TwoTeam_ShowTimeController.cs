using GCommon;

namespace COW;

internal class UIHUDUGC_TwoTeam_ShowTimeController : UIHUDUGC_InternalHudController
{
	private enum ShowTimeEnum
	{
		None,
		Victory,
		Defeated,
		Draw,
		Booyah
	}

	private UIHUDUGC_TwoTeam_ShowTimeView m_View;

	private UGCRoundResultShowTimeHudRepItem m_ViewData;

	private int m_PhaseEndTime;

	private int m_PhaseCountDown;

	private int m_LastTime;

	private uint m_DelayReturnBtnEnableID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void UpdatePhaseCountDown()
	{
	}

	private void Update()
	{
	}

	private void OnReturnBtnClick()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnShowTimeTypeChanged(int cur)
	{
	}

	private void OnPhaseEndTimeChanged(int cur)
	{
	}

	private void OnShowTwoTeamScoreChanged(bool cur)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void _003CRefreshVisibility_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
