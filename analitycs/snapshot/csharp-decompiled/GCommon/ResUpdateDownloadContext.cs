using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

public class ResUpdateDownloadContext : DownloadContext
{
	public delegate void SingleFileFinishedCallBack(ResErrorCode error_code, ResDownloadType type, ResVersionInfo.FileInfo file_info, bool is_from_background);

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public string fileName;

		internal bool _003CDeleteTempFiles_003Eb__0(ResVersionInfo.FileInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public string fileName;

		internal bool _003CDeleteFilesCache_003Eb__0(ResVersionInfo.FileInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass163_0
	{
		public ResUpdateDownloadContext _003C_003E4__this;

		public Action onHashCheckFinished;

		internal void _003CRefreshFileinfoFileStateAfterVersionCheck_003Eb__0(string hashCode, ResHashFileLoader hash_loader)
		{
		}

		internal void _003CRefreshFileinfoFileStateAfterVersionCheck_003Eb__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	public int MaxOptionalDownloadThreadCount;

	public int MultiDownloadGCIndex;

	public int MaxRetryCount;

	public string RemoteAddr;

	public string AstcRemoteAddr;

	public string LocalAddr;

	public string TempCacheAddr;

	public string VersionInfoPath;

	public string FileInfoPath;

	public string AssetBundlePrefix;

	public bool SingleFileDownloadFinished;

	protected EVersionCheckState m_VersionCheckState;

	protected Action<ResDownloadType> m_OnVersionCheckFinished;

	private SingleFileFinishedCallBack m_SingleFileFinishedCallBack;

	private SingleFileFinishedCallBack m_FileFinishedNotify;

	public List<ResVersionInfo.FileInfo> m_NeedRetryFileInfo;

	protected Dictionary<uint, List<ResVersionInfo.FileInfo>> m_TagFilesMap;

	private Dictionary<uint, int> m_TagDownloadStateMap;

	private string _003CCacheAddr_003Ek__BackingField;

	private string _003COldVersionCacheAddr_003Ek__BackingField;

	private bool _003CNeedDownload_003Ek__BackingField;

	private bool _003CNeedCheckVersion_003Ek__BackingField;

	private bool _003CRunningCheckVersion_003Ek__BackingField;

	private long _003CDownloadedSize_003Ek__BackingField;

	private long _003CTotalZipSize_003Ek__BackingField;

	private long _003CTotalSize_003Ek__BackingField;

	private bool _003CNeedContinueWithDownloadAll_003Ek__BackingField;

	public long m_StartDownloadSize;

	private EDownloadContextMode _003CDownloadMode_003Ek__BackingField;

	public List<ResVersionInfo.FileInfo> LastInDownloadFileList;

	public EVersionUpdateReason HaveVersionUpdate;

	public bool NeedSkipVersion;

	public bool NeedAutoResume;

	public Action<ResDownloadType, ResErrorCode> BackGroundDownloadFinished;

	protected HashSet<ResVersionInfo.FileInfo> m_DownloadingFileList;

	protected Dictionary<ResVersionInfo.FileInfo, ResLoaderInfo> m_LoaderInfoMap;

	protected DownloadVersionInfo m_LocalVersionInfo;

	protected DownloadVersionInfo m_RemoteVersionInfo;

	protected Dictionary<string, ResVersionInfo.FileInfo> m_RepairFileInfos;

	protected bool RepairedToETC;

	protected ResUpdateDownloadEngine m_OwnedEngine;

	protected bool m_NeedCheckFileState;

	protected List<string> m_NeedRemoveFilePathes;

	protected int m_MaxLoaderCount;

	protected bool m_ShouldOverrideWithFull;

	protected bool m_ShoulClearMemWhenAutoPause;

	protected bool m_SaveFileStateWithoutFiles;

	protected bool m_EnableRepairHashCheck;

	protected bool m_EnableABFileFindOptimize;

	private bool m_RepairErrorFileinfo;

	private bool m_NeedRecoverFromEncryption;

	protected List<string> m_LoginDownloadFileName;

	private List<ResVersionInfo.FileInfo> m_LoginDownloadFileInfo;

	public List<ResVersionInfo.FileInfo> NeedRetryFileInfo => null;

	public bool IsPendding => false;

	public bool IsIngamePendding => false;

	public string CacheAddr
	{
		get
		{
			return _003CCacheAddr_003Ek__BackingField;
		}
		protected set
		{
			_003CCacheAddr_003Ek__BackingField = value;
		}
	}

	public string OldVersionCacheAddr
	{
		get
		{
			return _003COldVersionCacheAddr_003Ek__BackingField;
		}
		protected set
		{
			_003COldVersionCacheAddr_003Ek__BackingField = value;
		}
	}

	public bool NeedDownload
	{
		get
		{
			return _003CNeedDownload_003Ek__BackingField;
		}
		protected set
		{
			_003CNeedDownload_003Ek__BackingField = value;
		}
	}

	public bool NeedCheckVersion
	{
		get
		{
			return _003CNeedCheckVersion_003Ek__BackingField;
		}
		protected set
		{
			_003CNeedCheckVersion_003Ek__BackingField = value;
		}
	}

	public bool RunningCheckVersion
	{
		get
		{
			return _003CRunningCheckVersion_003Ek__BackingField;
		}
		protected set
		{
			_003CRunningCheckVersion_003Ek__BackingField = value;
		}
	}

	public long DownloadedSize
	{
		get
		{
			return _003CDownloadedSize_003Ek__BackingField;
		}
		protected set
		{
			_003CDownloadedSize_003Ek__BackingField = value;
		}
	}

	public long TotalZipSize
	{
		get
		{
			return _003CTotalZipSize_003Ek__BackingField;
		}
		protected set
		{
			_003CTotalZipSize_003Ek__BackingField = value;
		}
	}

	public long TotalSize
	{
		get
		{
			return _003CTotalSize_003Ek__BackingField;
		}
		protected set
		{
			_003CTotalSize_003Ek__BackingField = value;
		}
	}

	public bool NeedContinueWithDownloadAll
	{
		get
		{
			return _003CNeedContinueWithDownloadAll_003Ek__BackingField;
		}
		private set
		{
			_003CNeedContinueWithDownloadAll_003Ek__BackingField = value;
		}
	}

	public EDownloadContextMode DownloadMode
	{
		get
		{
			return _003CDownloadMode_003Ek__BackingField;
		}
		protected set
		{
			_003CDownloadMode_003Ek__BackingField = value;
		}
	}

	public virtual bool SupportBackgroundDownload => false;

	public string Version => null;

	public uint VersionID => 0u;

	public bool NeedRecoverFromEncryptionPerContext
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EVersionCheckState GetVersionCheckState()
	{
		return EVersionCheckState.None;
	}

	public void SetVersionCheckState(EVersionCheckState state)
	{
	}

	public ResUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously, bool saveFileVersionWithoutFiles = false)
		: base(ResDownloadType.None, 0)
	{
	}

	public override void Clear()
	{
	}

	public void WWWLoad(string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, ResVersionInfo.FileInfo file_info = null)
	{
	}

	public virtual void BigFileDownload(ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool addLoaderFirst = false)
	{
	}

	public void Unzip(ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false, bool isBackGroundLoaderDownloadFinished = false)
	{
	}

	public virtual string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState, bool need_cache = true)
	{
		return null;
	}

	protected bool SaveFile(string path, byte[] content)
	{
		return false;
	}

	protected bool MoveTempFile(string relativePath, string tempPath)
	{
		return false;
	}

	protected void ClearTempFile(string tempPath, string flagPath = null)
	{
	}

	public void ClearAllTempFile()
	{
	}

	private void DeleteTempFiles(List<ResVersionInfo.FileInfo> fileInfos)
	{
	}

	public void CleanCache()
	{
	}

	protected virtual void DeleteFilesCache(List<ResVersionInfo.FileInfo> needDeleteFiles)
	{
	}

	public void CleanFiltCache()
	{
	}

	public void CleanCache(string file_name)
	{
	}

	public List<ResVersionInfo.FileInfo> CheckFilesInDownloading(List<ResVersionInfo.FileInfo> fileList)
	{
		return null;
	}

	public void PauseDownloadFile(List<string> fileNames)
	{
	}

	public void DeleteFiles(List<string> fileNames, uint deleted_tag, uint m_runningTag = 0u)
	{
	}

	public void ClearFileState(List<string> fileinfoNames)
	{
	}

	protected virtual void SaveLocalVersionInfo()
	{
	}

	public virtual void DeleteAllFile()
	{
	}

	public void RepairContextFileInfoAndVersionInfo()
	{
	}

	public void InitContextForMapUpdate()
	{
	}

	public void DeleleAllReplacedFiles()
	{
	}

	public override void StartDownload(Action<ResErrorCode, ResDownloadType> callback = null)
	{
	}

	public void StartDownload(bool need_add_first, Action<ResErrorCode, ResDownloadType> callback = null)
	{
	}

	public void StartDownloadAllFile(Action<ResErrorCode, ResDownloadType> callback, SingleFileFinishedCallBack file_downloaded_notify = null, bool isBackgroundThread = false)
	{
	}

	public void StartDownloadFile(List<string> download_file_names, Action<ResErrorCode, ResDownloadType> callback, SingleFileFinishedCallBack file_downloaded_notify = null, bool isBackgroundThread = false, bool isDownloadInGame = false, bool addFirst = false)
	{
	}

	public void PauseAndRemoveAllLoader()
	{
	}

	public void RegisterSteamingFileToLocal(ResHotUpdater.LocalStreamFileInfo streamingfileInfo)
	{
	}

	public override void PauseDownload(bool isPause, bool is_auto_pause = false)
	{
	}

	public List<ResVersionInfo.FileInfo> GetAllFileInfos()
	{
		return null;
	}

	public void SaveFileinfo()
	{
	}

	private void StartDownloadInGame(bool addFirst = false)
	{
	}

	public virtual void InitLocalFileInfoState()
	{
	}

	public bool InitLocalFileInfoStateWithNoCheck()
	{
		return false;
	}

	public virtual void StartGetLocalVersion(Action<ResDownloadType> on_version_check_finished = null)
	{
	}

	protected virtual void InitLoginDownloadFileinfo()
	{
	}

	public bool CheckFileInLoginDownload(string fileInfoName)
	{
		return false;
	}

	protected virtual void onLocalVersionInfoLoaded(bool result)
	{
	}

	public virtual void StartVersionCheck()
	{
	}

	protected virtual void onRemoteVersionInfoLoaded(bool result)
	{
	}

	private void VersionPass()
	{
	}

	private bool CanStartAstcCheck()
	{
		return false;
	}

	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	protected void onLocalFileInfoLoaded_Update(bool result)
	{
	}

	protected virtual void onRemoteFileInfoLoaded(bool result)
	{
	}

	protected virtual void UpdateLocalFileInfos(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	private void RemoveTempFile(ResVersionInfo.FileInfo localFileInfo)
	{
	}

	private void AfterUpdateLocalFileInfo()
	{
	}

	private void UpdateLocalFileInfosETC(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	private void UpdateLocalFileInfosASTC(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	protected virtual void OnRemoteFileInfoLoadedForRepair(bool result)
	{
	}

	private void AfterRepairFileinfoVersionCheck()
	{
	}

	private void AfterRepairFileInfo()
	{
	}

	private void RepairFileInfo(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	private void RepairFileInfoETC(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	private void RepairFileInfoASTC(Dictionary<string, ResVersionInfo.FileInfo> remote_fileinfos, Dictionary<string, ResVersionInfo.FileInfo> local_fileinfos)
	{
	}

	protected virtual void onVersionChecked()
	{
	}

	private void RegisterFileInfoAndIndexToEngine()
	{
	}

	public void CheckFileStates()
	{
	}

	protected void RegisterFileToEngine()
	{
	}

	public void CheckNeedDownload(bool refresh_last_download = false)
	{
	}

	private void UpdateNeedDownloadSize(ResVersionInfo.FileInfo fileInfo = null, bool is_unzip = false)
	{
	}

	private void RefreshFileinfoFileStateAfterVersionCheck(Dictionary<string, ResVersionInfo.FileInfo> remote_files, Dictionary<string, ResVersionInfo.FileInfo> local_files, Action onHashCheckFinished = null)
	{
	}

	public void HashFile(ResVersionInfo.FileInfo file_info, ResVersionInfo.FileInfo.OpState needCheckState, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	private void NotifyFileHashed(string hash_code, ResHashFileLoader hashFileLoader)
	{
	}

	protected void NotifyFileDownloaded(ResErrorCode result, ResFileLoader loader)
	{
	}

	protected void NotifyFileUnZipped(string hash_code, ResUnzipFileLoader unzip_loader)
	{
	}

	public ResVersionInfo.FileInfo GetCurrentDownloadFileInfo()
	{
		return null;
	}

	public void UpdateLastError(ResErrorCode error)
	{
	}

	public ResErrorCode GetDetailedDownloadError(string error)
	{
		return ResErrorCode.OK;
	}

	public virtual ResVersionInfo.FileInfo GetLocalFileInfo(string path, bool exceptLoginFile = false, bool isForDeleteCase = false)
	{
		return null;
	}

	public bool FileExist(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public string GetLocalPathByPlatfrom(string path)
	{
		return null;
	}

	public override void InvokeFinishCallBack()
	{
	}

	protected bool HaveEnoughStorage(long require_size)
	{
		return false;
	}

	public ResLoaderInfo GetLoaderByFileInfo(ResVersionInfo.FileInfo info)
	{
		return null;
	}

	public HashSet<ResVersionInfo.FileInfo> GetReadyForDownloadingFileinfos()
	{
		return null;
	}

	public long GetTotalSizeInByte()
	{
		return 0L;
	}

	public long GetTotalLoadedSizeInByte()
	{
		return 0L;
	}

	public virtual float GetFileDownloadProcess()
	{
		return 0f;
	}

	public void AddTagFilesPair(uint tag, List<ResVersionInfo.FileInfo> fileInfoList, bool isRecommend = false)
	{
	}

	public void AddTagFilesPair(uint tag, ResVersionInfo.FileInfo fileInfo, bool isRecommend = false)
	{
	}

	public void RemoveTagFilePair(uint tag, ResVersionInfo.FileInfo fileInfo)
	{
	}

	public void ClearFileInfoInTagFileMaps(IEnumerable<ResVersionInfo.FileInfo> fileInfos, uint tag)
	{
	}

	public List<uint> GetTagListByModeAllFile()
	{
		return null;
	}

	public bool AddTagDownloadStatePair(uint tag, EDownloadContextMode eDownloadContextState = EDownloadContextMode.DesignatedFile)
	{
		return false;
	}

	public void RemoveTagDownloadStatePair(uint tag)
	{
	}

	public List<ResVersionInfo.FileInfo> FileInfosByTag(uint tag)
	{
		return null;
	}

	public float GetTagFileDownloadedSize(uint tag)
	{
		return 0f;
	}

	public bool IsTagContainRecommendFile(uint tag)
	{
		return false;
	}

	public long GetTotalTagZipSize(uint tag, ref bool isRecommend, ref long TotalOutSize)
	{
		return 0L;
	}

	public bool GetTagFileDownloadState(uint tag)
	{
		return false;
	}

	public void ClearFileTagTable(uint tag)
	{
	}

	protected virtual string GetFileRelativePath(ResVersionInfo.FileInfo fileInfo)
	{
		return null;
	}

	public void StartDownloadLoginFile(Action<ResErrorCode, ResDownloadType> call_back)
	{
	}

	private void _003CStartDownloadFile_003Eb__126_0(UnityWebRequest www, ResWithTempFileLoader loader)
	{
	}

	private void _003CStartDownloadFile_003Eb__126_1(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}

	private void _003CNotifyFileDownloaded_003Eb__166_0(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}
}
