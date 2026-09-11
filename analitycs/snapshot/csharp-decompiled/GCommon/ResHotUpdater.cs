using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;
using tcp;

namespace GCommon;

public class ResHotUpdater : TSingleton<ResHotUpdater>
{
	public class LocalStreamFileInfo : ResVersionInfo.FileInfo
	{
		public string LocalPath;
	}

	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public DownloadContext context;

		public ResHotUpdater _003C_003E4__this;

		internal void _003CCheckNeedDownloadByType_003Eb__0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass167_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext context;

		internal void _003CNotifyFileDownloaded_003Eb__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext context;

		public ResVersionInfo.FileInfo fi;

		public Action<string, ResUnzipFileLoader> onUnzipped;

		internal void _003CCheckCopyAndUnzipDesignatedFile_003Eb__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		internal void _003CCheckCopyAndUnzipDesignatedFile_003Eb__1(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext context;

		public Action<ResErrorCode, ResDownloadType> finished_callback;

		internal void _003CCheckHashFile_003Eb__0(string hashCode, ResHashFileLoader hash_loader)
		{
		}

		internal void _003CCheckHashFile_003Eb__1(ResErrorCode error_code, ResDownloadType download_type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext context;

		internal void _003CCheckCopyAndUnzipFile_003Eb__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		internal void _003CCheckCopyAndUnzipFile_003Eb__1(string hashCode, ResHashFileLoader hash_loader)
		{
		}

		internal void _003CCheckCopyAndUnzipFile_003Eb__2(string hashCode, ResHashFileLoader hash_loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass175_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext context;

		public ResVersionInfo.FileInfo fi;

		public Action<string, ResUnzipFileLoader> onUnzipLoaded;

		internal void _003CLoadLocalAPKFile_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext download_context;

		internal void _003CLoadStreamingOptional_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass193_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext download_context;
	}

	private sealed class _003C_003Ec__DisplayClass193_1
	{
		public LocalStreamFileInfo streamfileinfo;

		public _003C_003Ec__DisplayClass193_0 CS_0024_003C_003E8__locals1;

		internal void _003CCopyStreamingOptional_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass203_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext download_context;

		internal void _003CMoveStreamingIconIntoCache_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass206_0
	{
		public ResHotUpdater _003C_003E4__this;

		public DownloadContext download_context;
	}

	private sealed class _003C_003Ec__DisplayClass206_1
	{
		public string iconName;

		public _003C_003Ec__DisplayClass206_0 CS_0024_003C_003E8__locals1;

		internal void _003CCopyStreamingIconCDN_003Eb__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	public static bool VersionToolsCompressCompulsoryAb;

	public static bool SaveUnCompressedCompulsoryAbToPersistDir;

	public static bool LoadLocalCompulsoryAbFromStreamDir;

	public const string CHECK_PD_CACHE_FILE_KEY = "CHECK_PD_CACHE_FILE";

	public const string PD_CACHE_FAILED_TIMES = "PD_CACHE_INIT_FAILED_TIMES";

	public const int PD_CACHE_FAILED_MAX_TIMES = 3;

	private ResHotUpdaterContext m_Context;

	private ResVersionInfo m_LocalVersionInfo;

	private ResVersionInfo m_RemoteVersionInfo;

	private Dictionary<uint, DownloadContext> m_DownloadContextMap;

	private LinkedList<DownloadContext> m_PendingDownloadContext;

	private ResErrorCode m_LastError;

	private string _003CFakeVersion_003Ek__BackingField;

	public string VersionCode;

	private string _003COriginalVersion_003Ek__BackingField;

	private bool _003CNeedUpdate_003Ek__BackingField;

	public int FileCount;

	public List<string> FileException;

	public string FileSimple;

	public string FileHash;

	public bool EnableUnzipLoaderReadOptimize;

	public bool EnableResVersionInfoSaveFileOptimize;

	public const string StreamOptionalPath = "streaming";

	public const string StreamFilePath = "streaming/fileinfo";

	public const string StreamOptionalStr = "optionalabs/";

	public const string StreamLoadSuccessPath = "contentcache/Optional/StreamOptional";

	public bool ShouldCheckABLoad;

	public bool ShouldCheckABExist;

	public bool ShouldCheckABSize;

	public bool ForceGetRemoteFileinfo;

	public string ShowCheckAbHotupdateHash;

	private List<string> m_NeedHashCheckFiles;

	private FileStream m_ABLoadRecordFile;

	private StreamWriter m_ABLoadRecordWriter;

	private HashSet<string> m_ABLoadRecordedPathes;

	private StringBuilder m_ABRecordPathCache;

	private const string ABLOADRECORD_FILEPATH = "contentcache/Optional/ABRecorder";

	private const string ExtraSoFilePath = "/font/";

	private HashSet<string> m_FileHashCodeSet;

	private float NextCheckTime;

	private bool useMultiThreadHash;

	private bool m_ContextInfoInited;

	private bool m_ClearFileInUpdateMajorVersion;

	private bool m_CopyAndUnzipProtect;

	private bool m_EnableDownloadVersionLocalFileinfoOptimize;

	private bool m_EnableDownloadVersionLoadLocalFileInfoOnce;

	public static List<uint> NeedCheckMapId;

	private List<MapVersionInfo> m_MapVersionInfo;

	private bool m_HaveInitMapVersionInfo;

	private static Dictionary<uint, int[]> ResDownloadTypeArray;

	protected bool m_InitFileInfoParseOptimize;

	protected bool m_EnableFileinfoParseOtimize;

	private string[] m_ggpSoPaths;

	private Dictionary<string, LocalStreamFileInfo> m_LocalStreamingFilesPathDict;

	private Dictionary<string, string> m_OptionalAbPathInfo;

	private uint m_finishedMoveFileCount;

	private const string LauncherLoadingIconCDNMove = "LauncherLoadingIconCDNMove";

	public uint MaxRetryCount;

	private const string IconCDNRelativePathInfo = "/IconCDNInfo";

	private List<string> m_InStreamingIconName;

	public ResHotUpdaterContext Context => null;

	public ResErrorCode LastError => ResErrorCode.OK;

	public string FakeVersion
	{
		get
		{
			return _003CFakeVersion_003Ek__BackingField;
		}
		set
		{
			_003CFakeVersion_003Ek__BackingField = value;
		}
	}

	public string Version => null;

	public uint MajorVersion => 0u;

	public string OptionalVersion => null;

	public string PlatformIdentifier => null;

	public string RemotePlatform => null;

	public string ReleaseChannel => null;

	public string AssetBundleManifestPath => null;

	public string OriginalVersion
	{
		get
		{
			return _003COriginalVersion_003Ek__BackingField;
		}
		private set
		{
			_003COriginalVersion_003Ek__BackingField = value;
		}
	}

	public bool NeedUpdate
	{
		get
		{
			return _003CNeedUpdate_003Ek__BackingField;
		}
		private set
		{
			_003CNeedUpdate_003Ek__BackingField = value;
		}
	}

	public bool EnableDownloadVersionLocalFileinfoOptimize => false;

	public bool EnableDownloadVersionLoadLocalFileInfoOnce => false;

	public HashSet<string> FileHashCodeSet => null;

	public bool ContextInfoInited => false;

	public void SetLastError(DownloadContext context, ResErrorCode error)
	{
	}

	public void Init(ResHotUpdaterContext context)
	{
	}

	public void InitContextInfo(ResHotUpdaterContext context)
	{
	}

	public DownloadContext GetDownloadContextByType(ResDownloadType type)
	{
		return null;
	}

	public bool AddToPendingDownload(DownloadContext context, bool isAddFirst = false)
	{
		return false;
	}

	public void PauseDownloadByType(ResDownloadType type, bool isPause)
	{
	}

	public void PauseRunningDownloadWithAllType(bool isPause)
	{
	}

	public void CleanTempCache(ResDownloadType type)
	{
	}

	public void ClearSpecialSoFile()
	{
	}

	private void ClearLocalGGPSoInNewWay()
	{
	}

	public void ClearLocalFileInfo()
	{
	}

	public void ClearLocalVersionAndFileInfo()
	{
	}

	public void CleanCache()
	{
	}

	public void StartGetLocalVersion()
	{
	}

	public void StartGetLocalFileInfo()
	{
	}

	public bool InitLocalInfoWithNoCheck()
	{
		return false;
	}

	public void InitGameVar(bool enableFileExistOptimize, bool should_use_internal_storage, bool enable_unzipLoader_read_optimize, bool enable_savefile_optimize, bool copyAndUnzipProtect, bool enable_load_local_fileinfo_optimize, bool enbale_downloadVersion_loadLocalFileinfo_once)
	{
	}

	public void StartVersionCheck(string remoteAbHotupdateAddr, string remoteAddr, string remoteVersion = null, bool enableAstcHotUpdate = false)
	{
	}

	public ResErrorCode GetDetailedDownloadError(string error)
	{
		return ResErrorCode.OK;
	}

	public void StartHotUpdateDownload(Action<ResErrorCode> onHotUpdateFinished)
	{
	}

	public void Update(float time)
	{
	}

	public void ClearContextActionReference()
	{
	}

	public void Clear()
	{
	}

	public void ClearPendingDownloadContext()
	{
	}

	public static bool CheckFileTypeIsCompusoryType(ResFileType file_type)
	{
		return false;
	}

	public void WWWLoad(DownloadContext context, string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, ResVersionInfo.FileInfo file_info = null)
	{
	}

	public void Download(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool isFromRemote)
	{
	}

	public void BigFileDownload(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded)
	{
	}

	public void Unzip(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	public void HashExternalFile(DownloadContext context, string file_path, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	public void AddHashExternalFileToMTQueue(DownloadContext context, string file_path, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	public void HashFile(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	public void AddHashFileToMTQueue(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false)
	{
	}

	private string GetLocalPathByPlatform(string path, out bool is_optional)
	{
		is_optional = default(bool);
		return null;
	}

	public string ABLoaderPath()
	{
		return null;
	}

	public bool ShouldCheckABFile(out string ab_loader_path)
	{
		ab_loader_path = null;
		return false;
	}

	public void InitABLoadRecordFileReady()
	{
	}

	public void CleanABLoadRecorder()
	{
	}

	public void AddABLoadRecorder(string path, bool is_from_async)
	{
	}

	public void RemoveABLoadRecorder(string path, bool is_from_async)
	{
	}

	public AssetBundle LoadAssetBundle(string path, bool logError = true)
	{
		return null;
	}

	public AsyncOperation LoadAssetBundleAsync(string path, bool logError = true)
	{
		return null;
	}

	public void DeleteAb(string path)
	{
	}

	public string GetHotUpdateMovieUrl(ResourceID id)
	{
		return null;
	}

	public long GetTotalSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return 0L;
	}

	public long GetTotalLoadedSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return 0L;
	}

	public long GetTotalDownloadSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return 0L;
	}

	public ResVersionInfo.FileInfo GetLocalFileInfo(string path)
	{
		return null;
	}

	public ResVersionInfo.FileInfo GetRemoteFileInfo(string path)
	{
		return null;
	}

	public bool ABFileExist(string ab_path)
	{
		return false;
	}

	public bool ABFileExist(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	public string GetLocalPathByPlatfrom(string path)
	{
		return null;
	}

	public bool CheckLocalFileSizeIsRight(string path)
	{
		return false;
	}

	public string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState)
	{
		return null;
	}

	private void ClearTempFile(string tempPath, string flagPath = null)
	{
	}

	private bool MoveTempFile(string relativePath, ResFileType type, string tempPath)
	{
		return false;
	}

	private bool SaveFile(string path, ResFileType type, byte[] content)
	{
		return false;
	}

	private void onLocalVersionInfoLoaded(bool result)
	{
	}

	private void onRemoveVersionInfoLoaded(bool result)
	{
	}

	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	private void onLocalFileInfoLoaded_Hotupdate(bool result)
	{
	}

	private void onRemoteFileInfoLoaded(bool result)
	{
	}

	public static bool IsOptionalMap(ResDownloadType type)
	{
		return false;
	}

	public static ResDownloadType GetMapIdToOptionalResDownloadType(uint mapId)
	{
		return ResDownloadType.None;
	}

	public void InitMapVersionInfo(bool force = false)
	{
	}

	public List<MapVersionInfo> GetAllMapAvailableMapVersionInfo()
	{
		return null;
	}

	public static ResDownloadType GetDefaultMapResType()
	{
		return ResDownloadType.None;
	}

	public static bool IsOptionalPet(ResDownloadType type)
	{
		return false;
	}

	public static int[] GetResFileTypeList(ResDownloadType type)
	{
		return null;
	}

	public bool GetEnableFileInfoParseOptimize()
	{
		return false;
	}

	public void SetEnableFileInfoParseOptimize(bool enableOtimize)
	{
	}

	public static int GetOptionalResDownloadTyepByFileType(ResFileType type)
	{
		return 0;
	}

	public bool CheckNeedDownloadByType(ResDownloadType type, bool useMultiThreadDownload = false)
	{
		return false;
	}

	private bool CheckNeedDownloadFile(ResVersionInfo.FileInfo fileInfo)
	{
		return false;
	}

	private string ConvertSimpleName(string full_name)
	{
		return null;
	}

	private void NotifyFileHashed(DownloadContext context, string hash_code, ResHashFileLoader hashFileLoader)
	{
	}

	private void NotifyFileHashedForHashCheck(DownloadContext context, string hash_code, ResHashFileLoader hashFileLoader, ResVersionInfo.FileInfo fileInfo = null)
	{
	}

	public void FinalHash()
	{
	}

	private void NotifyFileUnZiped(DownloadContext context, string hash_code, ResUnzipFileLoader unzip_loader)
	{
	}

	private void NotifyFileDownloaded(ResErrorCode result, DownloadContext context, ResFileLoader loader)
	{
	}

	public ResErrorCode SaveVersionInfo(ResDownloadType type)
	{
		return ResErrorCode.OK;
	}

	public void StartDownloadContextByType(uint[] type_list, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
	{
	}

	public void StartDownloadContextByType(ResDownloadType type, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
	{
	}

	public bool CheckCopyAndUnzipDesignatedFile(string ab_path, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return false;
	}

	public void CheckHashFile(float cool_down_time = 0f, ResDownloadType type = ResDownloadType.CompulsoryRes, Action<ResErrorCode, ResDownloadType> finished_callback = null)
	{
	}

	public void HashPDCacheFiles(bool multiThreadHash = false)
	{
	}

	public bool CheckCopyAndUnzipFile(ResDownloadType type = ResDownloadType.CompulsoryRes, bool multiThreadHash = false)
	{
		return false;
	}

	private void LoadLocalAPKFile(DownloadContext context, ResVersionInfo.FileInfo fi, Action<string, ResUnzipFileLoader> onUnzipLoaded)
	{
	}

	private bool CheckFileinfoExist(ResVersionInfo.FileInfo file_info)
	{
		return false;
	}

	private bool CheckFileNeedHashCheckForNewDownload(ResVersionInfo.FileInfo fi, DownloadContext context)
	{
		return false;
	}

	private void MultiTreadHashCheck(ResVersionInfo.FileInfo fi, DownloadContext context, Action<string, ResHashFileLoader> onHashFiled, bool multiThreadHash = false)
	{
	}

	private void MultiTreadHashCheckForForceHashCheck(ResVersionInfo.FileInfo fi, DownloadContext context, Action<string, ResHashFileLoader> onHashFiled, bool multiThreadHash = false)
	{
	}

	public void BeginMTHashFinish()
	{
	}

	public void WaitForMTHashFinish()
	{
	}

	public long GetLocalStoredFileSizeWithType(ResFileType type)
	{
		return 0L;
	}

	public long GetNeedDownloadFileSize(ResDownloadType type)
	{
		return 0L;
	}

	public bool ParseLocalStreamFile(string context)
	{
		return false;
	}

	public void LoadStreamingFileInfo(DownloadContext context, Action<WWW, ResWWWFileLoader> onLoaded)
	{
	}

	public void CleanStreamOptionalCache()
	{
	}

	public bool CheckNeedLoadFormStreamingOptional()
	{
		return false;
	}

	public void LoadStreamingOptional()
	{
	}

	public void LoadLocalOptionalStreamInfo()
	{
	}

	public bool CopyStreamingOptional(DownloadContext download_context)
	{
		return false;
	}

	public void WWWLoadLocalStreamingOptional(DownloadContext context, string path, Action<WWW, ResWWWFileLoader> onLoaded, long totalSize = 0L, bool includeVersionDir = true, ResVersionInfo.FileInfo file_info = null)
	{
	}

	public bool SaveStreamingOptionalFile(string fileInfoFullName, byte[] content)
	{
		return false;
	}

	private void RefreshFinishedFileCount()
	{
	}

	private bool CheckPlayerHaveMoveStreamingIcon()
	{
		return false;
	}

	public void MoveStreamingIconIntoCache()
	{
	}

	private void LoadIconCDNStreamingFileInfo(DownloadContext context, Action<WWW, ResWWWFileLoader> onloaded)
	{
	}

	private bool ParseLocalStreamIconFile(string context)
	{
		return false;
	}

	private bool CopyStreamingIconCDN(DownloadContext download_context)
	{
		return false;
	}

	private bool SaveStreamingIconCDNToCDNCache(string iconNameWithSurffix, byte[] content)
	{
		return false;
	}

	private void _003CStartHotUpdateDownload_003Eb__100_0(ResErrorCode result, ResDownloadType type)
	{
	}
}
