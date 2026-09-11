using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_TwoTeamLeaderboardControllerV2 : UIHUDUGC_InternalHudController
{
	private static int LEFT_INDEX;

	private static int RIGHT_INDEX;

	protected UserControlHandler m_UserControl;

	protected bool m_OriginInputState;

	private UIHUDUGC_TwoTeamLeaderboardView m_View;

	private UGCTwoTeamLeaderboardHudV2RepItem m_ViewData;

	private UIHUDUGC_TwoTeamLeaderboard_TeamItemController[] m_Teams;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnSpaceBtnClick()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void OnLeftPlayerArrayChanged(List<object> cur)
	{
	}

	private void OnRightPlayerArrayChanged(List<object> cur)
	{
	}

	private void OnScoreTypeNamesChanged(List<object> cur)
	{
	}

	private void OnLeftScoreContentChanged(List<object> cur)
	{
	}

	private void OnRightScoreContentChanged(List<object> cur)
	{
	}

	private void RefreshTeamCustomPlayerScores(bool refreshScoreOnly, int teamUIIndex, Transform teamParent, List<object> playerList, List<object> scoreContent)
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

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
