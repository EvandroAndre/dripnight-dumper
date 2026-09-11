using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace GCommon;

public static class PlatformUtility_Android
{
	private static class IntentExtra
	{
		public const string TEXT = "android.intent.extra.TEXT";

		public const string STREAM = "android.intent.extra.STREAM";
	}

	private static class IntentType
	{
		public const string TEXT_PLAIN = "text/plain";

		public const string IMAGE = "image/*";

		public const string VIDEO = "video/*";
	}

	public static class Permissions
	{
		public const string READ_EXTERNAL_STORAGE = "android.permission.READ_EXTERNAL_STORAGE";

		public const string WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";

		public const string READ_PHONE_STATE = "android.permission.READ_PHONE_STATE";

		public const string RECORD_AUDIO = "android.permission.RECORD_AUDIO";

		public const string BLUETOOTH_CONNECT = "android.permission.BLUETOOTH_CONNECT";

		public const string POST_NOTIFICATIONS = "android.permission.POST_NOTIFICATIONS";

		public const string CAMERA = "android.permission.CAMERA";

		public const string ACCESS_FINE_LOCATION = "android.permission.ACCESS_FINE_LOCATION";

		public const string READ_CALENDAR = "android.permission.READ_CALENDAR";

		public const string WRITE_CALENDAR = "android.permission.WRITE_CALENDAR";

		public static readonly Dictionary<string, int> MinAPILevels;

		public static readonly Dictionary<string, int> MaxAPILevels;

		public static readonly Dictionary<string, bool> DefaultStatus;
	}

	public class ActivityConfiguration
	{
		public int screenWidthDp;

		public int screenHeightDp;

		public int smallestScreenWidthDp;

		public int densityDpi;
	}

	public class AndroidGraphicsRect
	{
		public int left;

		public int right;

		public int top;

		public int bottom;

		public int width => 0;

		public int height => 0;
	}

	public class DisplayMetrics
	{
		public int widthPixels;

		public int heightPixels;

		public float density;

		public int densityDpi;

		public float scaledDensity;

		public float xdpi;

		public float ydpi;
	}

	public enum PermissionGrantResult
	{
		Denied = -1,
		Granted
	}

	public class RequestPermissionResult
	{
		public int RequestCode;

		public Dictionary<string, int> Results;
	}

	public delegate void OnRequestPermissionsResultCallback(RequestPermissionResult result);

	public class FcmRmtMsg
	{
		public long RecvTime;

		public Dictionary<string, string> Data;
	}

	[Serializable]
	public class CpuInfo
	{
		[Serializable]
		public class ProcessorInfo
		{
			public string Implementer;

			public string Part;

			public string Revision;

			public string Variant;

			public string Architecture;

			public float BogoMIPS;

			public string[] Features;

			public int Index;
		}

		public string Processor;

		public string Serial;

		public string Hardware;

		public ProcessorInfo[] Processors;
	}

	[Serializable]
	public class UnmapVirtualMemoryResult
	{
		public string ErrStep;

		public string ErrMsg;

		public ulong Addr;

		public ulong Size;

		public bool ProcMapsVerified;

		public ulong ProcMapsSize;

		public long ProcMaps_MS;

		public long Time_MS;
	}

	public enum ComponentType
	{
		Activity,
		Service,
		Receiver,
		Provider
	}

	public enum ComponentCheckResult
	{
		Error = 0,
		Found = 1,
		PackageNotFound = -1,
		ComponentNotFound = -2
	}

	public static class SYSTEM_FEATURES
	{
	}

	public class ProcessMemoryInfo
	{
		public int cost_ms;

		public int dalvikPrivateDirty;

		public int dalvikPss;

		public int dalvikSharedDirty;

		public int nativePrivateDirty;

		public int nativePss;

		public int nativeSharedDirty;

		public int otherPrivateDirty;

		public int otherPss;

		public int otherSharedDirty;

		public int totalPrivateClean;

		public int totalPrivateDirty;

		public int totalPss;

		public int totalSharedClean;

		public int totalSharedDirty;

		public int totalSwappablePss;
	}

	public class MemoryInfo
	{
		public long availMem;

		public bool lowMemory;

		public long threshold;

		public long totalMem;

		public long cost_ticks;
	}

	public class StorageDeviceSpace
	{
		public long Free;

		public long Total;
	}

	public static class MimeTypes
	{
		public const string VIDEO_AVC = "video/avc";
	}

	public class GetAdvertisingIdResult
	{
		public string Exception;

		public string AdvertisingId;

		public string ProviderPackageName;

		public bool IsLimitAdTrackingEnabled;
	}

	[Serializable]
	public class InAppReviewResult
	{
		public bool RequestFailure;

		public bool LaunchFailure;

		public string ExceptionType;

		public string ExceptionMessage;
	}

	[Serializable]
	public class AndroidDisplayCutout
	{
		public int top;

		public int bottom;

		public int left;

		public int right;

		public bool NoCutout()
		{
			return false;
		}

		public bool NoHorizontalCutout()
		{
			return false;
		}

		public bool NoVerticalCutout()
		{
			return false;
		}
	}

	public static class AndroidMouse
	{
		public class MotionEventJSON
		{
			public string source;

			public string action;

			public float x;

			public float y;

			public bool left;

			public bool right;

			public bool mid;

			public float scroll_v;

			public float scroll_h;
		}

		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public string data;

			internal void _003COnGenericMotionEvent_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass37_0
		{
			public string data;

			internal void _003COnCapturedPointer_003Eb__0()
			{
			}
		}

		private static AndroidJavaClass _AndroidMouseAPI;

		public const int PRIMARY_BUTTON = 0;

		public const int SECONDARY_BUTTON = 1;

		public const int TERTIARY_BUTTON = 2;

		private static Action<string> _GenericMotionEventListener;

		private static Action<string> _CapturedPointerListener;

		private static AndroidJavaClass AndroidMouseAPI => null;

		public static float X => 0f;

		public static float Y => 0f;

		public static Vector3 Position => default(Vector3);

		public static float DeltaX => 0f;

		public static float DeltaY => 0f;

		public static Vector3 DeltaPosition => default(Vector3);

		public static float ScrollX => 0f;

		public static float ScrollY => 0f;

		public static float DeltaScrollX => 0f;

		public static float DeltaScrollY => 0f;

		public static void RequestPointerCapture()
		{
		}

		public static void ReleasePointerCapture()
		{
		}

		public static void OnUnityFrame()
		{
		}

		public static bool HasPointerCapture()
		{
			return false;
		}

		public static bool IsPressingButton(int button)
		{
			return false;
		}

		public static bool JustPressedButton(int button)
		{
			return false;
		}

		public static bool JustReleasedButton(int button)
		{
			return false;
		}

		internal static void OnGenericMotionEvent(string data)
		{
		}

		public static void RegisterGenericMotionEventListener(Action<string> listener)
		{
		}

		public static void UnregisterGenericMotionEventListener()
		{
		}

		internal static void OnCapturedPointer(string data)
		{
		}

		public static void RegisterCapturedPointerListener(Action<string> listener)
		{
		}

		public static void UnregisterCapturedPointerListener()
		{
		}
	}

	public static class NetworkAPI
	{
		private static AndroidJavaClass _JavaAPI;

		public static bool LogNetworkType;

		public static bool EnhancedNetworkType;

		private static AndroidJavaClass JavaAPI => null;

		public static string GetNetworkType()
		{
			return null;
		}

		public static float GetWifiSignalLevel()
		{
			return 0f;
		}

		public static bool IsVPN()
		{
			return false;
		}

		public static void CallTraceRoute(string address, int thread_count)
		{
		}
	}

	public static class DataConnectionState
	{
		public class State
		{
			public const string DISCONNECTED = "disconnected";

			public const string CONNECTING = "connecting";

			public const string CONNECTED = "connected";

			public const string SUSPENDED = "suspended";

			public static bool IsAvailable(string state)
			{
				return false;
			}
		}

		private static AndroidJavaClass _JavaAPI;

		private static string _003CDataNetworkTypeFromCallback_003Ek__BackingField;

		private static string _003CDataNetworkStateFromCallback_003Ek__BackingField;

		private static AndroidJavaClass JavaAPI => null;

		public static string DataNetworkTypeFromCallback
		{
			get
			{
				return _003CDataNetworkTypeFromCallback_003Ek__BackingField;
			}
			private set
			{
				_003CDataNetworkTypeFromCallback_003Ek__BackingField = value;
			}
		}

		public static string DataNetworkStateFromCallback
		{
			get
			{
				return _003CDataNetworkStateFromCallback_003Ek__BackingField;
			}
			private set
			{
				_003CDataNetworkStateFromCallback_003Ek__BackingField = value;
			}
		}

		static DataConnectionState()
		{
		}

		public static void OnDataConnectionStateChanged(string data)
		{
		}

		public static void StartMonitoring()
		{
		}

		public static void StopMonitoring()
		{
		}
	}

	public static class NetworkConnectivity
	{
		public static class NetworkType
		{
			public const int WIFI = 0;

			public const int Cellular = 1;

			public const int VPN = 2;
		}

		public static class BindSocketError
		{
			public const string SDK_INT = "SDK_INT";

			public const string NO_NET = "NO_NET";

			public const string NO_FD = "NO_FD";

			public const string EPERM = "EPERM";
		}

		[Serializable]
		private class NetworkCallbackEvent
		{
			public static class Types
			{
				public const string AVAILABLE = "available";

				public const string UNAVAILABLE = "unavailable";

				public const string LOST = "lost";

				public const string BLOCKED = "blocked";

				public const string UNBLOCKED = "unblocked";

				public const string CAPABILITIES_CHANGED = "capabilities_changed";
			}

			public string Type;

			public string Event;

			public int Transport_Wifi;

			public int Transport_Cellular;

			public int Transport_VPN;

			public int Capability_Internet;

			public int Capability_Validated;

			public int Capability_NotMetered;

			public int Capability_NotVPN;
		}

		public static class NetworkCallbackType
		{
			public const string WIFI = "WIFI";

			public const string CELLULAR = "Cellular";

			public const string VPN = "VPN";
		}

		public class NetworkStatus
		{
			public int HasNetwork;

			public int Unblocked;

			public int Transport_VPN;

			public int Transport_WIFI;

			public int Transport_Cellular;

			public int Capability_Internet;

			public int Capability_Validated;

			public int Capability_NotMetered;

			public int Capability_NotVPN;

			public int Usable => 0;

			public string String => null;

			public void Reset()
			{
			}
		}

		[Serializable]
		public class HostAddr
		{
			public string IP;

			public string HostName;

			public string CanonicalHostName;
		}

		[Serializable]
		public class GetAddrByNameResult
		{
			public int Networktype;

			public string Host;

			public HostAddr[] Results;
		}

		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public PlatformUtility.INetworkCallback callback;

			internal bool _003CRequestNetwork_003Eb__0(PlatformUtility.NetworkCallbackHolder h)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public PlatformUtility.INetworkCallback callback;

			internal bool _003CReleaseNetwork_003Eb__0(PlatformUtility.NetworkCallbackHolder h)
			{
				return false;
			}
		}

		private static AndroidJavaClass _JavaAPI;

		public static readonly NetworkStatus[] _NetworkStatus;

		private static AndroidJavaClass JavaAPI => null;

		public static NetworkStatus GetNetworkStatus(int networkType)
		{
			return null;
		}

		private static void _ResetNetworkStatus()
		{
		}

		public static void OnNetworkCallbackLegacy(string data)
		{
		}

		internal static void OnNetworkCallback(string data)
		{
		}

		private static void TriggerNetworkCallback()
		{
		}

		internal static void StartMonitoring(int networkType)
		{
		}

		internal static void StopMonitoring(int networkType)
		{
		}

		public static bool SupportNetworkRequests()
		{
			return false;
		}

		public static void RequestNetwork(int networkType, PlatformUtility.INetworkCallback callback)
		{
		}

		public static void ReleaseNetwork(int networkType, PlatformUtility.INetworkCallback callback)
		{
		}

		public static void RequestNetworks(PlatformUtility.INetworkCallback callback)
		{
		}

		public static void ReleaseNetworks(PlatformUtility.INetworkCallback callback)
		{
		}

		public static bool SupportGetAddrByName()
		{
			return false;
		}

		public static GetAddrByNameResult GetAddrByName(int networkType, string host)
		{
			return null;
		}

		public static bool SupportBindSocket()
		{
			return false;
		}

		public static string BindSocket(IntPtr socketHandle, int networkType)
		{
			return null;
		}

		private static string BindSocket(int fileDescriptor, int networkType)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__195_0;

		internal void _003COnMainActivityDisplayChanged_003Eb__195_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass177_0
	{
		public GetAdvertisingIdResult result;

		internal void _003COnGetAdvertisingId_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass184_0
	{
		public InAppReviewResult result;

		internal void _003COnDoneInAppReview_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public string data;

		internal void _003COnMainActivityConfigurationChanged_003Eb__0()
		{
		}
	}

	public const int PERMISSION_REQUEST_CODE = 1638;

	public static string FileProviderAuthorities;

	private static OnRequestPermissionsResultCallback _OnRequestPermissionsResult;

	private static AndroidJavaClass _FFAPI;

	private static int _Build_Version_SDK_INT;

	private static UnmapVirtualMemoryResult _003CUnmapReservedWebViewVirtualMemoryResult_003Ek__BackingField;

	private static Action _SendIntentCallback;

	private static Dictionary<string, Action> _PositiveCallbacks;

	private static Dictionary<string, Action> _NegativeCallbacks;

	private static Dictionary<string, Action> _NeutralCallbacks;

	public const string CODEC_NAME_PREFIX_SOFTWARE = "OMX.google.";

	private static int? _Cpus;

	private const int SEEK_SET = 0;

	private const int SEEK_CUR = 1;

	private const int SEEK_END = 2;

	private const int O_RDONLY = 0;

	private const int O_WRONLY = 1;

	private const int O_RDWR = 2;

	private const int O_CREAT = 64;

	private const int O_EXCL = 128;

	private const int O_TRUNC = 512;

	private const int O_APPEND = 1024;

	private const int PROT_READ = 1;

	private const int MAP_PRIVATE = 2;

	private const int MAP_FAILED = -1;

	private static Dictionary<string, int> _SystemVirtualFileDescriptors;

	private static long[] _CpuMinFrequencies;

	private static long[] _CpuMaxFrequencies;

	public static int OptimizeAndroidReadCpuFreq;

	private static IntPtr[] _ScalingCurFreqAddrs;

	private const int _ScalingCurFreqMappedAddrBytes = 32;

	private const string _ScalingCurFreqPathFormat = "/sys/devices/system/cpu/cpu{0}/cpufreq/scaling_cur_freq";

	private static int[] _AsciiLookupTable;

	private const int ASCII_LENGTH = 256;

	private static Action<GetAdvertisingIdResult> _GetAdvertisingIdCallback;

	private static Action<bool> _DoInAppReviewCallback;

	private static Action<ActivityConfiguration> _ActivityConfigurationCallback;

	private static Action _ActivityDisplayChangedCallback;

	private static int preferredRefreshRate;

	private static bool supportDynamicRefreshRate;

	private static AndroidJavaClass _FFLocalNotification;

	private static AndroidJavaClass FFAPI => null;

	public static int AndroidSystemAPILevel => 0;

	public static UnmapVirtualMemoryResult UnmapReservedWebViewVirtualMemoryResult
	{
		get
		{
			return _003CUnmapReservedWebViewVirtualMemoryResult_003Ek__BackingField;
		}
		set
		{
			_003CUnmapReservedWebViewVirtualMemoryResult_003Ek__BackingField = value;
		}
	}

	public static bool CanUnmapReservedWebViewVirtualMemory => false;

	private static AndroidJavaClass FFLocalNotification => null;

	[PreserveSig]
	private static extern long FileDescriptorFromSocketHandle(uint handle);

	[PreserveSig]
	private static extern void ffutil_SetUnmapTarget(ulong addr, ulong size);

	[PreserveSig]
	private static extern ulong ffutil_UnmapAddr();

	[PreserveSig]
	private static extern ulong ffutil_UnmapSize();

	[PreserveSig]
	private static extern int ffutil_Unmap(uint realloc_size, int set_mem, string rename);

	[PreserveSig]
	public static extern void ffutil_UnmapCheck();

	public static int Build_VERSION_SDK_INT()
	{
		return 0;
	}

	public static string BuildVariant_PackageName()
	{
		return null;
	}

	public static T GetAndroidManifestMetaData<T>(string packageName, string name)
	{
		return default(T);
	}

	public static void NativeLog(string log)
	{
	}

	public static long GetTimeSinceMainActivityCreate_MS()
	{
		return 0L;
	}

	public static long GetMainActivityTotalPausedTime_MS()
	{
		return 0L;
	}

	public static bool IsGooglePlayServicesAvailable()
	{
		return false;
	}

	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	public static void SetUseScreenCaptureCallback(bool useCallback)
	{
	}

	public static PermissionGrantResult CheckPermission(string permission)
	{
		return PermissionGrantResult.Granted;
	}

	public static void RequestPermissions(int requestCode, string[] permissions, OnRequestPermissionsResultCallback callback)
	{
	}

	public static bool ShouldShowRequestPermissionRationale(string permission)
	{
		return false;
	}

	public static string ConvertFilePathToUri(string filePath)
	{
		return null;
	}

	public static PlatformUtility.OpenedWith GetOpenedWith()
	{
		return null;
	}

	public static void ClearOpenedWith()
	{
	}

	public static void CacheFcmRmtMsgs(bool cache)
	{
	}

	public static FcmRmtMsg[] GetCachedFcmRmtMsgs()
	{
		return null;
	}

	public static void WipeCachedFcmRmtMsgs(string[] msgIDs)
	{
	}

	public static void WipeAllCachedFcmRmtMsgs()
	{
	}

	public static long GetPageSize()
	{
		return 0L;
	}

	public static long GetVSS_MB()
	{
		return 0L;
	}

	public static CpuInfo ParseCpuInfo(string cpuinfoString)
	{
		return null;
	}

	public static string ReadSystemProc(string file)
	{
		return null;
	}

	public static string ReadProc(string file)
	{
		return null;
	}

	public static void DumpProcMaps(string label)
	{
	}

	public static void UnmapReservedWebViewVirtualMemory(bool revise, AndroidJavaClass ffutil, uint realloc_size, int set_mem, string rename)
	{
	}

	private static UnmapVirtualMemoryResult UnmapReservedWebViewVirtualMemory_ProcMaps(bool revise, uint realloc_size, int set_mem, string rename)
	{
		return null;
	}

	public static void SetCanHandleLowMemory(bool canHandle)
	{
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

	public static string GetCacheDir()
	{
		return null;
	}

	public static void SelectImageFromAlbumLegacy()
	{
	}

	public static void SelectImageFromAlbum()
	{
	}

	public static AndroidJavaObject ToJava(string[] strings)
	{
		return null;
	}

	public static AndroidJavaObject ToJava(float[] floats)
	{
		return null;
	}

	public static AndroidJavaObject ToJava(byte[] bytes)
	{
		return null;
	}

	private static AndroidJavaObject ToJava<T>(T[] ts, string javaClass)
	{
		return null;
	}

	public static bool CanOpenUrl(string url)
	{
		return false;
	}

	public static bool IsPackageInstalled(string bundleIdentifier)
	{
		return false;
	}

	public static ComponentCheckResult IsComponentAvailableInPackage(string packageName, string componentName, ComponentType componentType)
	{
		return ComponentCheckResult.Error;
	}

	public static bool HasSystemFeature(string feature)
	{
		return false;
	}

	public static bool IsDebuggable()
	{
		return false;
	}

	internal static void OnSentIntent()
	{
	}

	public static bool SendText(string title, string text, string packageName = "", string className = "", Dictionary<string, string> extras = null, Action callback = null)
	{
		return false;
	}

	public static bool SendImage(string title, string filePath, string packageName = "", string className = "", Dictionary<string, string> extras = null, Action callback = null)
	{
		return false;
	}

	public static bool SendVideo(string title, string filePath, string packageName = "", string className = "", Dictionary<string, string> extras = null, Action callback = null)
	{
		return false;
	}

	public static int GetAppMemory()
	{
		return 0;
	}

	public static ProcessMemoryInfo GetProcessMemoryInfo()
	{
		return null;
	}

	public static MemoryInfo GetMemoryInfo()
	{
		return null;
	}

	public static int GetAvailMemory()
	{
		return 0;
	}

	public static int GetLowMemoryThreshold()
	{
		return 0;
	}

	public static long GetSDCardAvailStorageWithByte()
	{
		return 0L;
	}

	public static long GetSDCardTotalStorageWithByte()
	{
		return 0L;
	}

	public static long GetSystemInnerTotalStorageWithByte()
	{
		return 0L;
	}

	public static long GetSystemInnerAvailStorageWithByte()
	{
		return 0L;
	}

	public static int GetSDCardTotalStorage()
	{
		return 0;
	}

	public static int GetSDCardAvailStorage()
	{
		return 0;
	}

	public static int GetSystemInnerTotalStorage()
	{
		return 0;
	}

	public static int GetSystemInnerAvailStorage()
	{
		return 0;
	}

	public static int getAvailbleStorageByPath(string _path)
	{
		return 0;
	}

	public static int getTotalStorageByPath(string _path)
	{
		return 0;
	}

	public static long getTotalStorageByPathInByte(string _path)
	{
		return 0L;
	}

	public static string getInternalStorageAbsolutePath()
	{
		return null;
	}

	public static StorageDeviceSpace getInternalStorageDeviceSpace()
	{
		return null;
	}

	public static StorageDeviceSpace getExternalStorageDeviceSpace()
	{
		return null;
	}

	public static void OnRequestPermissionsResult(string result)
	{
	}

	public static void ShowAlertDialog(string title, string content, string yes, string no, string cancel, Action onYes, Action onNo, Action onCancel, string identifier = "")
	{
	}

	public static void OnAlertDialogPositiveButtonClick(string identifier)
	{
	}

	public static void OnAlertDialogNegativeButtonClick(string identifier)
	{
	}

	public static void OnAlertDialogNeutralButtonClick(string identifier)
	{
	}

	public static void ShowRequestPermissionRationalesAlertDialog(Action onOK, string identifier)
	{
	}

	public static void ShowRequestPermissionRationaleAlertDialog(string permission, bool isCritical, Action onYes, Action onNo, string identifier)
	{
	}

	public static void ShowGotoApplicationDetailsSettingsAlertDialog(string permission, Action onYes, Action onNo, string identifier, bool critical)
	{
	}

	public static void GotoApplicationDetailsSettings()
	{
	}

	public static bool OpenUrlWithPackage(string url, string package)
	{
		return false;
	}

	private static string GetString(string className, string methodName, string[] parameters)
	{
		return null;
	}

	public static string GetSystemProperty(string propertyName)
	{
		return null;
	}

	private static bool CheckPackageName(string packageName)
	{
		return false;
	}

	public static bool CheckFileExists(string fileName)
	{
		return false;
	}

	public static string GetNetworkOperatorName()
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

	public static bool IsBatteryCharging()
	{
		return false;
	}

	public static string GetNativeLibraryDir()
	{
		return null;
	}

	public static string GetNativeDir()
	{
		return null;
	}

	public static void SendBroadcast(string packageName, string actionName, Dictionary<string, string> extras)
	{
	}

	public static string[] GetCodecsForMediaFormat_MimeType(string mime_type, bool isEncoder, bool log)
	{
		return null;
	}

	public static bool SupportHardwareDecodingForH264(bool log)
	{
		return false;
	}

	public static string GetCpuArchitecture()
	{
		return null;
	}

	public static int GetCpus()
	{
		return 0;
	}

	[PreserveSig]
	private static extern int open(string pathname, int flags);

	[PreserveSig]
	private static extern IntPtr mmap(IntPtr addr, ulong length, int prot, int flags, int fd, long offset);

	[PreserveSig]
	private static extern int munmap(IntPtr addr, ulong length);

	[PreserveSig]
	private static extern int close(int fd);

	[PreserveSig]
	private static extern int read(int fd, IntPtr buf, int count);

	[PreserveSig]
	private static extern long lseek(int fd, long offset, int whence);

	private static bool __GetFileDescriptor(string filePath, out int fd)
	{
		fd = default(int);
		return false;
	}

	private static void __ReleaseFileDescriptor(string filePath)
	{
	}

	private static bool _ReadSystemVirtualFileAsLong(string filePath, out long result)
	{
		result = default(long);
		return false;
	}

	public static long GetCpuMinFrequency(int cpu)
	{
		return 0L;
	}

	public static long GetCpuMaxFrequency(int cpu)
	{
		return 0L;
	}

	private static long GetCpuCurFreq_FD(int cpu)
	{
		return 0L;
	}

	private static void CpuCurrentFreq_Cleanup()
	{
	}

	public static long GetCpuCurrentFrequency(int cpu)
	{
		return 0L;
	}

	public static bool Relaunch(long delayMS)
	{
		return false;
	}

	public static GetAdvertisingIdResult GetGoogleAdvertisingId()
	{
		return null;
	}

	public static bool IsAdvertisingIdProviderAvailable()
	{
		return false;
	}

	internal static void OnGetAdvertisingId(GetAdvertisingIdResult result)
	{
	}

	public static void GetAdvertisingId(Action<GetAdvertisingIdResult> callback)
	{
	}

	public static bool SupportInAppReview()
	{
		return false;
	}

	public static bool DoInAppReview(Action<bool> callback)
	{
		return false;
	}

	internal static void OnDoneInAppReview(InAppReviewResult result)
	{
	}

	public static void SetDebugDisplayCutout(bool debug)
	{
	}

	public static bool HasDisplayCutout()
	{
		return false;
	}

	public static AndroidDisplayCutout GetDisplayCutout()
	{
		return null;
	}

	public static byte[] GetSignature()
	{
		return null;
	}

	public static void SetActivityConfigurationCallback(Action<ActivityConfiguration> callback)
	{
	}

	internal static void OnMainActivityConfigurationChanged(string data)
	{
	}

	public static void SetActivityDisplayChangedCallback(Action callback)
	{
	}

	internal static void OnMainActivityDisplayChanged(string data)
	{
	}

	public static DisplayMetrics GetDefaultDisplayRealMetrics()
	{
		return null;
	}

	public static int[] GetSupportedRefreshRates()
	{
		return null;
	}

	private static bool _SetRefreshRate(int frameRate)
	{
		return false;
	}

	public static void SetRefreshRate(int frameRate)
	{
	}

	public static void SetPreferredRefreshRate()
	{
	}

	public static float GetCurrentRefreshRate()
	{
		return 0f;
	}

	public static int GetSupportedModeCount()
	{
		return 0;
	}

	public static int GetCurrentDisplayModeId()
	{
		return 0;
	}

	public static int GetNativeThreadId()
	{
		return 0;
	}

	public static void InitLocalNotification()
	{
	}

	public static void SetLocalNtfLog(bool log)
	{
	}

	public static void SetLocalNotificationChannel(string channel_id, PlatformUtility.LocalNotificationImportance importance, string name, string description)
	{
	}

	public static void GotoChannelNotificationSettings()
	{
	}

	public static void ScheduleLocalNotification(int type, string guid, string title, string content, long time_ms, int repeat_interval_ms, int repeat_times, string uri, string channel_id)
	{
	}

	public static void UnscheduleLocalNotification(int type, string guid)
	{
	}

	public static void ScheduleLocalNotification(int type, string title, string content, long time_ms, int repeat_interval_ms, int repeat_times, string uri, string channel_id)
	{
	}

	public static void UnscheduleLocalNotification(int type)
	{
	}

	public static void UnscheduleAllLocalNotifications()
	{
	}

	public static void ClearAllNotifications()
	{
	}

	public static bool AreNotificationsEnabled()
	{
		return false;
	}

	public static bool HasNotificationChannels()
	{
		return false;
	}

	public static bool IsNotificationChannelEnabled(string channelId)
	{
		return false;
	}

	public static Dictionary<int, int> GetLocalNotificationRecords()
	{
		return null;
	}

	public static void ClearLocalNotificationRecords()
	{
	}

	public static void SetupTimeoutSettings(PlatformUtility.LocalNtfTimeoutSettings settings)
	{
	}

	public static PlatformUtility.LocalNtfDelayRecords GetLocalNtfDelayRecords()
	{
		return null;
	}

	public static void ClearLocalNtfDelayRecords()
	{
	}
}
