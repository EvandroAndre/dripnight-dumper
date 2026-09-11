using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelRankingTips : UIBaseModel, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RankingTipsLobby> _003C_003E9__123_0;

		public static Comparison<RankingTipsLobby> _003C_003E9__123_1;

		public static Comparison<RankingTipsPlayAgain> _003C_003E9__123_2;

		public static Comparison<RankingTipsPlayAgain> _003C_003E9__123_3;

		public static Comparison<ClientActivityTipsDesc> _003C_003E9__157_0;

		internal int _003CInitCSVData_003Eb__123_0(RankingTipsLobby a, RankingTipsLobby b)
		{
			return 0;
		}

		internal int _003CInitCSVData_003Eb__123_1(RankingTipsLobby a, RankingTipsLobby b)
		{
			return 0;
		}

		internal int _003CInitCSVData_003Eb__123_2(RankingTipsPlayAgain a, RankingTipsPlayAgain b)
		{
			return 0;
		}

		internal int _003CInitCSVData_003Eb__123_3(RankingTipsPlayAgain a, RankingTipsPlayAgain b)
		{
			return 0;
		}

		internal int _003CProcessActivityTipsDesc_003Eb__157_0(ClientActivityTipsDesc a, ClientActivityTipsDesc b)
		{
			return 0;
		}
	}

	public const uint PropID_RankingTipsRefresh = 1u;

	public const uint PropID_ForceDisplayActivityTipsDebug = 2u;

	private uint m_IntervalTime;

	private uint m_DurationTime;

	private ulong m_ChangeTime;

	public uint m_IntervalTimeDelayCallId;

	public uint m_DurationTimeDelayCallId;

	public uint m_ChangeTimeDelayCallId;

	public uint m_CSIntervalTimeDelayCallId;

	public uint m_CSDurationTimeDelayCallId;

	public uint m_CSChangeTimeDelayCallId;

	private uint m_SpecialTaskShowDelayCallId;

	private bool m_InitCSVReady;

	private bool m_MapOpeningInfoReady;

	private bool m_BRRankReady;

	private bool m_CSRankReady;

	private bool m_FriendDataReady;

	private bool m_BRTaskReady;

	private bool m_CSTaskReady;

	private bool m_BRSeasonInfoReady;

	private bool m_CSSeasonInfoReady;

	private bool m_CSPeakSeasonInfoReady;

	private bool m_CSPeakSeasonNextSeasonInfoReady;

	private bool m_BRGrandMasterPositionReady;

	private bool m_CSGrandMasterPositionReady;

	private bool m_ActivityDataReady;

	public List<uint> m_BrInGameRankingTipsShowNumberList;

	public List<uint> m_CSInGameRankingTipsShowNumberList;

	public uint m_BrQueueMaxLength;

	public uint m_CsQueueMaxLength;

	public uint m_BeginTime;

	public uint scoreCache;

	public uint csPointsNeededForCSPeakUnlock;

	public int rankCache;

	public uint csrankCache;

	private bool m_NeedChangeBr;

	private bool m_NeedChangeCS;

	private ulong m_BrModeLastRemainTime;

	private ulong m_CsModeLastRemainTime;

	private ulong m_BrChangeCountDownBeginTime;

	private ulong m_CsChangeCountDownBeginTime;

	private bool m_GameModeIsBr;

	public bool IsBrSeasonToShow;

	public bool IsBrSpecialTaskAlreadyShowed;

	public bool IsCsSpecialTaskAlreadyShowed;

	private bool IsSpecialTaskShowOver;

	public bool IsLogFirstLoginShow;

	public bool IsLogReturnToLobbyShow;

	public bool IsLogLobbyNextBrMissionShow;

	public bool IsLogLobbyNextCsMissionShow;

	public bool IsLogChangeGameModeShow;

	public GameModelLogState LogLastShowGameState;

	public FriendAccountInfo m_TargetBRFriendInfo;

	public FriendAccountInfo m_TargetCSFriendInfo;

	private Dictionary<uint, List<RankingTipsLobby>> m_DictRankingTipsLobby;

	private Dictionary<uint, List<RankingTipsPlayAgain>> m_DictRankingTipsPlayAgain;

	private Queue<RankingTipsLobby> m_BrRankingTipsShowQueue;

	private Queue<RankingTipsLobby> m_CSRankingTipsShowQueue;

	private Queue<uint> m_BrRankingTispTypeQueue;

	private Dictionary<uint, List<uint>> m_FrequencyLobbyLimitDict;

	public RankingTaskInfo m_BrCacheTask;

	public CSRankingTaskInfo m_CsCacheTask;

	public FriendAccountInfo m_FriendCacheInfo;

	private RankingTipsLobby m_CurrentShowBRTipsLobbyData;

	private RankingTipsLobby m_CurrentShowCSTipsLobbyData;

	public bool m_CurrentModeIsBr;

	private RankingTipsPlayAgain m_CurrentShowInGameData;

	private Queue<uint> m_BrRankingTipsShowIndexQueue;

	private Queue<uint> m_CsRankingTipsShowIndexQueue;

	private UIModelMapOpeningInfo m_UIModelMapOpeningInfo;

	private UIModelCSLadderMatch m_UIModelCSLadderMatch;

	private UIModelLadderMatch m_UIModelLadderMatch;

	private UIModelFriends m_UIModelFriends;

	private UIModelCSPeakTournamentLadderMatch m_UIModelCSPeakTournament;

	private bool m_IsGameAssistBubbleOpen;

	private ulong m_GameAssistantBubbleShowTimestamp;

	private bool m_WasGameAssistBubbleForcedHidden;

	private List<ClientActivityTipsDesc> m_ClientActivityTipsList;

	private bool m_InGameActivityTaskTcpReceived;

	private const string PREFS_CACHED_GENERAL_START_ACTIVITY_ID = "RankingTips_CachedGeneralStartActivityId";

	private const string PREFS_CACHED_GENERAL_START_EXPIRE_TIME = "RankingTips_CachedGeneralStartExpireTime";

	private const string PREFS_CACHED_LAST_ACTIVITY_WILL_LAST_TIMESTAMP = "RankingTips_CachedNext4AMShowTimestamp";

	private const string PREFS_CACHED_LAST_SHOW_ACTIVITYID = "RankingTips_CachedLastShowActivityId";

	private const string PREFS_CACHED_GAME_VERSION = "RankingTips_CachedGameVersion";

	private RankingTipsActivityData m_CurrentActivityTaskData;

	private bool m_ForceDisplayActivityTipsDebug;

	private ActivityTipsNtf m_ForcedActivityTipsDataDebug;

	private bool m_IsPetPanelOpen;

	private bool m_IsGameAssistWndOpen;

	public RankingTipsLobby CurrentShowBRTipsLobbyData => null;

	public RankingTipsLobby CurrentShowCSTipsLobbyData => null;

	public bool CurrentModeIsBr => false;

	public RankingTipsPlayAgain CurrentShowInGameData => null;

	public uint IntervalTime => 0u;

	public uint DurationTime => 0u;

	public RankingTipsActivityData CurrentActivityTaskData => null;

	public bool IsGameAssistBubbleOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsPetPanelOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsGameAssistWndOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void RecordGameAssistantBubbleShowTime()
	{
	}

	public bool CanPetGuideForceDisplay()
	{
		return false;
	}

	public void MarkGameAssistBubbleForcedHidden()
	{
	}

	public bool ShouldRestoreGameAssistBubble()
	{
		return false;
	}

	public void ClearGameAssistBubbleRestoreFlag()
	{
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

	protected override void OnCleanup()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitCSVData(uint ruleId, uint groupId)
	{
	}

	private bool CheckGameMode()
	{
		return false;
	}

	private void InitLobbyFirstBRData()
	{
	}

	private void InitLobbyFirstCSData()
	{
	}

	private RankingTipsLobby GetCurrentShowState()
	{
		return null;
	}

	private bool CheckIsFrequency(uint TipsId)
	{
		return false;
	}

	public void AddFrequency(uint TipsId)
	{
	}

	private TipsShowState CheckNewBie()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckGacha()
	{
		return TipsShowState.None;
	}

	private bool CheckNewBieForNoFrequency()
	{
		return false;
	}

	private TipsShowState CheckSeason()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckCSPeakSeasonEnd()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckCSPeakSeasonStart()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckDailyTask()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckSpecialTask()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckRank()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckFriendRank()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckCSRankCSPeakUnlock()
	{
		return TipsShowState.None;
	}

	private TipsShowState CheckBRMissionUpdated()
	{
		return TipsShowState.None;
	}

	private TipsShowState GetCurrentShowData(uint type)
	{
		return TipsShowState.None;
	}

	public bool TryGetCurrentLobbyShowData()
	{
		return false;
	}

	public bool GetLobbyShowData()
	{
		return false;
	}

	private bool CheckIsNewSpecialTaskFromGame(bool isBr)
	{
		return false;
	}

	public void SetCurrentSeasonInfoReady(bool isBr)
	{
	}

	public void SetTaskReady(bool isBr)
	{
	}

	public void SetMapOpenInfoReady()
	{
	}

	public void SetFriendReady()
	{
	}

	public void SetCSPeakSeasonInfoReady()
	{
	}

	public void SetCSPeakSeasonNextSeasonInfoReady()
	{
	}

	public RankingTipsLobby GetDebugData(uint id)
	{
		return null;
	}

	public void SetActivityDataReady()
	{
	}

	public void NotifyActivityTipsDebug(ActivityTipsNtf ntf)
	{
	}

	public bool IsForceDisplayingActivityTipsDebug()
	{
		return false;
	}

	public void ClearForceDisplayActivityTipsDebug()
	{
	}

	public void ProcessActivityTipsDesc(List<ActivityTipsDesc> activityTipsDescList)
	{
	}

	public void ResetInGameActivityTaskState()
	{
	}

	public void CacheActivityUpdates(List<tcp.ActivityUpdateInfo> updateInfos)
	{
	}

	private List<uint> GetCachedGeneralStartActivityIds()
	{
		return null;
	}

	private uint GetMostRecentCachedActivityId()
	{
		return 0u;
	}

	private bool IsActivityIdInCachedList(uint activityId)
	{
		return false;
	}

	private ulong GetCachedGeneralStartExpireTime()
	{
		return 0uL;
	}

	private void SetCachedGeneralStartActivity(uint activityId, ulong expireTime)
	{
	}

	private void ClearCachedGeneralStartActivity()
	{
	}

	private void CheckAndClearCacheOnVersionChange()
	{
	}

	private ClientActivityTipsDesc GetActivityTipsConfigGroup(uint activityId)
	{
		return null;
	}

	public RankingTipsActivityData GetActivityTaskData(bool isQuickMatch = false)
	{
		return null;
	}

	private RankingTipsActivityData ConstructActivityData(ClientActivityDesc activityDesc, uint progressData, ActivityTipsDesc tipsDesc, ActivityTipsShowType showType)
	{
		return null;
	}

	private TipsShowState CheckActivityTask()
	{
		return TipsShowState.None;
	}

	public bool GetIngameShowActivityTask()
	{
		return false;
	}

	public bool ShouldShowBRInGameRankingTips()
	{
		return false;
	}

	public bool ShouldShowCSInGameRankingTips()
	{
		return false;
	}

	private bool CanTipsShowInNonRankingMode(uint tipsType)
	{
		return false;
	}

	public bool GetInGameShowData(int rank, uint rankScore, bool isSpecialTask, bool isBrGame = true, bool isCSWinOrBRAddScore = true)
	{
		return false;
	}

	public bool GetInGameShowSwitch(uint type, bool isBr, int rank, uint rankScore, bool hasSpeical, bool isCSWinOrBRAddScore = true)
	{
		return false;
	}

	public bool GetIngameShowRankData(bool isBr, int rank, uint RankScore)
	{
		return false;
	}

	public bool GetIngameShowFriendRankData(bool isBr, int rank, uint RankScore)
	{
		return false;
	}

	public bool GetIngameShowSpeicalTask()
	{
		return false;
	}

	public bool GetIngameShowPeakSeasonUnlock(uint rankScore)
	{
		return false;
	}

	private void TimeMangerChange(bool isBr)
	{
	}

	public void TimeManagerAllPause()
	{
	}

	private void TimeManagerBrPause()
	{
	}

	private void TimeManagerCsPause()
	{
	}

	private void TimeManagerSpecialTask()
	{
	}

	public void ProcessABTestData(RankingTipsABTestDesc data)
	{
	}

	private void _003CTimeMangerChange_003Eb__181_0()
	{
	}

	private void _003CTimeMangerChange_003Eb__181_1()
	{
	}

	private void _003CTimeManagerSpecialTask_003Eb__185_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
