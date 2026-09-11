using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine.Networking;
using proto;
using tcp;

namespace COW;

public class UIModelActivity : UIBaseModel
{
	private class ActivityESportsMenuResponse
	{
		public int code;

		public string status;

		public string msg;

		public ActivityESportsMenuData data;
	}

	private class ActivityESportsMenuData
	{
		public List<ActivityESportsMenu> menus;
	}

	private class ActivityESportsMenu
	{
		public int id;

		public string menu_name;

		public string menu_path;

		public int priority;

		public long show_start_time;

		public long show_end_time;
	}

	[Serializable]
	private class FBInvitedPerActivity
	{
		public uint group_id;

		public ulong[] uids;
	}

	[Serializable]
	private class FBInvited
	{
		public FBInvitedPerActivity[] Info;
	}

	public enum ActivityOperateStatus
	{
		NotStarted,
		GoTo,
		UnClaimable,
		Claimable,
		Claimed,
		Expired
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ActivityGroupDesc> _003C_003E9__128_0;

		public static Comparison<ActivityInteractionDesc> _003C_003E9__133_0;

		public static Converter<proto.ActivityUpdateInfo, tcp.ActivityUpdateInfo> _003C_003E9__152_1;

		public static Converter<proto.ActivityUpdateInfo, tcp.ActivityUpdateInfo> _003C_003E9__154_1;

		public static Predicate<ActivityClientInfo> _003C_003E9__176_0;

		public static Predicate<ActivityClientInfo> _003C_003E9__177_0;

		public static Predicate<ActivityGroupDesc> _003C_003E9__196_0;

		public static Predicate<ActivityGroupDesc> _003C_003E9__197_0;

		public static Predicate<Item> _003C_003E9__206_0;

		public static Comparison<AdvertDesc> _003C_003E9__228_0;

		public static Converter<string, uint> _003C_003E9__239_0;

		public static Converter<uint, string> _003C_003E9__240_0;

		public static Comparison<ActivityGroupDesc> _003C_003E9__313_1;

		public static Comparison<LocalEventEntranceDesc> _003C_003E9__315_0;

		public static Comparison<FestivalAttendanceItem> _003C_003E9__318_1;

		public static Converter<AwardDesc, AwardItemInfo> _003C_003E9__319_2;

		public static Converter<AwardItemInfo, CommonRewardItemInfo> _003C_003E9__319_3;

		public static Comparison<ClientActivityDesc> _003C_003E9__332_1;

		internal int _003CProcessAllActivityDescs_003Eb__128_0(ActivityGroupDesc a, ActivityGroupDesc b)
		{
			return 0;
		}

		internal int _003COnActivityDescResponse_003Eb__133_0(ActivityInteractionDesc x, ActivityInteractionDesc y)
		{
			return 0;
		}

		internal tcp.ActivityUpdateInfo _003CRequestActivityAwardInGameScene_003Eb__152_1(proto.ActivityUpdateInfo updateInfo)
		{
			return null;
		}

		internal tcp.ActivityUpdateInfo _003CSendActivityAwardRequest_003Eb__154_1(proto.ActivityUpdateInfo updateInfo)
		{
			return null;
		}

		internal bool _003CHasClaimableReward_003Eb__176_0(ActivityClientInfo info)
		{
			return false;
		}

		internal bool _003CIsUnfinished_003Eb__177_0(ActivityClientInfo info)
		{
			return false;
		}

		internal bool _003CGetEasterRedDotNum_003Eb__196_0(ActivityGroupDesc temp)
		{
			return false;
		}

		internal bool _003CGetOverviewRedDotNum_003Eb__197_0(ActivityGroupDesc temp)
		{
			return false;
		}

		internal bool _003CExchangeActivityItemCountEnough_003Eb__206_0(Item e)
		{
			return false;
		}

		internal int _003CGetHistoryPatchAdDesc_003Eb__228_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}

		internal uint _003C_GetDisplayedFriendReunionInviteeActivities_003Eb__239_0(string idString)
		{
			return 0u;
		}

		internal string _003C_SetDisplayedFriendReunionInviteeActivities_003Eb__240_0(uint id)
		{
			return null;
		}

		internal int _003CGetActivityGroupDescList_003Eb__313_1(ActivityGroupDesc a, ActivityGroupDesc b)
		{
			return 0;
		}

		internal int _003CProcessLocalEventInfo_003Eb__315_0(LocalEventEntranceDesc x, LocalEventEntranceDesc y)
		{
			return 0;
		}

		internal int _003CGetMegaFestivalAttendanceInfo_003Eb__318_1(FestivalAttendanceItem x, FestivalAttendanceItem y)
		{
			return 0;
		}

		internal AwardItemInfo _003CClaimMegaFestivalItem_003Eb__319_2(AwardDesc item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CClaimMegaFestivalItem_003Eb__319_3(AwardItemInfo item)
		{
			return null;
		}

		internal int _003CGetBigEventSortedDescListByTwoType_003Eb__332_1(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public uint gameMode;

		internal int _003COnActivityFeaturesDescResponse_003Eb__0(ActivityFeaturesDesc x, ActivityFeaturesDesc y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_0
	{
		public UIModelActivity _003C_003E4__this;

		public uint[] activityid;

		public bool showRewardWindow;

		public bool bigPriceControlCommonRewardWnd;

		public bool protectBPCards;

		public UICommonRewardWndController.WndStyleEnum style;

		public bool childKeepStyle;

		public Action onSuccess;

		public Action _003C_003E9__2;

		internal void _003CSendActivityAwardRequest_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}

		internal void _003CSendActivityAwardRequest_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass154_1
	{
		public CSGetActivityRewardsRes res;

		public _003C_003Ec__DisplayClass154_0 CS_0024_003C_003E8__locals1;

		internal void _003CSendActivityAwardRequest_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass178_0
	{
		public proto.EActivity.State state;

		internal bool _003CFindActivityInfosByGroupIdAndState_003Eb__0(ActivityClientInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass198_0
	{
		public ClientActivityDesc activity;

		internal bool _003CIsOverviewActivityRedDotValid_003Eb__0(AdvertDesc temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass246_0
	{
		public uint group_id;

		internal bool _003CGetFriendReunionFBInvited_003Eb__0(FBInvitedPerActivity invited)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass293_0
	{
		public EventTabType type;

		internal bool _003CGetFestivalDesc_003Eb__0(ActivityFestivalDesc item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass294_0
	{
		public uint groupId;

		public uint affiliateTab;

		internal bool _003CGetFestivalDesc_003Eb__0(ActivityFestivalDesc item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass319_0
	{
		public UIModelActivity _003C_003E4__this;

		public uint id;

		public Predicate<FestivalAttendanceItem> _003C_003E9__1;

		internal void _003CClaimMegaFestivalItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CClaimMegaFestivalItem_003Eb__1(FestivalAttendanceItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass330_0
	{
		public uint activityID;

		internal bool _003CGetBigEventTaskDescByTypeAndId_003Eb__0(ClientActivityDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass331_0
	{
		public proto.EActivity.SubType subType;

		internal bool _003CGetBigEventActivityDescByTwoType_003Eb__0(ClientActivityDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass332_0
	{
		public proto.EActivity.SubType subType;

		internal bool _003CGetBigEventSortedDescListByTwoType_003Eb__0(ClientActivityDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass342_0
	{
		public uint activityid;

		internal bool _003CGetSortedDescList_003Eb__0(ActivityGroupDesc x)
		{
			return false;
		}
	}

	private sealed class _003CSendActivityESportsWebRequestCoroutine_003Ed__385 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string originalUrl;

		public string requestUrl;

		public string apiToken;

		public float timeout;

		public UIModelActivity _003C_003E4__this;

		public uint cacheTime;

		private string _003CcacheKey_003E5__2;

		private string _003CexpireKey_003E5__3;

		private UnityWebRequest _003Crequest_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSendActivityESportsWebRequestCoroutine_003Ed__385(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private List<ActivityGroupDesc> m_ActivityGroupDescList;

	private Dictionary<uint, List<ClientActivityDesc>> m_ActivityGroupIdDic;

	private Dictionary<uint, List<ActivityGroupDesc>> m_ActivityGroupTypeDic;

	private List<ActivityFestivalDesc> m_ActivityFestivalDescList;

	private List<ActivityFestivalSortRuleDesc> m_SortRuleDescList;

	private Dictionary<uint, uint> m_TableTypeWeightDict;

	private Dictionary<uint, ActivityClientInfo> m_ActivityInfoDic;

	private Dictionary<uint, string> m_ActivityInfoUpdateContextCache;

	private Dictionary<uint, List<ActivenessReward>> m_ActivenessRewardsDic;

	private Dictionary<uint, List<ClientActivityDesc>> m_ActivityListTypeIdDic;

	private Dictionary<uint, ClientActivityDesc> m_BigEventTaskDescDict;

	private HashSet<uint> m_BigEventTaskTypeSet;

	private readonly HashSet<uint> m_NotValidActivityGroupSet;

	private Dictionary<uint, List<ClientActivityDesc>> m_BigEventActivityDict;

	private HashSet<uint> m_BigEventActivityTypeSet;

	private Dictionary<uint, List<ClientActivityDesc>> m_SecretActivityGroupIdDict;

	private List<ClientActivityDesc> m_ClientActivityTempList;

	private List<LocalEventEntranceDesc> m_LocalEventEntranceDescs;

	private LocalEventEntranceDesc m_LocalEventEntranceDesc;

	private const string ACT_READED_FORMAT = "Activity{0}";

	private const string ACT_FEATURES_READED_FORMAT = "ReturnFeatureId{0}";

	private const string ACT_GOTO_CLICK_FORMAT = "ActivityGotoClick{0}";

	private const string ACT_EXCHANGE_REDTIPS_FORMAT = "ActivityExchangeRedTips{0}";

	private const string HTTPActivityNoRewardsAvailable = "BR_ACTIVITY_NO_REWARDS_AVAILABLE";

	private const string HTTPActivityGetRewardsFailed = "BR_ACTIVITY_GET_REWARDS_FAILED";

	private const string PREFS_CLOSE_ACTIVITY_EXCHANGE_RED_TIPS = "CLOSE_ACTIVITY_EXCHANGE_RED_TIPS";

	public const string CONFIG_CONSTANT_TIME = "2029-01-01 23:59:59";

	public const ulong REMIND_TAG_SHOW_TIME = 259200uL;

	public const string ACT_BIND_DAILY = "ACT_BIND_DAILY_KEY";

	public const string ACT_READED_FORMAT_TIMESTAMP = "Activity{0}_ReadedTimestamp";

	private bool m_HasFirstRecharge;

	private bool m_HasSecondRecharge;

	private CSGetActivityDescRes m_ActivityDescRes;

	private CSGetActivityInfoRes m_ActivityInfoRes;

	private CSGetActivityFeaturesRes m_ReturnFeaturesRes;

	private ActivenessInfo m_ActivenessInfoRes;

	private WaitingResponseHandler m_WaitingHandler;

	public List<MatchResultTaskInfo> BigEventTaskHasProgress;

	private Dictionary<uint, AdvertDesc> m_HistoryPathAdDict;

	private List<ClientActivityDesc> m_ClientTriggerActivitys;

	private Dictionary<uint, Dictionary<string, ActivityTemplateDesc>> m_ActivityTemplateDict;

	private string m_ActivityESportsWebData;

	private List<ClientActivityDesc> m_ActivityESportsWebviewDescList;

	private bool m_ActivityESportsWebRequesting;

	private bool m_ActivityESportsWebDataLoaded;

	private bool m_HasBindOTPActivityTrigger;

	private Dictionary<uint, uint> m_ActivityEventTabETipsType;

	private Dictionary<uint, int> m_ActivityEventTabTipsNum;

	private ulong _003CEasterActivityTodayExpireTime_003Ek__BackingField;

	public const int PropID_UpdateActivityInfo = 2;

	public const int PropID_GetActivityReward = 4;

	public const int PropID_UpdateActivityDesc = 8;

	public const int PropID_UpdateActivityDescFailed = 16;

	public const int PropID_UpdateActivityInfoFailed = 32;

	public const int PropID_ReunionFBInvited = 64;

	public const int PropID_MegaFestivalSignin = 128;

	public const int PropID_GetMegaFestivalAttendanceInfo = 256;

	public const int PropID_GetMegaFestivalItemInfo = 512;

	public const int PropID_UpdateActivenessInfo = 1024;

	public const int PropID_UpdateActivenessRewardsList = 2048;

	public const int PropID_GetActivenessTaskReward = 4096;

	public const int PropID_SingleActivityReaded = 8192;

	public const int PropID_Hint_Reset = 16384;

	public const int PropID_FestivalGetRewards = 32768;

	public const int PropID_GetMegaFestivalAttendanceInfoFailed = 65536;

	public const int PropID_GetActivityRewardFailed = 131072;

	public const int PropID_GetActivityRewardWithActivityID = 262144;

	public const int PropID_GetLocalActivity = 524288;

	public const int PropID_GetSignetProgressPercentum = 1048576;

	private Dictionary<int, TagConfig> TagConfigDict;

	private bool m_IsSignedTodayMegaFestival;

	private string _003CInviterUIDFromLink_003Ek__BackingField;

	private CSGetFestivalAttendanceInfoRes _003CMegaFestivalAttendanceInfo_003Ek__BackingField;

	private List<FestivalAttendanceItem> _003CMegaFestivalSigninAwards_003Ek__BackingField;

	private bool _003CHasGetMegaFestivalInfoSinceLogin_003Ek__BackingField;

	private bool m_PreloadActiveness;

	private ulong m_ToNextDailyReFreshTime;

	private bool m_PreloadActivenessReward;

	private bool m_HaveRewards;

	private uint m_GroupID;

	private string PLAYER_PREFS_KEY_FRIEND_REUNION_INVITEE_ACTIVITIES;

	private static readonly string PLAYER_PREFS_KEY_FB_INVITED;

	private Dictionary<int, Dictionary<uint, int>> m_RedDots;

	private ActivityGroupDesc _003CCurrentDisplayPaymentActivity_003Ek__BackingField;

	private List<ActivityGroupDesc> m_NormalTopUpEventDescList;

	public const string FIRSTTOPUPEVENTKEY = "FIRSTTOPUPEVENTKEY_{0}";

	public const string TOPUPEVENTKEY = "TOPUPEVENTKEY_{0}_{1}";

	private const string EIGHT_OPEN_CLICK = "EightSigentFirstInAnim{0}";

	private const string EIGHT_DAILY_FIRST_IN = "EIGHT_DAILY_FIRST_IN";

	protected uint m_SignetProgressPercentNum;

	public ActivityESportsDesc ActivityEsportsDesc => null;

	public string ActivityESportsWebData => null;

	public bool HasBindOTPActivityTrigger
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong EasterActivityTodayExpireTime
	{
		get
		{
			return _003CEasterActivityTodayExpireTime_003Ek__BackingField;
		}
		private set
		{
			_003CEasterActivityTodayExpireTime_003Ek__BackingField = value;
		}
	}

	public bool HasDiamondBonusRecharge => false;

	public bool HasFirstRecharge
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool HasSecondRecharge
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool HasShareImage => false;

	public bool ShowFriendReunion => false;

	public string InviterUIDFromLink
	{
		get
		{
			return _003CInviterUIDFromLink_003Ek__BackingField;
		}
		set
		{
			_003CInviterUIDFromLink_003Ek__BackingField = value;
		}
	}

	public CSGetFestivalAttendanceInfoRes MegaFestivalAttendanceInfo
	{
		get
		{
			return _003CMegaFestivalAttendanceInfo_003Ek__BackingField;
		}
		private set
		{
			_003CMegaFestivalAttendanceInfo_003Ek__BackingField = value;
		}
	}

	public List<FestivalAttendanceItem> MegaFestivalSigninAwards
	{
		get
		{
			return _003CMegaFestivalSigninAwards_003Ek__BackingField;
		}
		private set
		{
			_003CMegaFestivalSigninAwards_003Ek__BackingField = value;
		}
	}

	public bool HasGetMegaFestivalInfoSinceLogin
	{
		get
		{
			return _003CHasGetMegaFestivalInfoSinceLogin_003Ek__BackingField;
		}
		private set
		{
			_003CHasGetMegaFestivalInfoSinceLogin_003Ek__BackingField = value;
		}
	}

	public IEnumerable<ActivityGroupDesc> ActivityGroupDescList => null;

	public ActivityGroupDesc CurrentDisplayPaymentActivity
	{
		get
		{
			return _003CCurrentDisplayPaymentActivity_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentDisplayPaymentActivity_003Ek__BackingField = value;
		}
	}

	public bool IsActivityESportsWebRequesting => false;

	public bool IsActivityESportsEnabled()
	{
		return false;
	}

	public TagConfig GetActivityTagConfigByEvent(EEventTag eEvent)
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void UpdateEasterActivityTodayExpireTime()
	{
	}

	public bool ActivityDescDataFetched()
	{
		return false;
	}

	public bool HasActivityInfoData()
	{
		return false;
	}

	public bool HasMegaAttendanceInfoData()
	{
		return false;
	}

	public bool HasActivityFeaturesResData()
	{
		return false;
	}

	public List<ActivityFeaturesDesc> GetActivityFeatures()
	{
		return null;
	}

	public HttpRequest RequestActivityDesc(float timeout = 0f, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
		return null;
	}

	public HttpRequest RequestReturnerFeaturesDesc(ActivityFestivalDesc desc, float timeout = 0f, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
		return null;
	}

	public override void NotifyDataChanged(uint propID, object[] param)
	{
	}

	public static proto.EActivity.Platform ActivityPlatform()
	{
		return proto.EActivity.Platform.Platform_NONE;
	}

	private void ClearActivityDesc()
	{
	}

	public void ProcessAllActivityDescs(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool notifyChange = true)
	{
	}

	private void ProcessGroupDesc(ActivityGroupDesc groupDesc)
	{
	}

	private void ProcessActivityGroupDesc(List<ClientActivityDesc> activityDescList)
	{
	}

	public List<ActivityInteractionDesc> GetActivityInteractions(uint activityId)
	{
		return null;
	}

	private void OnActivityFeaturesDescResponse(HttpErrorCode errorCode, object obj)
	{
	}

	public void OnActivityDescResponse(HttpErrorCode errorCode, object obj)
	{
	}

	public ClientActivityDesc GetSecretDescByGroupIdAndSubType(uint groupId, proto.EActivity.SubType subType)
	{
		return null;
	}

	public bool IsInValidLevel(ClientActivityDesc desc)
	{
		return false;
	}

	public bool IsValidGroup(uint groupId, bool showTips = true)
	{
		return false;
	}

	public ClientActivityDesc GetActivityByGroup(uint groupId)
	{
		return null;
	}

	public HttpRequest RequestActivityInfo(float timeout = 0f, bool forceUpdate = false, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
		return null;
	}

	private void OnGetActivenessInfo()
	{
	}

	public void OnActivityInfoResponse(HttpErrorCode errorCode, CSGetActivityInfoRes obj, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateActivityInfos(List<ActivityInfo> activityInfos, bool notify = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void SaveData()
	{
	}

	public void LoadData()
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public void RequestActivityAward(uint activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false, Action onSuccess = null, int exchangeTimes = 1, bool protectBPCards = false, ActivityMultiCdtValueInfo multiCdtValueInfo = null)
	{
	}

	public void RequestActivityAwardWithGroup(uint activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false, Action onSuccess = null, int exchangeTimes = 1)
	{
	}

	public void RequestActivityAwardInGameScene(uint activityid)
	{
	}

	public void RequestActivityAward(uint[] activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false, Action onSuccess = null, List<ActivityMultiCdtValueInfo> multiCdtValueInfos = null)
	{
	}

	private void SendActivityAwardRequest(CSGetActivityRewardsReq req, uint[] activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false, Action onSuccess = null, bool protectBPCards = false)
	{
	}

	public bool NeedShowActivenessClaimAllBtn()
	{
		return false;
	}

	public void NotifyActivityUpdate(List<tcp.ActivityUpdateInfo> updateInfos, bool updateByHTTP = false)
	{
	}

	public void ClearBigEventMatchresultTask()
	{
	}

	public ClientActivityDesc GetBigEventDescByID(uint activityID)
	{
		return null;
	}

	public ActivityClientInfo GetActicityInfo(uint activityid)
	{
		return null;
	}

	public ActivenessInfo GetActivenessInfo()
	{
		return null;
	}

	public void ResetActivenessTaskAndReward()
	{
	}

	public ulong GetActivenessResetTime(EActivenessRewardType type)
	{
		return 0uL;
	}

	public List<ActivenessReward> GetActivenessRewardList(EActivenessRewardType type)
	{
		return null;
	}

	public proto.EActivity.State GetActivityListState(List<ClientActivityDesc> list)
	{
		return proto.EActivity.State.State_RECEIVED;
	}

	public proto.EActivity.State GetActivityListStateWithTime(List<ClientActivityDesc> list)
	{
		return proto.EActivity.State.State_RECEIVED;
	}

	public bool HasExchangeActivity()
	{
		return false;
	}

	public int GetExchangeActivityLeftTimes(ClientActivityDesc desc)
	{
		return 0;
	}

	public bool HasBindActivity()
	{
		return false;
	}

	public bool HasBindActivityNow()
	{
		return false;
	}

	public bool IsInActivePeriod(ActivityGroupDesc group)
	{
		return false;
	}

	public bool IsInShowPeriod(ClientActivityDesc desc)
	{
		return false;
	}

	public bool IsInShowPeriod(ActivityGroupDesc desc)
	{
		return false;
	}

	public bool IsInActivePeriod(ClientActivityDesc desc)
	{
		return false;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescs_Unfinished(EEventType eventType)
	{
		return null;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescs_RewardClaimable(EEventType eventType)
	{
		return null;
	}

	public bool HasClaimableReward(ActivityGroupDesc group)
	{
		return false;
	}

	public bool IsUnfinished(ActivityGroupDesc group)
	{
		return false;
	}

	public List<ActivityClientInfo> FindActivityInfosByGroupIdAndState(uint groupId, proto.EActivity.State state)
	{
		return null;
	}

	private bool MatchWithActivityInfo(ActivityGroupDesc activityGroupDesc, Predicate<ActivityClientInfo> predicate)
	{
		return false;
	}

	public bool IsInPreviewPeriod(ActivityGroupDesc group)
	{
		return false;
	}

	public bool IsInPreviewPeriod(ClientActivityDesc group)
	{
		return false;
	}

	public bool IsInPreLoginPeriod(uint groupid)
	{
		return false;
	}

	public bool IsInRemindPeriod(ActivityGroupDesc group)
	{
		return false;
	}

	public ActivityGroupDesc GetActivityGroupDesc(uint groupid)
	{
		return null;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescs(EEventType eventType)
	{
		return null;
	}

	public List<ClientActivityDesc> GetAllActivityGroupDescs(EEventType eventType, proto.EActivity.SubType subType, proto.EActivity.CircleType circle_type)
	{
		return null;
	}

	public bool HasFriendReunionActivity()
	{
		return false;
	}

	public ActivityGroupDesc GetFriendReunionActivityDesc()
	{
		return null;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescs(EEventType eventType, proto.EActivity.SubType subType)
	{
		return null;
	}

	public List<ActivityGroupDesc> GetActivityFriendReunionGroupDesc()
	{
		return null;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescs(EventEntryType entry, EEventType eventType)
	{
		return null;
	}

	public List<ClientActivityDesc> GetActivityDescList(uint groupid)
	{
		return null;
	}

	public List<ClientActivityDesc> GetActivityDescListByType(uint groupid, uint eEventType, proto.EActivity.CircleType circle_type)
	{
		return null;
	}

	public List<ActivityClientInfo> GetActivityInfoList(uint groupid)
	{
		return null;
	}

	public bool IsActivityGroupHasState(uint groupID, proto.EActivity.State state)
	{
		return false;
	}

	public int GetEasterRedDotNum()
	{
		return 0;
	}

	public int GetOverviewRedDotNum()
	{
		return 0;
	}

	public bool IsOverviewActivityRedDotValid(ClientActivityDesc activity)
	{
		return false;
	}

	public int GetExchangeActivityCanExchageNum(ActivityGroupDesc groupDesc)
	{
		return 0;
	}

	public int GetNewOverViewRedNum(ActivityGroupDesc groupDesc)
	{
		return 0;
	}

	public int GetInteractiveActivityRedNum(ActivityGroupDesc groupDesc)
	{
		return 0;
	}

	public bool GetNewOverViewRed(ClientActivityDesc activityDesc)
	{
		return false;
	}

	public bool IsActicityFinished(uint activityId)
	{
		return false;
	}

	public bool ExchangeActivityCanExchange(uint activityId)
	{
		return false;
	}

	public bool ExchangeActivityNoExchangeByUniqueItem(uint activityId)
	{
		return false;
	}

	public bool ExchangeActivityItemCountEnough(ClientActivityDesc desc)
	{
		return false;
	}

	private static bool IsExchangeActivityType(uint activityType)
	{
		return false;
	}

	private bool IsExchangeActivityDescCompleted(ClientActivityDesc desc)
	{
		return false;
	}

	private bool IsExchangeRowCompleted(List<ClientActivityDesc> rowList)
	{
		return false;
	}

	private bool IsExchangeActivityListAwarded(List<ClientActivityDesc> activityList)
	{
		return false;
	}

	private bool IsNormalActivityListAwarded(List<ClientActivityDesc> activityList)
	{
		return false;
	}

	private bool IsMixedActivityListAwarded(List<ClientActivityDesc> activityList)
	{
		return false;
	}

	private bool IsExchangeGroupAwarded(ActivityGroupDesc group)
	{
		return false;
	}

	public bool IsActivityInForecastTime(uint activityId)
	{
		return false;
	}

	private void UpdateExtraInfo(bool tcpNotify = false)
	{
	}

	private void UpdateShowActivityDescGroup()
	{
	}

	public void UpdateActivityTipsNum()
	{
	}

	public void CloseExchangeRedTips(uint activity_id)
	{
	}

	public void OpenExchangeRedTips(uint activity_id)
	{
	}

	public bool IsExchangeRedTipsClosed(uint activity_id)
	{
		return false;
	}

	public int ReleaseNotesTipsNum()
	{
		return 0;
	}

	public int RefreshReturnFeatureTipsNum()
	{
		return 0;
	}

	public int ActivityTopTabTipsNum(EventTabType tabType)
	{
		return 0;
	}

	public int ReturnFeaturesTabTipsNum()
	{
		return 0;
	}

	private int MegaFestivalGroupTipsNum(ActivityGroupDesc group)
	{
		return 0;
	}

	public int GetActivityTipsNumForThirdTab(List<ClientActivityDesc> activityList)
	{
		return 0;
	}

	public int ActivityGroupTipsNum(ActivityGroupDesc group)
	{
		return 0;
	}

	public AdvertDesc GetHistoryPatchAdDesc(uint activityId)
	{
		return null;
	}

	private bool ProcessPathAdDict(string language, List<AdvertDesc> adDescs)
	{
		return false;
	}

	private int GetNormalActivityRedNum(List<ClientActivityDesc> activityList)
	{
		return 0;
	}

	public int GetScoreProgressRedNum(List<ClientActivityDesc> activityList)
	{
		return 0;
	}

	public int GetBindPlatformAndOTPRedNum(List<ClientActivityDesc> activityList)
	{
		return 0;
	}

	public bool FestivalActivityAvailble(ActivityGroupDesc group)
	{
		return false;
	}

	public bool FestivalActivityAvailble(List<ClientActivityDesc> descs)
	{
		return false;
	}

	private void UpdateFirstRecharge()
	{
	}

	private void UpdateSecondRecharge()
	{
	}

	public EQuestState GetActivityGroupState(EEventType eventType)
	{
		return EQuestState.None;
	}

	private List<uint> _GetDisplayedFriendReunionInviteeActivities()
	{
		return null;
	}

	private void _SetDisplayedFriendReunionInviteeActivities(List<uint> group_ids)
	{
	}

	private FBInvited _GetFBInvited()
	{
		return null;
	}

	private void _SetFBInvited(FBInvited fbInvited)
	{
	}

	public bool GetFriendReunionFBInvited(ulong uid, uint group_id)
	{
		return false;
	}

	public void OnFriendReunionInviteeActivityDisplayed(ActivityGroupDesc desc)
	{
	}

	public bool ShowTipsForFriendReunionInviteeActivity(ActivityGroupDesc desc)
	{
		return false;
	}

	public bool ShowInviterInputForFriendReunionInviteeActivity(ActivityGroupDesc desc)
	{
		return false;
	}

	public bool IsFriendReunionInviteeActivityGained(ActivityGroupDesc desc)
	{
		return false;
	}

	public bool ShouldShowFriendReunionFor(FriendAccountInfo friend)
	{
		return false;
	}

	public bool CheckFriendReunionActivityShow()
	{
		return false;
	}

	public void InspectFriendReunionInviteeActivity(ActivityGroupDesc desc, out bool show, out int tips)
	{
		show = default(bool);
		tips = default(int);
	}

	public void InspectFriendReunionInviterActivity(ActivityGroupDesc desc, out bool show, out int tips)
	{
		show = default(bool);
		tips = default(int);
	}

	public void SendFriendReunion(ulong inviterID, uint activityID, bool isFriend, uint subType)
	{
	}

	public int GetRedDot(EEventType eventType, uint group_id)
	{
		return 0;
	}

	private void ClearRedDot(EEventType eventType)
	{
	}

	private void SetRedDot(EEventType eventType, uint group_id, int num)
	{
	}

	private int CalcRedDots(EEventType eventType)
	{
		return 0;
	}

	private void UpdatePaymentActivity()
	{
	}

	private void UpdatePaymentTotal()
	{
	}

	private void UpdateOptionalDownloadRewarded(bool tcpNotify = false)
	{
	}

	public bool IsNewActivity(uint groupid)
	{
		return false;
	}

	public bool IsNewLocalActivity()
	{
		return false;
	}

	public bool IsActivityUseInterval(uint activity)
	{
		return false;
	}

	public bool IsLocalActivityUseInterval(uint event_id)
	{
		return false;
	}

	public bool IsGroupUseInterval(uint groupid)
	{
		return false;
	}

	public int GetActivityRefreshInterval(uint groupid)
	{
		return 0;
	}

	public uint GetActivityReddotRefreshIntervalDays(uint groupid)
	{
		return 0u;
	}

	public uint GetLocalActivityReddotRefreshIntervalDays()
	{
		return 0u;
	}

	public long GetActivityStartTime(uint groupid)
	{
		return 0L;
	}

	public long GetLocalActivityStartTime(uint event_id)
	{
		return 0L;
	}

	public void SetActivityReadedTimestamp(uint activity)
	{
	}

	public void SetGroupReadedTimestamp(uint groupid)
	{
	}

	public bool IsNewReturenFeature(uint featureId)
	{
		return false;
	}

	public void SetActivityReaded(uint groupid)
	{
	}

	public void SetSingleActivityReaded(uint activity)
	{
	}

	public void SetLocalActivityReaded()
	{
	}

	public void SetReturnFeatureReaded(uint featureId)
	{
	}

	public bool IsSingleActivityGotoUnClicked(uint activityId)
	{
		return false;
	}

	public void SetSingleActivityGotoClicked(uint activityId)
	{
	}

	public bool IsActivityGotoUnClicked(uint groupid)
	{
		return false;
	}

	public void SetActivityGotoClicked(uint groupid)
	{
	}

	public ActivityGroupDesc GetGroupDescOfActivity(uint activityid)
	{
		return null;
	}

	public ClientActivityDesc GetActivityDesc(uint activityid)
	{
		return null;
	}

	public List<uint> GetUnFinishedClientTriggerActivityByGopos(EV2NavigationPageType gopos)
	{
		return null;
	}

	public uint GetTableTypeWeight(uint tableType)
	{
		return 0u;
	}

	public ActivityFestivalDesc GetFestivalDesc(EventTabType type)
	{
		return null;
	}

	public ActivityFestivalDesc GetFestivalDesc(uint groupId, uint affiliateTab)
	{
		return null;
	}

	public ActivityTemplateDesc GetTemplateConfig(uint groupId, string configKey)
	{
		return null;
	}

	public string GetTemplateParam(uint groupId, string configKey, int paramIndex = 1)
	{
		return null;
	}

	public bool GetTemplateParamBool(uint groupId, string configKey)
	{
		return false;
	}

	public string GetTemplateCdnUrl(uint groupId, string configKey, int paramIndex = 1)
	{
		return null;
	}

	public bool HasTemplateCdnUrl(uint groupId, string configKey, int paramIndex = 1)
	{
		return false;
	}

	public string GetTemplateLocStr(uint groupId, string configKey, int paramIndex = 1)
	{
		return null;
	}

	public string GetTemplateLocStrFormat(uint groupId, string configKey, object[] args)
	{
		return null;
	}

	public uint GetTemplateParamUInt(uint groupId, string configKey, int paramIndex = 1, uint defaultValue = 0u)
	{
		return 0u;
	}

	public int GetTemplateParamInt(uint groupId, string configKey, int paramIndex = 1, int defaultValue = 0)
	{
		return 0;
	}

	public ActivityTemplateDesc GetTemplateConfig(uint groupId, EActivityTemplateConfigKey configKey)
	{
		return null;
	}

	public string GetTemplateParam(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1)
	{
		return null;
	}

	public bool GetTemplateParamBool(uint groupId, EActivityTemplateConfigKey configKey)
	{
		return false;
	}

	public string GetTemplateCdnUrl(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1)
	{
		return null;
	}

	public bool HasTemplateCdnUrl(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1)
	{
		return false;
	}

	public string GetTemplateLocStr(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1)
	{
		return null;
	}

	public string GetTemplateLocStrFormat(uint groupId, EActivityTemplateConfigKey configKey, object[] args)
	{
		return null;
	}

	public uint GetTemplateParamUInt(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1, uint defaultValue = 0u)
	{
		return 0u;
	}

	public int GetTemplateParamInt(uint groupId, EActivityTemplateConfigKey configKey, int paramIndex = 1, int defaultValue = 0)
	{
		return 0;
	}

	public List<ActivityGroupDesc> GetActivityGroupDescList(EventTabType type)
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ProcessLocalEventInfo(List<LocalEventEntranceDesc> localEventEntranceDescs)
	{
	}

	public bool IsLocalActivityOpen()
	{
		return false;
	}

	public LocalEventEntranceDesc GetCurLocalEventEntranceDesc()
	{
		return null;
	}

	public HttpRequest GetMegaFestivalAttendanceInfo(bool silence = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return null;
	}

	public void ClaimMegaFestivalItem(uint id)
	{
	}

	public bool CheckIsNeedAutoSignMegaFestival()
	{
		return false;
	}

	public void MegaFestivalAutoSignin()
	{
	}

	public int GetNowDaysSinceMegaFestivalStartDay()
	{
		return 0;
	}

	public static EventEntryType GetEventEntryType(EventTabType tabType)
	{
		return EventEntryType.Unkonw;
	}

	public static EventEntryType GetEventEntryType(int tabType)
	{
		return EventEntryType.Unkonw;
	}

	public void RequestClientActivityTrigger(uint activityId)
	{
	}

	public void RequestClientActivityTriggerWithEventType(uint activityId, uint eventType)
	{
	}

	public bool NavigateActivityByGoPos(uint activityID, UINavigationUtil.UINavigationFrom from, string fromInfo = "", string toInfo = "")
	{
		return false;
	}

	public static bool TryBuildWorkshopDetailNavigateInfo(ClientActivityDesc activityDesc, out string fromInfo)
	{
		fromInfo = null;
		return false;
	}

	public ClientActivityDesc GetBigEventTaskDescById(uint activityID)
	{
		return null;
	}

	public ClientActivityDesc GetBigEventTaskDescByTypeAndId(EEventType type, uint activityID)
	{
		return null;
	}

	public ClientActivityDesc GetBigEventActivityDescByTwoType(EEventType type, proto.EActivity.SubType subType)
	{
		return null;
	}

	public List<ClientActivityDesc> GetBigEventSortedDescListByTwoType(EEventType type, proto.EActivity.SubType subType)
	{
		return null;
	}

	public List<ClientActivityDesc> GetBigEventActivityDesc(EEventType type)
	{
		return null;
	}

	public void ProcesssNormalTopUpEvent()
	{
	}

	public void UpdateTopUpEventRedDotTips()
	{
	}

	public bool IsNewTopUpEvent(uint groupID)
	{
		return false;
	}

	public bool HasNormalTopUpEvent()
	{
		return false;
	}

	public List<ActivityGroupDesc> GetNormalTopUpEventDescList()
	{
		return null;
	}

	public List<ClientActivityDesc> GetSortedDescList(uint activityid)
	{
		return null;
	}

	private int SortNormalTopUpEventGroupDescList(ActivityGroupDesc a, ActivityGroupDesc b)
	{
		return 0;
	}

	public int SortNormalTopUpEventDescList(ClientActivityDesc a, ClientActivityDesc b)
	{
		return 0;
	}

	private int CalculateWeight(proto.EActivity.State state)
	{
		return 0;
	}

	public bool NeedNewReleaseNotesStyle()
	{
		return false;
	}

	public void ProcessFriendReunionFakingActivityData(bool isCallBackOpen, long reunionStartTime = 0L, long reunionEndTime = 0L)
	{
	}

	public void FilterFriendReunionFakingDataByCallBackType(ActivityGroupDesc activityGroupDesc)
	{
	}

	public bool GetFriendReunionTabTypeAndGroupId(out uint tableType, out uint groupID)
	{
		tableType = default(uint);
		groupID = default(uint);
		return false;
	}

	public void UpdateFriendReunionRedTips()
	{
	}

	public bool GetActivityListClaimable(List<ClientActivityDesc> list)
	{
		return false;
	}

	public bool HasAnyActivityClaimable(List<ClientActivityDesc> list, List<uint> excludeActivityIds = null)
	{
		return false;
	}

	public bool GetActivityClaimable(ClientActivityDesc desc)
	{
		return false;
	}

	public ActivityOperateStatus GetOperateStatus(ClientActivityDesc desc)
	{
		return ActivityOperateStatus.NotStarted;
	}

	public ActivityOperateStatus GetOperateStatus(ClientActivityDesc desc, proto.EActivity.State state)
	{
		return ActivityOperateStatus.NotStarted;
	}

	public void RequestSignetProgressPercent(uint num)
	{
	}

	public uint GetSignetProgressPercent()
	{
		return 0u;
	}

	public int GetEightEightRedPointState(ActivityGroupDesc activityList)
	{
		return 0;
	}

	public void ChectActivitySpecialReaded(ActivityGroupDesc groupDesc)
	{
	}

	protected bool CheckSignetOpenRed(ActivityGroupDesc groupDesc)
	{
		return false;
	}

	protected void SetSignetOpenRed(ActivityGroupDesc groupDesc)
	{
	}

	public bool IsUnreadEighthSignetMission(uint id)
	{
		return false;
	}

	public void SetReadEighthSignetMission(uint id)
	{
	}

	public bool IsShowEighthSignetMission(uint id)
	{
		return false;
	}

	public void SetShowEighthSignetMission(uint id)
	{
	}

	public bool IsNeedEighthSignetFirstInAnim(uint index)
	{
		return false;
	}

	public void SaveEighthSignetFirstInAnim(uint index)
	{
	}

	public bool IsNeedEighthSignetDailyFirstInAnim()
	{
		return false;
	}

	public void SaveEighthSignetDailyFirstInAnim()
	{
	}

	public bool IsSignetGuideFirstIn()
	{
		return false;
	}

	public void SaveSignetGuideFirstIn()
	{
	}

	private void ClearActivityESportsRuntimeState()
	{
	}

	private void ProcessActivityESportsWebviewGroups()
	{
	}

	public bool HasActivityESportsWebData()
	{
		return false;
	}

	public HttpRequest RequestActivityESportsDesc()
	{
		return null;
	}

	private static bool IsActivityESportsWebCacheExpired(string originalUrl)
	{
		return false;
	}

	private bool TryLoadActivityESportsWebDataFromCache()
	{
		return false;
	}

	private void SendActivityESportsWebRequest(string requestUrl, string originalUrl, string apiToken, uint cacheTime, float timeout = 10f)
	{
	}

	private IEnumerator SendActivityESportsWebRequestCoroutine(string requestUrl, string originalUrl, string apiToken, uint cacheTime, float timeout)
	{
		return null;
	}

	private void InvalidateExpiredActivityESportsWebData(string originalUrl)
	{
	}

	private void RebuildAllActivityDescsFromConfig()
	{
	}

	private void ApplyActivityESportsWebDataAndRebuild()
	{
	}

	private static void GetActivityESportsCacheKeys(string originalUrl, out string cacheKey, out string expireKey)
	{
		cacheKey = null;
		expireKey = null;
	}

	private static void SaveActivityESportsWebCache(string cacheKey, string expireKey, string webData, uint cacheTime)
	{
	}

	private static void ClearActivityESportsWebCache(string cacheKey, string expireKey)
	{
	}

	private static bool IsValidActivityESportsMenuResponse(ActivityESportsMenuResponse response)
	{
		return false;
	}

	private bool TryParseActivityESportsWebResponse(string json, out ActivityESportsMenuResponse response)
	{
		response = null;
		return false;
	}

	private static string ReplaceActivityESportsUrlPlaceholders(string url)
	{
		return null;
	}

	private static string AppendActivityESportsQueryArgs(string url, List<object> requestArgs)
	{
		return null;
	}

	private static List<object> GetActivityESportsCommonWebQueryArgs(string originalUrl, string currentUrl)
	{
		return null;
	}

	private static string BuildActivityESportsRequestUrl(string originalUrl)
	{
		return null;
	}

	public void ProcessESportWebData()
	{
	}

	private string BuildActivityESportsMenuUrl(string menuPath)
	{
		return null;
	}

	private void _003CRequestActivityAwardInGameScene_003Eb__152_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CSendFriendReunion_003Eb__255_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CGetActivityGroupDescList_003Eb__313_0(ActivityGroupDesc e)
	{
		return false;
	}

	private void _003CGetMegaFestivalAttendanceInfo_003Eb__318_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CMegaFestivalAutoSignin_003Eb__321_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CMegaFestivalAutoSignin_003Eb__321_1(FestivalAttendanceItem item)
	{
		return false;
	}

	private void _003CRequestSignetProgressPercent_003Eb__360_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_NotifyDataChanged(uint P0, object[] P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
