using System;
using System.Collections.Generic;
using GCommon;

namespace COW.RemoteNotifications;

public class RemoteNotificationManager_Firebase : RemoteNotificationManager
{
	private enum UserProperty
	{
		Environment,
		Region,
		Language,
		LastActiveServerTime,
		PlayerLevel,
		IsPaid,
		ElitePassBadgeNumber,
		ClanID,
		InClan,
		TimeZoneOffsetHours,
		TimeZoneStandardName,
		GamesPlayed_RankedMatch,
		Variant,
		Store,
		ReleaseVersion
	}

	private class UserPropertyInfo
	{
		public string Key;

		public Func<string> Value;
	}

	private class RecvedNtfObserver : FirebaseManager.Messaging.FirebaseMessagingDelegate.IRecvedNtfsObserver
	{
		public void OnRecvedNtfs(PlatformUtility.DeliveredNotification[] notifications)
		{
		}
	}

	private enum UserPropertyTopic
	{
		Basic_EnvReg,
		Basic_VarEnvReg,
		Basic_EnvRegLang,
		Basic,
		IsPaid,
		InClan,
		Store,
		ReleaseVersion
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string> _003C_003E9__3_0;

		public static Func<string> _003C_003E9__3_1;

		public static Func<string> _003C_003E9__3_2;

		public static Func<string> _003C_003E9__3_3;

		public static Func<string> _003C_003E9__3_4;

		public static Func<string> _003C_003E9__3_5;

		public static Func<string> _003C_003E9__3_6;

		public static Func<string> _003C_003E9__3_7;

		public static Func<string> _003C_003E9__3_8;

		public static Func<string> _003C_003E9__3_9;

		public static Func<string> _003C_003E9__3_10;

		public static Func<string> _003C_003E9__3_11;

		public static Func<string> _003C_003E9__3_12;

		public static Func<string> _003C_003E9__3_13;

		public static Func<string> _003C_003E9__3_14;

		internal string _003C_002Ector_003Eb__3_0()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_1()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_2()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_3()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_4()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_5()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_6()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_7()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_8()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_9()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_10()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_11()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_12()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_13()
		{
			return null;
		}

		internal string _003C_002Ector_003Eb__3_14()
		{
			return null;
		}
	}

	public static readonly string FIREBASE_MESSAGING_NOTIFICATION_CHANNEL_ID;

	private const string PLAYER_PREFS_KEY_USER_PROPERTIES_TEMPLATE = "RNM_FIREBASE_USER_PROPERTIES_{0}";

	private const string PLAYER_PREFS_KEY_USER_ID = "RNM_FIREBASE_USER_ID";

	private const string FIREBASE_USER_PROPERTY_NAME_TEMPLATE = "ff_{0}";

	private readonly Dictionary<int, UserPropertyInfo> USER_PROPERTIES;

	private string _PendingUserId;

	private Dictionary<int, string> _PendingUserProperties;

	private RecvedNtfObserver _RecvedNtfObserver;

	private const string PLAYER_PREFS_KEY_USER_PROPERTY_TOPIC_TEMPLATE = "RNM_FIREBASE_USER_PROPERTY_TOPIC_{0}";

	private const string FIREBASE_USER_PROPERTY_TOPIC_TEMPLATE = "ff1_{0}";

	private static readonly Dictionary<int, int[]> USER_PROPERTY_TOPICS;

	private static readonly Dictionary<int, string> USER_PROPERTY_TOPIC_TEMPLATES;

	public override string Token => null;

	private static bool DisableCacheForFirebaseAnalytics => false;

	private static bool DisableCacheForFirebaseMessaging => false;

	private static bool UseAnalyticsUserProperties => false;

	private static bool UseMessagingTopics => false;

	internal RemoteNotificationManager_Firebase()
	{
	}

	private void ShowDebugTips(string tips)
	{
	}

	private void _OnInited()
	{
	}

	private string FormatFirebaseUserPropertyName(string key)
	{
		return null;
	}

	private string FormatUserPropertyPlayerPrefsKey(string key)
	{
		return null;
	}

	private void LogUserInfo(string method)
	{
	}

	private void UpdateUserInfo(bool force = false)
	{
	}

	private void _UpdateUserId(string userId)
	{
	}

	private void UpdateUserId(bool force = false)
	{
	}

	private void ClearUserId()
	{
	}

	private void _UpdateUserProperty(UserProperty userProperty, string value)
	{
	}

	private void UpdateUserProperty(UserProperty userProperty, bool force = false)
	{
	}

	private void ClearUserProperty(UserProperty userProperty)
	{
	}

	public override void AfterLoginSDK()
	{
	}

	public override void BeforeLoginServer()
	{
	}

	public override void CheckAndLogRecvedNtfs(bool shouldClearNtfs, out bool willClearNtfs)
	{
		willClearNtfs = default(bool);
	}

	public override void AfterLoginServer()
	{
	}

	private void EnsureToken()
	{
	}

	private void BeforeTokenOperation(FcmTokenMgr.TokenOperation tokenOp)
	{
	}

	private void AfterTokenOperation(FcmTokenMgr.TokenOperation tokenOp)
	{
	}

	private void OnTokenReceived(string token, bool changed)
	{
	}

	public override void BeforeLogoutServer()
	{
	}

	public override void AfterLogoutServer()
	{
	}

	public override void AfterLogoutSDK()
	{
	}

	public override void AfterChangeLanguage()
	{
	}

	public override void AfterChangeClanID()
	{
	}

	public override void AfterChangeElitePassBadgeNumber()
	{
	}

	public override void AfterChangeFirstTimePaid()
	{
	}

	public override void AfterChangePlayerLevel()
	{
	}

	public override void BeforeChangeGamesPlayedInRankedMatch()
	{
	}

	public override void AfterChangeGamesPlayedInRankedMatch()
	{
	}

	public override void OnEnterGame()
	{
	}

	public override void OnLeaveGame()
	{
	}

	private string FormatTopicPlayerPrefsKey(UserPropertyTopic topic)
	{
		return null;
	}

	private string UserPropertyTopicValue(UserPropertyTopic topic)
	{
		return null;
	}

	private bool PerhapsClearTopicCache()
	{
		return false;
	}

	private bool PerhapsResubscribeUserPropertyTopics()
	{
		return false;
	}

	private void UpdateUserPropertyTopic(UserPropertyTopic topic)
	{
	}

	private void _003C_OnInited_003Eb__5_0()
	{
	}

	private void _003C_OnInited_003Eb__5_1()
	{
	}

	private string _003CUserPropertyTopicValue_003Eb__60_0(int p)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_get_Token()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_AfterLoginSDK()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeLoginServer()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckAndLogRecvedNtfs(bool P0, out bool P1)
	{
		P1 = default(bool);
	}

	public void _003C_003EiFixBaseProxy_AfterLoginServer()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeLogoutServer()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterLogoutServer()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterLogoutSDK()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangeLanguage()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangeClanID()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangeElitePassBadgeNumber()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangeFirstTimePaid()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangePlayerLevel()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeChangeGamesPlayedInRankedMatch()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterChangeGamesPlayedInRankedMatch()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnterGame()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLeaveGame()
	{
	}
}
