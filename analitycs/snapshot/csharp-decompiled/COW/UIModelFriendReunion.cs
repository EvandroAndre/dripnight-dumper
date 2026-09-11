using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelFriendReunion : UIBaseModel
{
	public enum BtnOperateType
	{
		None,
		LevelLimit,
		Goto,
		FinishedWithNoInviterID,
		CanClaim,
		Claimed
	}

	public enum EFriendStatusType
	{
		None,
		CanInvite,
		CanJoinGroup,
		CanInviteAndJoin
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CallbackProcessDesc> _003C_003E9__120_0;

		internal int _003CSetCallbackProcessDesc_003Eb__120_0(CallbackProcessDesc x, CallbackProcessDesc y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public FriendAccountInfo friend;

		internal bool _003CIsReunionInviteeShow_003Eb__0(CallbackRequest x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public FriendAccountInfo friend;

		internal bool _003CCheckHasInviterRecallFriends_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public FriendAccountInfo friend;

		internal bool _003CSetInviterRecallFriends_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public ulong accountIDNeedRemove;

		internal bool _003COnUpdateCallBackValidFriends_003Eb__0(FriendAccountInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public CallbackAcceptInviteNtf callbackUpAcceptInviteNtf;

		internal bool _003COnCallbackAcceptInviteUpdate_003Eb__0(ReturnerCallbackInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public ReturnerGamePlayedInfo returnerInfo;

		internal bool _003COnCallbackPointUpdate_003Eb__0(ReturnerCallbackInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public FriendCallbackInviteNtf callbackUpInvite;

		internal bool _003COnReceiveCallBackInvite_003Eb__0(CallbackRequest x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestFriendReunionDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		internal void _003CRequestFriendReunionInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		public List<FriendAccountInfo> list;

		internal void _003CRequestCallBackValidFriends_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		internal void _003CRequestClaimProgressAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_1
	{
		public CSClaimCallbackProcessRewardRes info;

		internal bool _003CRequestClaimProgressAward_003Eb__1(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		internal void _003CRequestRecallFriends_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_1
	{
		public ulong receiverID;

		internal bool _003CRequestRecallFriends_003Eb__1(CallbackRequest x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		public ulong inviterID;

		internal void _003CRequestAcceptFriendCallbackInvite_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public UIModelFriendReunion _003C_003E4__this;

		public string cmd;

		internal void _003CRequestAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public uint taskID;

		internal bool _003CGetSelfTaskInfoByTaskID_003Eb__0(CallbackTaskInfo x)
		{
			return false;
		}
	}

	public const int PropID_FriendReunionReady = 1;

	public const int PropID_GetFriendReunionDesc = 2;

	public const int PropID_GetFriendReunionInfo = 4;

	public const int PropID_CallBackValidFriends = 8;

	public const int PropID_FriendReunionRedTipsUpdate = 16;

	public const int PropID_HideRemindTips = 32;

	public const int PropID_ClaimCallbackProgressAward = 64;

	public const int PropID_InviterSendFriendCallback = 128;

	public const int PropID_InviteeAcceptFriendCallbackInvite = 256;

	public const int PropID_OnCallbackPointUpdate = 512;

	public const int PropID_OnInviteeReceiveCallBackInvite = 1024;

	public const int PropID_OnInviteeFriendTaskInfoUpdate = 2048;

	public const int PropID_OnInviterAcceptFriendCallbackInviteUpdate = 4096;

	private const byte ALL_STEP_READY = 14;

	private byte m_ReadyFlag;

	private uint m_ReunionPlayerLevelLimit;

	private CallbackOpenInfoDesc m_FriendReunionOpenInfo;

	private List<CallbackTaskDesc> m_ListFriendReunionTaskDesc;

	private PlayerCallbackInfo m_SelfInfo;

	private List<ReturnerCallbackInfo> m_ListInvitedReturnerInfo;

	private CallbackPointDesc m_CallbackPointDesc;

	private CSGetPlayerCallbackInfoRes m_CallBackInfo;

	private readonly Dictionary<uint, List<CallbackProcessDesc>> m_CallBackIDToProcessDescsDic;

	private readonly Dictionary<uint, int> m_DicTaskIDToType;

	private readonly List<FriendCallData> m_InviterRecallFriendDatas;

	private readonly List<CallBackFriendData> m_InviterTeamFriendDatas;

	private readonly List<FriendAccountInfo> m_CallBackValidFriendInfos;

	private ulong m_AddFriendIDCache;

	private long m_ReturnPlayerTimeSecs;

	private bool m_FriendReunionInActivityOpen;

	private bool m_IsFriendReunionActivityShow;

	private bool m_IsCallBackValidFriendsReady;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private WaitingResponseHandlerWithRequest m_WaitingHandlerResponseWithRequest;

	public static string PROGRESS_KEY;

	public static float ONLYONE_EASYLISTWIDTH;

	public static float RECALL_EASYLISTWIDTH;

	public static float TEAM_EASYLISTWIDTH;

	public static float ITEM_WIDTH_OFFSET;

	public static float QUICK_BTN_OFFSET;

	public static float TEAM_SSCORE_OFFSET;

	public static float TEAM_SSCORE_OFFSET_BIGTYPE;

	private List<float> m_ProgressBarVal;

	private byte ReadyFlag
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint CallBackID => 0u;

	public bool IsCallBackOpen => false;

	public bool IsFriendReunionExpire => false;

	public bool IsFriendReunionOpen => false;

	public bool IsPlayerCallBack => false;

	public bool IsUserLevelMatchReunionPlayerLevelLimit => false;

	public uint ReunionPlayerLevelLimit => 0u;

	public bool FriendReunionInActivityOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public long FriendReunionStartTimestamp => 0L;

	public long FriendReunionEndTimestamp => 0L;

	public List<FriendCallData> InviterRecallFriendDatas => null;

	public List<CallBackFriendData> InviterTeamFriendDatas => null;

	public bool IsFriendReunionActivityShow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private EFriendStatusType GetFriendStatusType(BaseProfileInfo info)
	{
		return EFriendStatusType.None;
	}

	private EFriendStatusType GetFriendStatusTypeInGroup(BaseProfileInfo info)
	{
		return EFriendStatusType.None;
	}

	public void ProcessFriendReunionFakingActivityData()
	{
	}

	public CallbackTaskInfo GetSelfTaskInfoByTaskID(uint taskID)
	{
		return null;
	}

	public bool HasSetInviterID()
	{
		return false;
	}

	public BtnOperateType GetBtnOperateState(CallbackTaskInfo info)
	{
		return BtnOperateType.None;
	}

	public bool HasInvitedReturners()
	{
		return false;
	}

	public string GetTaskTitle(CallbackTaskDesc DescData)
	{
		return null;
	}

	public List<CallbackProcessDesc> GetCallBackProgressItemDatas()
	{
		return null;
	}

	public int GetCurCallBackScore()
	{
		return 0;
	}

	public string GetActivityStartEndTime()
	{
		return null;
	}

	public int GetCallBackScore()
	{
		return 0;
	}

	public int GetGameScore()
	{
		return 0;
	}

	public int GetGameScoreMax()
	{
		return 0;
	}

	private int GetPlayMaxTimes()
	{
		return 0;
	}

	public bool CheckFriendIsCalledBack(ulong accountID)
	{
		return false;
	}

	public bool ReachMaxInTeamScore(ulong accountID)
	{
		return false;
	}

	public List<CallbackTaskDesc> GetCallBackTaskDescs()
	{
		return null;
	}

	public bool IsSuccessBind()
	{
		return false;
	}

	public ulong GetBindFriendAccountID()
	{
		return 0uL;
	}

	public CallbackRequest GetRequestSenderData(ulong accountID)
	{
		return null;
	}

	public bool CheckProgressAwardIsClaimed(uint processID)
	{
		return false;
	}

	public bool CheckProgressValReached(int progressVal)
	{
		return false;
	}

	public bool IsReunionInviterShow()
	{
		return false;
	}

	public bool IsReunionInviteeShow()
	{
		return false;
	}

	public bool CheckHasInviterRecallFriends()
	{
		return false;
	}

	public void SetInviterRecallFriends()
	{
	}

	public void SetInviterTeamFriends()
	{
	}

	public void RefreshCallBackFriendData(CallBackFriendData data)
	{
	}

	public void ProcessReturnPlayerConfigDesc(ReturnPlayerConfigDesc returnPlayerConfigDesc)
	{
	}

	public float GetCurProgressStageRate()
	{
		return 0f;
	}

	public int GetFriendReunionInviteeRedTips()
	{
		return 0;
	}

	public int GetFriendReunionInviterRedTips()
	{
		return 0;
	}

	public void NotifyUpdateRedTipsInActivityTab()
	{
	}

	public void OnUpdateCallBackValidFriends(ulong[] account_ids)
	{
	}

	public void OnCallbackAcceptInviteUpdate(CallbackAcceptInviteNtf callbackUpAcceptInviteNtf)
	{
	}

	public void OnCallbackPointUpdate(CallbackPointUpdateNtf callbackUpPointValue)
	{
	}

	public void OnReceiveCallBackInvite(FriendCallbackInviteNtf callbackUpInvite)
	{
	}

	public void OnInviteeTaskProgressChange(CallbackTaskUpdateNtf updateValue)
	{
	}

	public void RequestCallBackValidFriendInfos()
	{
	}

	public HttpRequest RequestFriendReunionDesc(bool force = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return null;
	}

	private void SetCallbackProcessDesc(CSGetReturnPlayerSettingDescRes info)
	{
	}

	public HttpRequest RequestFriendReunionInfo(bool force = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return null;
	}

	public void RequestCallBackValidFriends()
	{
	}

	private void ProcessInfoType()
	{
	}

	public void RequestClaimProgressAward(uint processID)
	{
	}

	public void RequestRecallFriends(List<ulong> accountIDs)
	{
	}

	public void RequestAcceptFriendCallbackInvite(ulong inviterID)
	{
	}

	public void RequestAward(uint taskID)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
