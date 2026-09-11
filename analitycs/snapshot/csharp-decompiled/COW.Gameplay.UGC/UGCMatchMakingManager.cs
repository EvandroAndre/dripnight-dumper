using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCMatchMakingManager : SingletonModule<UGCMatchMakingManager>
{
	private enum UGCMatchMakingState
	{
		NotReady,
		LeaveGroup,
		LeaveRoom,
		RequestSlotInfo,
		Matchmaking
	}

	public enum UGCMatchMakingResult
	{
		NotFinished,
		Succeed,
		Failed
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<uint, bool> _003C_003E9__22_0;

		internal bool _003CCanMatchmaking_003Eb__22_0(uint ruleTag)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UGCMatchMakingManager _003C_003E4__this;

		public Action<SceneEditSlotInfo> callback;

		internal void _003CRequestSlotInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private UGCMatchMakingState m_State;

	private UGCMatchMakingResult m_Result;

	private bool m_IsInGameMatchMaking;

	private bool m_LeaveGroupFailed;

	private UIHUDUGC_MatchMakingWaitingController m_MatchMakingHud;

	private UIInGameScene m_InGameScene;

	private int m_PanelDepth;

	private string m_CurrentWorkshopCode;

	private Action m_PlayerQuitCallback;

	private bool m_ShowMsgWhenCancel;

	private bool m_RestartMsgActivated;

	public string LastGameShareCode;

	public ulong LastGameMatchId;

	private Dictionary<ulong, Player> m_CachedDeadPlayer;

	private bool IsMatchMaking => false;

	public bool IsInGameMatchMaking => false;

	public bool ShowMsgWhenCancel => false;

	private bool NextState(UGCMatchMakingState nextState)
	{
		return false;
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool CanMatchmaking(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	private void RequestSlotInfo(Action<SceneEditSlotInfo> callback)
	{
	}

	private void OnSlotInfoReady(SceneEditSlotInfo slotInfo)
	{
	}

	public void RequestStartInGameMatchMaking(string workshopCode, bool showMsgWhenCancel)
	{
	}

	public void RequestRestartInGameMatchMaking(bool changeTarget = false, string workshopCode = "")
	{
	}

	private void RequestLeaveGroup()
	{
	}

	private void OnLeaveGroup(object[] data)
	{
	}

	public void OnLeaveGroupFailed()
	{
	}

	private void OnGroupError()
	{
	}

	private void RequestLeaveRoom()
	{
	}

	public void OnLeaveRoom()
	{
	}

	public void OnStartInGameMatchMaking(object[] data)
	{
	}

	public void OnEndInGameMatchMaking(object[] data)
	{
	}

	public void HandleInGameMatchMakingFailed(bool showOptionMsg)
	{
	}

	public void SetMatchMakingResult(bool isSucceed)
	{
	}

	public void ShowMsgOrEndMatchMaking()
	{
	}

	public void StopInGameMatchMaking(bool returnToLobby = true)
	{
	}

	public void CacheDeadPlayer(object player)
	{
	}

	public void ClearCachedDeadPlayer()
	{
	}

	public void Hide3PForInGameMatchMaking(uint playerId)
	{
	}

	public void NotifyGSMatchmakingFinished()
	{
	}

	private void _003CShowMsgOrEndMatchMaking_003Eb__39_0()
	{
	}

	private void _003CShowMsgOrEndMatchMaking_003Eb__39_1()
	{
	}
}
