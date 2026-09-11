using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudFootballGameLeaderBoardController : UIHUDFootballGameLeaderBoardBaseController<UIHudFootballGameLeaderBoardItemController>
{
	private enum EPlayerHandleType
	{
		Add,
		Quit
	}

	private class PlayerHandleInfo
	{
		public BHGGAEEHJCO PID;

		public EPlayerHandleType HandleType;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__15_0;

		internal void _003CSetChildOfMatchResult_003Eb__15_0()
		{
		}
	}

	private bool m_IsChildOfMatchResult;

	private Queue<PlayerHandleInfo> m_PlayerHandleInfos;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetInfoTitlesByInfoType()
	{
	}

	protected override void SetInfoTypeList()
	{
	}

	protected override void SetSortingTypes()
	{
	}

	public override void RegisterUIEvent()
	{
	}

	protected override bool IsPlayerExist(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public override void OnAddPlayer(GEvent param)
	{
	}

	protected override void OnPlayerAdded(UIHudFootballGameLeaderBoardItemController itemCtrl)
	{
	}

	private void OnPlayerTeamChange(object[] data)
	{
	}

	private void ShowLeaderBoard(object[] param)
	{
	}

	public void SetChildOfMatchResult()
	{
	}

	private bool IsFightingPhase()
	{
		return false;
	}

	private void HandleDelayedPlayerAddQuit()
	{
	}

	private void RemoveDeletedPlayers()
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoTitlesByInfoType()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoTypeList()
	{
	}

	public void _003C_003EiFixBaseProxy_SetSortingTypes()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsPlayerExist(BHGGAEEHJCO P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAddPlayer(GEvent P0)
	{
	}
}
