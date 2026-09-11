using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using message;
using proto;
using tcp;

namespace COW;

internal class UIModelAntiAddiction : UIBaseModel
{
	public class PlayerBRInfo
	{
		public tcp.AntiAddictionAgeAuthInfo authInfo;

		public tcp.GuardianVoiceChatSetting voiceSetting;

		public tcp.GuardianTextChatSetting textSetting;

		public string nickname;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__113_0;

		internal void _003CUpdateAntiAddictByDesc_003Eb__113_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public proto.EAntiAddiction.AgeState age;

		public Action onFinish;

		public bool isFirst;

		internal void _003CSetAntiAddictionAgeState_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public ulong friendId;

		public UIModelAntiAddiction _003C_003E4__this;

		internal void _003CRequestFriendBRAntiAddictionInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UIModelAntiAddiction _003C_003E4__this;

		public bool isBeforeLogin;

		public bool needWait;

		public bool isOnlyGetVerificationInfo;

		internal void _003CRequestUpdateAgeAuthInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass211_0
	{
		public UIModelAntiAddiction _003C_003E4__this;

		public BindingGuardianInfo guardianInfo;

		internal void _003CRequestApplyBindingGuardian_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass214_0
	{
		public UIModelAntiAddiction _003C_003E4__this;

		public bool realUnbind;

		internal void _003CRequestApplyUnBindGuardian_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public UIModelAntiAddiction _003C_003E4__this;

		public ulong minorAccountId;

		public Predicate<BindingGuardianInfo> _003C_003E9__1;

		internal void _003CRequestAcceptBindingGuardian_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestAcceptBindingGuardian_003Eb__1(BindingGuardianInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass219_0
	{
		public UIModelAntiAddiction _003C_003E4__this;

		public ulong minorAccountId;

		public Predicate<BindingGuardianInfo> _003C_003E9__1;

		internal void _003CRequestRefuseBindingGuardian_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestRefuseBindingGuardian_003Eb__1(BindingGuardianInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass311_0
	{
		public AntiAddictionApplyBindNtf ntf;

		internal bool _003COnTcpChildCancelApplyBindNtf_003Eb__0(BindingGuardianInfo info)
		{
			return false;
		}
	}

	public const uint PropID_BR_AgeAuthInfoUpdated = 2u;

	public const uint PropID_BR_GuardianInfoUpdated = 4u;

	public const uint PropID_BR_ApplyBindingGuardianListUpdated = 8u;

	public const uint PropID_BR_ApplyBindingGuardianResult = 16u;

	public const uint PropID_BR_AcceptBindingGuardianResult = 32u;

	public const uint PropID_BR_RefuseBindingGuardianResult = 64u;

	public const uint PropID_BR_ApplyUnBindingGuardianResult = 128u;

	public const uint PropID_BR_CancelApplyUnBindingGuardianResult = 256u;

	public const uint PropID_BR_ChildUnbindNtf = 512u;

	public const uint PropID_BR_GuardianUnbindNtf = 1024u;

	public const uint PropID_BR_GuardianAcceptApplyNtf = 2048u;

	public const uint PropID_BR_GuardianRefuseApplyNtf = 4096u;

	public const uint PropID_BR_ParentalControlNtf = 8192u;

	public const uint PropID_BR_ParentalControlTimeLimitNtf = 16384u;

	public const uint PropID_BR_ParentalControlTextChatNtf = 32768u;

	public const uint PropID_BR_ParentalControlVoiceChatNtf = 65536u;

	public const uint PropID_BR_OtherAccountAgeAuthInfoUpdated = 131072u;

	public const uint PropID_BR_HistorySecondsUpdated = 262144u;

	public const uint PropID_BR_FriendAntiAddictionInfoUpdated = 524288u;

	public const uint PropID_BR_ChildApplyBindNtf = 1048576u;

	public const uint PropID_BR_GuardianBindInfoUpdated = 2097152u;

	public const uint PropID_BR_CancelApplyBindingGuardianResult = 4194304u;

	public const uint PropID_BR_ChildCancelApplyBindNtf = 8388608u;

	public const uint PropID_BR_ClearAccountAgeAuthInfoResult = 16777216u;

	public const string DEBUG_BR_KEY = "DebugBR";

	private bool m_CanAutoTaskAddictWndPopup;

	private bool m_IsAntiAddictActivated;

	private bool m_IsChooseAgeActivated;

	private bool m_IsChooseAgeVerifyActivated;

	private bool m_IsBan;

	private string m_AntiAddictBanCDN;

	private string m_AntiAddictWarnCDN;

	private uint m_UnbanTime;

	private bool m_IsCanSkip;

	private string m_AddicticMessage;

	private string m_AddicticBanMessage;

	private proto.EAntiAddiction.TotalTimeBanMode m_AddicticBanMode;

	private List<PhoneNumControlDesc> m_PhoneNumberDescs;

	private bool m_LobbyTimeSiwtch;

	private bool m_IsBeKickedWndShowing;

	private readonly string TODAY_SEND_VERIFICATION_TIMES;

	private uint m_DailyResetHour;

	private int m_TodaySendVerificationTimes;

	private uint m_SendCodeTimesDayLimit;

	private uint m_SendLogDelaycall;

	private const string DEFAULT_ADULT_AGE = "17";

	private string m_AdultAge;

	private bool m_Age18LogoSwitchDataLoaded;

	private Dictionary<string, AntiAddiction18LogoSwitchData> m_Age18LogoSwitchIPRegionData;

	private Dictionary<string, AntiAddiction18LogoSwitchData> m_Age18LogoSwitchLockRegionData;

	private string m_BindPhoneStr;

	private ulong m_NextCheckPhoneTime;

	private ulong m_CheckPhoneCD;

	private List<DailyRechargeLimitDesc> m_DailyRechargeLimitDesc;

	private uint m_TopUpLimit;

	private AntiAddictionBRCommonConfigDesc m_AntiAddictionBRCommonConfigDesc;

	private List<AntiAddictionBRConfigDesc> m_AntiAddictionBRConfigDescs;

	private List<AntiAddictionConfigDesc> m_AntiAddictionConfigDescs;

	private proto.EAntiAddiction.AntiAddictionType m_AntiAddictionType;

	private proto.EAntiAddiction.PlayTimeResetType m_PlayTimeResetType;

	private List<uint> m_CachedBRAgeIndexList;

	private proto.AntiAddictionAgeAuthInfo m_AgeAuthInfo;

	private BindingGuardianInfo m_GuardianInfo;

	private ProtoAccountApplyBindInfo m_GuardianApplyBindInfo;

	private ProtoAccountApplyUnbindInfo m_GuardianApplyUnbindInfo;

	private List<BindingGuardianInfo> m_ApplyBindingGuardianList;

	private List<ulong> m_GuardianBoundChildrenIds;

	private bool m_HasRequestedGuardianBindInfo;

	private HashSet<ulong> m_NewMinorRequestsFromTcp;

	private Dictionary<ulong, proto.AntiAddictionAgeAuthInfo> m_OtherAccountAgeAuthInfoCache;

	private Dictionary<ulong, AccountGuardianSettingInfo> m_OtherAccountGuardianSettingCache;

	private ulong m_LastQueriedFriendId;

	private AccountGuardianSettingInfo m_GuardianSettingInfo;

	private uint m_HistorySeconds;

	private long m_HistorySecondsFetchTimestamp;

	private long m_InGameStartTimestamp;

	private long m_InGameAccumulatedSinceLastFetch;

	private const int FETCH_ANTI_ADDICTION_INFO_CD = 600;

	private long m_LastFetchAntiAddictionInfoTime;

	private Dictionary<ulong, PlayerBRInfo> m_PlayerBRInfoCache;

	private const int RESET_HOUR = 4;

	private const string KEY_BR_ANTI_ADDICTION_OFFLINE_BAN_UNBAN_TIME = "AntiAddiction_BR_OfflineBan_UnbanTime";

	private uint m_OfflineModePlayTimeSeconds;

	private long m_OfflineModeSaveTimestamp;

	private proto.EAntiAddiction.PlayTimeResetType m_OfflineModeSavedResetType;

	private const string KEY_OFFLINE_PLAY_TIME = "AntiAddiction_OfflineMode_PlayTime";

	private const string KEY_OFFLINE_LAST_TIMESTAMP = "AntiAddiction_OfflineMode_LastTimestamp";

	private const string KEY_OFFLINE_RESET_TYPE = "AntiAddiction_OfflineMode_ResetType";

	public bool CanAutoTaskAddictWndPopup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string AdultAge
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsAntiAddictActivated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsChooseAgeVerifyActivated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsChooseAgeActivated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBan
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string AntiAddictBanCDN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string AntiAddictWarnCDN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint UnbanTime
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsCanSkip
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string AddicticMessage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string AddicticBanMessage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public proto.EAntiAddiction.TotalTimeBanMode AddicticBanMode
	{
		get
		{
			return proto.EAntiAddiction.TotalTimeBanMode.TotalTimeBanMode_NONE;
		}
		set
		{
		}
	}

	public bool LobbyTimeSwitch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBeKickedWndShowing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int TodaySendCodeTimes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint SendCodeTimesDayLimit
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public ulong NextBindPhoneSendVerifyCodeTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public string BindPhoneStr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ulong NextCheckPhoneTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public ulong CheckPhoneCD
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public uint TopUpLimit => 0u;

	public ulong LastQueriedFriendId => 0uL;

	public uint HistorySeconds => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool TryGetLoginAge18Logo(string ipRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetLoginAge18LogoByLockRegion(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetUGCOfflineLobbyAge18Logo(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetUGCOfflineInGameAge18Logo(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetLobbyAge18Logo(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetInGameAge18Logo(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public bool TryGetEndMatchAge18Logo(string lockRegion, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	private bool TryGetAge18LogoSwitchByIPRegion(string ipRegion, out AntiAddiction18LogoSwitchData data)
	{
		data = null;
		return false;
	}

	private bool TryGetAge18LogoSwitchByLockRegion(string lockRegion, out AntiAddiction18LogoSwitchData data)
	{
		data = null;
		return false;
	}

	private bool TryGetAge18LogoSwitchResult(bool switchOn, string cdnConfig, bool requireCDN, out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	private void LoadAge18LogoSwitchData()
	{
	}

	public void UpdateAntiAddictByDesc(CSAntiAddictionSwitchDescRes res)
	{
	}

	private void ParseFFISpecificFields(AntiAddictionSwitchDesc switchDesc, CSAntiAddictionSwitchDescRes res)
	{
	}

	private void ParseBRSpecificFields(AntiAddictionSwitchDesc switchDesc, CSAntiAddictionSwitchDescRes res)
	{
	}

	private void CacheBRAgeIndexList()
	{
	}

	private void DebugFFI()
	{
	}

	public void SetAntiAddictionAgeState(proto.EAntiAddiction.AgeState age, Action onFinish = null, bool isFirst = false)
	{
	}

	public void UpdateAntiAddictionSmsOtpCoolDown()
	{
	}

	public List<PhoneNumControlDesc> GetPhoneNumDescs()
	{
		return null;
	}

	public void ProcessTopUpLimit()
	{
	}

	private void ClearTopUpLimit()
	{
	}

	public string GenerateRemindContent(string hintString, uint playTime)
	{
		return null;
	}

	public string GenerateBanRemindContent(string hintString, uint playTime, uint unBanTime)
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetMobileNumberBindInfo(SDKOTP.MobileNumberBindInfo info)
	{
	}

	public void LoadTodaySendCodeTimes()
	{
	}

	public void SetTodaySendCodeTimes()
	{
	}

	public bool IsSendCodeLimit()
	{
		return false;
	}

	public bool CheckTodaySendCodeTimesReachLimit()
	{
		return false;
	}

	public uint TodayRemainSendCodeTimes()
	{
		return 0u;
	}

	public int GetNextHourTimeStamp()
	{
		return 0;
	}

	public bool IsBRAntiAddiction()
	{
		return false;
	}

	public bool IsFFIAntiAddiction()
	{
		return false;
	}

	private void DebugBR()
	{
	}

	public bool IsBRBeforeLogin()
	{
		return false;
	}

	public uint GetLogMaxAdultsLimit()
	{
		return 0u;
	}

	public uint GetLogIntervalSeconds()
	{
		return 0u;
	}

	public void UpdateAgeAuthInfo(proto.AntiAddictionAgeAuthInfo ageAuthInfo)
	{
	}

	private void CancelMinorReportLogIfAdult()
	{
	}

	public bool CheckAntiAddictionBRNeedLoginAgeVerify(ref bool forceShow)
	{
		return false;
	}

	public bool IsBRNewAgeVerifyFlowEnabled()
	{
		return false;
	}

	public bool IsBRPlatformAgeVerifyPriority()
	{
		return false;
	}

	public uint GetBRPlatformVerifyFailStrategy()
	{
		return 0u;
	}

	public bool IsBRAgeVerifyRetryEnabled()
	{
		return false;
	}

	public uint GetBRMaxAgeVerifyRetryCount()
	{
		return 0u;
	}

	public proto.EAntiAddiction.AgeState GetBRAgeState()
	{
		return proto.EAntiAddiction.AgeState.AgeState_NONE;
	}

	public proto.EAntiAddiction.AgeState GetBRAgeStateWithTreatAs()
	{
		return proto.EAntiAddiction.AgeState.AgeState_NONE;
	}

	public bool HasCompletedAgeAuth()
	{
		return false;
	}

	public proto.EAntiAddiction.AuthState GetAuthState()
	{
		return proto.EAntiAddiction.AuthState.AuthState_NONE;
	}

	public string GetAgeType()
	{
		return null;
	}

	public proto.AntiAddictionAgeAuthInfo GetAgeAuthInfo()
	{
		return null;
	}

	public bool CanSyncAgeInSetting()
	{
		return false;
	}

	public ulong GetNextSyncAgeTime()
	{
		return 0uL;
	}

	public bool IsSyncAgeInCooldown()
	{
		return false;
	}

	public bool CanReAuthInSetting()
	{
		return false;
	}

	public ulong GetNextReAuthTime()
	{
		return 0uL;
	}

	public bool IsReAuthInCooldown()
	{
		return false;
	}

	public void RequestAntiAddictionBRVerifyAge(bool playerRefresh, bool isBeforeLogin, bool isOnlyGetVerificationInfo = false, bool reauth = false)
	{
	}

	public void RequestFriendBRAntiAddictionInfo(ulong friendId)
	{
	}

	public void RequestUpdateAgeAuthInfo(bool playerRefresh, bool isBeforeLogin, bool needWait = false, bool isOnlyGetVerificationInfo = false, bool reauth = false)
	{
	}

	private proto.EAntiAddiction.AgeState BRAgeTypeToAgeState(string ageType)
	{
		return proto.EAntiAddiction.AgeState.AgeState_NONE;
	}

	public AntiAddictionBRConfigDesc GetBRConfigByAgeType(string ageType)
	{
		return null;
	}

	private void CacheOtherAccountAgeAuthInfo(ulong accountId, proto.AntiAddictionAgeAuthInfo info)
	{
	}

	private void CacheOtherAccountGuardianSetting(ulong accountId, AccountGuardianSettingInfo setting)
	{
	}

	public AccountGuardianSettingInfo GetCachedOtherAccountGuardianSetting(ulong accountId)
	{
		return null;
	}

	public proto.AntiAddictionAgeAuthInfo GetCachedOtherAccountAgeAuthInfo(ulong accountId)
	{
		return null;
	}

	public bool CanAccountBeGuardian(ulong accountId)
	{
		return false;
	}

	public bool CanBeGuardianByAgeType(string ageType)
	{
		return false;
	}

	public void CheckAccountCanBeGuardian(ulong accountId)
	{
	}

	public void RequestGetAntiAddictionInfoWhenTimeReset()
	{
	}

	public void RequestAccountGuardianInfo()
	{
	}

	public void RequestApplyBindingGuardian(ulong guardianAccountId, BindingGuardianInfo guardianInfo = null)
	{
	}

	public void RequestCancelApplyBindGuardian()
	{
	}

	public void RequestClearAccountAgeAuthInfo()
	{
	}

	public void RequestApplyUnBindGuardian(bool realUnbind)
	{
	}

	public void CancelRequestApplyUnBindGuardian()
	{
	}

	public void RequestApplyBindingGuardianList()
	{
	}

	public void RequestGuardianGetBindInfo()
	{
	}

	public void RequestAcceptBindingGuardian(ulong minorAccountId)
	{
	}

	public void RequestRefuseBindingGuardian(ulong minorAccountId)
	{
	}

	public BindingGuardianInfo GetGuardianInfo()
	{
		return null;
	}

	public ProtoAccountApplyBindInfo GetGuardianApplyBindInfo()
	{
		return null;
	}

	public ProtoAccountApplyUnbindInfo GetGuardianApplyUnbindInfo()
	{
		return null;
	}

	public uint GetUnbindCoolDownTime()
	{
		return 0u;
	}

	public uint GetUnbindCoolDownTimeMinutes()
	{
		return 0u;
	}

	public bool IsInUnbindCoolDown()
	{
		return false;
	}

	public ulong GetUnbindCoolDownRemainingTime()
	{
		return 0uL;
	}

	public uint GetTwiceBindCoolDownTime()
	{
		return 0u;
	}

	public bool IsInTwiceBindCoolDown()
	{
		return false;
	}

	public ulong GetTwiceBindCoolDownRemainingTime()
	{
		return 0uL;
	}

	public uint GetApplyBindAutoRefuseTime()
	{
		return 0u;
	}

	public string GetBRWebLink()
	{
		return null;
	}

	public bool IsApplyBindExpired()
	{
		return false;
	}

	public bool ClearExpiredApplyBindInfo()
	{
		return false;
	}

	public bool CheckHasGuardian()
	{
		return false;
	}

	public bool IsApplyingGuardian()
	{
		return false;
	}

	public bool GetCanBeGuardian()
	{
		return false;
	}

	public bool IsBrAdult()
	{
		return false;
	}

	public bool IsMinor()
	{
		return false;
	}

	public List<BindingGuardianInfo> GetPendingBindingGuardianList()
	{
		return null;
	}

	public List<ulong> GetGuardianBoundChildrenIds()
	{
		return null;
	}

	public int GetGuardianBoundChildrenCount()
	{
		return 0;
	}

	public bool IsChildBoundToGuardian(ulong childAccountId)
	{
		return false;
	}

	public void UpdateHistorySeconds(uint historySeconds)
	{
	}

	private void SyncHistoryToAntiAddicCache(uint historySeconds, long historyUpdateTs)
	{
	}

	public int GetCurrentPlayedTimeMinutes()
	{
		return 0;
	}

	public void NotifyEnterLobby()
	{
	}

	public void NotifyLeaveLobby()
	{
	}

	public int GetRemainingPlayTimeMinutes()
	{
		return 0;
	}

	public int GetTotalPlayTimeLimitMinutes()
	{
		return 0;
	}

	public AccountGuardianSettingInfo GetGuardianSettingInfo()
	{
		return null;
	}

	public void UpdateGuardianSettingInfo(AccountGuardianSettingInfo settingInfo)
	{
	}

	public bool IsTimeLimitSettingInit()
	{
		return false;
	}

	public bool IsTimeLimitUnlimited()
	{
		return false;
	}

	public long GetTimeLimitSeconds()
	{
		return 0L;
	}

	public long GetPlayableTimeLimitSeconds()
	{
		return 0L;
	}

	public long GetDefaultPlayableTimeLimitSeconds()
	{
		return 0L;
	}

	public AntiAddictionConfigDesc GetCurrentAgeStateConfig()
	{
		return null;
	}

	public AntiAddictionConfigDesc GetAgeStateConfigByAgeType(string ageType)
	{
		return null;
	}

	public uint GetWarnBanModeTotalTime()
	{
		return 0u;
	}

	public int GetRemainingPlayTimeFromHint(ulong playTime)
	{
		return 0;
	}

	private bool IsUnverifiedPlayer(proto.AntiAddictionAgeAuthInfo info)
	{
		return false;
	}

	public bool IsSelfUnverified()
	{
		return false;
	}

	public bool isSelfVerifing()
	{
		return false;
	}

	private bool IsUnverifiedCommsEnabled()
	{
		return false;
	}

	private string GetAgeTypeByAgeIndex(uint ageIndex)
	{
		return null;
	}

	public bool IsAdultByAgeType(string ageType)
	{
		return false;
	}

	private proto.EAntiAddiction.AgeState GetAgeStateFromAgeType(string ageType)
	{
		return proto.EAntiAddiction.AgeState.AgeState_NONE;
	}

	private bool CanMinorChatWithAdults(AccountGuardianTextChatSetting textSetting, AccountGuardianVoiceChatSetting voiceSetting, bool isVoiceChat, string minorAgeType, ulong targetAccountId = 0uL)
	{
		return false;
	}

	private bool CanMinorChatWithMinors(AccountGuardianTextChatSetting textSetting, AccountGuardianVoiceChatSetting voiceSetting, bool isVoiceChat, string minorAgeType, ulong targetAccountId, string targetMinorAgeType, out bool isTargetInUidWhitelist)
	{
		isTargetInUidWhitelist = default(bool);
		return false;
	}

	private bool IsAgeStateAdult(proto.EAntiAddiction.AgeState ageState)
	{
		return false;
	}

	private bool IsAgeGroupInSwitchList(uint[] switchList, uint ageGroupIndex)
	{
		return false;
	}

	private bool IsAnyAdultAgeGroupInList(uint[] switchList)
	{
		return false;
	}

	public bool IsTextChatSettingInit()
	{
		return false;
	}

	public bool CanTextChatWith(proto.AntiAddictionAgeAuthInfo targetInfo, AccountGuardianTextChatSetting targetTextSetting, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	public bool CanTextChatWithTcp(tcp.AntiAddictionAgeAuthInfo targetInfo, tcp.GuardianTextChatSetting targetTextSetting, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	public bool CanChatInPublicChannel()
	{
		return false;
	}

	private bool IsAllAgeGroupsInWhitelist(uint[] whitelist)
	{
		return false;
	}

	public bool CanTextChatWithInMatch(ulong targetAccountId)
	{
		return false;
	}

	public bool IsVoiceChatSettingInit()
	{
		return false;
	}

	public bool CanVoiceChatWith(proto.AntiAddictionAgeAuthInfo targetInfo, AccountGuardianVoiceChatSetting targetVoiceSetting, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	public bool CanVoiceChatWithTcp(tcp.AntiAddictionAgeAuthInfo targetInfo, tcp.GuardianVoiceChatSetting targetVoiceSetting, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	public bool CanVoiceChatWith(JKFICGGHNFN targetInfo, GHDEMJHFOJM targetVoiceSetting, ref ChatRestrictionReason restrictionReason)
	{
		return false;
	}

	public void CheckAndApplyBRVoiceRestrictionInMatch(ulong playerUserId, JKFICGGHNFN brAuthInfo, GHDEMJHFOJM voiceChatSetting)
	{
	}

	public void UpdatePlayerBRInfoCache(ulong accountId, tcp.AntiAddictionAgeAuthInfo authInfo, tcp.GuardianVoiceChatSetting voiceSetting, tcp.GuardianTextChatSetting textSetting = null, string nickname = "")
	{
	}

	public void UpdatePlayerBRInfoCacheFromMessage(ulong accountId, JKFICGGHNFN authInfo, GHDEMJHFOJM voiceSetting, DCLNOPKBHLB textSetting = null, string nickname = "")
	{
	}

	public bool GetPlayerBRInfoFromCache(ulong accountId, out tcp.AntiAddictionAgeAuthInfo authInfo, out tcp.GuardianVoiceChatSetting voiceSetting)
	{
		authInfo = null;
		voiceSetting = null;
		return false;
	}

	public bool GetPlayerBRInfoFromCache(ulong accountId, out tcp.AntiAddictionAgeAuthInfo authInfo, out tcp.GuardianTextChatSetting textSetting)
	{
		authInfo = null;
		textSetting = null;
		return false;
	}

	public bool GetPlayerBRInfoFromCache(ulong accountId, out tcp.AntiAddictionAgeAuthInfo authInfo, out tcp.GuardianVoiceChatSetting voiceSetting, out string nickname)
	{
		authInfo = null;
		voiceSetting = null;
		nickname = null;
		return false;
	}

	public static AntiAddictionGuardianSetting ConvertToTcpGuardianSetting(AccountGuardianSettingInfo setting)
	{
		return null;
	}

	public static tcp.GuardianChatSetting ConvertToTcpChatSetting(proto.GuardianChatSetting setting)
	{
		return null;
	}

	public static tcp.AntiAddictionAgeAuthInfo ConvertToTcpAuthInfo(proto.AntiAddictionAgeAuthInfo authInfo)
	{
		return null;
	}

	public tcp.AntiAddictionAgeAuthInfo GetSelfTcpAuthInfo()
	{
		return null;
	}

	public tcp.GuardianTextChatSetting GetSelfTcpTextChatSetting()
	{
		return null;
	}

	public tcp.GuardianVoiceChatSetting GetSelfTcpVoiceChatSetting()
	{
		return null;
	}

	public void OnTcpChildUnbindNtf(AntiAddictionUnbindNtf ntf)
	{
	}

	public void OnTcpGuardianUnbindNtf(AntiAddictionUnbindNtf ntf)
	{
	}

	public void OnTcpGuardianAcceptApplyNtf(AntiAddictionApplyBindResNtf ntf)
	{
	}

	public void OnTcpGuardianRefuseApplyNtf(AntiAddictionApplyBindResNtf ntf)
	{
	}

	public void OnTcpChildApplyBindNtf(AntiAddictionApplyBindNtf ntf)
	{
	}

	public void OnTcpChildCancelApplyBindNtf(AntiAddictionApplyBindNtf ntf)
	{
	}

	public void OnTcpParentalControlNtf(AntiAddictionGuardianSetting tcpSetting)
	{
	}

	private void UpdateAntiAddictionHistoryAndResendTcp()
	{
	}

	public void OnTcpUnbindResetNtf(AntiAddictionUnbindResetNtf ntf)
	{
	}

	private void UpdateGuardianSettingFromTcp(AntiAddictionGuardianSetting tcpSetting)
	{
	}

	public bool HasPassedResetTime(ulong lastTimestamp)
	{
		return false;
	}

	public bool HasPassedResetTime(ulong lastTimestamp, ulong currentTimestamp)
	{
		return false;
	}

	private bool HasPassedDailyReset(ulong lastTimestamp, ulong currentTimestamp)
	{
		return false;
	}

	private bool HasPassedWeeklyReset(ulong lastTimestamp, ulong currentTimestamp)
	{
		return false;
	}

	private DateTime GetNextWeeklyResetTime(DateTime time)
	{
		return default(DateTime);
	}

	private bool HasPassedMonthlyReset(ulong lastTimestamp, ulong currentTimestamp)
	{
		return false;
	}

	private DateTime GetNextMonthlyResetTime(DateTime time)
	{
		return default(DateTime);
	}

	public ulong GetNextResetTimestamp()
	{
		return 0uL;
	}

	public proto.EAntiAddiction.AuthState ConvertVerificationStatusToAuthState(VerificationStatus status, bool skipped)
	{
		return proto.EAntiAddiction.AuthState.AuthState_NONE;
	}

	public void UpdateAgeAuthInfoFromMsdkVerification(VerificationStatus verificationStatus, string ageGroup, bool skipped, bool isBeforeLogin = false, bool playerRefresh = false, bool isOK = true, bool isOnlyGetVerificationInfo = false, bool reauth = false)
	{
	}

	public void SaveBRAntiAddictionBanForOffline(ulong unbanTime)
	{
	}

	public bool IsBRAntiAddictionBannedForOffline()
	{
		return false;
	}

	public void ClearBRAntiAddictionBanForOffline()
	{
	}

	public bool CheckAndShowBRAntiAddictionBanPopupForOffline()
	{
		return false;
	}

	public void LoadOfflineModePlayTime()
	{
	}

	private bool HasPassedResetTimeWithType(ulong lastTimestamp, proto.EAntiAddiction.PlayTimeResetType resetType)
	{
		return false;
	}

	public void AutoSaveOfflineModePlayTime(uint currentGameTimeSeconds)
	{
	}

	public void RequestReportOfflineUGCPlayTime()
	{
	}

	private void _003CRequestGetAntiAddictionInfoWhenTimeReset_003Eb__209_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAccountGuardianInfo_003Eb__210_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCancelApplyBindGuardian_003Eb__212_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClearAccountAgeAuthInfo_003Eb__213_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CCancelRequestApplyUnBindGuardian_003Eb__215_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestApplyBindingGuardianList_003Eb__216_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGuardianGetBindInfo_003Eb__217_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestReportOfflineUGCPlayTime_003Eb__341_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
