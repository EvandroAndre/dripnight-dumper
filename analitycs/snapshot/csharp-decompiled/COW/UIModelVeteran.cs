using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelVeteran : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<VeteranAwardDesc> _003C_003E9__210_0;

		public static Comparison<VeteranAwardDesc> _003C_003E9__210_1;

		public static Comparison<FriendAccountInfo> _003C_003E9__217_0;

		public static Comparison<VeteranRewardItem> _003C_003E9__223_0;

		public static Predicate<BatchShowContentDesc> _003C_003E9__225_0;

		public static Predicate<uint> _003C_003E9__231_0;

		public static Predicate<uint> _003C_003E9__232_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__241_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__242_1;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__244_1;

		internal int _003CFilterActivenessAwardList_003Eb__210_0(VeteranAwardDesc x, VeteranAwardDesc y)
		{
			return 0;
		}

		internal int _003CFilterActivenessAwardList_003Eb__210_1(VeteranAwardDesc x, VeteranAwardDesc y)
		{
			return 0;
		}

		internal int _003CSendLogIntimacyInfos_003Eb__217_0(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}

		internal int _003CProcessVeteranInfo_003Eb__223_0(VeteranRewardItem a, VeteranRewardItem b)
		{
			return 0;
		}

		internal bool _003CProcessBatchShowContentRes_003Eb__225_0(BatchShowContentDesc x)
		{
			return false;
		}

		internal bool _003CAddFriendPresenceBarrageData_003Eb__231_0(uint type)
		{
			return false;
		}

		internal bool _003CAddWeaponPowerBarrageData_003Eb__232_0(uint type)
		{
			return false;
		}

		internal CommonRewardItemInfo _003CRequestClaimDailyReward_003Eb__241_1(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimActivinessRewards_003Eb__242_1(BaseItemInfo item)
		{
			return null;
		}

		internal BaseItemInfo _003COnTcpUpdateTaskInfos_003Eb__244_1(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public uint taskId;

		internal bool _003CGetTaskInfo_003Eb__0(VeteranTaskInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public uint taskId;

		internal bool _003CGetTaskDesc_003Eb__0(ClientVeteranTaskDesc temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass182_0
	{
		public int levelID;

		internal bool _003CGetAwardDescByIndex_003Eb__1(VeteranAwardDesc x)
		{
			return false;
		}

		internal bool _003CGetAwardDescByIndex_003Eb__0(VeteranAwardDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass209_0
	{
		public VeteranAwardDesc item;

		internal bool _003CSetClaimedStageIDInActivenessRewardDescList_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass209_1
	{
		public VeteranAwardDesc item;

		internal bool _003CSetClaimedStageIDInActivenessRewardDescList_003Eb__1(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass212_0
	{
		public uint id;

		internal bool _003CRefreshProgressAwardClaimState_003Eb__0(VeteranAwardDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass212_1
	{
		public uint id;

		internal bool _003CRefreshProgressAwardClaimState_003Eb__1(VeteranAwardDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public int rangeValue;

		public string[] sayHelloFriendIDs;

		internal int _003CSayHelloToIntimacyFriends_003Eb__0(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_1
	{
		public string[] listMeetIntimacyFriendIDString;

		public _003C_003Ec__DisplayClass218_0 CS_0024_003C_003E8__locals1;

		internal void _003CSayHelloToIntimacyFriends_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public UIModelVeteran _003C_003E4__this;

		public string cmd;

		public ClientVeteranTaskDesc desc;

		public bool isLongterm;

		public int index;

		public Predicate<VeteranTaskInfo> _003C_003E9__1;

		public Action _003C_003E9__2;

		internal void _003CRequestClaimTaskRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestClaimTaskRewards_003Eb__1(VeteranTaskInfo temp)
		{
			return false;
		}

		internal void _003CRequestClaimTaskRewards_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_0
	{
		public UIModelVeteran _003C_003E4__this;

		public string cmd;

		public List<uint> taskIDList;

		public List<uint> taskActivenessList;

		internal void _003CRequestClaimTaskRewardsInMatchResult_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_1
	{
		public int i;

		public _003C_003Ec__DisplayClass240_0 CS_0024_003C_003E8__locals1;

		internal bool _003CRequestClaimTaskRewardsInMatchResult_003Eb__1(VeteranTaskInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass241_0
	{
		public UIModelVeteran _003C_003E4__this;

		public string cmd;

		internal void _003CRequestClaimDailyReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass241_1
	{
		public uint id;

		internal bool _003CRequestClaimDailyReward_003Eb__2(VeteranRewardItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_0
	{
		public UIModelVeteran _003C_003E4__this;

		public List<uint> stageIDs;

		public List<uint> specialStageIDs;

		internal void _003CRequestClaimActivinessRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public VeteranTaskUpdateInfo taskInfoUnpdate;

		internal bool _003COnTcpUpdateTaskInfos_003Eb__0(ClientVeteranTaskDesc x)
		{
			return false;
		}

		internal bool _003COnTcpUpdateTaskInfos_003Eb__2(VeteranTaskInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public UIModelVeteran _003C_003E4__this;

		public ulong veteranAccountId;

		internal void _003CInviteVeteranFriendAfterGroupCreate_003Eb__0(object[] _)
		{
		}

		internal void _003CInviteVeteranFriendAfterGroupCreate_003Eb__1()
		{
		}
	}

	public const byte PropID_VeteranRewardInfo = 1;

	public const byte PropID_VeteranInfo = 2;

	public const byte PropID_GetTaskInfo = 4;

	public const byte PropID_GetVeteranConfig = 8;

	public const byte PropID_GetTaskDesc = 16;

	public const uint PropID_TaskRewardsClaim = 32u;

	public const uint PropID_DailyRewardsClaim = 64u;

	public const uint PropID_UpdateTaskInfo = 128u;

	public const uint PropID_ActivenessRewardsClaim = 256u;

	public const uint PropID_TaskRewardsClaimInMatchResult = 512u;

	public const uint PropID_VeteranFirstGameUpdate = 1024u;

	public const uint PropID_VeteranPurchaseSpecialProgressAward = 2048u;

	public const uint PropID_VeteranCallBackBuffCountUpdate = 4096u;

	public const uint PropID_VeteranReady = 8192u;

	public const uint PropID_VeteranBarrageInfo = 16384u;

	private const byte ALL_STEP_READY = 3;

	public const string PROGRESS_FORMAT = "{0}/{1}";

	public const int ACTIVINESS_REWARD_NUM = 4;

	public const int MAX_PROGRESS_REWARD_NUM = 8;

	public const int MISSION_REWARD_NUM = 3;

	public const int DAILY_REWARD_NUM = 7;

	public const string DEFAULTLANG = "default";

	public const uint VETERANTOKENID = 802000027u;

	private const float FIRST_AWARD_PROGRESS_RATE = 0.175f;

	private const float OTHER_AWARD_PROGRESS_RATE = 0.275f;

	private const int CLOCK_4_REFRESH_DELAY = 3;

	private byte m_ReadyFlag;

	private uint m_RecommendAvatarID;

	private uint[] m_RecommendSkillsID;

	private ulong m_LoginTime;

	private bool m_IsVeteran;

	private EAttendance.VeteranLeaveDays m_LeaveDaysTag;

	private CSGetVeteranRewardListRes m_VeteranInfo;

	private VeteranConfigDesc m_VeteranConfigDesc;

	private CSGetVetBarrageInfoRes m_VetBarrageInfo;

	private Dictionary<uint, VeteranModeMainDesc> m_VeteranModeMainDescDict;

	private Dictionary<uint, VeteranModeSubDesc> m_VeteranModeSubDescDict;

	private List<VeteranTaskInfo> m_TaskInfosList;

	private uint m_VeteranDiscount;

	private List<ClientVeteranTaskDesc> m_TaskDescList;

	private readonly List<VeteranAwardDesc> m_ActivenessRewardDescList;

	private readonly List<VeteranAwardDesc> m_SpecialRewardDescList;

	private readonly List<VeteranAwardDesc> m_AllProgressRewardDescList;

	private readonly List<MatchResultTaskInfo> m_VeteranMatchResultTaskFinishedInfoList;

	private readonly List<MatchResultTaskInfo> m_VeteranMatchResultTaskReceivedInfoList;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private List<BatchShowContentDesc> m_BatchShowContentList;

	private Queue<BarrageData> m_VetBarrageInfoQueue;

	private uint m_CSRank;

	public bool GetBarrageInfos;

	public bool GetFriendPresenceState;

	public bool HasAddFriendData;

	public bool HasAddWPData;

	private List<VeteranModeDesc> m_VeteranModeDatas;

	private bool m_HasPurchasedSpecialReward;

	private uint m_VeteranSpecialProgressAwardPrice;

	private readonly Dictionary<uint, VeteranRightsDesc> m_VeteranRightsDic;

	private string OpenItemNewHotTagInGamePlayerPrefs;

	public static string LobbyEventIconWithVeteranPlayerPrefs;

	public static string LobbyBuildIconWithVeteranPlayerPrefs;

	public static string DailySignPlayerPrefs;

	public static string SayHelloFriendsPlayerPrefs;

	public static string VeteranSayHello;

	private bool needShowItemNewHotTagByPlayerPrefs;

	private bool m_CanRequestOfflineFriendsNotify;

	private bool m_SayHelloToConfidantFriendAlredy;

	private bool m_InviteGroupMeetIntimacyFriendsAlredy;

	private const int INVITE_FRIENDS_INTIMACY_LIMIT = 5;

	private bool m_IsFirstVeteran;

	public bool FirstGameTcpFlgDone;

	public bool IsWaitingForSecondGame;

	public VeteranABTestMode GotoAbTestMode;

	private ulong _003CVeteranEndTimeStamp_003Ek__BackingField;

	private uint _003CVeteranBrCallBackBuffCount_003Ek__BackingField;

	private uint _003CVeteranCsCallBackBuffCount_003Ek__BackingField;

	private uint _003CVeteranBrCallBackBuffMaxCount_003Ek__BackingField;

	private uint _003CVeteranCsCallBackBuffMaxCount_003Ek__BackingField;

	private bool _003CHasRequestedCallBackBuffCounts_003Ek__BackingField;

	private long _003CVeteranCallBackBufRefreshTime_003Ek__BackingField;

	private EventDispatcher.EventHandler m_InviteVeteranLambda;

	public List<VeteranTaskInfo> TaskInfosList => null;

	public uint CsRank => 0u;

	public List<VeteranModeDesc> VeteranModeDatas => null;

	public Dictionary<uint, VeteranModeMainDesc> VeteranModeMainDescDict => null;

	public Dictionary<uint, VeteranModeSubDesc> VeteranModeSubDescDict => null;

	public CSGetVetBarrageInfoRes VetBarrageInfo => null;

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

	public bool IsVeteran => false;

	public bool IsFirstVeteran => false;

	public bool IsFirstGamePlayed => false;

	public uint VeteranDiscount => 0u;

	public bool IsVeteranDiscountGet => false;

	public ulong ReturnAt => 0uL;

	public uint RecommendAvatarID => 0u;

	public uint[] RecommendSkillsID => null;

	public bool HasSecondGamePlayed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private int ReminderDays => 0;

	public ulong VeteranStartTimeStamp => 0uL;

	public ulong VeteranEndTimeStamp
	{
		get
		{
			return _003CVeteranEndTimeStamp_003Ek__BackingField;
		}
		private set
		{
			_003CVeteranEndTimeStamp_003Ek__BackingField = value;
		}
	}

	public ulong VeteranDailyMissionRefreshTime => 0uL;

	private ulong VeteranDailyMissionRefreshTimeEachLogin => 0uL;

	public VeteranConfigDesc VeteranConfigDesc => null;

	public List<MatchResultTaskInfo> VeteranMatchResultTaskFinishedInfoList => null;

	public List<MatchResultTaskInfo> VeteranMatchResultTaskReceivedInfoList => null;

	public List<BatchShowContentDesc> BatchShowContentList => null;

	public string LocLang => null;

	public bool HasPurchasedSpecialReward => false;

	public uint VeteranSpecialProgressAwardPrice => 0u;

	public uint VeteranBrCallBackBuffCount
	{
		get
		{
			return _003CVeteranBrCallBackBuffCount_003Ek__BackingField;
		}
		set
		{
			_003CVeteranBrCallBackBuffCount_003Ek__BackingField = value;
		}
	}

	public uint VeteranCsCallBackBuffCount
	{
		get
		{
			return _003CVeteranCsCallBackBuffCount_003Ek__BackingField;
		}
		set
		{
			_003CVeteranCsCallBackBuffCount_003Ek__BackingField = value;
		}
	}

	public uint VeteranBrCallBackBuffMaxCount
	{
		get
		{
			return _003CVeteranBrCallBackBuffMaxCount_003Ek__BackingField;
		}
		set
		{
			_003CVeteranBrCallBackBuffMaxCount_003Ek__BackingField = value;
		}
	}

	public uint VeteranCsCallBackBuffMaxCount
	{
		get
		{
			return _003CVeteranCsCallBackBuffMaxCount_003Ek__BackingField;
		}
		set
		{
			_003CVeteranCsCallBackBuffMaxCount_003Ek__BackingField = value;
		}
	}

	public bool HasRequestedCallBackBuffCounts
	{
		get
		{
			return _003CHasRequestedCallBackBuffCounts_003Ek__BackingField;
		}
		private set
		{
			_003CHasRequestedCallBackBuffCounts_003Ek__BackingField = value;
		}
	}

	public long VeteranCallBackBufRefreshTime
	{
		get
		{
			return _003CVeteranCallBackBufRefreshTime_003Ek__BackingField;
		}
		private set
		{
			_003CVeteranCallBackBufRefreshTime_003Ek__BackingField = value;
		}
	}

	public bool IsOpenItemNewHotTagInGame => false;

	public bool IsVeteranAndValidTime => false;

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Init()
	{
	}

	public void SetPlayerPrefsKeys()
	{
	}

	public void SetVeteran()
	{
	}

	public void SetVeteranLeaveDays(EAttendance.VeteranLeaveDays tag)
	{
	}

	public void SetVeteranStoreDiscount(uint discount)
	{
	}

	public bool IsReady()
	{
		return false;
	}

	public void ClearVeteranMatchResultTaskInfoList()
	{
	}

	public VeteranTaskInfo GetTaskInfo(uint taskId)
	{
		return null;
	}

	public ClientVeteranTaskDesc GetTaskDesc(uint taskId)
	{
		return null;
	}

	public List<AwardDesc> GetFirstReturnRewardList()
	{
		return null;
	}

	public List<AwardDesc> GetFirstGameRewardList()
	{
		return null;
	}

	public AwardDesc GetDailyRewardToday()
	{
		return null;
	}

	public AwardDesc GetDailyRewardNextDay()
	{
		return null;
	}

	public uint GetCurActiveness()
	{
		return 0u;
	}

	public List<VeteranAwardDesc> GetProgressAwardList()
	{
		return null;
	}

	public uint GetLimitActiveness()
	{
		return 0u;
	}

	public bool IsAllAwardClaimed()
	{
		return false;
	}

	public int GetShortTaskCurIndex()
	{
		return 0;
	}

	public int GetDailyRewardIndex()
	{
		return 0;
	}

	public AwardDesc GetAwardDescByIndex(int levelID)
	{
		return null;
	}

	public bool GetMissionDescList(out List<ClientVeteranTaskDesc> missionList, bool isLongTerm)
	{
		missionList = null;
		return false;
	}

	public List<VeteranRewardItem> GetDailyRewardList()
	{
		return null;
	}

	public uint GetShortTermTaskState(uint taskid)
	{
		return 0u;
	}

	public float GetCurProgressStageRate(float curNum)
	{
		return 0f;
	}

	public bool IsDailyRewardSpecialByIndex(int index)
	{
		return false;
	}

	public bool IsLongTermVeteran()
	{
		return false;
	}

	public bool IsLongTermVeteranAndValidTime()
	{
		return false;
	}

	public EAttendance.VeteranLeaveDays GetLeaveDaysTag()
	{
		return EAttendance.VeteranLeaveDays.VeteranLeaveDays_NONE;
	}

	public bool IsDailyRewardTodayClaimed()
	{
		return false;
	}

	public bool IsAllDailyRewardClaimed()
	{
		return false;
	}

	public bool IsAllShortTaskDone()
	{
		return false;
	}

	public bool IsAutoOpenShortVeteranTask()
	{
		return false;
	}

	public bool IsShowMatchResultWnd()
	{
		return false;
	}

	public bool IsRandomTaskNull()
	{
		return false;
	}

	public void ResetItemNewHotTagInGamePlayerPrefs()
	{
	}

	public bool NeedReRequestVeteranInfo()
	{
		return false;
	}

	private List<uint> GetCanClaimProgressAwardStages()
	{
		return null;
	}

	private List<uint> GetCanClaimSpecialProgressAwardStages()
	{
		return null;
	}

	public List<AwardDesc> GetAllUnlockProgressAward()
	{
		return null;
	}

	public VeteranRightsDesc GetValidVeteranRightsDataByPrivilegeType(uint type)
	{
		return null;
	}

	private bool CheckIsActivityValid(uint type)
	{
		return false;
	}

	public void GetThreeRightStyleRes(string style, out string vfxName, out string key, out string icon)
	{
		vfxName = null;
		key = null;
		icon = null;
	}

	public void RescheduleLocalNotifications()
	{
	}

	private bool GetMissionDescListInternal(out List<ClientVeteranTaskDesc> missionList, bool isLongTerm)
	{
		missionList = null;
		return false;
	}

	private VeteranRewardItem GetDailyRewardItemToday(out int index)
	{
		index = default(int);
		return null;
	}

	private bool HasProgressAwardCanClaim()
	{
		return false;
	}

	private void SetClaimedStageIDInActivenessRewardDescList()
	{
	}

	private void FilterActivenessAwardList(List<VeteranAwardDesc> activenessAwardList, List<VeteranAwardDesc> specialAwardList)
	{
	}

	private uint GetVeteranTime()
	{
		return 0u;
	}

	private void RefreshProgressAwardClaimState(List<uint> stageIDs, List<uint> specialStageIDs)
	{
	}

	private void RandomSetItemNewHotTag()
	{
	}

	private bool HaveNewRewardAvailable()
	{
		return false;
	}

	public int GetWaitClaimNum()
	{
		return 0;
	}

	public void RequestPresense()
	{
	}

	private void SendLogIntimacyInfos()
	{
	}

	private void SayHelloToIntimacyFriends()
	{
	}

	private void RequestInteractionSend(ulong id, string playername)
	{
	}

	public void RequestDefaultSend(ulong id, string playername)
	{
	}

	public void SendClanMessage()
	{
	}

	public bool RequestAllVeteranIfNotReady()
	{
		return false;
	}

	public void ProcessVeteranInfo(CSGetVeteranRewardListRes res, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestVeteranData(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void ProcessBatchShowContentRes(CSGetBatchShowContentRes res)
	{
	}

	public void RequestVeteranInfo(HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestVeteranBarrageInfo(HttpManager.Priority priority = HttpManager.Priority.UrgentKeepOrder, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void ProcessBarrageData()
	{
	}

	private bool CheckBarrageDataMatchType(uint type, VetBarrageInfo barrageInfo)
	{
		return false;
	}

	public bool TryGetVetBarrageData(out BarrageData vetBarrageData)
	{
		vetBarrageData = null;
		return false;
	}

	public void AddFriendPresenceBarrageData()
	{
	}

	public void AddWeaponPowerBarrageData()
	{
	}

	private void OnProcessTaskDesc(CSGetVeteranTaskDescRes dest)
	{
	}

	private void OnProcessVeteranConfig(CSGetVeteranConfigDescRes res)
	{
	}

	private void ProcessModeMainAndSubDesc(List<VeteranModeMainDesc> mainDescs, List<VeteranModeSubDesc> subDescs)
	{
	}

	private void OnProcessTaskInfo(CSGetVeteranTaskInfoRes resInfo)
	{
	}

	private void OnProcessVeteranRights(List<VeteranRightsDesc> resList)
	{
	}

	private void OnProcessVeteranModeDesc(List<VeteranModeDesc> modeDatas, uint csRank)
	{
	}

	public void RequestClaimTaskRewards(ClientVeteranTaskDesc desc, int index = 0, bool isLongterm = false)
	{
	}

	public void RequestClaimTaskRewardsInMatchResult(List<uint> taskIDList, List<uint> taskActivenessList)
	{
	}

	public void RequestClaimDailyReward(int rewardIndex, bool urgent)
	{
	}

	public void RequestClaimActivinessRewards()
	{
	}

	public void RequestPurchaseSpecialProgressAward()
	{
	}

	public void OnTcpUpdateTaskInfos(List<VeteranTaskUpdateInfo> taskinfos)
	{
	}

	public void OnTcpUpdateFirstGameInfos()
	{
	}

	public void RequestVeteranOfflineRemind()
	{
	}

	public void AddCallBackRequestVeteranOfflineRemind()
	{
	}

	public void InviteVeteranFriendAfterGroupCreate(ulong veteranAccountId)
	{
	}

	public void InviteVeteranFriend(ulong veteranAccountId)
	{
	}

	public void SetVeteranLogs()
	{
	}

	public bool CheckVeteranInfoIsNull()
	{
		return false;
	}

	private bool _003CGetShortTaskCurIndex_003Eb__180_0(ClientVeteranTaskDesc x)
	{
		return false;
	}

	private void _003CRequestVeteranInfo_003Eb__226_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestVeteranBarrageInfo_003Eb__227_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPurchaseSpecialProgressAward_003Eb__243_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestVeteranOfflineRemind_003Eb__246_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
