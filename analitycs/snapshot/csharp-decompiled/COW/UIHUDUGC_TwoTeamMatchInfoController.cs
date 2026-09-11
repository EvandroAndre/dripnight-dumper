using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamMatchInfoController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_TwoTeamMatchInfoView m_View;

	private UGCTwoTeamMatchInfoHudRepItem m_ViewData;

	private Color Blue;

	private Color Red;

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

	private void ShowTeammateState(UIGrid grid, int alive, int dead, int knockDown, int flag)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnShowTeamScoreChanged(bool cur)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void OnShowTeammateStateChanged(bool cur)
	{
	}

	private void OnLeftTeammateStateArrayChanged(List<object> cur)
	{
	}

	private void OnRightTeammateStateArrayChanged(List<object> cur)
	{
	}

	private void OnLeftTeammateFlagCountChanged(int cur)
	{
	}

	private void OnRightTeammateFlagCountChanged(int cur)
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
}
