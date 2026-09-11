using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using GCommon;
using GarenaMSDK;
using proto;
using proto.Login;

namespace COW;

internal class UIModelLogin : UIBaseModel
{
	public enum EPGSTokenSyncStates
	{
		Unauthorized,
		AuthorizedButNotSync,
		AuthorizedAndSync,
		Max
	}

	private class ServerStatusInfo
	{
		public uint code;

		public string billboard_msg;
	}

	public enum ELogoutType
	{
		Manually,
		Exception,
		LogOutAll,
		Bind,
		KickOut
	}

	private enum BRPlatformVerifyFailStrategy
	{
		None,
		Allow,
		Reject,
		OpenForm
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__133_0;

		public static SDKLogin.SAFGuestCb _003C_003E9__143_0;

		public static Action<HttpErrorCode, object> _003C_003E9__182_0;

		public static Action _003C_003E9__192_0;

		public static Predicate<AbTestChoice> _003C_003E9__207_1;

		public static Action<MSDKResult, SDKOTP.MobileNumberBindInfo> _003C_003E9__255_0;

		public static Predicate<CSVBaseData> _003C_003E9__265_0;

		public static Predicate<CSVBaseData> _003C_003E9__265_1;

		public static Action _003C_003E9__278_0;

		public static Action _003C_003E9__279_0;

		public static Action _003C_003E9__287_0;

		public static Predicate<DMAPolicyLinkData> _003C_003E9__295_1;

		public static Action _003C_003E9__317_0;

		public static Action _003C_003E9__322_0;

		internal void _003CRequestServerStatus_003Eb__133_0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CProcessAutosaveGuest_003Eb__143_0(SDKLogin.SAFGuestResult safResult)
		{
		}

		internal void _003CRequestGenerateNickname_003Eb__182_0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CPopupWrongVersionMessage_003Eb__192_0()
		{
		}

		internal bool _003CProcessLastLoginRes_003Eb__207_1(AbTestChoice newChoice)
		{
			return false;
		}

		internal void _003CGetMobileNumberBindInfo_003Eb__255_0(MSDKResult res, SDKOTP.MobileNumberBindInfo info)
		{
		}

		internal bool _003C_ShowPlatformLoginBtnDirectly_003Eb__265_0(CSVBaseData x)
		{
			return false;
		}

		internal bool _003C_ShowPlatformLoginBtnDirectly_003Eb__265_1(CSVBaseData x)
		{
			return false;
		}

		internal void _003CProcesssLoginErrorBRCodeVersion_003Eb__278_0()
		{
		}

		internal void _003CProcessHighReleaseVersionLogin_003Eb__279_0()
		{
		}

		internal void _003CProcessMtpChangeOnLogin_003Eb__287_0()
		{
		}

		internal bool _003CGetDMAPolicyLinkData_003Eb__295_1(DMAPolicyLinkData x)
		{
			return false;
		}

		internal void _003CCheckMsdkRegFormAntiAddictionBR_003Eb__317_0()
		{
		}

		internal void _003CShowWebViewErrorQuitPopup_003Eb__322_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public UIPopupMessageBoxController messageBox;

		internal void _003C_OnLoginSDK_Garena_Failure_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public UIModelLogin _003C_003E4__this;

		public LoginResp resp;

		internal void _003COnLoginSDK_Garena_Failure_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass164_0
	{
		public UIModelLogin _003C_003E4__this;

		public string msg;

		internal void _003COnPGSRecallReadFailure_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public UIModelLogin _003C_003E4__this;

		public string region;

		internal void _003CRequestRegionChoose_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass177_0
	{
		public bool isBind;

		internal void _003CRequestGetPlatformProfile_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass183_0
	{
		public UIModelLogin _003C_003E4__this;

		public uint avatar_id;

		internal void _003CRequestPlatformRegister_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public PlatformType newPlatform;

		public UIModelLogin _003C_003E4__this;

		internal void _003CRequestBind_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UIModelLogin _003C_003E4__this;

		public bool logoutSdk;

		public ELogoutType type;

		internal void _003CRequestLogout_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass201_0
	{
		public UIModelLogin _003C_003E4__this;

		public MajorLoginRes majorRes;

		internal void _003CProcessMiddleLoginRes_003Eb__0(HttpErrorCode errorCode1, object loginDataRes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass205_0
	{
		public string advertising_id;

		public Dictionary<string, string> parameters;

		public string adidKey;

		public string eventName;

		internal void _003CLogFireBaseAd_003Eb__0(PlatformUtility_Android.GetAdvertisingIdResult r)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass224_0
	{
		public UIModelLogin _003C_003E4__this;

		public EGLJDBDMENB loginRes;

		internal void _003CRequestStaticDescOnLogin_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass258_0
	{
		public List<int> installedIDs;

		internal void _003CDetectAndroidApplications_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass271_0
	{
		public UIModelLogin _003C_003E4__this;

		public PlatformType newPlatform;

		public Action<SDKBind.PlatformBindingInfo> _003C_003E9__1;

		internal void _003CRequestSecondaryBind_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestSecondaryBind_003Eb__1(SDKBind.PlatformBindingInfo rsp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass280_0
	{
		public EFFIBlockType blockType;

		public UISecondConfirmBigController confirmWnd;

		internal void _003CShowFFIBlockedPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass280_1
	{
		public string customerLink;

		public string storeLink;

		public _003C_003Ec__DisplayClass280_0 CS_0024_003C_003E8__locals1;

		internal void _003CShowFFIBlockedPopup_003Eb__1()
		{
		}

		internal void _003CShowFFIBlockedPopup_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass288_0
	{
		public UIModelAntiAddiction modelAntiAddiction;

		internal void _003CProcessAntiAddictionInfoOnLogin_003Eb__0()
		{
		}

		internal void _003CProcessAntiAddictionInfoOnLogin_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass289_0
	{
		public UIModelAntiAddiction modelAntiAddiction;

		internal void _003CProcessAntiAddictionInfoAfterVerifyAge_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass295_0
	{
		public string lang;

		internal bool _003CGetDMAPolicyLinkData_003Eb__0(DMAPolicyLinkData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass296_0
	{
		public UIModelLogin _003C_003E4__this;

		public string screenKey;

		internal void _003CStartGetEVData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass301_0
	{
		public UIModelLogin _003C_003E4__this;

		public EAccount.NewbieChoice choice;

		public ulong accountId;

		internal void _003CRequestSetNewbieVeteranChoose_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass304_0
	{
		public UIModelLogin _003C_003E4__this;

		public Action callback;

		internal void _003CConstructDMAInquiryWndInfo_003Eb__0()
		{
		}

		internal void _003CConstructDMAInquiryWndInfo_003Eb__1(bool consentForAnalytics, bool consentForAds)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass307_0
	{
		public UIModelLogin _003C_003E4__this;

		public string cmd;

		internal void _003CRequestLoginGetAccountInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass312_0
	{
		public UIModelLogin _003C_003E4__this;

		public bool forceDisplay;

		public bool isBeforeLogin;

		public bool playerRefresh;

		public bool reauth;

		public bool isOnlyGetVerificationInfo;

		public uint retryCount;

		internal void _003CRequestBRPlatformAgeVerify_003Eb__0(SdkUserIdentification.GoogleUserIdentificationInfo info)
		{
		}

		internal void _003CRequestBRPlatformAgeVerify_003Eb__1(SdkUserIdentification.AppleUserIdentificationInfo info)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass320_0
	{
		public string region;

		internal bool _003CIsInListOfRegions_003Eb__0(string r)
		{
			return false;
		}
	}

	private sealed class _003CGotoLobbyV2Coroutine_003Ed__217 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelLogin _003C_003E4__this;

		private string _003ChttpLoginGetSplash_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGotoLobbyV2Coroutine_003Ed__217(int _003C_003E1__state)
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

		void IEnumerator.Reset()
		{
		}
	}

	public const uint PropID_LoginRetOK = 2u;

	public const uint PropID_LoginRetNewUser = 4u;

	public const uint PropID_GuestBindSuccess = 8u;

	public const uint PropID_SDKLogin = 16u;

	public const uint PropID_LoginRegionChoose = 32u;

	public const uint PropID_LoginRegionReChoose = 64u;

	public const uint PropID_LoginServerFailure_Logout = 128u;

	public const uint PropID_RegisterSuccess = 256u;

	public const uint PropID_ShowMaintenanceMessage = 1024u;

	public const uint PropID_LoginLoadOver = 2048u;

	public const uint PropID_MajorLoginSuccess = 4096u;

	public const uint PropID_PlatformBindSuccess = 8192u;

	public const uint PropID_GetPlatformBindInfoSuccess = 16384u;

	public const uint PropID_MajorRegisterResponed = 32768u;

	public const uint PropID_ServerFatalError = 65536u;

	public const uint PropID_GetLoginDescFailed = 131072u;

	public const uint PropID_LoginError = 262144u;

	public const uint PropID_SDKLoginError = 524288u;

	public const uint PropID_PGSTokenSyncStateChange = 1048576u;

	public const uint PropID_StartLoginGame = 2097152u;

	public const uint PropID_GetLoginDataSuccess = 4194304u;

	public const uint PropID_DebugLogin = 8388608u;

	public const uint PropID_SDKSwap = 16777216u;

	public const uint PropID_GetAccountBriefInfoBeforeLogin = 67108864u;

	public const uint PropID_ChangeNewbieVeteranChoose = 134217728u;

	public const uint PropID_PlatformVerifyFailedRejectedLogin = 268435456u;

	private const float TIMEOUT_LOGIN = 10f;

	private const float TIMEOUT_LOGOUT = 10f;

	private const float TIMEOUT_REGISTER = 20f;

	private const float TIMEOUT_BINDING = 20f;

	private const string KEY_InstantApp = "instantapp";

	public const string KEY_GUIDE_BINDACCOUNT = "KEY_GUIDE_BINDACCOUNT";

	public const string KEY_NEW_WEEK_BINDACCOUNT = "KEY_NEW_WEEK_BINDACCOUNT";

	public const string KEY_OTP_WEEK_BINDACCOUNT = "KEY_OTP_WEEK_BINDACCOUNT";

	public const string KEY_BIND_ACCOUNT_VN_LAST_SHOW_TIME = "KEY_BIND_ACCOUNT_VN_LAST_SHOW_TIME";

	public const string KEY_BIND_ACCOUNT_IND_LAST_SHOW_TIME = "KEY_BIND_ACCOUNT_IND_LAST_SHOW_TIME";

	public const string KEY_INSTANCEGAME = "KEY_INSTANCEGAME";

	private const int ReRequestLogInterval = 5;

	private uint m_CurRequestLoginDelayCallID;

	private EAccount.DownloadType m_DownLoadType;

	private bool IsSendingChooseNewbieChoice;

	public bool FirstTimeInLobby;

	private bool m_HasEverLoggedIn;

	private bool ffantihackGPPProcessed;

	public string loginRegion;

	public string IpCity;

	public string IpSubdivision;

	public string IpRegion;

	public static string EnableBugReporter;

	private string AgoraEnvironment;

	public static ELoginType LastHotUpdateErrorType;

	public static bool IsOfflineSkipVersionCheck;

	public static bool IsSkipPopEnteringOfflineScene;

	private List<AndroidApplicationToDetectDesc> m_AndroidApplicationToDetectDescs;

	private Dictionary<uint, WorkshopFriendStatesSwitchDesc> m_WorkshopFriendStatesSwitchDescs;

	private Thread m_GenerateLibMapAndMemThread;

	private Thread m_ResetScheduleNotifyThread;

	private uint m_RegisterCreateNameDuration;

	private bool m_ForbidenRepeatLogin;

	public bool IsDefaultNewbieChoice;

	private string m_Region;

	private bool m_LastLoginMtpEnabled;

	private bool m_HasLastLoginMtpInfo;

	public const uint GIN_INIT_GGP_ENABLE = 1u;

	public const uint GIN_INIT_EARLY_SWITCH = 4u;

	private static readonly Dictionary<byte, string> m_DictLoginErrorMessage;

	private bool _003CIsLogout_003Ek__BackingField;

	private EPGSTokenSyncStates m_PGSTokenSyncState;

	private bool _003CGetSwitchFromServer_003Ek__BackingField;

	private uint _003Cm_LoginTryTimes_003Ek__BackingField;

	private bool m_EnableDebugUpload;

	private bool m_AutoUploadLastLog;

	private bool m_EnableBotAgent;

	private uint _003CTodayWeatherId_003Ek__BackingField;

	private Dictionary<string, DMAPolicyControlData> m_DMAPolicyControlDataDic;

	private Dictionary<string, List<DMAPolicyLinkData>> m_DMAPolicyLinkDataDic;

	private Thread m_GetEVDataThread;

	private byte[] m_CachedEVData;

	private string m_CachedEVDataScreenKey;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private UIPopupMessageBoxController m_LoginQueuePopupController;

	private UILoginQueueInfoPopupWndController m_LoginQueueInfoCtrl;

	private LoginQueueInfo m_CacheQueueInfo;

	private ulong m_LastFetchQueueInfoTime;

	private string m_CachedRegion;

	private bool _PendingLoginSDK_Garena;

	private AccountPlatform _PendingLoginSDK_Garena_AccountPlatform;

	private const int GMSDK_LOGIN_RETRY_INTERVAL_MAX = 20;

	private const int GMSDK_LOGIN_RETRY_INTERVAL_STEP = 5;

	private int _GMSDKLoginRetryTimes;

	private const int AUTO_LOGIN_TIMEOUT_S = 60;

	private const int PGS_READ_TIMEOUT_S = 5;

	private uint _DelayCallId_AbortLoginSDK_Garena;

	public const string PLAYER_PREFS_KEY_PGS_TOKEN_DIGEST = "PGSRecallTokenDigest";

	public const string PLAYER_PREFS_KEY_MSDK_REG_FORM_IDENTIFIED_OPENIDS = "MSDK_REG_FORM_IDENTIFIED_OPENIDS";

	public static readonly char[] OPEN_ID_SEPARATOR;

	private bool _JustLoggedOut;

	private string m_ffantiUrl;

	private EGLJDBDMENB m_TempLoginRes;

	private MajorLoginRes m_TempMajorLoginRes;

	private bool ffantihackEnabled;

	private bool ffantihackHPEEnabled;

	private bool _LogGuestMigrationResult;

	private int _GuestMigrationResult;

	private bool _MigratedGuestInvalid;

	private List<string> m_ChatWebWhiteListServer;

	public static string PREFS_KEY_RECHECK_APPEAL;

	public bool HasLoginGetAccountInfo;

	private RegFormObserverBR m_RegFormObserverBR;

	public bool IsLogout
	{
		get
		{
			return _003CIsLogout_003Ek__BackingField;
		}
		set
		{
			_003CIsLogout_003Ek__BackingField = value;
		}
	}

	public EPGSTokenSyncStates PGSTokenSyncState => EPGSTokenSyncStates.Unauthorized;

	public bool GetSwitchFromServer
	{
		get
		{
			return _003CGetSwitchFromServer_003Ek__BackingField;
		}
		private set
		{
			_003CGetSwitchFromServer_003Ek__BackingField = value;
		}
	}

	public uint m_LoginTryTimes
	{
		get
		{
			return _003Cm_LoginTryTimes_003Ek__BackingField;
		}
		set
		{
			_003Cm_LoginTryTimes_003Ek__BackingField = value;
		}
	}

	public bool EnableDebugUpload => false;

	public bool EnableBotAgent => false;

	public uint TodayWeatherId
	{
		get
		{
			return _003CTodayWeatherId_003Ek__BackingField;
		}
		private set
		{
			_003CTodayWeatherId_003Ek__BackingField = value;
		}
	}

	private Dictionary<string, DMAPolicyControlData> DMAPolicyControlDataDic => null;

	private Dictionary<string, List<DMAPolicyLinkData>> DMAPolicyLinkDataDic => null;

	public string CachedRegion => null;

	public string DeviceUniqueIdentifier => null;

	public override void Init()
	{
	}

	public void LogVerbose(string log)
	{
	}

	public static string GetLoginErrorMessage(ELoginType loginType, string errorMessage)
	{
		return null;
	}

	public static string GetLoginErrorMessage(ELoginType loginType)
	{
		return null;
	}

	private void StartLoginLoading()
	{
	}

	public bool SupportSwapTo(string swappingRegion, PlatformType platformType)
	{
		return false;
	}

	public bool SupportBind(PlatformType platformType)
	{
		return false;
	}

	private bool CanUseAndroidSystemWebViewInProcess()
	{
		return false;
	}

	private bool IsOAuthAvailable(PlatformType platformType)
	{
		return false;
	}

	public bool SupportSignIn(PlatformType platformType)
	{
		return false;
	}

	public bool CheckPlatformAuthorizableOrPrompt(PlatformType platformType)
	{
		return false;
	}

	public bool IsNewWeekLoginInWhenLevelMeet()
	{
		return false;
	}

	public bool IsNewWeekLoginInWhenOTPLevelMeet()
	{
		return false;
	}

	private bool IsNewWeekLogin(string formatKey)
	{
		return false;
	}

	public void SaveRegisterCreateNameDuration(uint duration)
	{
	}

	public void SaveRegisterIsDefaultChooseNewBie(bool if_newbie_choice)
	{
	}

	public void TryGetRegisterCreateNameDurationAndSendLog()
	{
	}

	private void StopReRequestLoginProcess()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RequestServerStatus(string region)
	{
	}

	public void ShowFailedPanel(ELoginType loginType)
	{
	}

	public void ShowRegionNotOpenPanel(uint time, ELoginType loginType)
	{
	}

	public void LoginSDK(PlatformType platformType, bool autoLogin)
	{
	}

	private void LoginSDK_Garena_Abort_Cancel()
	{
	}

	private void LoginSDK_Garena_Abort()
	{
	}

	private void LoginSDK_PGSRead_Abort()
	{
	}

	private void OnLoginSDK_Garena_Success(LoginResp rsp)
	{
	}

	private void ProcessAutosaveGuest()
	{
	}

	private void _OnLoginSDK_Garena_Failure(ErrorCode errCode)
	{
	}

	private void OnLoginSDK_Garena_Failure(LoginResp resp)
	{
	}

	private void LoginSDK_Garena(AccountPlatform accountPlatform, bool autoLogin)
	{
	}

	public bool IsPGSReadIPRegion()
	{
		return false;
	}

	public bool ShouldReadFromPGSRecall()
	{
		return false;
	}

	public string MakePGSTokenDigest(string token)
	{
		return null;
	}

	public bool IsPGSWriteIPRegion()
	{
		return false;
	}

	private bool ShouldWriteToPGSRecall()
	{
		return false;
	}

	private void ProcessPGSRecallAfterGarenaLogin()
	{
	}

	public void SetPGSTokenSyncState(uint syncState)
	{
	}

	public void CheckPGSTokenSyncState()
	{
	}

	public void ProcessPGSRecallBeforeGarenaLogin()
	{
	}

	private void OnPGSRecallReadSuccess(LoginResp rsp)
	{
	}

	private void OnPGSRecallReadFailure(string msg)
	{
	}

	private void _OnPGSRecallReadFailure(string msg)
	{
	}

	public static bool PlayerPrefsHasOpenID(string key, string openID)
	{
		return false;
	}

	public static bool AddOpenIDToPlayerPrefs(string key, string openID)
	{
		return false;
	}

	public static bool RemoveOpenIDFromPlayerPrefs(string key, string openID)
	{
		return false;
	}

	private static string[] GetOpenIDsFromPlayerPrefs(string key)
	{
		return null;
	}

	private static void SetOpenIDsToPlayerPrefs(string key, string[] openIDs)
	{
	}

	private void FixReleaseVersion()
	{
	}

	private string ReleaseVersionAdd(string releaseVesion, int add)
	{
		return null;
	}

	public void RequestLogin()
	{
	}

	public void RequestRegionChoose(string region)
	{
	}

	public void RequestGetPlatformProfile(bool isBind = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public EAccount.DownloadType PublicGetDownloadType()
	{
		return EAccount.DownloadType.DownloadType_NONE;
	}

	private EAccount.DownloadType GetDownloadType()
	{
		return EAccount.DownloadType.DownloadType_NONE;
	}

	private void ClearCookie()
	{
	}

	private void WarmUpLobby()
	{
	}

	public void RequestGenerateNickname()
	{
	}

	public void RequestPlatformRegister(string nickname, uint avatar_id, bool isDefaultChooseNewbie)
	{
	}

	public void SetRegisterFlowBit(ulong account_id, CSChooseNewbieChoiceRes chooseNewbieChoiceRes, bool needResetCSFirst = true)
	{
	}

	public void RequestBind(PlatformType oldPlatform, PlatformType newPlatform, string newOpenId, string newToken)
	{
	}

	public void RequestLogout(ELogoutType type, bool logoutSdk = true)
	{
	}

	public bool ShouldRestorePlatformLogin()
	{
		return false;
	}

	private void ClearAfterLogout()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void PopupWrongVersionMessage(ELoginType loginType)
	{
	}

	private void PopupLoginQueueIsFull()
	{
	}

	private void UpdateLoginQueueInfo(LoginQueueInfo info, bool isNew = false)
	{
	}

	private void ClearQueueInfo()
	{
	}

	private void InitCachedLockRegion()
	{
	}

	private void UpdateCachedLockRegion(string region)
	{
	}

	private void ProcessLoginError(HttpErrorCode errorCode, ELoginType loginType)
	{
	}

	private void ProcessAccountForbidden(BlacklistInfoRes blackList)
	{
	}

	private void OnMiddleLoginRes(HttpErrorCode errorCode, object res)
	{
	}

	private void ProcessMiddleLoginRes(HttpErrorCode errorCode, object res, uint login_by = 0u)
	{
	}

	private void SetVeteranState(EGLJDBDMENB loginRes)
	{
	}

	private void SendLogBRTutorialABTest()
	{
	}

	public void SendLoginAppFlyerEvent(EGLJDBDMENB loginRes)
	{
	}

	private void LogFireBaseAd(string eventName, ulong accountID)
	{
	}

	private void ProcessLastLoginRes(HttpErrorCode errorCode, EGLJDBDMENB loginRes, MajorLoginRes majorRes)
	{
	}

	public void ContinueToGoToLobbyAfterChooseAgeBR(AccountAntiAddictionInfo antiAddictionInfo)
	{
	}

	public static KeyValuePair<TKey, TValue> Pair<TKey, TValue>(TKey key, TValue value)
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	private void PreloadConfigData()
	{
	}

	private void AfterRequestMiddleLogin()
	{
	}

	private void OnGetLoginDesc(HttpErrorCode errorCode, object obj)
	{
	}

	public void GotoLobby()
	{
	}

	public void ReportIL2cppStartPos()
	{
	}

	private IEnumerator GotoLobbyV2Coroutine()
	{
		return null;
	}

	public static void PauseAsyncLoadingIfLowMachine()
	{
	}

	public void DelaySendBattleNotify()
	{
	}

	private static void ResumeAsyncLoadingIfLowMachine()
	{
	}

	private void StartDetachAndroidApp()
	{
	}

	private void ProcessReleaseVersion(List<ReleaseVersion> releaseVersions)
	{
	}

	private void RequestStaticDescOnLogin()
	{
	}

	private void RequestStaticDescOnLogin(EGLJDBDMENB loginRes, MajorLoginRes majorRes)
	{
	}

	public void RequestLobbyMessage()
	{
	}

	private void RequestLobbyMessageLater()
	{
	}

	private void RequestLobbyMessageLater_iOS()
	{
	}

	private void RequestLobbyMessageLater_Android()
	{
	}

	private void ProcessSuccessfulLogin(EGLJDBDMENB loginRes, MajorLoginRes majorRes)
	{
	}

	public void SecPlayerLogin(bool isReconnect = false)
	{
	}

	private void GenerateLibMapAndMem(EGLJDBDMENB loginRes)
	{
	}

	private void SetOptionalWhiteListState(EGLJDBDMENB loginRes)
	{
	}

	private void GenerateLibMapAndMemThread(object loginResParam)
	{
	}

	private void WaitGenerateLibMapAndMemThread()
	{
	}

	private void WaitResetScheduleNotifyThread()
	{
	}

	private void ProcessIngameHUDSetting(EGLJDBDMENB loginRes)
	{
	}

	private void ProcessBugReport(EGLJDBDMENB loginRes)
	{
	}

	public void ProcessffantihackOpen(FFAntiConfigDesc mtpSwitchDesc)
	{
	}

	public bool GetffantihackEnabled()
	{
		return false;
	}

	private bool GetEffectiveffantihackEnabled()
	{
		return false;
	}

	public bool GetffantihackEnabledTempValue(FFAntiConfigDesc mtpSwitchDesc)
	{
		return false;
	}

	private void ProcessffantihackGGP(EGLJDBDMENB loginRes)
	{
	}

	private void CleanFFAntiState(bool enable)
	{
	}

	private void ResetScheduleNotificationsWork()
	{
	}

	private void ResetScheduleNotifications()
	{
	}

	private void ProcessAH(EGLJDBDMENB loginRes)
	{
	}

	private void ProcessModelInitAfterLogin(EGLJDBDMENB loginRes, MajorLoginRes majorRes)
	{
	}

	private void ProcessVoiceEngine(EGLJDBDMENB loginRes)
	{
	}

	private void ProcessEighthLobbySetting(EGLJDBDMENB loginRes)
	{
	}

	private void ProcessSceneEditOfflineMode(EGLJDBDMENB loginRes)
	{
	}

	private void ProcessConnectTCPServer(EGLJDBDMENB loginRes)
	{
	}

	private void ConnectTCPServerThread(object loginResParam)
	{
	}

	private void GetMobileNumberBindInfo()
	{
	}

	public void CheckUnmapWebViewReservedVirtualMemory()
	{
	}

	private void CheckAstcAnd64bitSupport()
	{
	}

	private void DetectAndroidApplications()
	{
	}

	private void CreateLoginReqInfoData(ref PMGLEAFAIGF req)
	{
	}

	public bool ShouldShowBindAccount()
	{
		return false;
	}

	public bool ShouldShowBindAccountForCompliance()
	{
		return false;
	}

	public bool CheckBindAccountForComplianceNeedLoginShow()
	{
		return false;
	}

	public static bool CheckCanShowByIntervalDays(SwitchDesc desc, string playerPrefsKey)
	{
		return false;
	}

	public bool PlatformBtnNeedShowOutOfMoreButton(PlatformType platformType)
	{
		return false;
	}

	private bool _ShowPlatformLoginBtnDirectly(PlatformType platformType)
	{
		return false;
	}

	public void Bind(PlatformType platform)
	{
	}

	private void BindGarena(PlatformType platform)
	{
	}

	private void BindSecondaryPlatform(PlatformType platform)
	{
	}

	private string ProcessBindErrcode(ErrorCode errCode)
	{
		return null;
	}

	private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
	{
	}

	public void RequestSecondaryBind(PlatformType newPlatform, string newOpenId, string newToken)
	{
	}

	private void ShowAccountBindResult()
	{
	}

	public void OnGuestMigrationResult(int result)
	{
	}

	private void LogGuestMigration()
	{
	}

	private void ProcesssLoginErrorBRCodeVersion(ELoginType loginType)
	{
	}

	private void ProcessHighReleaseVersionLogin(ELoginType loginType)
	{
	}

	private void ShowFFIBlockedPopup(string text, EFFIBlockType blockType = EFFIBlockType.None)
	{
	}

	private void ProcessChatWebWhitelist(CSGetChatWebWhiteListRes desc)
	{
	}

	public bool ContainWhiteList(string msg)
	{
		return false;
	}

	public void ProcessDebugUploadSwitch(bool open)
	{
	}

	public void ChangeEnableDebugUploadSwitch(bool isOpen)
	{
	}

	private void UploadLastLog()
	{
	}

	private void ProcessMtpChangeOnLogin(ref bool canGoToLobby)
	{
	}

	private void ProcessAntiAddictionInfoOnLogin(EGLJDBDMENB loginRes, MajorLoginRes majorRes, ref bool canGoToLobby)
	{
	}

	private void ProcessAntiAddictionInfoAfterVerifyAge(AccountAntiAddictionInfo antiAddictionInfo, ref bool canGoToLobby)
	{
	}

	private void BuildAntiAddictionHistoryInfo(EGLJDBDMENB loginRes)
	{
	}

	private void ClearAppealCache(ulong accountId)
	{
	}

	private void RequestKocInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public UserPrivacyManager.GoogleConsentMode.UserApplicability GetDMASwitch()
	{
		return UserPrivacyManager.GoogleConsentMode.UserApplicability.None;
	}

	public DMAPolicyLinkData GetDMAPolicyLinkData()
	{
		return null;
	}

	public void StartGetEVData()
	{
	}

	private void CalculateEVDataWork(string screenKey)
	{
	}

	private byte[] WaitAndGetCachedEVData(string screenKey)
	{
		return null;
	}

	private void ReleaseCachedEVData()
	{
	}

	public void RequestAccountBriefInfoBeforeLogin()
	{
	}

	public void RequestSetNewbieVeteranChoose(ulong accountId, EAccount.NewbieChoice choice)
	{
	}

	public bool GetFriendStatesSwitch(uint gameMode)
	{
		return false;
	}

	public bool GetReserveButtonSwitch(uint gameMode)
	{
		return false;
	}

	public UIDMAInquiryWndController.WndInfo ConstructDMAInquiryWndInfo(Action callback = null)
	{
		return null;
	}

	public CSChooseNewbieChoiceRes CreateChooseNewbieChoiceResByRegister(PlatformRegisterRes registerRes)
	{
		return null;
	}

	public void RequestLoginGetAccountInfo()
	{
	}

	public void OnSwapCompleteLogin(AccountPlatform accountPlatform)
	{
	}

	public bool CheckBRAgeVerifyAntiAddictionBR(bool forceDisplay = false, bool isBeforeLogin = false, bool playerRefresh = false, bool reauth = false, bool isOnlyGetVerificationInfo = false)
	{
		return false;
	}

	private bool RequestBRPlatformAgeVerify(bool forceDisplay, bool isBeforeLogin, bool playerRefresh, bool reauth, bool isOnlyGetVerificationInfo, bool hasCallerFallback, uint retryCount = 0u)
	{
		return false;
	}

	private void OnBRGoogleUserIdentification(SdkUserIdentification.GoogleUserIdentificationInfo info, bool forceDisplay, bool isBeforeLogin, bool playerRefresh, bool reauth, bool isOnlyGetVerificationInfo, uint retryCount)
	{
	}

	private void OnBRAppleUserIdentification(SdkUserIdentification.AppleUserIdentificationInfo info, bool forceDisplay, bool isBeforeLogin, bool playerRefresh, bool reauth, bool isOnlyGetVerificationInfo, uint retryCount)
	{
	}

	private void UpdateBRAgeAuthInfoFromPlatformVerification(SdkUserIdentification.VerificationInfo verificationInfo, bool isBeforeLogin, bool playerRefresh, bool isOnlyGetVerificationInfo, bool reauth)
	{
	}

	private bool HandleBRPlatformAgeVerifyFailed(bool forceDisplay, bool isBeforeLogin, bool playerRefresh, bool reauth, bool isOnlyGetVerificationInfo, uint retryCount, bool canRetry, bool hasCallerFallback)
	{
		return false;
	}

	public bool CheckMsdkRegFormAntiAddictionBR(bool forceDisplay = false, bool isBeforeLogin = false, bool playerRefresh = false, bool reauth = false)
	{
		return false;
	}

	public void RequestVerificationInfoInSettingIfVerifying()
	{
	}

	public bool WaitForMsdkRegForm(string region)
	{
		return false;
	}

	public bool IsInListOfRegions(string region, string list)
	{
		return false;
	}

	public void UnRegisterRegFormObserverBR()
	{
	}

	public void ShowWebViewErrorQuitPopup()
	{
	}

	private void Create2DLobby()
	{
	}

	private void _003CProcessPGSRecallAfterGarenaLogin_003Eb__159_0(string msg)
	{
	}

	private void _003CProcessPGSRecallAfterGarenaLogin_003Eb__159_1(string str)
	{
	}

	private void _003CCheckPGSTokenSyncState_003Eb__161_0(string msg)
	{
	}

	private void _003CProcessPGSRecallBeforeGarenaLogin_003Eb__162_0(string msg)
	{
	}

	private void _003CProcessPGSRecallBeforeGarenaLogin_003Eb__162_1(string msg)
	{
	}

	private void _003CProcessLastLoginRes_003Eb__207_0()
	{
	}

	private void _003COnGetLoginDesc_003Eb__214_0()
	{
	}

	private void _003CBindGarena_003Eb__267_0(BindSessionResp rsp)
	{
	}

	private void _003CBindGarena_003Eb__267_1(BindSessionResp rsp)
	{
	}

	private void _003CBindSecondaryPlatform_003Eb__268_0(BindSessionResp rsp)
	{
	}

	private void _003CRequestKocInfo_003Eb__293_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAccountBriefInfoBeforeLogin_003Eb__300_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003COnSwapCompleteLogin_003Eb__308_0(LoginResp resp)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
