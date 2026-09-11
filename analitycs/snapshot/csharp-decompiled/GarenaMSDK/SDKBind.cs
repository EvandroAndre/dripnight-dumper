using System;

namespace GarenaMSDK;

public class SDKBind
{
	public delegate void GetBindSessionSuccessCb(BindSessionResp rsp);

	public delegate void GetBindSessionFaildCb(BindSessionResp rsp);

	public delegate void ClearThirdPartySessionCb();

	[Serializable]
	public class PlatformBindingInfo
	{
		[Serializable]
		public class PlatformAccount
		{
			public AccountPlatform Platform;

			public ulong UID;

			public uint CreateTime;

			public string Nickname;

			public int Gender;

			public const int GENDER_UNKNOWN = 0;

			public const int GENDER_MALE = 1;

			public const int GENDER_FEMAILE = 2;

			public string IconUrl;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<PlatformBindingInfo_Android.BoundAccountInfo, PlatformAccount> _003C_003E9__4_0;

			internal PlatformAccount _003C_002Ector_003Eb__4_0(PlatformBindingInfo_Android.BoundAccountInfo account)
			{
				return null;
			}
		}

		public int[] AvailablePlatforms;

		public PlatformAccount[] PlatformAccounts;

		private static AccountPlatform _(int p)
		{
			return AccountPlatform.None;
		}

		public PlatformBindingInfo(PlatformBindingInfo_Android android)
		{
		}
	}

	[Serializable]
	public class PlatformBindingInfo_Android
	{
		[Serializable]
		public class BoundAccountInfo
		{
			[Serializable]
			public class UserInfo
			{
				public string nickname;

				public int gender;

				public string icon;
			}

			public int platform;

			public ulong uid;

			public uint create_time;

			public UserInfo user_info;
		}

		public string error;

		public int[] available_platforms;

		public BoundAccountInfo[] bounded_accounts;
	}

	[Serializable]
	public class PerformPlatformBindingResult
	{
		public int result;

		public string error;
	}

	protected GetBindSessionSuccessCb getBindSessionSuccessCb;

	protected GetBindSessionFaildCb getBindSessionFaildCb;

	protected ClearThirdPartySessionCb clearThirdPartySessionCb;

	public string bindOpenId;

	public string bindAccessToken;

	public AccountPlatform bindPlatform;

	private Action<PlatformBindingInfo> _OnGetPlatformBindingInfo;

	private Action<BindSessionResp> _OnGetPlatformBindingSessionResult;

	private Action<PerformPlatformBindingResult> _OnPerformPlatformBindingComplete;

	private static BindSessionResp CreateFailedBindSessionResp(ErrorCode errCode, string exception)
	{
		return null;
	}

	private void FailGetBindSession(ErrorCode errCode, string exception)
	{
	}

	public void GetBindSession(AccountPlatform accountType, GetBindSessionSuccessCb getBindSessionSuccessCb, GetBindSessionFaildCb getBindSessionFaildCb)
	{
	}

	public void ResetGuest()
	{
	}

	public void OnGetBindSession(string msg)
	{
	}

	public bool CanClearThirdPartySession()
	{
		return false;
	}

	public void ClearThirdPartySession(ClearThirdPartySessionCb cb)
	{
	}

	public void OnClearThirdPartySession()
	{
	}

	public void GetPlatformBindingInfo(Action<PlatformBindingInfo> callback)
	{
	}

	public void GetPlatformBindingSession(AccountPlatform platform, Action<BindSessionResp> callback)
	{
	}

	public void OnGetPlatformBindingSession(string result)
	{
	}

	public void OnGetPlatformBindingInfoComplete_Android(string result)
	{
	}

	public void PerformPlatformBinding(Action<PerformPlatformBindingResult> callback)
	{
	}

	public void OnPerformPlatformBindingComplete_Android(string result)
	{
	}
}
