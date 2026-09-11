using System;

namespace GarenaMSDK;

public class SDKLogin
{
	public delegate void LoginCallback(LoginResp resp);

	public class SAFGuestResult
	{
		public int result;

		public string msg;
	}

	public delegate void SAFGuestCb(SAFGuestResult result);

	private LoginCallback _OnLoginSuccess;

	private LoginCallback _OnLoginFailure;

	private SAFGuestCb migrateGuestCb;

	private SAFGuestCb backupGuestCb;

	private SAFGuestCb autosaveGuestCb;

	public const int SAF_SUCCESS = 0;

	public const int SAF_FAILURE = 1;

	public const int SAF_REFUSED = 2;

	public const int SAF_EXCEPTION = 3;

	private Action<string> _GetAuthStatusInPGSCallback;

	private Action<string> _SignInPGSCallback;

	private Action<GetCurrentPGSPlayerIdResult> _GetCurrentPGSPlayerIdCallback;

	private Action<string> _WriteSessionToPGSCallback;

	private Action<LoginResp> _ReadSessionFromPGSSuccessCallback;

	private Action<string> _ReadSessionFromPGSFailureCallback;

	private Action<RequestAuthCodePGSResult> _RequestAuthCodePGSCallback;

	private static LoginResp CreateFailedLoginResp(string exceptionMessage, string exceptionStackTrace)
	{
		return null;
	}

	private void FailLoginWithParseError(string message, string stackTrace)
	{
	}

	public AccountPlatform GetLoginRecord()
	{
		return AccountPlatform.None;
	}

	public bool NeedGuestMigration()
	{
		return false;
	}

	public bool SupportGuestMigration()
	{
		return false;
	}

	public void MigrateGuest(SAFGuestCb onMigrate)
	{
	}

	public bool NeedGuestBackup()
	{
		return false;
	}

	public bool SupportGuestBackup()
	{
		return false;
	}

	public void BackupGuest(SAFGuestCb onBackup)
	{
	}

	public void AutosaveGuest(SAFGuestCb onAutosave)
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

	public bool PlatformAvailable(AccountPlatform platform)
	{
		return false;
	}

	public void Login(AccountPlatform accountPlatform, bool autoLogin, LoginCallback loginSuccess, LoginCallback loginFailure)
	{
	}

	public void Logout()
	{
	}

	public void OnLogin_Android(string msg)
	{
	}

	public bool SupportPGSRecall()
	{
		return false;
	}

	public void GetAuthStatusInPGS(Action<string> callback)
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

	public void OnRecvAuthStatusInPGS(string data)
	{
	}

	public void OnSignedInPGS(string data)
	{
	}

	public void OnGetCurrentPGSPlayerId(GetCurrentPGSPlayerIdResult result)
	{
	}

	public void OnWriteSessionToPGS(string data)
	{
	}

	public void OnReadSessionFromPGS(string data)
	{
	}

	public void RequestAuthCodePGS(string serverOAuthClientId, bool forceRefreshToken, Action<RequestAuthCodePGSResult> callback)
	{
	}

	public void OnRequestAuthCodePGS(RequestAuthCodePGSResult result)
	{
	}
}
