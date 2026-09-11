using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIModelTeamReserve : UIBaseModel, IUIModelDataChangeObserver
{
	public enum ReserveStatus
	{
		None,
		Reserved,
		Reserving,
		ReserveRejected
	}

	public enum EReserveReplyStatus
	{
		None,
		Accepted,
		Rejected,
		Expired
	}

	public enum ReserveRejectedReason
	{
		None,
		AcceptOther,
		MaxLimit,
		SettingBlock,
		TempBlock,
		Repeated,
		RejectAfterAll,
		NotInGame,
		InGame,
		Expired
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public ulong id;

		public UIModelTeamReserve _003C_003E4__this;

		internal void _003CNotifyReservationSend_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public ulong id;

		internal bool _003CClearReserveById_003Eb__0(GroupReservationShowInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public ulong id;

		internal bool _003CGetFriendAccountInfoById_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIModelTeamReserve _003C_003E4__this;

		public UIModelCustomRoom modelRoom;

		public UIModelGroup modelGroup;
	}

	private sealed class _003C_003Ec__DisplayClass76_1
	{
		public FriendAccountInfo tempInfo;

		public _003C_003Ec__DisplayClass76_0 CS_0024_003C_003E8__locals1;

		internal void _003CProcessReserveContentForBeReserved_003Eb__0()
		{
		}

		internal void _003CProcessReserveContentForBeReserved_003Eb__1()
		{
		}

		internal void _003CProcessReserveContentForBeReserved_003Eb__2()
		{
		}

		internal void _003CProcessReserveContentForBeReserved_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public bool isRoomConcerned;

		public UIModelTeamReserve _003C_003E4__this;

		public ulong accountId;

		internal void _003CShowQuitGroupHint_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public UIModelTeamReserve _003C_003E4__this;

		public UIModelCustomRoom modelRoom;

		internal void _003CRepopReserveForRoom_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public UIModelTeamReserve _003C_003E4__this;

		public ulong inviterId;

		internal void _003COnMixGroupInviteNtfInGame_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public UIModelTeamReserve _003C_003E4__this;

		public ulong requesterId;

		internal void _003COnMixGroupJoinNtfInGame_003Eb__0()
		{
		}
	}

	public const int PropID_UpdateReserveStatus = 1;

	public const int PropID_UpdateReservationList = 2;

	public const int PropID_UpdateMixGroupInviteList = 4;

	public const int PropID_UpdateMixGroupJoinList = 8;

	private Dictionary<ulong, ReserveStatus> m_ReserveStatusDic;

	private Dictionary<ulong, long> m_ReserveTimeDic;

	private bool m_ReserveFlag;

	private bool m_AutoReject;

	private bool m_ReturnToLobbyFlag;

	private List<FriendAccountInfo> m_ReserveReplyInfoList;

	private Dictionary<ulong, ReserveReplyStatus> m_WaitingList;

	private Dictionary<ulong, MixGroupInviteStatus> m_MixGroupInviteList;

	private Dictionary<ulong, MixGroupJoinStatus> m_MixGroupJoinList;

	private ulong m_PendingMixGroupInviteId;

	private ulong m_PendingMixGroupJoinId;

	private Dictionary<ulong, uint> m_ReceiverIDToSourceDict;

	private Dictionary<ulong, uint> m_SenderIDToSourceDict;

	private Dictionary<ulong, int> m_ReceiverStatusDict;

	private bool m_SettingSwitchOn;

	private bool m_IsReservationBlocked;

	public bool IsRoomReserveNeedRepop;

	public FriendAccountInfo m_RoomReservePopInfo;

	private bool m_LeaveGroup;

	private ulong m_InviteAccountId;

	private string m_InviteRegion;

	private List<ulong> m_ReserveIdList;

	public bool Unread;

	private List<ReservationSenderInfo> m_NewReservationSenderInfos;

	private uint m_FriendListTimeoutDelayCallID;

	public bool IsReservationBlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Dictionary<ulong, ReserveStatus> ReserveStatusDic
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<ulong, ReserveReplyStatus> WaitingList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<ulong, MixGroupInviteStatus> MixGroupInviteList => null;

	public Dictionary<ulong, MixGroupJoinStatus> MixGroupJoinList => null;

	public ulong PendingMixGroupInviteId => 0uL;

	public ulong PendingMixGroupJoinId => 0uL;

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void CheckBlock()
	{
	}

	public void UpdateStatus(ulong id)
	{
	}

	public void CancelWaitingListDelayCall(ulong id)
	{
	}

	public void NotifyReservationSend(ReservationSenderInfo reservationSenderInfo, uint source)
	{
	}

	private uint GetReservationMessageSourceBySenderId(ulong id)
	{
		return 0u;
	}

	private uint GetReservationMessageSourceByReceiverId(ulong id)
	{
		return 0u;
	}

	private int GetReservationGameTypeOfReceiver(ulong id)
	{
		return 0;
	}

	public void NotifyReservationSend()
	{
	}

	public void RequestReservationReply(ulong id, EReserveReplyStatus status, ReserveRejectedReason reason = ReserveRejectedReason.None)
	{
	}

	public void NotifyReservationReply(ulong id, bool isAccepted)
	{
	}

	public void ClearReserveById(ulong id)
	{
	}

	public FriendAccountInfo GetFriendAccountInfoById(ulong id)
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void ClearData()
	{
	}

	public void ReturnToLobby(bool refreshFriendList = true)
	{
	}

	public void ClearWaitingListData()
	{
	}

	public void ClearReserveReplyInfoListData()
	{
	}

	public void ClearReserve()
	{
	}

	public void SendMessage(ulong accountId, string content)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnReserveBtnClick(ulong id)
	{
	}

	public void SendReserveMessage(ulong id, bool isFrontEndGame = true)
	{
	}

	public void AfterOnGroupCreate()
	{
	}

	private void ProcessReserveContentForBeReserved()
	{
	}

	public void ProcessReserveContentForReserve(GroupJoinRequestNtf joinData)
	{
	}

	public void AfterRequestLeaveGroup()
	{
	}

	public void ShowQuitGroupHint(string hintContent, Action action, ulong accountId, string nickName, string title = null, bool isRoomConcerned = false)
	{
	}

	public void RepopReserveForRoom()
	{
	}

	public ReserveStatus GetReserveStatusByAccountId(ulong id)
	{
		return ReserveStatus.None;
	}

	public bool HasAcceptedReservation()
	{
		return false;
	}

	private bool IsMatchMaking()
	{
		return false;
	}

	private void RefuseReserve(ulong accountId, ReserveRejectedReason reason = ReserveRejectedReason.None)
	{
	}

	private void AcceptReserve(ReservationSenderInfo reservationSenderInfo, ulong gameStartTime, uint gameMode, uint mapId, uint matchId)
	{
	}

	private void LogReservationConfirm(ulong receivedAccountId, bool confirm)
	{
	}

	public void LogReservationResult(ulong sendAccountId, ulong receivedAccountId, bool result)
	{
	}

	public void OnJoinRequestNtfAndInviteNtfInGame(ulong id)
	{
	}

	public void OnMixGroupInviteNtfInGame(GroupInviteNtf data)
	{
	}

	private void OnMixGroupInviteExpired(ulong inviterId)
	{
	}

	public void AcceptMixGroupInvite(ulong inviterId)
	{
	}

	private void AutoRejectOtherMixGroupInvites(ulong acceptedInviterId)
	{
	}

	public void RejectMixGroupInvite(ulong inviterId, uint rejectReasonIndex = 0u)
	{
	}

	public MixGroupInviteStatus GetMixGroupInviteStatus(ulong inviterId)
	{
		return null;
	}

	public void ClearAllMixGroupInvites()
	{
	}

	public bool HasMixGroupInvite(ulong inviterId)
	{
		return false;
	}

	public void OnMixGroupInviteAcceptSuccess()
	{
	}

	public void OnMixGroupInviteAcceptFailed()
	{
	}

	public void OnMixGroupJoinNtfInGame(GroupJoinRequestNtf data)
	{
	}

	private void OnMixGroupJoinExpired(ulong requesterId)
	{
	}

	public void AcceptMixGroupJoin(ulong requesterId)
	{
	}

	private void AutoRejectOtherMixGroupJoins(ulong acceptedRequesterId)
	{
	}

	public void RejectMixGroupJoin(ulong requesterId)
	{
	}

	public MixGroupJoinStatus GetMixGroupJoinStatus(ulong requesterId)
	{
		return null;
	}

	public void ClearAllMixGroupJoins()
	{
	}

	public bool HasMixGroupJoin(ulong requesterId)
	{
		return false;
	}

	public void OnMixGroupJoinAcceptSuccess(GroupMemberInfo newMemberInfo = null, GroupInfo groupInfo = null)
	{
	}

	public void OnMixGroupJoinAcceptFailed()
	{
	}

	public void PopPendingMixGroupMessagesForMatchEnd(List<GroupInviteNtf> outInviteList, List<GroupJoinRequestNtf> outJoinList)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
