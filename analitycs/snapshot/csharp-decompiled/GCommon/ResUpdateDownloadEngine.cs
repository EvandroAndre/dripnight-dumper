using System;
using System.Collections.Generic;
using System.Threading;
using COW;
using TsiU;

namespace GCommon;

public class ResUpdateDownloadEngine : TSingleton<ResUpdateDownloadEngine>
{
	public enum VersionCheckState
	{
		None,
		Start,
		End
	}

	public Dictionary<uint, string> VersionMap;

	public Dictionary<uint, string[]> LoginDownloadMap;

	private Dictionary<string, uint> m_FileNameMap;

	private Dictionary<string, ResVersionInfo.FileInfo> m_IndexFileinfoMap;

	private Dictionary<uint, ResUpdateDownloadContext> m_DownloadContextMap;

	private LinkedList<ResUpdateDownloadContext> m_PendingDownloadContext;

	private LinkedList<ResUpdateDownloadContext> m_PendingDownloadInGameContext;

	private bool m_UpdateDownloadInSys;

	private Thread m_DownloadBackgroundThread;

	public Action<ResUpdateDownloadContext, ResErrorCode, bool> PendingContextChangeNotify;

	private Dictionary<ResVersionInfo.FileInfo, ResFileLoader> m_LoaderInfoMap;

	private ResHotUpdaterContext _003CHotUpdaterContext_003Ek__BackingField;

	private string _003CCDNAddr_003Ek__BackingField;

	private bool _003CEnableBackgroundDownload_003Ek__BackingField;

	private bool _003CCahcedBackgroundFlag_003Ek__BackingField;

	public Action BackgroundDownloadStart;

	public Action<ResDownloadType, ResErrorCode> BackgroundDownloadFinishedCallback;

	public int UnZipBuffSize;

	public bool OptimizeUnzipLoaderRead;

	public bool NeedInitFileLength;

	public int MultiDownloadGCIndex;

	public bool EnableClearMemWhenAutoPause;

	public bool EnableRepairHashCheck;

	public bool EnablelABFileFindOptimize;

	private const int BASE_UNZIP_SIZE = 102400;

	private int m_BackgroundThreadSleepTime;

	private bool m_SkipVersionCheck;

	private bool m_SaveFileInfosWithoutFiles;

	public bool EtcButAstcAb;

	public bool NeedRepairToETC;

	private List<EventLogger.FileInfoEncryptResult> m_DecryptResults;

	private List<EventLogger.FileInfoEncryptResult> m_EncryptResults;

	private bool m_FileInfoEncryptLogReady;

	public bool EnableVersionCheckRowUpdate;

	public static string UsedAstcAbOnEtc;

	public string PersistentDataPath;

	public bool EnableReuseMemUseMap;

	private bool m_ContextMapInited;

	private bool m_EnableBackGroundOptimize;

	private DateTime m_StartTime;

	private bool m_NeedClearBuff;

	private bool m_OnApplicationPuased;

	private VersionCheckState m_VersionCheckState;

	private ResErrorCode m_VersionCheckErrorCode;

	private bool m_VersionRepairSuccess;

	private List<ResUpdateDownloadContext> m_VersionCheckTasks;

	private List<ResUpdateDownloadContext> m_VersionCheckTasksNeedRemove;

	private Action<ResErrorCode> m_FinishedCallBack;

	private ResVersionInfo.FileInfo m_RunningFileinfo;

	private ResVersionInfo.FileInfo m_RuningInGameFileinfo;

	private HashSet<ResVersionInfo.FileInfo> m_InPendingFileinfo;

	private HashSet<ResVersionInfo.FileInfo> m_InPendingInGameFileinfo;

	private ResUpdateDownloadContext m_RunningContext;

	private ResUpdateDownloadContext m_RunningContextInGame;

	private List<ResVersionInfo.FileInfo> m_FileinfosNeedAddToDownload;

	private List<ResVersionInfo.FileInfo> m_FileinfosNeedAddToDownloadInGame;

	private List<ResVersionInfo.FileInfo> m_FileinfosNeedRemoveFromDownload;

	private List<ResVersionInfo.FileInfo> m_FileinfosNeedDelete;

	private List<ResUpdateDownloadContext> m_NeedRemoveFromPendingContext;

	private Dictionary<uint, List<string>> m_TransferMainToBackThreadNeedAddToDownloadDict;

	private Dictionary<uint, List<string>> m_TransferMainToBackThreadFileinfossNeedRemoveFromDownloadDict;

	private Dictionary<uint, List<string>> m_TransferMainToBackThreadFileinfosNeedDeleteDict;

	private List<ResUpdateDownloadContext> m_TransferMainToBackThreadNeedRemoveFromPendingContext;

	private Action<ResErrorCode, ResDownloadType> m_DownloadFinishedCallBack;

	private ResUpdateDownloadContext.SingleFileFinishedCallBack m_SingleFileDownloadFinishedCallBack;

	private bool m_DownloadInGameres;

	private uint m_DeletedTag;

	private uint m_RunningTag;

	private Action<ResDownloadType, List<string>, uint> m_DeletedCallBack;

	private bool m_MutiledThreadPaused;

	private bool m_MutiledThreadManualPaused;

	private bool m_MutiledThreadNeedAutoResume;

	private static bool s_MergeGcCalls;

	private static bool s_PendingGcCall;

	private int m_TotalNeedCheckTypeCount;

	private int m_HaveCheckedTypeCount;

	private Dictionary<string, List<string>> m_ABPathStringListDict;

	private List<uint> m_ForceRefreshResType;

	private List<ResVersionInfo.FileInfo> m_TempRealNeedCheckSizeFileList;

	private List<string> m_LoginFileInfoName;

	public ResHotUpdaterContext HotUpdaterContext
	{
		get
		{
			return _003CHotUpdaterContext_003Ek__BackingField;
		}
		private set
		{
			_003CHotUpdaterContext_003Ek__BackingField = value;
		}
	}

	public string CDNAddr
	{
		get
		{
			return _003CCDNAddr_003Ek__BackingField;
		}
		set
		{
			_003CCDNAddr_003Ek__BackingField = value;
		}
	}

	public bool EnableBackgroundDownload
	{
		get
		{
			return _003CEnableBackgroundDownload_003Ek__BackingField;
		}
		set
		{
			_003CEnableBackgroundDownload_003Ek__BackingField = value;
		}
	}

	public bool CahcedBackgroundFlag
	{
		get
		{
			return _003CCahcedBackgroundFlag_003Ek__BackingField;
		}
		set
		{
			_003CCahcedBackgroundFlag_003Ek__BackingField = value;
		}
	}

	public string PlatformIdentifierForOptionals => null;

	public void AddFileInfoEncryptResult(bool isEncrypt, int resDownloadType, int errCode, int version)
	{
	}

	public void SendFileInfoEncryptLog()
	{
	}

	public void Init(ResHotUpdaterContext updater_context, int multi_download_gc_index, bool need_init_file_length, int backgroundSleepTime = 10, bool skipVersion = false, bool saveFilesState = false)
	{
	}

	public void InitContextMap(ResHotUpdaterContext updater_context)
	{
	}

	public void InitGameVar(bool enableAstcAbForEtc = true, bool enabelRepairHashCheck = true, bool enableFileFindOptimize = false, bool enableVersionCheckRowErrorUpdate = false, bool reuseMemUseMap = true, bool optimizeUnziploaderRead = false, bool enableBackGroundOptimize = false)
	{
	}

	public bool IsASTCSupport()
	{
		return false;
	}

	public void StartBackGroundThread()
	{
	}

	public void StopBackGroundThread()
	{
	}

	public void BackgroundThread()
	{
	}

	private void DisposeAllContextLoader()
	{
	}

	public void SetVersionMap(Dictionary<uint, string> version_map)
	{
	}

	public void RefreshVersionMap(uint downloadType, string remoteVersion)
	{
	}

	public void SetLoginDownloadPackMap(Dictionary<uint, string[]> login_download_map)
	{
	}

	public void SetSpeedScale(float speed_scale)
	{
	}

	public bool AddToPendingDownload(ResUpdateDownloadContext context, bool isAddFirst = false)
	{
		return false;
	}

	public void PauseDownloadByType(ResDownloadType type, bool isPause, bool need_auto_resume = false)
	{
	}

	public void PauseDownloadByTypeList(List<uint> typeList, bool isPause, bool need_auto_resume = false, bool manualPuse = false, bool InGameDownloadNeedStart = false)
	{
	}

	public void PauseDownloadByType(ResUpdateDownloadContext context, bool isPause, bool need_auto_resume = false, bool manualPause = false, bool InGameDownloadNeedStart = false)
	{
	}

	public ResUpdateDownloadContext GetRunningDownloadContext()
	{
		return null;
	}

	public ResUpdateDownloadContext GetRunningInGameDownloadContext()
	{
		return null;
	}

	private void RefreshRunningContextInGame()
	{
	}

	public bool IsInPendingDownloadContext(ResUpdateDownloadContext context)
	{
		return false;
	}

	public ResUpdateDownloadContext GetDownloadContextByType(ResDownloadType type, string param = "")
	{
		return null;
	}

	public ResUpdateDownloadContext GetDownloadContextByFileName(string fileName)
	{
		return null;
	}

	public void StartGetLocalVersionInfo(List<uint> type_list, Action<ResErrorCode> finished_callback, bool parellelForEach = false)
	{
	}

	public void Update(float time)
	{
	}

	public void ChangeUpdateDownloadState(bool downloadInSys = true)
	{
	}

	public bool AddToInGamePending(ResUpdateDownloadContext context, bool isAddFirst = false)
	{
		return false;
	}

	public void RegistFileNameToEngine(string full_name, ResDownloadType type)
	{
	}

	public void RegisterFileIndexToEngine(string abIdex, ResVersionInfo.FileInfo fileInfo)
	{
	}

	public ResDownloadType GetDownloadTypeByFileName(string full_name)
	{
		return ResDownloadType.None;
	}

	public string GetLocalPathByPlatfrom(string full_name)
	{
		return null;
	}

	public ResVersionInfo.FileInfo GetLocalFileInfo(string full_name)
	{
		return null;
	}

	public ResVersionInfo.FileInfo GetLocalFileInfoWithContext(string full_name, out ResUpdateDownloadContext download_context)
	{
		download_context = null;
		return null;
	}

	public ResVersionInfo.FileInfo GetLocalFileInfoByAbIndex(string abIdex)
	{
		return null;
	}

	public void DeleteFilesByDownloadType(ResDownloadType type)
	{
	}

	public void RemoveFromPending(ResUpdateDownloadContext context)
	{
	}

	public void OnApplicationPaused(bool is_paused)
	{
	}

	public bool GetApplicationPuasedState()
	{
		return false;
	}

	public bool RegisterLoader(ResVersionInfo.FileInfo fileInfo, ResFileLoader loader)
	{
		return false;
	}

	public ResFileLoader GetLoaderByFileInfo(ResVersionInfo.FileInfo info)
	{
		return null;
	}

	public void UnRegisterLoader(ResVersionInfo.FileInfo fileInfo)
	{
	}

	public long FileDownloadedAndZipSize(ResVersionInfo.FileInfo fileInfo)
	{
		return 0L;
	}

	public long FileNeedDownloadAndZipSize(ResVersionInfo.FileInfo fileInfo)
	{
		return 0L;
	}

	public long FileNeedDownloadSize(ResVersionInfo.FileInfo fileInfo)
	{
		return 0L;
	}

	public float DownloadedSizeInfo(List<ResVersionInfo.FileInfo> fileInfos, out float estimateRemainDownloadSize, out long totalNeedDownloadSize)
	{
		estimateRemainDownloadSize = default(float);
		totalNeedDownloadSize = default(long);
		return 0f;
	}

	public void OnApplicationQuit()
	{
	}

	public void InitFileIsOldResource(List<string> ab_Name_List)
	{
	}

	public void UnRegisterInGameDownloadRes()
	{
	}

	public void InvokeBackgroundDownloadFinishedCallBack(ResDownloadType type, ResErrorCode error)
	{
	}

	public void StartTask()
	{
	}

	public VersionCheckState GetVersionCheckState()
	{
		return VersionCheckState.None;
	}

	public void InitVersionCheckDownloadType(List<uint> resTypeList, Action<ResErrorCode> finishedCallBack, bool parellelForEach = false)
	{
	}

	public void StopVersionCheckState()
	{
	}

	public void UpdateForVersionCheckQuick()
	{
	}

	public void UpdateForVersionCheck()
	{
	}

	private void UpdateVersionCheckErrorCode(ResErrorCode error)
	{
	}

	private void UpdateRefresThreadTransferContent(bool isBackground = false)
	{
	}

	private void RefreshDownloadingInGameFileinfoContent()
	{
	}

	private void RefreshDownloadingFileinfoContent()
	{
	}

	private void RefreshInPendingInGameFileinfosContent()
	{
	}

	private void RefreshInPendingFileinfosContent()
	{
	}

	public bool IsFileInfoDownloading(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public bool IsFileInfoInGameDownloading(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public bool IsFileInfoInPendingInGame(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public bool IsFileInfoInPending(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public void StartDownloadMutileFileInfo(List<ResVersionInfo.FileInfo> needDownloadFiles, bool isPriorityMode = false)
	{
	}

	public void StartDownloadMutileFileinfoInGame(List<ResVersionInfo.FileInfo> needDownloadFileInGameRes)
	{
	}

	public void PauseDownloadMutileFileinfo(List<ResVersionInfo.FileInfo> needPauseFiles)
	{
	}

	public void DeleteMutileFileinfo(List<ResVersionInfo.FileInfo> needDeleteFiles, uint deleted_tag, uint running_tag = 0u)
	{
	}

	private void UpdateFileinfoDownload()
	{
	}

	private void UpdateContextRemoveFromPending()
	{
	}

	private void UpdateFileinfoPauseDownload()
	{
	}

	public static void GcCollect()
	{
	}

	private void UpdateFileDelete()
	{
	}

	private void UpdateAddFileInfo()
	{
	}

	public void SetDownloadFinishedCallBack(Action<ResErrorCode, ResDownloadType> finishedCallBack)
	{
	}

	public void SetSingleDownloadFinishedCallBack(ResUpdateDownloadContext.SingleFileFinishedCallBack callBack)
	{
	}

	public void SetDeleteResFileCallBack(Action<ResDownloadType, List<string>, uint> deletedCallBack)
	{
	}

	public void RepairTargetLocalVersionInfo(List<uint> typeList, Action<ResErrorCode> finishedCallBack)
	{
	}

	private void DisposeAllLoaderInCache()
	{
	}

	public void ClearHaveCheckedTypeCount()
	{
	}

	public float GetVersionRepairProgress()
	{
		return 0f;
	}

	public bool CheckVersionRepairSuccess()
	{
		return false;
	}

	public void RegisterABFileResPathStringMapping(string abFileName, string resAbPath)
	{
	}

	public void ReleaseLoadedFilePathRes(List<string> needReleaseFile)
	{
	}

	public List<string> GetLoadedAbPathList()
	{
		return null;
	}

	public void RegisterStreamingFileinfo(ResHotUpdater.LocalStreamFileInfo fileInfo)
	{
	}

	public void RegisterForceRefreshResType(List<uint> resType)
	{
	}

	public bool CheckFileNeedForceRefresh(ResDownloadType resType)
	{
		return false;
	}

	public void GetAllShowDownloadTypeFileDownloadedSize(List<uint> downloadTypeList, out float downloadedSize)
	{
		downloadedSize = default(float);
	}

	public void GetFileInfoDownloadedSizeWithoutLoginDownload(List<ResVersionInfo.FileInfo> fileinfoList, out float downloadedSize)
	{
		downloadedSize = default(float);
	}

	public void RegisterLoginFileName(string fileinfoName)
	{
	}

	public bool CheckFileInfoIsInLoginDownload(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	private void _003CInitVersionCheckDownloadType_003Eb__115_0(uint resType)
	{
	}
}
