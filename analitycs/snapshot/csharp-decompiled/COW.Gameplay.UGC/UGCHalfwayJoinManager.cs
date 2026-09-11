using System;
using GCommon;
using tcp;

namespace COW.Gameplay.UGC;

public class UGCHalfwayJoinManager : SingletonModule<UGCHalfwayJoinManager>
{
	private enum UGCHalfwayJoinState
	{
		Idle,
		WaitingCheck,
		WaitingSlotInfo,
		WaitingPreConfirm,
		WaitingLeave,
		WaitingDownload,
		Prepared,
		WaitingPassword,
		WaitingJoinResp
	}

	private class HalfwayJoinArgs
	{
		public ulong target_room_id;

		public ulong target_account_id;

		public string code;

		public bool from_invite;

		public ulong inviter_account_id;

		public string workshop_code;

		public string workshop_name;

		public uint map_id;

		public uint game_mode;
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UGCHalfwayJoinManager _003C_003E4__this;

		public UIModelSceneEdit modelSceneEdit;

		internal void _003CRequestSlotInfoThenProceed_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UGCHalfwayJoinManager _003C_003E4__this;

		public UICommonCountDownBoxController ctrl;

		internal void _003COnDownloadPhaseComplete_003Eb__0()
		{
		}

		internal void _003COnDownloadPhaseComplete_003Eb__1()
		{
		}
	}

	private UGCHalfwayJoinState m_State;

	private HalfwayJoinArgs m_PendingArgs;

	private bool m_NeedSecondCheckLeave;

	private bool m_NeedCode;

	private SceneEditSlotInfo m_SlotInfo;

	private UGCSimpleDownloadTask m_ResDownloadTask;

	private float m_Needdownloadsize;

	private Action m_OnLeaveChainComplete;

	private int m_GameDataUrlRetryCount;

	public bool IsInHalfwayJoin => false;

	public bool IsCurrentRoomHalfwayJoinEnabled => false;

	public bool IsCurrentRoomFull => false;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private bool CanStart()
	{
		return false;
	}

	public void RequestInvite(ulong inviteeAccountId)
	{
	}

	public void StartJoinFromLobby(FriendAccountInfo friend)
	{
	}

	public void StartJoinFromInvite(RoomWorkshopHalfwayInviteNtf ntf)
	{
	}

	public void OnCheckNtf(RoomWorkshopHalfwayJoinCheckNtf ntf)
	{
	}

	private void RequestSlotInfoThenProceed()
	{
	}

	private void OnSlotInfoReady(SceneEditSlotInfo slotInfo)
	{
	}

	private void RequestGameDataUrl()
	{
	}

	private void ProceedAfterResInfoReady()
	{
	}

	public void OnHalfwayJoinError(uint errCode)
	{
	}

	private string GetErrCodeLocKey(uint errCode)
	{
		return null;
	}

	private void StartLeave()
	{
	}

	private void RunLeaveChain()
	{
	}

	private void OnLeaveGroupFinished(object[] data)
	{
	}

	private void LeaveRoomIfNeeded()
	{
	}

	private void OnLeaveGroupError()
	{
	}

	private void OnLeavePhaseComplete()
	{
	}

	private void StartDownload()
	{
	}

	private void OnDownloadRefresh(object[] data)
	{
	}

	private void OnDownloadFailed(object[] data)
	{
	}

	private void UnRegisterDownloadEvents()
	{
	}

	private void OnDownloadPhaseComplete()
	{
	}

	private void StartPostDownloadLeave()
	{
	}

	private void OnAllPhasesComplete()
	{
	}

	private void OnFinalConfirmOK()
	{
	}

	private void SendHalfwayJoinReq()
	{
	}

	private RoomWorkshopHalfwayJoinReq BuildHalfwayJoinReq()
	{
		return null;
	}

	private void ShowPreConfirmDialog(string content, bool needLeave)
	{
	}

	private string BuildPreConfirmContent(bool needDownload, bool needLeaveGroup, bool needLeaveRoom)
	{
		return null;
	}

	private void ApplyMapDataToLobbyUI()
	{
	}

	private bool NeedDownloadForWorkshop()
	{
		return false;
	}

	private void ShowTips(string locKey)
	{
	}

	public void ResetFlow()
	{
	}

	private void _003CRequestGameDataUrl_003Eb__26_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGameDataUrl_003Eb__26_1(byte[] gameDataBytes)
	{
	}

	private void _003CProceedAfterResInfoReady_003Eb__27_0()
	{
	}

	private void _003COnFinalConfirmOK_003Eb__43_0(string code, string group, string groupAbbr)
	{
	}

	private void _003CShowPreConfirmDialog_003Eb__46_0()
	{
	}

	private void _003CShowPreConfirmDialog_003Eb__46_1()
	{
	}

	private void _003CShowPreConfirmDialog_003Eb__46_2()
	{
	}
}
