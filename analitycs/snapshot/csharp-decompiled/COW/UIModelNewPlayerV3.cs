using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelNewPlayerV3 : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LevelRewardsDesc> _003C_003E9__177_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__186_1;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__188_0;

		internal int _003CProcessGrowPathData_003Eb__177_0(LevelRewardsDesc x, LevelRewardsDesc y)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimExploreReward_003Eb__186_1(BaseItemInfo item)
		{
			return null;
		}

		internal BaseItemInfo _003CUpdateActivities_003Eb__188_0(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public ulong currentTime;

		internal bool _003CFindValidLimitedTaskMainDesc_003Eb__0(NewPlayerLimitedTaskMainDesc mainDesc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass161_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		internal void _003CRequestFreshDesc_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass164_0
	{
		public uint taskId;

		internal bool _003CRefreshAndNotifyLimitTaskAward_003Eb__0(NewPlayerLimitedTaskDesc task)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestAccountFreshInfo_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		internal void _003CRequestTeamUpBufDesc_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		public uint day;

		internal void _003CRequestClaimSignRewards_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		public List<uint> activityIds;

		public bool forMatchResult;

		internal void _003CRequestBatchActivityRewards_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		public uint activityId;

		internal void _003CRequestClaimFreshActivityRewards_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		internal void _003CRequestRewardLevelData_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public List<uint> sectionIDList;

		public UIModelNewPlayerV3 _003C_003E4__this;

		internal void _003CRequestClaimExploreReward_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UIModelNewPlayerV3 _003C_003E4__this;

		public string cmd;

		internal void _003CRequestPushDesc_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass194_0
	{
		public string title1;

		public string content1;

		public string title2;

		public string content2;

		internal string _003CHandleNewbieRetentionNotification_003Eb__0()
		{
			return null;
		}

		internal string _003CHandleNewbieRetentionNotification_003Eb__1()
		{
			return null;
		}

		internal string _003CHandleNewbieRetentionNotification_003Eb__2()
		{
			return null;
		}

		internal string _003CHandleNewbieRetentionNotification_003Eb__3()
		{
			return null;
		}
	}

	public static uint GROW_PATH_MAX_LEVEL;

	public const uint PropID_GetTeamUpBufDesc = 1u;

	public const uint PropID_FreshInfo = 2u;

	public const uint PropID_ActivityUpdate = 4u;

	public const uint PropID_GetSignReward = 8u;

	public const uint PropID_TaskRewardsClaimInMatchResult = 16u;

	public const uint PropID_ShowBubble = 32u;

	public const uint PropID_LevelRewards = 64u;

	public const uint PropID_GetExploreDescAndInfo = 128u;

	public const uint PropID_ExploreInfoUpdate = 256u;

	public const uint PropID_NewPlayerReady = 512u;

	public const uint PropID_LimitTaskSettingReady = 1024u;

	public const uint PropID_LimitTaskChanged = 2048u;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private readonly List<MatchResultTaskInfo> m_NPMatchResultTaskFinishedInfoList;

	private readonly List<MatchResultTaskInfo> m_NPMatchResultTaskReceivedInfoList;

	private List<TeamUpBonusDesc> m_TeamUpBufDesc;

	private readonly Dictionary<uint, ActivityInfo> m_DictIDToActivityInfo;

	private readonly Dictionary<uint, FreshRewardItem> m_DictDayToFreshAwardItem;

	private List<NewPlayerSurveyEntranceDesc> m_SurveyEntranceDescList;

	private BaseItemInfo[] m_SignRewardsInfoList;

	private readonly Dictionary<uint, NewPlayerGrowPathData> m_DicLevelToGrowPathData;

	private readonly Dictionary<uint, LevelRewardsDesc> m_DictLevelToLevelRewradsDesc;

	private CSGetAccountFreshInfoRes m_FreshInfo;

	private Dictionary<uint, NewbieExploreSectionDesc> m_DicSectionIDToNewPlayerExploreSectionDesc;

	private Dictionary<uint, NewbieExploreTaskDesc> m_DicTaskIDToNewPlayerExploreTaskDesc;

	private Dictionary<uint, ActivityInfo> m_DicSectionIDToNewPlayerExploreSectionInfo;

	private Dictionary<uint, ActivityInfo> m_DicTaskIDToNewPlayerExploreTaskInfo;

	private List<uint> m_NewPlayerExploreSectionIDList;

	private bool m_HasFreshInfo;

	private bool m_IsNewPlayer;

	private bool m_IsNewPlayerEnd;

	private bool m_IsInventoryBagpackReady;

	private bool m_HasSetAchievementEntrancePoint;

	private uint m_LimitLevel;

	private uint m_LimitDay;

	private uint m_StoreLevel;

	private int m_TotalAwardsNum;

	private int m_HasAwardsToClaimMinDay;

	private int m_HasOnlyOneNormalTaskToFinishBigRewardDay;

	private int m_HasSignRewardsOrDailyBigRewardsToClaim;

	private bool m_FreshGachaStart;

	private readonly HashSet<uint> m_UnlockAnimPlayLevelSet;

	public string SECONDEDAY_GUIDE_PLAYERPREFS;

	public string PLAYERPREFS_UNLOCKANIMPALY_LEVEL;

	public string PLAYERPREFS_SURFVEY_VFX;

	public string PLAYERPREFS_CS_PLAYTIMES;

	private uint m_ReadyFlag;

	private const uint ALL_STEP_READY = 1090u;

	private CSGetFreshDescRes m_FreshDescData;

	private CSGetNewbiePushDescRes m_NewbiePushDescData;

	private Dictionary<uint, LimitTaskAwardInfo> m_DicLimitTaskIdToLimitAward;

	private NewPlayerLimitedTaskMainDesc m_ValidLimitTaskMainDesc;

	private uint ReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsReady => false;

	public uint UnLockDay => 0u;

	public ulong ExpireTimeStamp => 0uL;

	public int TotalDays => 0;

	public bool[] GuideRewardClaimed => null;

	public bool HasFreshInfo => false;

	public bool IsNewPlayer => false;

	public bool IsNewPlayerEnd => false;

	private string OnceIsNewPlayer => null;

	public static string DailySignPlayerPrefs => null;

	public List<MatchResultTaskInfo> NPMatchResultTaskFinishedInfoList => null;

	public List<MatchResultTaskInfo> NPMatchResultTaskReceivedInfoList => null;

	public bool NeedLobbyV2Guide => false;

	public bool IsInventoryBagPackReady
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsExploreDescReady => false;

	public bool IsExploreInfoReady => false;

	public bool FreshGachaStart => false;

	public NewPlayerLimitedTaskMainDesc CurrentLimitTaskMainDesc => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	private AwardDesc GetNewPlayerDisplayLevelReward(uint level)
	{
		return null;
	}

	private void SetSignRewardsTipsData(FreshRewardItem freshRewardItem, ref int signNeedToClaimCount)
	{
	}

	private void SetDailyBigRewardTipsData(FreshRewardItem freshRewardItem, ref int missionNeedToFinishCount, ref int missionNeedToClaimCount, ref int bigRewardMissionNeedToClaimCount)
	{
	}

	private void SetNormalMissionRewardsTipsData(FreshRewardItem freshRewardItem, ref int missionNeedToFinishCount, ref int missionNeedToClaimCount, ref int normalMissionNeedToFinishCount, out int normalMissionCnt)
	{
		normalMissionCnt = default(int);
	}

	private NewPlayerLimitedTaskMainDesc FindValidLimitedTaskMainDesc()
	{
		return null;
	}

	public void ProcessActivityInfoDict(CSGetAccountFreshInfoRes freshInfo)
	{
	}

	public void ProcessFreshAwardDict(CSGetAccountFreshInfoRes freshInfo)
	{
	}

	public void ProcessNewPlayerTag(CSGetAccountFreshInfoRes freshInfo)
	{
	}

	public void ProcessSignRewrads()
	{
	}

	public uint GetNewPlayerLimitDays()
	{
		return 0u;
	}

	public uint GetNewPlayerStoreLevel()
	{
		return 0u;
	}

	public uint GetNewPlayerLevelUpperLimit()
	{
		return 0u;
	}

	public uint GetNewPlayerDays()
	{
		return 0u;
	}

	public uint GetNewBieOfferDays()
	{
		return 0u;
	}

	public ulong GetNewbieOfferExpireTime()
	{
		return 0uL;
	}

	public bool IsPlayerLevelMeetLimit()
	{
		return false;
	}

	public bool HasTeamBufDesc()
	{
		return false;
	}

	public uint GetTeamUpTokenIdByType(uint type)
	{
		return 0u;
	}

	public void GetTeamUpBuffFactorValue(out uint value, out uint nextValue)
	{
		value = default(uint);
		nextValue = default(uint);
	}

	public ActivityInfo GetActivityInfoById(uint activityId)
	{
		return null;
	}

	public FreshRewardItem GetAttendanceRewardData(uint day)
	{
		return null;
	}

	public bool IsSubMission(uint id)
	{
		return false;
	}

	public bool IsAwardedAllSevenDays()
	{
		return false;
	}

	public int GetDefaultSelectIndex()
	{
		return 0;
	}

	public void RefreshRedTips()
	{
	}

	private void RefreshGrowPathRedTips()
	{
	}

	public bool HasAwardsToClaim()
	{
		return false;
	}

	public int GetNormalMissionHasFinishedCount(int day)
	{
		return 0;
	}

	public bool HasOnlyOneNormalTaskToFinishBigReward()
	{
		return false;
	}

	public bool HasSignRewardsOrDailyBigRewardsToClaim()
	{
		return false;
	}

	public string[] GetAllTabName()
	{
		return null;
	}

	public BaseItemInfo GetSignRewardItemByIndex(int index)
	{
		return null;
	}

	public BaseItemInfo GetDailyBigRewardItemByIndex(int index)
	{
		return null;
	}

	public void SetNewPlayerEnd(bool isEnd)
	{
	}

	public bool IsNewPlayerEntranceOpen()
	{
		return false;
	}

	public bool IsNewPlayerEntranceOpenLoginIn()
	{
		return false;
	}

	public bool IsNewBieOfferLoginIn()
	{
		return false;
	}

	public List<NewPlayerGrowPathData> GetNewPLayerGrowPathDatas()
	{
		return null;
	}

	public bool IsNewPlayerGrowPathDataReady()
	{
		return false;
	}

	public int GetGrowPathIndex(uint level)
	{
		return 0;
	}

	public bool IsShowTipInLobbyStartGameTop()
	{
		return false;
	}

	public AwardDesc GetNextLevelItemInfo()
	{
		return null;
	}

	public bool IsShowGrowPathTip()
	{
		return false;
	}

	public void SetGrowPathTipPlayerPrefs()
	{
	}

	public void RefreshNewBieOfferRemind()
	{
	}

	public bool CheckShowSurvey(out NewPlayerSurveyData surveyOutData)
	{
		surveyOutData = null;
		return false;
	}

	public bool NeedShowSurvey()
	{
		return false;
	}

	public void ProcessSystemUnlockAnimPlaySet()
	{
	}

	public void SetPlayerPrefsSystemUnlockAnim(uint level)
	{
	}

	public bool IsSystemUnlockAnimPlayed(uint level)
	{
		return false;
	}

	public bool IsShowMatchResultWnd()
	{
		return false;
	}

	public void ClearMatchResultTaskInfoList()
	{
	}

	public List<ActivityInfo> GetAllUnLockNpMission()
	{
		return null;
	}

	private void RefreshAchievementEntranceRedPoint(int claimableSectionCount)
	{
	}

	public NewbieExploreSectionDesc GetNewPlayerExploreSectionDescByID(uint id)
	{
		return null;
	}

	public List<uint> GetNewPlayerExploreSectionIDList()
	{
		return null;
	}

	public List<uint> GetNewPlayerExploreTaskIDListBySectionID(uint sectionID)
	{
		return null;
	}

	public NewbieExploreTaskDesc GetNewPlayerExploreTaskDescByID(uint id)
	{
		return null;
	}

	public ActivityInfo GetNewPlayerExploreSectionInfoByID(uint id)
	{
		return null;
	}

	public ActivityInfo GetNewPlayerExploreTaskInfoByID(uint id)
	{
		return null;
	}

	public bool IsNewPlayerExploreSectionUnlock(uint sectionID)
	{
		return false;
	}

	public uint GetNewPlayerExploreNeweastUnlockSectionID()
	{
		return 0u;
	}

	public int GetNewPlayerExploreSectionNeedToClaimCount()
	{
		return 0;
	}

	public List<uint> GetNewPlayerExploreSectionClaimableList()
	{
		return null;
	}

	public void RequestFreshDesc()
	{
	}

	private bool IsFreshDescDataValid()
	{
		return false;
	}

	public void ForceDebugSetLimitTaskEndTime()
	{
	}

	public void RefreshAndNotifyLimitTaskAward()
	{
	}

	private bool CheckLimitTaskAwardValid()
	{
		return false;
	}

	public AwardDesc GetLimitTaskAwardByTaskId(uint taskId)
	{
		return null;
	}

	public void ProcessSurveyEntranceDesc(CSGetNewPlayerSurveyEntranceDescRes surveyEntranceDesc)
	{
	}

	public void RequestAccountFreshInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestTeamUpBufDesc()
	{
	}

	public void RequestClaimSignRewards(uint day)
	{
	}

	public void RequestClaimMissionReward(uint activityId)
	{
	}

	public void RequestClaimMissionDailyBigReward(uint activityId)
	{
	}

	public void RequestBatchActivityRewards(List<uint> activityIds, bool isDailyBigReward = false, bool forMatchResult = true)
	{
	}

	private void RequestClaimFreshActivityRewards(uint activityId, bool isDailyBigReward = false)
	{
	}

	public void RequestRewardLevelData(HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public AwardDesc GetLevelFreshAward(uint levelID)
	{
		return null;
	}

	public void ProcessGrowPathData()
	{
	}

	private void ProcessNewPlayerFirstLevel(uint userCurLevel, uint userCurExp, Dictionary<uint, LevelEntranceData> dictLevelToLevelEntranceData)
	{
	}

	private void SetGrowPathDataNodeState(uint targetLevel, uint userCurLevel, NewPlayerGrowPathData data)
	{
	}

	private void SetGrowPathDataProgress(uint targetLevel, uint userCurExp, NewPlayerGrowPathData data)
	{
	}

	private uint GetExpFromConfig(uint level)
	{
		return 0u;
	}

	private void SetGrowPathDataSystemType(int index, uint targetLevel, Dictionary<uint, LevelEntranceData> dictLevelToLevelEntranceData, NewPlayerGrowPathData data)
	{
	}

	private Dictionary<uint, LevelEntranceData> GetGrowPathTypeDict()
	{
		return null;
	}

	public void RequestExploreDesc()
	{
	}

	public void RequestExploreInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestClaimExploreReward(List<uint> sectionIDList)
	{
	}

	public void RequestPushDesc()
	{
	}

	public void UpdateActivities(List<FreshActivityUpdateInfo> infos)
	{
	}

	public void UpdateExploreSectionsAndTasks(FreshExploreDataUpdateNtf refreshInfos)
	{
	}

	public bool CheckShowNewbieCSGuideGuide(ulong accountId)
	{
		return false;
	}

	public void ProcessNewbieCSGuide(ulong accountId)
	{
	}

	private void SetPlayerPrefsCSPlayTimes(uint matchMode, ulong accountId)
	{
	}

	public void ArangeNewbieRetentionNotification()
	{
	}

	private void HandleNewbieRetentionNotification(string title1, string content1, string title2, string content2)
	{
	}

	private void ScheduleNewbiePushForSpecificDay(LocalNotificationManager.NotifyType notifyType, int targetDay)
	{
	}

	private void _003CRequestExploreDesc_003Eb__184_0(HttpErrorCode err, object res)
	{
	}

	private void _003CRequestExploreInfo_003Eb__185_0(HttpErrorCode err, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
