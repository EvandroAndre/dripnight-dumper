using System;

namespace GarenaMSDK;

public class SDKOTP
{
	[Serializable]
	public class MobileNumberBindInfo
	{
		public string Number;

		public long LastUpdateTime;
	}

	[Serializable]
	public class GetBindInfoResult
	{
		public int Result;

		public string Description;

		public string Mobile;

		public string MobileToBe;

		public string Email;

		public string EmailToBe;

		public long CoolDown;
	}

	public static class OTPRecipientType
	{
		public const int Mobile = 1;

		public const int Email = 2;

		public const int WhatsApp = 3;
	}

	[Serializable]
	public class SwapAccountByOTPResult
	{
		public int Result;

		public string Description;

		public string Token;

		public string OpenID;
	}

	public static class Android
	{
		[Serializable]
		public class BoundPhoneNumResp : BaseResp_Android
		{
			public string phoneNumber;

			public long lastUpdateTime;
		}

		[Serializable]
		public class SecurityVerifierBindInfo : BaseResp_Android
		{
			public string mobile;

			public string email;

			public string mobileToBe;

			public string emailToBe;

			public long remainingCoolDownTime;

			public bool isInCoolDown;
		}

		[Serializable]
		public class SwapTokenInfo : BaseResp_Android
		{
			public string token;

			public string openId;
		}

		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public BaseResp_Android response;

			internal void _003COnVerifyIdentityByOTP_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public BaseResp_Android response;

			internal void _003COnVerifyIdentityByPassword_003Eb__0()
			{
			}
		}

		private static Action<MSDKResult> _VerifyIdentityByOTPCallback;

		private static Action<MSDKResult> _VerifyIdentityByPasswordCallback;

		public static void SetDataDomeSDKKey(string sdkKey)
		{
		}

		public static void SetDataDomeActivateLogger(bool activateLogger)
		{
		}

		public static void GetOTP(string phoneNum, string countryCode)
		{
		}

		internal static void OnGetOTP(BaseResp_Android resp)
		{
		}

		public static void VerifyOTP(string phoneNum, string otpCode)
		{
		}

		internal static void OnVerifyOTP(BaseResp_Android resp)
		{
		}

		public static void BindOrUpdatePhoneNum(string phoneNum, string otpCode)
		{
		}

		internal static void OnBindOrUpdatePhoneNum(BaseResp_Android resp)
		{
		}

		public static void UnbindPhoneNum(string phoneNum, string otpCode)
		{
		}

		internal static void OnUnbindPhoneNum(BaseResp_Android resp)
		{
		}

		public static void RetrieveBoundPhoneNumInfo()
		{
		}

		internal static void OnRetrieveBoundPhoneNumInfo(BoundPhoneNumResp resp)
		{
		}

		internal static void GetBindInfo()
		{
		}

		internal static void OnGetBindInfo(SecurityVerifierBindInfo info)
		{
		}

		internal static void GetBindAccountOTP(string region, int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnGetBindAccountOTP(BaseResp_Android response)
		{
		}

		internal static void VerifyBindAccountOTP(string otp, int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnVerifyBindAccountOTP(BaseResp_Android response)
		{
		}

		internal static void CreateBindRequest(string second_password, int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnCreateBindRequest(BaseResp_Android response)
		{
		}

		internal static void CreateRebindRequest(int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnCreateRebindRequest(BaseResp_Android response)
		{
		}

		internal static void CreateUnbindRequest()
		{
		}

		internal static void OnCreateUnbindRequest(BaseResp_Android response)
		{
		}

		internal static void VerifyIdentityByOTP(string otp, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
		{
		}

		internal static void OnVerifyIdentityByOTP(BaseResp_Android response)
		{
		}

		internal static void VerifyIdentityByPassword(string password, Action<MSDKResult> callback)
		{
		}

		internal static void OnVerifyIdentityByPassword(BaseResp_Android response)
		{
		}

		internal static void CancelRequest()
		{
		}

		internal static void OnCancelRequest(BaseResp_Android response)
		{
		}

		internal static void GetSwapAccountOTP(string region, int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnGetSwapAccountOTP(BaseResp_Android response)
		{
		}

		internal static void VerifySwapByOTP(string otp, int otp_recipient_type, string otp_recipient)
		{
		}

		internal static void OnVerifySwapByOTP(SwapTokenInfo response)
		{
		}

		internal static void GetSwapSession(AccountPlatform accountPlatform)
		{
		}

		internal static void OnGetSwapSession(LoginResp loginResp)
		{
		}

		internal static void OnClearSwapSession()
		{
		}

		internal static LoginResp RestoreSwapSession()
		{
			return null;
		}

		internal static void ClearSwapSession()
		{
		}

		internal static void CompleteSwap()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__56_0;

		internal void _003COnClearSwapSession_003Eb__56_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public MSDKResult result;

		internal void _003COnBindMobilePhoneNumber_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public MSDKResult result;

		internal void _003COnUnbindMobilePhoneNumber_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public MSDKResult result;

		public MobileNumberBindInfo info;

		internal void _003COnGetMobileNumberBindInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public GetBindInfoResult result;

		internal void _003COnGetBindInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public MSDKResult result;

		internal void _003COnGetBindAccountOTP_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public MSDKResult result;

		internal void _003COnVerifyBindAccountOTP_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public MSDKResult result;

		internal void _003COnCreateBindRequest_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public MSDKResult result;

		internal void _003COnCreateRebindRequest_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public MSDKResult result;

		internal void _003COnCreateUnbindRequest_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public MSDKResult result;

		internal void _003COnCancelRequest_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public MSDKResult result;

		internal void _003COnGetSwapAccountOTP_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public SwapAccountByOTPResult result;

		internal void _003COnVerifySwapAccountOTP_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public LoginResp loginRsp;

		internal void _003COnGetSwapSession_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public MSDKResult result;

		internal void _003COnSendOTP_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public MSDKResult result;

		internal void _003COnVerifyOTP_003Eb__0()
		{
		}
	}

	private static Action<MSDKResult> _OnSendOTP;

	private static Action<MSDKResult> _OnVerifyOTP;

	private static Action<MSDKResult> _OnBindMobilePhoneNumber;

	private static Action<MSDKResult> _OnUnbindMobilePhoneNumber;

	private static Action<MSDKResult, MobileNumberBindInfo> _OnGetMobileNumberBindInfo;

	private static Action<GetBindInfoResult> _GetBindInfoCallback;

	private static Action<MSDKResult> _GetBindAccountOTPCallback;

	private static Action<MSDKResult> _VerifyBindAccountOTPCallback;

	private static Action<MSDKResult> _CreateBindRequestCallback;

	private static Action<MSDKResult> _CreateRebindRequestCallback;

	private static Action<MSDKResult> _CreateUnbindRequestCallback;

	private static Action<MSDKResult> _CancelRequestCallback;

	private static Action<MSDKResult> _GetSwapAccountOTPCallback;

	private static Action<SwapAccountByOTPResult> _VerifySwapAccountOTPCallback;

	private static Action<LoginResp> _GetSwapSessionCallback;

	private static Action _ClearSwapSessionCallback;

	public static bool SupportOTP => false;

	public static bool ResultOK(MSDKResult result)
	{
		return false;
	}

	public static void SendOTP(string phoneNo, string countryCode, Action<MSDKResult> callback)
	{
	}

	private static void OnSendOTP(MSDKResult result)
	{
	}

	public static void VerifyOTP(string phoneNo, string code, Action<MSDKResult> callback)
	{
	}

	private static void OnVerifyOTP(MSDKResult result)
	{
	}

	public static void BindMobilePhoneNumber(string phoneNo, string code, Action<MSDKResult> callback)
	{
	}

	private static void OnBindMobilePhoneNumber(MSDKResult result)
	{
	}

	public static void UnbindMobilePhoneNumber(string phoneNo, string code, Action<MSDKResult> callback)
	{
	}

	private static void OnUnbindMobilePhoneNumber(MSDKResult result)
	{
	}

	public static void GetMobileNumberBindInfo(Action<MSDKResult, MobileNumberBindInfo> callback)
	{
	}

	private static void OnGetMobileNumberBindInfo(MSDKResult result, MobileNumberBindInfo info)
	{
	}

	public static void GetBindInfo(Action<GetBindInfoResult> callback)
	{
	}

	private static void OnGetBindInfo(GetBindInfoResult result)
	{
	}

	public static void GetBindAccountOTP(string region, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	private static void OnGetBindAccountOTP(MSDKResult result)
	{
	}

	public static void VerifyBindAccountOTP(string otp, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	private static void OnVerifyBindAccountOTP(MSDKResult result)
	{
	}

	public static void CreateBindRequest(string second_password, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	private static void OnCreateBindRequest(MSDKResult result)
	{
	}

	public static void CreateRebindRequest(int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	private static void OnCreateRebindRequest(MSDKResult result)
	{
	}

	public static void CreateUnbindRequest(Action<MSDKResult> callback)
	{
	}

	private static void OnCreateUnbindRequest(MSDKResult result)
	{
	}

	public static void VerifyIdentityByOTP(string otp, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	public static void VerifyIdentityByPassword(string password, Action<MSDKResult> callback)
	{
	}

	public static void CancelRequest(Action<MSDKResult> callback)
	{
	}

	private static void OnCancelRequest(MSDKResult result)
	{
	}

	public static void GetSwapAccountOTP(string region, int otp_recipient_type, string otp_recipient, Action<MSDKResult> callback)
	{
	}

	private static void OnGetSwapAccountOTP(MSDKResult result)
	{
	}

	public static void VerifySwapAccountOTP(string otp, int otp_recipient_type, string otp_recipient, Action<SwapAccountByOTPResult> callback)
	{
	}

	private static void OnVerifySwapAccountOTP(SwapAccountByOTPResult result)
	{
	}

	public static void GetSwapSession(AccountPlatform accountPlatform, string appKey, Action<LoginResp> callback)
	{
	}

	private static void OnGetSwapSession(LoginResp loginRsp)
	{
	}

	public static void ClearSwapSession(Action callback)
	{
	}

	private static void OnClearSwapSession()
	{
	}

	public static LoginResp RestoreSwapSession()
	{
		return null;
	}

	internal static void CompleteSwap()
	{
	}
}
