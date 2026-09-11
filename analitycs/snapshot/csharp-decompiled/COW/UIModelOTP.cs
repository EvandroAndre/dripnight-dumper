using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;

namespace COW;

public class UIModelOTP : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__172_1;

		internal void _003CRequestSwapBindingOpenID_003Eb__172_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public UIModelOTP _003C_003E4__this;

		public AccountPlatform platform;

		public LoginResp resp;

		internal void _003CRequestSwapBindingOpenID_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public UIModelOTP _003C_003E4__this;

		public bool isFromBanAccount;

		public ulong accountId;

		public string region;

		internal void _003CRequestCancelRequest_003Eb__0(MSDKResult res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public UIModelOTP _003C_003E4__this;

		public AccountPlatform platform;

		internal void _003CRequestSwapNewAccount_003Eb__0(LoginResp resp)
		{
		}
	}

	private OTPBindInfo m_OTPBindInfo;

	private OTPProcess m_Process;

	private OTPSupportVerifyAccess m_OTPSupportVerifyAccess;

	private OTPSupportVerifyAccess m_OTPRecommendVerifyAccess;

	private OTPPhoneVerifyAccess m_OTPSupportPhoneVerifyAccess;

	private AccountSecurityData m_AccountSecurity;

	private AccountBindPhoneData m_BindPhone;

	private AccountBindEmailData m_BindEmail;

	private AccountSecurityIPData m_AccountSecurityIP;

	private OTPSwapOldInfo m_SwapOldInfo;

	private CSVAsyncDataMap<uint, AccountSecurityData> m_AccountSecurityDatas;

	private CSVAsyncDataMap<uint, AccountBindPhoneData> m_AccountBindPhoneDatas;

	private CSVAsyncDataMap<uint, AccountBindEmailData> m_AccountBindEmailDatas;

	private CSVAsyncDataMap<uint, MailBindBlacklistData> m_MailBindBlacklistDatas;

	private CSVAsyncDataMap<uint, AccountSecurityIPData> m_AccountSecurityIPDatas;

	public const uint PropID_GetBindInfo = 1u;

	public const uint PropID_SendOTPPhone = 2u;

	public const uint PropID_SendOTPEmail = 4u;

	public const uint PropID_VerifyOTPPhone = 8u;

	public const uint PropID_VerifyOTPEmail = 16u;

	public const uint PropID_VerifyIdentity = 32u;

	public const uint PropID_CreateBind = 64u;

	public const uint PropID_CreateRebind = 128u;

	public const uint PropID_CreateUnbind = 256u;

	public const uint PropID_CancelRequest = 512u;

	public const uint PropID_CreateSwap = 1024u;

	public const uint PropID_GetAccountIDByOpenID = 2048u;

	public const uint PropID_GetAccountBriefInfoBeforeLogin = 4096u;

	public const uint PropID_SwapBindingOpenID = 16384u;

	public const uint PropID_VerifyIdentityByOTP = 8192u;

	public const uint PropID_VerifyOTPFailed = 32768u;

	public const uint PropID_VerifyPasswordUnmatched = 65536u;

	private UIModelUser m_ModelUser;

	private const string TODAY_SEND_PHONE_OTP_TIMES = "TodaySendPhoneOTPTimes";

	private const string TODAY_SEND_EMAIL_OTP_TIMES = "TodaySendEmailOTPTimes";

	private const string TODAY_VERIFY_PHONE_OTP_TIMES = "TodayVerifyPhoneOTPTimes";

	private const string TODAY_VERIFY_EMAIL_OTP_TIMES = "TodayVerifyEmailOTPTimes";

	private bool m_HasShowLoginExceptionRemind;

	private bool m_HasShowAndCloseOTPRemindTipsInLobby;

	private bool m_IsOTPSwapReady;

	private bool m_HasRequestBindInfo;

	private bool m_RecommendBindOTP;

	private bool m_HasLoadAccountSecurityAfterLogin;

	private bool m_HasLoadAccountSecurityBeforeLogin;

	private bool m_HasLoadAccountBindPhoneAfterLogin;

	private bool m_HasLoadAccountBindEmailAfterLogin;

	private bool m_HasLoadAccountBindEmailBeforeLogin;

	private AccountSecurityData AccountSecurity => null;

	private AccountBindPhoneData BindPhone => null;

	private AccountBindEmailData BindEmail => null;

	public bool HasShowLoginExceptionRemind => false;

	public bool HasShowAndCloseOTPRemindTipsInLobby
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOTPSwapReady => false;

	public bool HasRequestBindInfo => false;

	public bool RecommendBindOTP
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

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestOTPBindInfo()
	{
	}

	private void SetOTPBindInfo(AccountSecurityState state, OTPVerifyAccess access, SDKOTP.GetBindInfoResult res)
	{
	}

	public void SetBindInfoState(AccountSecurityState state)
	{
	}

	public OTPBindInfo GetOTPBindInfo()
	{
		return null;
	}

	public ulong GetOTPBindCoolStamp()
	{
		return 0uL;
	}

	public AccountSecurityState GetCurrentAccountSecurityState()
	{
		return AccountSecurityState.None;
	}

	public AccountSecurityLevel GetCurrentAccountSecurityLevel()
	{
		return AccountSecurityLevel.None;
	}

	public void StartOTPProcess(OTPOperationType operation)
	{
	}

	public void StartOTPProcess(OTPOperationType operation, OTPSupportVerifyAccess supportAccess = OTPSupportVerifyAccess.PhoneAndEmail, OTPVerifyAccess otpVerifyAccess = OTPVerifyAccess.None)
	{
	}

	public void GoOTPNextState()
	{
	}

	public void BackOTPState()
	{
	}

	public void ExitOTPProcess()
	{
	}

	public void FinishOTPProcess()
	{
	}

	private void InitGarenaMSDK()
	{
	}

	public void RequestSendOTPByPhoneNumber()
	{
	}

	public void RequestSendOTPByEmail()
	{
	}

	public void RequestVerifyOTPPhone()
	{
	}

	public void RequestVerifyOTPEmail()
	{
	}

	public void RequestVerifyIdentity()
	{
	}

	public void RequestVerifyIdentityByOTPPhone()
	{
	}

	public void RequestVerifyIdentityByOTPEmail()
	{
	}

	public void RequestCreateBind()
	{
	}

	public void RequestCancelRequest(bool isFromBanAccount = false, string region = "", ulong accountId = 0uL)
	{
	}

	public void RequestCreateReBind()
	{
	}

	public void RequestCreateUnbind()
	{
	}

	public void RequestSwapNewAccount(AccountPlatform platform)
	{
	}

	public string GetBindingPhoneOrEmail()
	{
		return null;
	}

	public string GetBindingOriPhoneOrEmail()
	{
		return null;
	}

	public void RequestCoolDown(AccountSecurityState type)
	{
	}

	public void ChangeHasShowLoginExceptionRemind()
	{
	}

	public bool IsNeedOTPBindRemind()
	{
		return false;
	}

	public uint GetOTPLevel()
	{
		return 0u;
	}

	public string GetOTPSecurityLevelExplanationCDN()
	{
		return null;
	}

	public string GetOTPAccountRetrievalIntroductionCDN()
	{
		return null;
	}

	public int GetOTPCoolingDownDays()
	{
		return 0;
	}

	public int GetOTPRebindCoolingDownDays()
	{
		return 0;
	}

	public bool GetOTPReminder()
	{
		return false;
	}

	public bool CheckOTPOpen()
	{
		return false;
	}

	public bool CheckOTPOpenWithOutLevel()
	{
		return false;
	}

	public OTPProcess GetCurrentOTPProcess()
	{
		return null;
	}

	public void ClearCurrentOTPProcess()
	{
	}

	public OTPVerifyInfo GetOTPProcessVerifyInfo()
	{
		return null;
	}

	public OTPPhoneVerifyInfo GetOTPPhoneVerifyInfo()
	{
		return null;
	}

	public void InitPhoneVerifyInfo()
	{
	}

	public OTPEmailVerifyInfo GetOTPEmailVerifyInfo()
	{
		return null;
	}

	public void InitEmailVerifyInfo()
	{
	}

	public int GetOTPTodaySendCodeTimes()
	{
		return 0;
	}

	public int GetOTPTodaySendCodeTimesLimit()
	{
		return 0;
	}

	public bool CheckOTPTodaySendCodeReachLimit()
	{
		return false;
	}

	public int GetOTPTodayVerifyCodeTimes()
	{
		return 0;
	}

	public int GetOTPTodayVerifyCodeTimesLimit()
	{
		return 0;
	}

	public bool CheckOTPTodayVerifyCodeReachLimit()
	{
		return false;
	}

	public bool CheckPhoneNumberLengthValid(string phoneNumber)
	{
		return false;
	}

	public int GetOTPPhoneVerifyCodeLength()
	{
		return 0;
	}

	public int GetOTPEmailVerifyCodeLength()
	{
		return 0;
	}

	public int GetOTPPasswordCodeLength()
	{
		return 0;
	}

	public ulong GetOTPVerifySendCodeCD()
	{
		return 0uL;
	}

	public int GetPhoneNumberInputLimit()
	{
		return 0;
	}

	public int GetEmailInputLimit()
	{
		return 0;
	}

	public string GetOTPAreaCode()
	{
		return null;
	}

	public string GetOTPAreaCodeWithPlus()
	{
		return null;
	}

	public List<string> GetAreaCodeList()
	{
		return null;
	}

	public OTPSupportVerifyAccess GetOTPRecommendAccess()
	{
		return OTPSupportVerifyAccess.None;
	}

	public OTPPhoneVerifyAccess GetOTPPhoneRecommendAccess()
	{
		return OTPPhoneVerifyAccess.None;
	}

	public bool CheckWhatsAppFirst()
	{
		return false;
	}

	public string GetProtectedPhoneNumber(string phoneNumber)
	{
		return null;
	}

	public string GetProtectedEmail(string email)
	{
		return null;
	}

	public ulong GetNextCanSendOTPTimeStamp()
	{
		return 0uL;
	}

	public void SetNextCanSendPhoneTimeStamp(ulong time)
	{
	}

	public bool NeedShowChooseVerifyAccess()
	{
		return false;
	}

	public bool NeedShowChoosePhoneVerifyAccess()
	{
		return false;
	}

	public bool CheckInputEmailValid(string email)
	{
		return false;
	}

	private bool IsMailBindBlacklisted(string email)
	{
		return false;
	}

	private bool IsGmailAddress(string email)
	{
		return false;
	}

	public bool CheckEmailEqualsBindingEmail(string email)
	{
		return false;
	}

	private string RemoveDotsBeforeAt(string email)
	{
		return null;
	}

	public void ResetSwapReady()
	{
	}

	public string GetSwapOldOpenId()
	{
		return null;
	}

	public OTPVerifyAccess GetSwapRecoveryType()
	{
		return OTPVerifyAccess.None;
	}

	public void SetSwapAccountId(ulong id)
	{
	}

	public string GetPrivacyPolicyText()
	{
		return null;
	}

	public void LoadTodaySendOTPTimes(OTPVerifyAccess access)
	{
	}

	public void AddSendOTPTimes()
	{
	}

	public void LoadTodayVerifyOTPTimes(OTPVerifyAccess access)
	{
	}

	public void AddVerifyOTPTimes()
	{
	}

	private void GoOTPBindProcess()
	{
	}

	private void GoOTPRebindProcess()
	{
	}

	private void GoOTPUnbindProcess()
	{
	}

	private void GetOTPSwapProcess()
	{
	}

	private void GetOTPCoolDownCancelProcess()
	{
	}

	private void LoadOTPData()
	{
	}

	private bool IsDefault(string input)
	{
		return false;
	}

	private int GetOTPProcessRecipientType()
	{
		return 0;
	}

	private string GetOTPProcessRecipient()
	{
		return null;
	}

	private void ProcessOTPErrorCode(ErrorCode errorCode)
	{
	}

	private string CdnChangeLoclizationLanguage(string cdnUrl)
	{
		return null;
	}

	private void LoadAccountSecurity()
	{
	}

	private void LoadBindPhone()
	{
	}

	private void LoadBindEmail()
	{
	}

	private void LoadAccountSecurityIP()
	{
	}

	private void LoadAccountSecurityIPHotFix()
	{
	}

	public void RequestAccountIDByOpenID()
	{
	}

	public void RequestAccountBriefInfoBeforeLogin()
	{
	}

	public void RequestSwapBindingOpenID(LoginResp resp, AccountPlatform platform)
	{
	}

	private void _003CRequestOTPBindInfo_003Eb__64_0(SDKOTP.GetBindInfoResult res)
	{
	}

	private void _003CRequestSendOTPByPhoneNumber_003Eb__78_0(MSDKResult res)
	{
	}

	private void _003CRequestSendOTPByPhoneNumber_003Eb__78_1(MSDKResult res)
	{
	}

	private void _003CRequestSendOTPByEmail_003Eb__79_0(MSDKResult res)
	{
	}

	private void _003CRequestSendOTPByEmail_003Eb__79_1(MSDKResult res)
	{
	}

	private void _003CRequestVerifyOTPPhone_003Eb__80_0(SDKOTP.SwapAccountByOTPResult res)
	{
	}

	private void _003CRequestVerifyOTPPhone_003Eb__80_1(MSDKResult res)
	{
	}

	private void _003CRequestVerifyOTPEmail_003Eb__81_0(SDKOTP.SwapAccountByOTPResult res)
	{
	}

	private void _003CRequestVerifyOTPEmail_003Eb__81_1(MSDKResult res)
	{
	}

	private void _003CRequestVerifyIdentity_003Eb__82_0(MSDKResult res)
	{
	}

	private void _003CRequestVerifyIdentityByOTPPhone_003Eb__83_0(MSDKResult res)
	{
	}

	private void _003CRequestVerifyIdentityByOTPEmail_003Eb__84_0(MSDKResult res)
	{
	}

	private void _003CRequestCreateBind_003Eb__85_0(MSDKResult res)
	{
	}

	private void _003CRequestCreateReBind_003Eb__87_0(MSDKResult res)
	{
	}

	private void _003CRequestCreateUnbind_003Eb__88_0(MSDKResult res)
	{
	}

	private void _003CRequestAccountIDByOpenID_003Eb__170_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestAccountBriefInfoBeforeLogin_003Eb__171_0(HttpErrorCode errorCode, object obj)
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
