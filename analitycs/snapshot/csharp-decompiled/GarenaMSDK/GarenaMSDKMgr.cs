using System;
using UnityEngine;

namespace GarenaMSDK;

public class GarenaMSDKMgr : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public Action<SDKBind.PlatformBindingInfo> callback;

		internal void _003CGetPlatformBindingInfo_003Eb__0(SDKBind.PlatformBindingInfo info)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string platformBindingInfo;

		internal void _003COnGetPlatformBindingInfoComplete_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public Action<BindSessionResp> callback;

		internal void _003CGetPlatformBindingSession_003Eb__0(BindSessionResp rsp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string loginRsp;

		internal void _003COnGetPlatformBindingSession_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string result;

		internal void _003COnPerformPlatformBindingComplete_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public SDKLogin.LoginCallback loginSuccess;

		public SDKLogin.LoginCallback loginFail;

		internal void _003CLogin_003Eb__0(LoginResp resp)
		{
		}

		internal void _003CLogin_003Eb__1(LoginResp resp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string data;

		internal void _003COnRecvAuthStatusInPGS_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string data;

		internal void _003COnSignedInPGS_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public string data;

		public GarenaMSDKMgr _003C_003E4__this;

		internal void _003COnGetCurrentPGSPlayerId_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string data;

		internal void _003COnWriteSessionToPGS_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public string data;

		internal void _003COnReadSessionFromPGS_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public string data;

		public GarenaMSDKMgr _003C_003E4__this;

		internal void _003COnRequestAuthCodePGS_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public SDKBind.GetBindSessionSuccessCb getBindSessionSuccess;

		public SDKBind.GetBindSessionFaildCb getBindSessionFaild;

		internal void _003CGetBindSession_003Eb__0(BindSessionResp rsp)
		{
		}

		internal void _003CGetBindSession_003Eb__1(BindSessionResp rsp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public GarenaMSDKMgr _003C_003E4__this;

		public LoginResp loginResp;

		internal void _003C_OnSwapCompleted_003Eb__0()
		{
		}
	}

	public bool EnableDebugLog;

	public bool UseSupportPGS;

	private string _003CGuestOpenID_003Ek__BackingField;

	private string _003CGuestAccessToken_003Ek__BackingField;

	private string _003COpenID_003Ek__BackingField;

	private string _003CAccessToken_003Ek__BackingField;

	private AccountPlatform _003CPlatform_003Ek__BackingField;

	private AccountPlatform _003CLoginPlatform_003Ek__BackingField;

	private AccountPlatform _003COriginalPlatform_003Ek__BackingField;

	private string appId;

	private string appKey;

	private string appPushKey;

	private SDKLogin sdkLogin;

	private SDKBind sdkBind;

	private static GarenaMSDKMgr instance;

	private static bool InitFlag;

	private Action<LoginResp> _OnSwapCompletedCallback;

	private SDKBind.PlatformBindingInfo _003CPlatformBindingInfo_003Ek__BackingField;

	public string GuestOpenID
	{
		get
		{
			return _003CGuestOpenID_003Ek__BackingField;
		}
		set
		{
			_003CGuestOpenID_003Ek__BackingField = value;
		}
	}

	public string GuestAccessToken
	{
		get
		{
			return _003CGuestAccessToken_003Ek__BackingField;
		}
		set
		{
			_003CGuestAccessToken_003Ek__BackingField = value;
		}
	}

	public string OpenID
	{
		get
		{
			return _003COpenID_003Ek__BackingField;
		}
		set
		{
			_003COpenID_003Ek__BackingField = value;
		}
	}

	public string AccessToken
	{
		get
		{
			return _003CAccessToken_003Ek__BackingField;
		}
		set
		{
			_003CAccessToken_003Ek__BackingField = value;
		}
	}

	public AccountPlatform Platform
	{
		get
		{
			return _003CPlatform_003Ek__BackingField;
		}
		set
		{
			_003CPlatform_003Ek__BackingField = value;
		}
	}

	public AccountPlatform LoginPlatform
	{
		get
		{
			return _003CLoginPlatform_003Ek__BackingField;
		}
		set
		{
			_003CLoginPlatform_003Ek__BackingField = value;
		}
	}

	public AccountPlatform PrimaryPlatform => AccountPlatform.None;

	public AccountPlatform OriginalPlatform
	{
		get
		{
			return _003COriginalPlatform_003Ek__BackingField;
		}
		set
		{
			_003COriginalPlatform_003Ek__BackingField = value;
		}
	}

	public static GarenaMSDKMgr Instance => null;

	public SDKBind.PlatformBindingInfo PlatformBindingInfo
	{
		get
		{
			return _003CPlatformBindingInfo_003Ek__BackingField;
		}
		private set
		{
			_003CPlatformBindingInfo_003Ek__BackingField = value;
		}
	}

	public bool FacebookAutoLogAppEvents
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FacebookAdvertisingIDCollectionEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public bool IsPlatformInstalled(AccountPlatform platform)
	{
		return false;
	}

	public void SetDataDomeSDKKey(string sdkKey)
	{
	}

	public bool SetPlatformAuthStrategy(AccountPlatform accountPlatform, int strategy)
	{
		return false;
	}

	public void InitSDK(string appId, string appKey, string appPushKey, bool production, bool force = false)
	{
	}

	public static void EnableSensitiveLogHiding(bool enable)
	{
	}

	public static void ShouldTrackAppDidBecomeActive(bool track)
	{
	}

	public static void OverrideFBGraphAPIVersion(string version)
	{
	}

	public static void SetOverrideDomainUrl(string authUrl, string payUrl)
	{
	}

	public static void SetGoogleClientID(string googleClientID)
	{
	}

	public AccountPlatform GetLoginRecord()
	{
		return AccountPlatform.None;
	}

	public bool SupportGuestMigration()
	{
		return false;
	}

	public bool NeedGuestMigration()
	{
		return false;
	}

	public void MigrateGuest(SDKLogin.SAFGuestCb onMigrate)
	{
	}

	public bool SupportGuestBackup()
	{
		return false;
	}

	public void AutosaveGuest(SDKLogin.SAFGuestCb onAutosave)
	{
	}

	public bool PlatformAvailable(AccountPlatform platform)
	{
		return false;
	}

	public void Login(AccountPlatform accountPlatform, bool autoLogin, SDKLogin.LoginCallback loginSuccess, SDKLogin.LoginCallback loginFail)
	{
	}

	public void Logout()
	{
	}

	public void OnLogin(string msg)
	{
	}

	public bool SupportPGSRecall()
	{
		return false;
	}

	public void GetAuthStateInPGS(Action<string> callback)
	{
	}

	public void SignInPGS(Action<string> callback)
	{
	}

	public void GetCurrentPGSPlayerId(Action<GetCurrentPGSPlayerIdResult> callback)
	{
	}

	public void WriteSessionToPGS(Action<string> callback)
	{
	}

	public void ReadSessionFromPGS(Action<LoginResp> success, Action<string> failure)
	{
	}

	public void RequestAuthCodePGS(string serverOAuthClientId, bool forceRefreshToken, Action<RequestAuthCodePGSResult> callback)
	{
	}

	public void OnRecvAuthStatusInPGS(string data)
	{
	}

	public void OnSignedInPGS(string data)
	{
	}

	public void OnGetCurrentPGSPlayerId(string data)
	{
	}

	public void OnWriteSessionToPGS(string data)
	{
	}

	public void OnReadSessionFromPGS(string data)
	{
	}

	public void OnRequestAuthCodePGS(string data)
	{
	}

	public void GetBindSession(AccountPlatform platform, SDKBind.GetBindSessionSuccessCb getBindSessionSuccess, SDKBind.GetBindSessionFaildCb getBindSessionFaild)
	{
	}

	public void OnGetBindSession(string msg)
	{
	}

	public void ResetGuest()
	{
	}

	public void OnMigrateGuestResult(string result)
	{
	}

	public void OnBackupGuestResult(string result)
	{
	}

	public void OnAutosaveGuestResult(string result)
	{
	}

	public void ClearSwapSession(Action callback)
	{
	}

	public void CompleteSwap(Action<LoginResp> callback)
	{
	}

	private void _OnSwapCompleted(LoginResp loginResp)
	{
	}

	public void OnGetOTP(string resp)
	{
	}

	public void OnVerifyOTP(string resp)
	{
	}

	public void OnBindOrUpdatePhoneNum(string resp)
	{
	}

	public void OnUnbindPhoneNum(string resp)
	{
	}

	public void OnRetrieveBoundPhoneNumInfo(string resp)
	{
	}

	public void OnGetBindInfo(string info)
	{
	}

	public void OnGetBindAccountOTP(string resp)
	{
	}

	public void OnVerifyBindAccountOTP(string resp)
	{
	}

	public void OnCreateBindRequest(string resp)
	{
	}

	public void OnCreateRebindRequest(string resp)
	{
	}

	public void OnCreateUnbindRequest(string resp)
	{
	}

	public void OnVerifyIdentityByOTP(string resp)
	{
	}

	public void OnVerifyIdentityByPassword(string resp)
	{
	}

	public void OnCancelRequest(string resp)
	{
	}

	public void OnGetSwapAccountOTP(string resp)
	{
	}

	public void OnVerifySwapByOTP(string resp)
	{
	}

	public void OnGetSwapSession(string resp)
	{
	}

	public void OnClearSwapSession(string resp)
	{
	}

	public void OnSwapCompleted(string resp)
	{
	}

	public bool SupportRegistrationForm()
	{
		return false;
	}

	public void ProtectWebViewForRegistrationForm(bool protect)
	{
	}

	public bool OpenRegistrationForm(string region, string locale, bool forceDisplay)
	{
		return false;
	}

	public void CloseRegistrationForm()
	{
	}

	public void GetUserVerificationInfo(string region)
	{
	}

	public bool SupportGoogleUserIdentification()
	{
		return false;
	}

	public bool SupportAppleUserIdentification()
	{
		return false;
	}

	public bool RequestGoogleUserIdentification(string region, Action<SdkUserIdentification.GoogleUserIdentificationInfo> callback)
	{
		return false;
	}

	public bool RequestAppleUserIdentification(string region, Action<SdkUserIdentification.AppleUserIdentificationInfo> callback, bool enableCustomAgeGate = false, int ageGateThreshold1 = -1, int ageGateThreshold2 = -1, int ageGateThreshold3 = -1)
	{
		return false;
	}

	public void SetAppleCustomAgeGates(int threshold1, int threshold2 = -1, int threshold3 = -1)
	{
	}

	public void GetPlatformBindingInfo(Action<SDKBind.PlatformBindingInfo> callback)
	{
	}

	public void OnGetPlatformBindingInfoComplete(string platformBindingInfo)
	{
	}

	public void GetPlatformBindingSession(AccountPlatform platform, Action<BindSessionResp> callback)
	{
	}

	public void OnGetPlatformBindingSession(string loginRsp)
	{
	}

	public void PerformPlatformBinding(Action<SDKBind.PerformPlatformBindingResult> callback)
	{
	}

	public void OnPerformPlatformBindingComplete(string result)
	{
	}

	public void SendGameToSessionException(string message)
	{
	}

	public void SendGameToSessionCallback(string pluginResult)
	{
	}

	public void SendMediaToSessionCallback(string pluginResult)
	{
	}

	public void SendLinkToSessionCallback(string pluginResult)
	{
	}

	public void ShareToFacebookException(string message)
	{
	}

	public void ShareToFacebookCallback(string pluginResult)
	{
	}

	public void SendLinkToFacebookCallback(string pluginResult)
	{
	}

	public void SendRequestInvitationToFacebookCallback(string pluginResult)
	{
	}

	public void SendGameRequestToFacebookUserCallback(string pluginResult)
	{
	}

	public void ShareToVkCallback(string pluginResult)
	{
	}

	public void ShareVideoToTikTokCallback(string pluginResult)
	{
	}

	public void onGetRebateOptions(string getRebateOptionsResult)
	{
	}

	public void onRedeemResultObtained(string redeemResult)
	{
	}

	public void onPaymentOptionsLoaded(string loadPaymentOptionsResult)
	{
	}

	public void onPaymentProcessed_Exception(string transactionInfo)
	{
	}

	public void onPaymentProcessed(string transactionInfo)
	{
	}

	public void onScanGoogleInAppPurchaseInventoryResult(string result)
	{
	}

	public void onObtainPendingTransactionsResult(string result)
	{
	}

	public void onLoadEventConfigsResult(string result)
	{
	}

	public void onEventPaymentOptionsLoaded(string result)
	{
	}

	public void onEventPaymentProcessed_Exception(string result)
	{
	}

	public void onEventPaymentProcessed(string result)
	{
	}

	private static void _DebugCallback<T>(string cb, string tString)
	{
	}

	private static bool TryParseGoogleAuthExtraMessage(string extraMessage, out GoogleAuthExtraMessage info)
	{
		info = null;
		return false;
	}

	public static void LogAuthExtraMessage(string source, AccountPlatform platform, string extraMessage)
	{
	}

	private static void LogAuthException(string source, BindSessionResp rsp)
	{
	}

	private static void LogAuthException(string source, LoginResp resp)
	{
	}

	private static void LogGoogleAuthExtraMessage(string source, string extraMessage)
	{
	}

	public bool ShouldLogoutForErrorCode(ErrorCode errorCode)
	{
		return false;
	}
}
