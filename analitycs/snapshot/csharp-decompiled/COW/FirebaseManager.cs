using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase;
using Firebase.Analytics;
using Firebase.Messaging;
using GCommon;
using InterApp;

namespace COW;

public static class FirebaseManager
{
	public static class Crashlytics
	{
		private static bool _003CCrashlyticsInited_003Ek__BackingField;

		private static string _PendingUserId;

		private static Dictionary<string, string> _PendingKeyValues;

		private static Queue<object> _PendingStuffs;

		public static bool UseCrashlytics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool CrashlyticsInited
		{
			get
			{
				return _003CCrashlyticsInited_003Ek__BackingField;
			}
			private set
			{
				_003CCrashlyticsInited_003Ek__BackingField = value;
			}
		}

		internal static void Init()
		{
		}

		internal static void Shutdown()
		{
		}

		public static void SetUserId(string userId)
		{
		}

		public static void SetKeyValue(string key, string value)
		{
		}

		public static void Log(string msg)
		{
		}

		public static void Report(Exception exception)
		{
		}
	}

	public static class Analytics
	{
		public static class Consent
		{
			public const int AdStorage = 0;

			public const int AnalyticsStorage = 1;

			public const int AdUserData = 2;

			public const int AdPersonalization = 3;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<KeyValuePair<string, string>, Parameter> _003C_003E9__13_0;

			internal Parameter _003CLogEvent_003Eb__13_0(KeyValuePair<string, string> pair)
			{
				return null;
			}
		}

		private static bool _003CAnalyticsInited_003Ek__BackingField;

		public static bool UseAnalytics => false;

		public static bool AnalyticsInited
		{
			get
			{
				return _003CAnalyticsInited_003Ek__BackingField;
			}
			private set
			{
				_003CAnalyticsInited_003Ek__BackingField = value;
			}
		}

		public static void Init()
		{
		}

		public static void SetConsentForDefaultUser()
		{
		}

		public static void SetConsent(Dictionary<int, bool> consents)
		{
		}

		internal static void Shutdown()
		{
		}

		public static void SetUserId(string userId)
		{
		}

		public static void SetUserProperty(string key, string value)
		{
		}

		public static void LogEvent(string eventName, Dictionary<string, string> parameters = null)
		{
		}
	}

	public static class Messaging
	{
		private enum UpdateTokenStatus
		{
			None,
			Deleting,
			Getting
		}

		public class FirebaseMessagingDelegate : OpenedWithParamsDelegate
		{
			private class RecvedNtfDelImpl
			{
				private class RecvedNtfDelImpl_Android : RecvedNtfDelImpl
				{
					[Serializable]
					private sealed class _003C_003Ec
					{
						public static readonly _003C_003Ec _003C_003E9;

						public static Converter<PlatformUtility.DeliveredNotification, string> _003C_003E9__4_0;

						internal string _003CAfterNotifyRecvedNtfs_003Eb__4_0(PlatformUtility.DeliveredNotification ntf)
						{
							return null;
						}
					}

					public override string MSG_ID_KEY => null;

					public override void ShouldObserveRecvedNtfs(bool cache)
					{
					}

					public override void AfterNotifyRecvedNtfs(PlatformUtility.DeliveredNotification[] notifications)
					{
					}

					public string _003C_003EiFixBaseProxy_get_MSG_ID_KEY()
					{
						return null;
					}

					public void _003C_003EiFixBaseProxy_ShouldObserveRecvedNtfs(bool P0)
					{
					}

					public void _003C_003EiFixBaseProxy_AfterNotifyRecvedNtfs(PlatformUtility.DeliveredNotification[] P0)
					{
					}
				}

				private static RecvedNtfDelImpl _I;

				public static RecvedNtfDelImpl I => null;

				public virtual string MSG_ID_KEY => null;

				protected RecvedNtfDelImpl()
				{
				}

				public virtual void ShouldObserveRecvedNtfs(bool cache)
				{
				}

				public virtual PlatformUtility.DeliveredNotification[] WillNotifyRecvedNtfs(PlatformUtility.DeliveredNotification[] notifications)
				{
					return null;
				}

				public virtual void AfterNotifyRecvedNtfs(PlatformUtility.DeliveredNotification[] notifications)
				{
				}

				public virtual void OnMsgRecved(Dictionary<string, string> msg)
				{
				}
			}

			public interface IRecvedNtfsObserver
			{
				void OnRecvedNtfs(PlatformUtility.DeliveredNotification[] notifications);
			}

			private sealed class _003C_003Ec__DisplayClass16_0
			{
				public bool shouldClearNtfsAfterwards;

				internal void _003CUpdateRecvedNtfs_003Eb__0(PlatformUtility.DeliveredNotification[] notifications)
				{
				}
			}

			public const string DEEP_LINK_URL_KEY = "freefire.deeplink.url";

			public const string WEB_VIEW_URL_KEY = "freefire.webview.url";

			public const string WEB_VIEW_STYLE_KEY = "freefire.webview.style";

			public const string BROWSER_URL_KEY = "freefire.browser.url";

			public const string ENV_NAME_KEY = "freefire.env_name";

			public const string TASK_ID_KEY = "freefire.task_id";

			public const string PUSH_TYPE_KEY = "freefire.push_type";

			private static List<IRecvedNtfsObserver> _RecvedNtfsObservers;

			private static bool _ShouldObserveRecvedNtfs;

			private static Queue<Dictionary<string, string>> _ImplicitMessages;

			private static Queue<Dictionary<string, string>> _ExplicitMessages;

			private static Dictionary<string, bool> _MsgId_Processed;

			public static string GetMsgId(Dictionary<string, string> data)
			{
				return null;
			}

			public static bool TryGetTaskInfo(Dictionary<string, string> data, out string env_name, out string task_id)
			{
				env_name = null;
				task_id = null;
				return false;
			}

			public static bool TryGetPushType(Dictionary<string, string> data, out string pushType)
			{
				pushType = null;
				return false;
			}

			public static void RegisterNtfRecvedObserver(IRecvedNtfsObserver observer)
			{
			}

			public static void ShouldObserveRecvedNtfs(bool observe)
			{
			}

			public static void UpdateRecvedNtfs(bool shouldClearNtfsAfterwards)
			{
			}

			public static void OnMessageReceived(bool isExplicit, string msgId, IDictionary<string, string> parameters)
			{
			}

			public override PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
			{
				return null;
			}

			public override bool CanProcess(Dictionary<string, string> parameters)
			{
				return false;
			}

			public override OpenedWithParams Process(Dictionary<string, string> parameters)
			{
				return null;
			}

			public override void Processed(OpenedWithParams openedWithParams)
			{
			}

			public PlatformUtility.OpenedWith _003C_003EiFixBaseProxy_OverrideOpenedWith(PlatformUtility.OpenedWith P0)
			{
				return null;
			}

			public bool _003C_003EiFixBaseProxy_CanProcess(Dictionary<string, string> P0)
			{
				return false;
			}

			public OpenedWithParams _003C_003EiFixBaseProxy_Process(Dictionary<string, string> P0)
			{
				return null;
			}

			public void _003C_003EiFixBaseProxy_Processed(OpenedWithParams P0)
			{
			}
		}

		public class FirebaseMessagingAnonMsgDelegate : OpenedWithParamsDelegate
		{
			public const string NTF_TYPE_KEY = "";

			public const string NTF_URL_KEY = "";

			private static Queue<Dictionary<string, string>> _PendingMessages;

			public static void OnMessageReceived(bool isExplicit, IDictionary<string, string> parameters)
			{
			}

			public override PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
			{
				return null;
			}

			public override bool CanProcess(Dictionary<string, string> parameters)
			{
				return false;
			}

			public override OpenedWithParams Process(Dictionary<string, string> parameters)
			{
				return null;
			}

			public override void Processed(OpenedWithParams openedWithParams)
			{
			}

			public PlatformUtility.OpenedWith _003C_003EiFixBaseProxy_OverrideOpenedWith(PlatformUtility.OpenedWith P0)
			{
				return null;
			}

			public bool _003C_003EiFixBaseProxy_CanProcess(Dictionary<string, string> P0)
			{
				return false;
			}

			public OpenedWithParams _003C_003EiFixBaseProxy_Process(Dictionary<string, string> P0)
			{
				return null;
			}

			public void _003C_003EiFixBaseProxy_Processed(OpenedWithParams P0)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__13_0;

			public static Action<Task<string>> _003C_003E9__20_3;

			public static Action<Task> _003C_003E9__20_2;

			public static Action<Task<string>> _003C_003E9__20_1;

			public static Action<Task> _003C_003E9__20_0;

			public static Action<Task> _003C_003E9__21_0;

			public static Action<Task<string>> _003C_003E9__22_0;

			internal void _003C_TriggerTokenCallbacks_003Eb__13_0()
			{
			}

			internal void _003CForceUpdateToken_003Eb__20_0(Task deleteTask)
			{
			}

			internal void _003CForceUpdateToken_003Eb__20_1(Task<string> getTask)
			{
			}

			internal void _003CForceUpdateToken_003Eb__20_2(Task _deleteTask)
			{
			}

			internal void _003CForceUpdateToken_003Eb__20_3(Task<string> _getTask)
			{
			}

			internal void _003CDeleteToken_003Eb__21_0(Task deleteTask)
			{
			}

			internal void _003CGetToken_003Eb__22_0(Task<string> getTask)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass25_0<T>
		{
			public string topic;

			public Action<T, string, bool, string> callback;

			public T t;

			internal void _003CSubscribeTopic_003Eb__0(Task task)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass25_1<T>
		{
			public bool isOK;

			public string errorMessage;

			public _003C_003Ec__DisplayClass25_0<T> CS_0024_003C_003E8__locals1;

			internal void _003CSubscribeTopic_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass26_0<T>
		{
			public string topic;

			public Action<T, string, bool, string> callback;

			public T t;

			internal void _003CUnsubscribeTopic_003Eb__0(Task task)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass26_1<T>
		{
			public bool isOK;

			public string errorMessage;

			public _003C_003Ec__DisplayClass26_0<T> CS_0024_003C_003E8__locals1;

			internal void _003CUnsubscribeTopic_003Eb__1()
			{
			}
		}

		private static bool _003CMessagingInited_003Ek__BackingField;

		private static string _003CToken_003Ek__BackingField;

		private static List<Action<string>> _TokenCallbacks;

		private static UpdateTokenStatus _UpdateTokenStatus;

		public static bool UseMessaging => false;

		public static bool MessagingInited
		{
			get
			{
				return _003CMessagingInited_003Ek__BackingField;
			}
			private set
			{
				_003CMessagingInited_003Ek__BackingField = value;
			}
		}

		public static string Token
		{
			get
			{
				return _003CToken_003Ek__BackingField;
			}
			private set
			{
				_003CToken_003Ek__BackingField = value;
			}
		}

		public static bool UpdatingToken => false;

		public static void RegisterTokenCallback(Action<string> callback)
		{
		}

		public static void UnregisterTokenCallback(Action<string> callback)
		{
		}

		private static void _TriggerTokenCallbacks(string token)
		{
		}

		public static void Init()
		{
		}

		internal static void Shutdown()
		{
		}

		public static void ForceUpdateToken()
		{
		}

		public static void DeleteToken()
		{
		}

		public static void GetToken()
		{
		}

		public static void OnTokenReceived(object sender, TokenReceivedEventArgs token)
		{
		}

		public static void OnMessageReceived(object sender, MessageReceivedEventArgs e)
		{
		}

		public static void SubscribeTopic<T>(T t, string topic, Action<T, string, bool, string> callback)
		{
		}

		public static void UnsubscribeTopic<T>(T t, string topic, Action<T, string, bool, string> callback)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_2;

		public static Action _003C_003E9__22_1;

		public static Action<Task<DependencyStatus>> _003C_003E9__22_0;

		internal void _003CInit_003Eb__22_0(Task<DependencyStatus> task)
		{
		}

		internal void _003CInit_003Eb__22_2()
		{
		}

		internal void _003CInit_003Eb__22_1()
		{
		}
	}

	private static bool _PendingShutdown;

	private static bool _003CIsInited_003Ek__BackingField;

	private static bool _003CIsIniting_003Ek__BackingField;

	private static bool _003CIsOK_003Ek__BackingField;

	private static HashSet<Action> _InitCallbacks;

	public static bool UseFirebase => false;

	public static bool ShouldUseFirebase
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CanUseFirebase => false;

	public static bool IsInited
	{
		get
		{
			return _003CIsInited_003Ek__BackingField;
		}
		private set
		{
			_003CIsInited_003Ek__BackingField = value;
		}
	}

	public static bool IsIniting
	{
		get
		{
			return _003CIsIniting_003Ek__BackingField;
		}
		private set
		{
			_003CIsIniting_003Ek__BackingField = value;
		}
	}

	public static bool IsOK
	{
		get
		{
			return _003CIsOK_003Ek__BackingField;
		}
		private set
		{
			_003CIsOK_003Ek__BackingField = value;
		}
	}

	private static void Shutdown()
	{
	}

	public static void Init(Action callback = null)
	{
	}
}
