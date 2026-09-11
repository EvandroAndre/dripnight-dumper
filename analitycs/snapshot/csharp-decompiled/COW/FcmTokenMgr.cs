using System;

namespace COW;

internal class FcmTokenMgr
{
	public enum TokenOperation
	{
		None,
		Inspect,
		ForceUpdate
	}

	private static FcmTokenMgr _I;

	private const string PLAYER_PREFS_KEY_FCM_TOKEN = "FcmToken";

	private const string PLAYER_PREFS_KEY_TOKEN_INSPECTION_TIMESTAMP = "RNM_FCM_TOKEN_INSPECTION_TIMESTAMP";

	private Action<string, bool> _OnTokenReceived;

	public static FcmTokenMgr I => null;

	public string CachedToken
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private ulong LastTokenInpectionTimeStamp
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	private FcmTokenMgr()
	{
	}

	private void ShowDebugTips(string tips)
	{
	}

	public void EnsureToken(Action<TokenOperation> before, Action<TokenOperation> after, Action<string, bool> onTokenReceived)
	{
	}

	private void OnTokenReceived(string token)
	{
	}
}
