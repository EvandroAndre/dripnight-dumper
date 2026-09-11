using System;
using System.Collections.Generic;
using COW;
using COW.OpSysExt;
using GCommon;
using VoxelBusters.ReplayKit;

public class ReplayKitManager : SingletonModule<ReplayKitManager>
{
	public enum DeviceQuailty
	{
		None,
		Super_Low,
		Low,
		Simple,
		Middle,
		High,
		Super_High
	}

	private enum MatchResultEM
	{
		None,
		CPU,
		GPU,
		Memory,
		iOS,
		Editor,
		PC,
		Emulator
	}

	public enum RecordStopStateEm
	{
		Stop2Delete,
		Stoped,
		Stop2Save,
		StopInReplayRecord
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ReplayKitDelegates.OnRecordActionCallback _003C_003E9__160_0;

		internal void _003CInitialise_003Eb__160_0(bool result, string message)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public ReplayKitManager _003C_003E4__this;

		public string output;

		internal void _003COnThumbnailCallback_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public Action<bool> callback;

		internal void _003CCheckVideoPermission_003Eb__0(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus status, string error)
		{
		}
	}

	private DeviceQuailty mDeviceQuailty;

	private MatchResultEM mMatchResult;

	private string mStrMatchTarget;

	private bool isFuzzyMatching;

	private const int MATCH_VERSION = 1;

	private const string REPLAYKIT_MATCH_VERSION_KEY = "REPLAYKIT_MATCH_VERSION_KEY";

	private const string strEnableInGameReplayKitKey = "FF_EnableInGameReplayKit";

	private const string strEnableLobbyReplayKitKey = "FF_EnableLobbyReplayKit";

	private List<ReplayKitVideoInfo> mlistVideoInfos;

	private ReplayKitVideoInfo mCurrentVideoInfo;

	private ReplaykitMainController replaykitController;

	private List<ReplayKitVideoInfo> mlistWaitThumbnails;

	private List<ReplayKitVideoInfo> mlistWaitVideoInfos;

	private uint delayGetThumbnailKey;

	private uint delayGetVideoInfolKey;

	private uint m_RestoreReplaykitCtrlWhenIdleKey;

	private bool m_ClearIdleCurrentVideoBeforeRestoreReplaykitCtrl;

	private int mRecordDuration;

	private bool mIsRecordReplayPreview;

	private ulong m_PendingSavedHighlightMatchId;

	public const string REPLAYKIT_STOP = "T_39_ZP_SC_STOP";

	public const string REPLAYKIT_SAVE = "T_39_ZP_SC_SAVE";

	public const string REPLAYKIT_VIDEO_NAME_DEFAULT = "T_39_ZP_SC_NAME";

	public const string REPLAYKIT_VIDEO_NAME_LOBBY = "T_39_ZP_SC_LOBBY";

	public const string REPLAYKIT_VIDEO_DELETE_FAIL = "T_39_ZP_SC_DELETE_FAIL";

	public const string REPLAYKIT_VIDEO_DELETE_SUCCESS = "T_39_ZP_SC_DELETE_SUCCESS";

	public const string REPLAYKIT_THUMBNAIL_FAIL = "T_39_ZP_SC_BITMAP";

	public const string PROFILE_REPLAY_BIG_TAB = "T_50_L_PROFILETABNAME_ALBUM";

	public const string PROFILE_REPLAY_SUB_TAB = "T_39_ZP_SC_SUB_TAB";

	public const string REPLAYKIT_GOTO_VIDEO_LIMIT = "T_39_ZP_SC_LIMIT";

	public const string REPLAYKIT_PREVIEW_FAIL = "T_39_ZP_SC_PREVIEW";

	public const string REPLAYKIT_RECORD_MEMORY_LIMIT = "T_39_ZP_SC_MEMORY";

	public const string REPLAYKIT_SETTING_SWITCH_TITLE = "T_39_ZP_SC_SET_TITLE";

	public const string REPLAYKIT_SETTING_INGAME = "T_39_ZP_SC_SET_INGAME";

	public const string REPLAYKIT_SETTING_LOBBY = "T_39_ZP_SC_SET_LOBBY";

	public const string REPLAYKIT_SETTING_VIDEO_QUALITY = "T_39_ZP_SC_SET_QUALITY";

	public const string REPLAYKIT_SETTING_VIDEO_HIGH = "T_39_ZP_SC_SET_HIGH";

	public const string REPLAYKIT_SETTING_VIDEO_MIDDLE = "T_39_ZP_SC_SET_MIDDLE";

	public const string REPLAYKIT_SETTING_VIDEO_LOW = "T_39_ZP_SC_SET_LOW";

	public const string REPLAYKIT_SETTING_VIDEO_QUALITY2 = "T_39_ZP_SC_SET_QUALITY2";

	public const string REPLAYKIT_TIPS = "T_39_ZP_SC_TIPS";

	public const string REPLAYKIT_SETTING_MICROPHONE = "T_39_ZP_SC_SET_MIC";

	public const string REPLAYKIT_SETTING_MICROPHONE2 = "T_39_ZP_SC_SET_MIC2";

	public const string REPLAYKIT_SETTING_REPLAY = "T_39_ZP_SC_SET_REPLAY";

	public const string REPLAYKIT_SETTING_REPLAY2 = "T_39_ZP_SC_SET_REPLAY2";

	public const string REPLAYKIT_DELETE_TITLE = "T_39_ZP_SC_DEL_TITLE";

	public const string REPLAYKIT_DELETE_CONTENT = "T_39_ZP_SC_DEL_CONTENT";

	public const string REPLAYKIT_SAVEING_TIPS = "T_39_ZP_SC_SAVEING_TIPS";

	public const string REPLAYKIT_VIDEO_NAME_REPLAY = "T_40_ZP_SC_REPLAY";

	public const string REPLAYKIT_VIDEO_NAME_HIGHLIGHT = "T_40_ZP_SC_HIGHLIGHT";

	public const string REPLAYKIT_SETTING_HIGHLIGHTRECORD = "T_49_ZYC_SET_TITLE";

	public const string REPLAYKIT_START = "StartBtn";

	public const string REPLAYKIT_OVER = "OverBtn";

	public const string REPLAYKIT_VIDEO = "VideoBtn";

	private static ReplayKitDelegates.OnRecordingPreviewAvailable m_onRecordingPreviewAvailable;

	private static ReplayKitDelegates.InitialiseCallback m_DidInitialise;

	private static ReplayKitDelegates.OnRecordActionCallback m_DidStartRecordAction;

	private static ReplayKitDelegates.OnRecordActionCallback m_DidRecordAvailableAction;

	private static ReplayKitDelegates.OnRecordActionCallback m_DidStopRecordAction;

	private static ReplayKitDelegates.OnRecordActionCallback m_DidSaveRecordAction;

	private static readonly string DATA_PATH;

	private static float replaykit_point;

	public static RecordStopStateEm SaveState;

	private static bool _003CsUsesMicrophone_003Ek__BackingField;

	private static string strAudioPath;

	private static string strRecordTime;

	public static bool EnableInGameReplayKit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EnableLobbyReplayKit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ReplayKitRecordingState recordingState => ReplayKitRecordingState.None;

	public static int ReplayKitDuration => 0;

	public static bool sUsesMicrophone
	{
		get
		{
			return _003CsUsesMicrophone_003Ek__BackingField;
		}
		private set
		{
			_003CsUsesMicrophone_003Ek__BackingField = value;
		}
	}

	public static event ReplayKitDelegates.InitialiseCallback DidInitialise
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event ReplayKitDelegates.OnRecordActionCallback DidStartRecordAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event ReplayKitDelegates.OnRecordActionCallback DidRecordAvailableAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event ReplayKitDelegates.OnRecordActionCallback DidStopRecordAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event ReplayKitDelegates.OnRecordActionCallback DidSaveRecordAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public string GetMatchResult()
	{
		return null;
	}

	public DeviceQuailty GetDeviceMatchQuailty()
	{
		return DeviceQuailty.None;
	}

	public void AdapterMobile()
	{
	}

	public DeviceQuailty GetAndroidQuality4DeviceName(string strDevice, string cpuName, string gpuName)
	{
		return DeviceQuailty.None;
	}

	private string GetRealDevice(string strDevice)
	{
		return null;
	}

	private DeviceQuailty GetAndroidQuality4Memory(string strDevice, string strCpuName, string strGpuName)
	{
		return DeviceQuailty.None;
	}

	private DeviceQuailty AdapterAndroidDevice(string strDevice, string strCpuName, string strGpuName, List<CPUInfo> cpu_list, List<GPUInfo> gpu_list)
	{
		return DeviceQuailty.None;
	}

	private DeviceQuailty GetIOSQuality4DeviceName(string strDevice, string strCpuName, string strGpuName)
	{
		return DeviceQuailty.None;
	}

	private DeviceQuailty GetIOSQuality4Memory(bool bIphone, string strDevice, string strCpuName, string strGpuName)
	{
		return DeviceQuailty.None;
	}

	public bool ReadIPhoneLevel(string strDevice, out int level_1, out int level_2)
	{
		level_1 = default(int);
		level_2 = default(int);
		return false;
	}

	public static bool IsNumeric(char ch)
	{
		return false;
	}

	public static string GetNumeric(string serial)
	{
		return null;
	}

	private void SendReplaykitMatchLog(string device_name, string cpu, string gpu, int match_mode, int match_quality, string match_value)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<ReplayKitVideoInfo> GetReplayKitVideos()
	{
		return null;
	}

	private void CheckAndCreateDirectory()
	{
	}

	private void ReadReplayVideoInfo()
	{
	}

	private void DeleteFile(string filePath)
	{
	}

	public void OpenRecordUIController()
	{
	}

	public void OnUnInitGame()
	{
	}

	public bool IsExistReplaykitCtrl()
	{
		return false;
	}

	public bool IsReplaykitCtrlShowHideVisible()
	{
		return false;
	}

	public bool TryClearIdleCurrentVideo()
	{
		return false;
	}

	public void RestoreReplaykitCtrlWhenIdle(bool clearIdleCurrentVideo = false)
	{
	}

	private void TryRestoreReplaykitCtrlWhenIdle()
	{
	}

	private void RestoreReplaykitCtrlIfIdle()
	{
	}

	private void CancelRestoreReplaykitCtrlWhenIdle()
	{
	}

	public void CloseReplaykitCtrl()
	{
	}

	public void ShowHideReplaykitCtrl(bool show)
	{
	}

	public bool isSupportReplayKit()
	{
		return false;
	}

	public bool isSupportReplayKit(bool inGame)
	{
		return false;
	}

	public void ModifyReplayKitEnable(bool result, bool ingame, bool bsend = true)
	{
	}

	public long GetVideoMemory()
	{
		return 0L;
	}

	public float GetFreeStorage()
	{
		return 0f;
	}

	public bool IsLobbyRecord()
	{
		return false;
	}

	private bool IsGameVaild(out bool inGame)
	{
		inGame = default(bool);
		return false;
	}

	public bool IsRecordEnabled(bool isSkipSettingCheck = false, bool isSkipGameValidCheck = false)
	{
		return false;
	}

	public bool StartRecord(bool isSingleHighlight = false, bool isSkipSettingCheck = false, bool isSkipGameValidCheck = false)
	{
		return false;
	}

	public void StopRecord(RecordStopStateEm result = RecordStopStateEm.Stop2Save)
	{
	}

	public void SaveRecord(ulong savedHighlightMatchId = 0uL)
	{
	}

	public void EndRecord()
	{
	}

	public void ModifyRecordingVideoPath(string filePath)
	{
	}

	public bool StopingRecordFinish(bool result, string message, out string filePath)
	{
		filePath = null;
		return false;
	}

	public void SaveingRecordFinish(bool result, string filePath)
	{
	}

	public void DeleteUnSaveVideo(ReplayKitVideoInfo info)
	{
	}

	public void DeleteCurrentVideo()
	{
	}

	public void DeleteVideo(ReplayKitVideoInfo info, bool isRecordReplayPreview = false)
	{
	}

	private void OnVideoDeleteCallback(bool result, string message)
	{
	}

	public void ClearWaitCallback()
	{
	}

	public void GetVideoThumbnail(ReplayKitVideoInfo info)
	{
	}

	private void OnThumbnailCallback(string input, string output)
	{
	}

	public void GetVideoInfo(ReplayKitVideoInfo info)
	{
	}

	private void OnVideoInfoCallback(string path, string size, string duration)
	{
	}

	public int SortVideoInfo(ReplayKitVideoInfo left, ReplayKitVideoInfo right)
	{
		return 0;
	}

	public void SetEnableReplaykitMicrophone(bool result)
	{
	}

	public void CheckVideoPermission(Action<bool> callback)
	{
	}

	private static string GetReplaykitDirectory()
	{
		return null;
	}

	public static string GetVideoDirectory()
	{
		return null;
	}

	private static string GetFileDirectory()
	{
		return null;
	}

	private static string GetBitmapDirectory()
	{
		return null;
	}

	public static string GetPath(string fileName)
	{
		return null;
	}

	public static string GetVideoPath(string time, string suffix = "", string format = ".mp4")
	{
		return null;
	}

	public static string GetAudioPath(string time, string suffix = "", string format = ".aac")
	{
		return null;
	}

	public static void RegisterMuxerAction(ReplayKitDelegates.OnVideoMuxerActionCallback callback)
	{
	}

	public static void UnregisterMuxerAction(ReplayKitDelegates.OnVideoMuxerActionCallback callback)
	{
	}

	public static void RegisterAudioEncodeAction(ReplayKitDelegates.OnAudioEncodeProgressCallback callback)
	{
	}

	public static void UnregisterAudioEncodeAction(ReplayKitDelegates.OnAudioEncodeProgressCallback callback)
	{
	}

	public static void Initialise()
	{
	}

	public static bool IsRecordingAPIAvailable()
	{
		return false;
	}

	public static bool IsExistVideo(string filePath)
	{
		return false;
	}

	public static void PrepareRecording()
	{
	}

	public static void StartRecordingInternal(string time, string video_path, string audio_path)
	{
	}

	public static void StopRecordingInternal(RecordStopStateEm result = RecordStopStateEm.Stop2Save)
	{
	}

	public static void EndRecordingInternal()
	{
	}

	public bool Discard(string filePath)
	{
		return false;
	}

	public static void SavePreviewInternal(string filename, string outputPath)
	{
	}

	public static void SetVideoQuality(VideoQuality quality)
	{
	}

	public static void GetVideoInfo(string filePath, ReplayKitDelegates.OnVideoInfoCallback callback)
	{
	}

	public static void DiscardVideo(string filePath, ReplayKitDelegates.OnRecordActionCallback callback = null)
	{
	}

	public static void PreviewVideo(string input, ReplayKitDelegates.OnRecordActionCallback callback = null)
	{
	}

	public static void PreviewVideoFinish()
	{
	}

	public static void GetThumbnail(string input, string output, ReplayKitDelegates.OnThumbnailCallback callback)
	{
	}

	public static void WriteAudio(float[] data, int channels)
	{
	}

	public static void WriteRecordoPauseTime(long microsecond)
	{
	}

	public static void SetAudio(string filePath, int sampleRate, int channels)
	{
	}

	private static void OnStartRecordCallback(bool result, string message)
	{
	}

	private static void OnStopRecordCallback(bool result, string message)
	{
	}

	private static void OnRecordAvailableCallback(bool result, string message)
	{
	}

	private static void OnSaveRecordCallback(bool result, string message)
	{
	}

	public static string GetCPUName()
	{
		return null;
	}

	public static string GetGPUName()
	{
		return null;
	}

	public static string ReplaceGPUName(string gpuName)
	{
		return null;
	}

	public void BeforeScreenshot()
	{
	}

	public void AfterScreenshot()
	{
	}

	private void _003COnVideoInfoCallback_003Eb__81_0()
	{
	}
}
