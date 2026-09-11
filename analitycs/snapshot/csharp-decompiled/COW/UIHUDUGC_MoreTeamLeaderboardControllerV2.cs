using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHUDUGC_MoreTeamLeaderboardControllerV2 : UIHUDUGC_InternalHudController
{
	protected UserControlHandler m_UserControl;

	protected bool m_OriginInputState;

	private UIHUDUGC_MoreTeamLeaderboardView m_View;

	private UGCMoreTeamLeaderboardHudV2RepItem m_ViewData;

	private List<UIHUDUGC_MoreTeamLeaderboard_TeamItemController> m_Teams;

	protected int m_SelfTeamUIIndex;

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

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void PostTeamTableReposition()
	{
	}

	private void OnSpaceBtnClick()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnPlayersChanged(List<object> cur)
	{
	}

	private void OnRanksChanged(List<object> cur)
	{
	}

	private void OnTotalScoresChanged(List<object> cur)
	{
	}

	private void OnScoresChanged(List<object> cur)
	{
	}

	private void OnColorsChanged(List<object> cur)
	{
	}

	private void OnScoreTypeNamesChanged(List<object> cur)
	{
	}

	private void RefreshAll()
	{
	}

	private void RefreshScoresOnly()
	{
	}

	private void UpdateSelfTeamUIIndex()
	{
	}

	private int ConvertObjectToInt(object source)
	{
		return 0;
	}

	private void Reposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
