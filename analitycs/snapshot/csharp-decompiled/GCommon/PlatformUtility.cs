using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public static class PlatformUtility
{
	public delegate void LogCallback(string log);

	public class PlatformUtilityOption
	{
		public string AndroidFileProviderAuthorities;
	}

	public enum UserInterfaceIdiom
	{
		Unknown = -1,
		Unspecified,
		Phone,
		Pad,
		TV,
		Car,
		Computer,
		HMD
	}

	public class OpenedWith
	{
		public Dictionary<string, string> Params;

		public string Url;

		public string WebUrl;

		public int NotifyType;

		public bool HasParams => false;

		public bool HasUrl => false;

		public bool HasWebUrl => false;

		public bool HasNotifyType => false;

		public static bool HasValue(OpenedWith ow)
		{
			return false;
		}

		public void FromJson(string json)
		{
		}
	}

	public class DeliveredNotification
	{
		public long RecvTime;

		public Dictionary<string, string> Data;

		private DeliveredNotification()
		{
		}

		public static DeliveredNotification _()
		{
			return null;
		}

		public static DeliveredNotification _(PlatformUtility_Android.FcmRmtMsg msg)
		{
			return null;
		}
	}

	public class SendContentResult
	{
		public bool Completed;

		public string SendTarget;

		public string Error;
	}

	public static class NetworkType
	{
		public const string UNKNOWN = "Unknown";

		public const string WIFI = "WIFI";

		public const string CELLULAR = "Cellular";

		public const string CELLULAR_2G = "2G";

		public const string CELLULAR_3G = "3G";

		public const string CELLULAR_4G = "4G";

		public const string CELLULAR_5G = "5G";
	}

	public class NetworkCallbackStatus
	{
		private bool _003CWIFI_003Ek__BackingField;

		private bool _003CCellular_003Ek__BackingField;

		private bool _003CVPN_003Ek__BackingField;

		public bool WIFI
		{
			get
			{
				return _003CWIFI_003Ek__BackingField;
			}
			internal set
			{
				_003CWIFI_003Ek__BackingField = value;
			}
		}

		public bool Cellular
		{
			get
			{
				return _003CCellular_003Ek__BackingField;
			}
			internal set
			{
				_003CCellular_003Ek__BackingField = value;
			}
		}

		public bool VPN
		{
			get
			{
				return _003CVPN_003Ek__BackingField;
			}
			internal set
			{
				_003CVPN_003Ek__BackingField = value;
			}
		}
	}

	public interface INetworkCallback
	{
		void OnNetworkCallback(NetworkCallbackStatus before, NetworkCallbackStatus after);
	}

	internal class NetworkCallbackHolder
	{
		private INetworkCallback _003CCallback_003Ek__BackingField;

		internal bool Monitor;

		internal bool[] Requests;

		public INetworkCallback Callback
		{
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			private set
			{
				_003CCallback_003Ek__BackingField = value;
			}
		}

		public NetworkCallbackHolder(INetworkCallback callback)
		{
		}

		internal bool Holding(INetworkCallback callback)
		{
			return false;
		}
	}

	public enum NetworkInterface
	{
		None = -1,
		WIFI,
		Cellular
	}

	public class ResolveDNSResult
	{
		public NetworkInterface NetworkInterface;

		public string Host;

		private List<string> _003CIPv4_003Ek__BackingField;

		private List<string> _003CIPv6_003Ek__BackingField;

		public List<string> IPv4
		{
			get
			{
				return _003CIPv4_003Ek__BackingField;
			}
			private set
			{
				_003CIPv4_003Ek__BackingField = value;
			}
		}

		public List<string> IPv6
		{
			get
			{
				return _003CIPv6_003Ek__BackingField;
			}
			private set
			{
				_003CIPv6_003Ek__BackingField = value;
			}
		}

		public ResolveDNSResult(NetworkInterface networkInterface, string host)
		{
		}

		public void Add(string ip)
		{
		}
	}

	public delegate void BatteryChargingChangedCallback(bool charging);

	public delegate void BatteryLevelChangedCallback(float level);

	public class TakenSreenshotMaskToken : IDisposable
	{
		private string _003CReason_003Ek__BackingField;

		private string[] _003CMaskForClues_003Ek__BackingField;

		public string Reason
		{
			get
			{
				return _003CReason_003Ek__BackingField;
			}
			private set
			{
				_003CReason_003Ek__BackingField = value;
			}
		}

		public string[] MaskForClues
		{
			get
			{
				return _003CMaskForClues_003Ek__BackingField;
			}
			private set
			{
				_003CMaskForClues_003Ek__BackingField = value;
			}
		}

		public static TakenSreenshotMaskToken Create(string reason, string[] maskForClues = null)
		{
			return null;
		}

		private TakenSreenshotMaskToken(string reason, string[] maskForClues = null)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	public class DisplayCutout
	{
		public float top;

		public float bottom;

		public float left;

		public float right;
	}

	public enum LocalNotificationImportance
	{
		Unspecified = -1000,
		None = 0,
		Min = 1,
		Low = 2,
		Default = 3,
		High = 4,
		Max = 5
	}

	public enum LocalNotificationAuthorizationStatus
	{
		NotDetermined,
		Denied,
		Authorized
	}

	public class NtfParams
	{
		public int Type;

		public string GUID;

		public string Channel;

		public string Title;

		public string Content;

		public string DeepLinkUrl;

		public long Time_UTC_MS;

		public int TotalTimes;

		public int Interval_MS;
	}

	public class LocalNtfTimeoutSettings
	{
		public Dictionary<int, int> TimeoutMins;
	}

	public class LocalNtfDelayRecords
	{
		public class NtfDelay
		{
			public int Type;

			public int Delay;

			public int Timeout;
		}

		public NtfDelay[] NtfDelays;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<PlatformUtility_Android.FcmRmtMsg, DeliveredNotification> _003C_003E9__18_0;

		internal DeliveredNotification _003CGetDeliveredNotifications_003Eb__18_0(PlatformUtility_Android.FcmRmtMsg r)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public string clue;

		internal void _003COnTakenScreenshot_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public string path;

		internal void _003COnSelectedImageFromAlbum_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public string path;

		internal void _003COnSelectedVideoFromAlbum_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public Action<string, SendContentResult> callback;

		public string text;

		internal void _003CSendText_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public Action<string, SendContentResult> callback;

		public string filePath;

		internal void _003CSendVideo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public int vpn;

		public int wifi;

		public int cellular;

		internal void _003CTriggerNetworkCallback_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public INetworkCallback callback;

		internal bool _003CStartMonitoringNetworks_003Eb__0(NetworkCallbackHolder h)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public INetworkCallback callback;

		internal bool _003CStopMonitoringNetworks_003Eb__0(NetworkCallbackHolder h)
		{
			return false;
		}
	}

	private static LogCallback OnLog;

	private static LogCallback OnLogError;

	private static UserInterfaceIdiom _UserInterfaceIdiom;

	public static bool LogClipboard;

	internal static Action<string> _SelectImageFromAlbumCallback;

	internal static Action<string> _SelectVideoFromAlbumCallback;

	private static NetworkCallbackStatus _Before;

	private static NetworkCallbackStatus _After;

	internal static List<NetworkCallbackHolder> _NetworkCallbacks;

	public static BatteryChargingChangedCallback OnBatteryChargingChanged;

	public static BatteryLevelChangedCallback OnBatteryLevelChanged;

	private static bool _003COptimizePInvokePerf_003Ek__BackingField;

	private static bool _003CCacheTotalMemory_003Ek__BackingField;

	private static int _TotalMemory;

	private static int _CachedSystemPhysicalMemory;

	private static Action _OnTakenScreenshot;

	public static bool StripURIOnTakenScreenshot;

	private static Dictionary<string, Func<string, bool>> _TakenScreenshotFilters;

	private static HashSet<TakenSreenshotMaskToken> _TakenScreenshotMaskTokens;

	public static string VersionCode => null;

	public static bool IsBuiltForMobileOnStandalone => false;

	public static bool IsRunningMobileOnStandalone => false;

	public static bool OptimizePInvokePerf
	{
		get
		{
			return _003COptimizePInvokePerf_003Ek__BackingField;
		}
		set
		{
			_003COptimizePInvokePerf_003Ek__BackingField = value;
		}
	}

	public static bool CacheTotalMemory
	{
		get
		{
			return _003CCacheTotalMemory_003Ek__BackingField;
		}
		set
		{
			_003CCacheTotalMemory_003Ek__BackingField = value;
		}
	}

	public static void Init(PlatformUtilityOption option)
	{
	}

	public static void SetLogCallbacks(LogCallback onLog, LogCallback onLogError)
	{
	}

	internal static void LogFormat(string format, object[] parameters)
	{
	}

	internal static void Log(string log)
	{
	}

	internal static string ToJSON(Dictionary<string, string> dict)
	{
		return null;
	}

	internal static void LogError(string logError)
	{
	}

	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	public static UserInterfaceIdiom GetUserInterfaceIdiom()
	{
		return UserInterfaceIdiom.Unspecified;
	}

	public static OpenedWith GetOpenedWith()
	{
		return null;
	}

	public static void ClearOpenedWith()
	{
	}

	public static void GetDeliveredNotifications(Action<DeliveredNotification[]> onGetDeliveredNotifications)
	{
	}

	public static void SetCanHandleLowMemory(bool canHandle)
	{
	}

	public static void GotoOpSysAppSettings()
	{
	}

	public static bool CanOpenUrl(string url)
	{
		return false;
	}

	public static string GetTempCachePath()
	{
		return null;
	}

	public static bool CanReadClipboardSilently()
	{
		return false;
	}

	public static void CopyStringToClipboard(string content)
	{
	}

	public static string CopyStringFromClipboard()
	{
		return null;
	}

	public static void SelectImageFromAlbum(Action<string> callback, bool legacy = false)
	{
	}

	internal static void OnSelectedImageFromAlbum(string path)
	{
	}

	public static void SelectVideoFromAlbum(Action<string> callback)
	{
	}

	internal static void OnSelectedVideoFromAlbum(string path)
	{
	}

	public static void SendText(string caption, string text, Rect rect, Action<string, SendContentResult> callback = null)
	{
	}

	public static bool SendImage(string text, string filePath)
	{
		return false;
	}

	public static bool SendVideo(string caption, string filePath, Rect rect, Action<string, SendContentResult> callback = null)
	{
		return false;
	}

	public static void NativeLog(string text)
	{
	}

	public static uint IsVulkanSupported()
	{
		return 0u;
	}

	public static bool IsVPN()
	{
		return false;
	}

	public static string GetNetworkType()
	{
		return null;
	}

	public static string GetNetworkName()
	{
		return null;
	}

	internal static void TriggerNetworkCallback(int vpn, int wifi, int cellular)
	{
	}

	public static void StartMonitoringNetworks(INetworkCallback callback)
	{
	}

	public static void StopMonitoringNetworks(INetworkCallback callback)
	{
	}

	public static ResolveDNSResult ResolveDNS(NetworkInterface networkInterface, string host)
	{
		return null;
	}

	private static ResolveDNSResult _ResolveDNS_Android(NetworkInterface networkInterface, string host)
	{
		return null;
	}

	public static void ToggleBatteryReport(bool shouldReport)
	{
	}

	public static float GetBatteryLevel()
	{
		return 0f;
	}

	public static int GetAppMemory()
	{
		return 0;
	}

	public static int GetAvailMemory()
	{
		return 0;
	}

	public static int GetTotalMemory()
	{
		return 0;
	}

	public static int GetSystemPhysicalMemory()
	{
		return 0;
	}

	public static string GetPlatformInfo()
	{
		return null;
	}

	public static bool IsTotalMemoryAboveThreshold(float number_gigabytes)
	{
		return false;
	}

	public static int GetLowMemoryThreshold()
	{
		return 0;
	}

	public static bool IsBatteryCharging()
	{
		return false;
	}

	public static float GetWifiSignalLevel()
	{
		return 0f;
	}

	public static int IntPtrBytes()
	{
		return 0;
	}

	public static bool Is32BitsProcess()
	{
		return false;
	}

	public static bool Is64BitsProcess()
	{
		return false;
	}

	public static bool SupportInAppReview()
	{
		return false;
	}

	public static bool DoInAppReview(Action<bool> callback)
	{
		return false;
	}

	public static void RegisterTakenScreenshotCallback(Action action)
	{
	}

	public static void UnregisterTakenScreenshotCallback(Action action)
	{
	}

	public static void RegisterTakenScreenshotFilter(string name, Func<string, bool> filterFunc)
	{
	}

	public static void UnregisterTakenScreenshotFilter(string name)
	{
	}

	internal static void OnTakenScreenshot(string clue)
	{
	}

	public static bool HasDisplayCutout()
	{
		return false;
	}

	public static DisplayCutout GetDisplayCutout()
	{
		return null;
	}

	public static void SetLocalNtfLog(bool log)
	{
	}

	public static bool SupportsLocalNotification()
	{
		return false;
	}

	public static void InitLocalNotification()
	{
	}

	public static bool ShouldSetupLocalNotificationChannels()
	{
		return false;
	}

	public static bool HasLocalNotificationChannels()
	{
		return false;
	}

	public static void SetupLocalNotificationChannel(string channel_id, string channel_name, string channel_description, LocalNotificationImportance importance)
	{
	}

	public static void ScheduleLocalNtf(NtfParams param, Action<bool, string> done)
	{
	}

	private static void ScheduleLocalNotification(int type, string guid, string channel_id, string title, string content, string url, long time_utc_ms, int times, int interval_ms, Action<bool, string> done)
	{
	}

	public static void UnscheduleLocalNotification(int type, string guid, Action<bool, string> done)
	{
	}

	private static void ScheduleLocalNotification(int type, string channel_id, string title, string content, string url, long time_ms, int times, int interval_ms, Action<bool, string> done)
	{
	}

	public static void UnscheduleLocalNotification(int type, Action<bool, string> done)
	{
	}

	public static void UnscheduleAllLocalNotifications()
	{
	}

	public static void ClearAllNotifications()
	{
	}

	public static void SetupTimeoutSettings(LocalNtfTimeoutSettings settings)
	{
	}

	public static LocalNtfDelayRecords GetLocalNtfDelayRecords()
	{
		return null;
	}

	public static void ClearLocalNtfDelayRecords()
	{
	}
}
