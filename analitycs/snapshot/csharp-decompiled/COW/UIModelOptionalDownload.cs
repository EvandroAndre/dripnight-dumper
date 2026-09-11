using System;
using System.Collections.Generic;
using System.Threading;
using COW.Gameplay.UGC;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelOptionalDownload : UIBaseModel
{
	public enum EOptionalLobbyResType
	{
		None,
		BigEvent,
		VirtualBrand,
		FullHD
	}

	public class RecordABPath
	{
		public string AbName;

		public DateTime useTime;
	}

	public class TempWriteUseAbPath
	{
		public List<RecordABPath> TempRecordAbPath;

		public string WriteLocalPath;

		public TempWriteUseAbPath(List<RecordABPath> originalData, string path)
		{
		}
	}

	public enum EHDResType
	{
		NONE = 0,
		ANIMATION = 1,
		LOBBY = 2,
		EFFECT = 4,
		FFO_ANIMATION = 5
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__119_2;

		public static WaitCallback _003C_003E9__341_0;

		internal void _003CPrepareForBackGroundDownload_003Eb__119_2()
		{
		}

		internal void _003CWriteUseAbPathFileInfoLocal_003Eb__341_0(object Object)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public Action checked_callback;

		internal void _003CCheckOptionalVersionWithCallback_003Eb__0(ResErrorCode error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public Action<HttpErrorCode, object> onFinished;

		internal void _003CNotifyServieTag_003Eb__0(HttpErrorCode error, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public ResDownloadType type;

		public ResVersionInfo.FileInfo file_info;

		internal void _003COnFileDownloadedNotify_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public ResErrorCode error;

		public ResDownloadType type;

		public ResVersionInfo.FileInfo file_info;

		public ResUpdateDownloadContext context;

		internal void _003COnSingleFileDownloadedFinished_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass158_0
	{
		public ResDownloadType type;

		public List<string> fileInfoNames;

		public UIModelOptionalDownload _003C_003E4__this;

		internal void _003COnDeletedFinished_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public ResErrorCode error;

		internal void _003COnDownloadedFinished_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass233_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public uint tag;

		public ResErrorCode lastError;

		internal void _003COnTagDownloadFinished_003Eb__0()
		{
		}

		internal void _003COnTagDownloadFinished_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelOptionalDownload _003C_003E4__this;

		public ResErrorCode lastError;

		internal void _003COnTagSingleFileDownloadFinished_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass364_0
	{
		public List<uint> needGetVersionType;

		public UIModelOptionalDownload _003C_003E4__this;

		public Action<ResErrorCode> _003C_003E9__1;

		internal void _003CProcessMapVersion_003Eb__0()
		{
		}

		internal void _003CProcessMapVersion_003Eb__1(ResErrorCode result)
		{
		}
	}

	public static int OptionalSettingOpen;

	public static int OptionalSettingOff;

	public List<uint> m_NeedAutoClearDownloadTypeList;

	private List<uint> m_DownloadTypeList;

	private List<DownloadInfo> m_DownloadInfoList;

	public const uint PropID_VersionChecked = 2u;

	public const uint PropID_NotifyAssetRefresh = 4u;

	public const uint PropID_DownloadFinished = 8u;

	public const uint PropID_SingleFileDownloadFinished = 16u;

	public const uint PropID_InfoListRefreshed = 32u;

	public const uint PropID_ActivityStateRefreshed = 64u;

	public const uint PropID_TipsStateRefreshed = 128u;

	public const uint PropID_AllFileDownloaded = 256u;

	public const uint PropID_DownloadCentreVisibleRefresh = 512u;

	public const uint PropID_TagOptioanlPatchDownloadFinished = 1024u;

	public const uint PropID_TagOptionalPatchDownloadDelete = 2048u;

	public const uint PropID_TagOptionalPatchDownloadStart = 4096u;

	public const uint PropID_CheckOptionalAutoDownload = 8192u;

	public const uint PropID_OptionalDownloadFailed = 16384u;

	public const uint PropID_OptionalDownloadPause = 32768u;

	public const uint AbType_Multiplier = 100000u;

	public const uint ResType_Multiplier = 1000u;

	private bool m_AutoPopUpTaskClearFinished;

	private const string DELTED_KEY = "_Deleted";

	private const string DELTED_KEYTAG = "_DeletedTag";

	private EModelDownloadState m_DownloadState;

	public const float DownloadSizeUnit = 9.536743E-07f;

	public const string DOWNLOAD_PARTIAL_RESOURCES = "DownloadPartialResources";

	private const string OPTIONAL_EQUIPPED_OWN_WEK_LOG = "DownloadOptionalEquippedAndOwn_{0}_{1}";

	public const string OPTIONAL_LAST_CLEAR_TIME = "DownloadOptionalLastClearTime";

	private EOptionalLobbyResType m_CurOptionalLobbyResType;

	private bool? m_LocalClothReady;

	private bool? m_LocalPetSkinReady;

	private bool? m_HaveVersionUpdate;

	private bool m_EnterLobby;

	private bool _003CInSpeedUp_003Ek__BackingField;

	private uint m_SpeedUpDelayCall;

	private const float CHECK_NETWORK_TIME = 5f;

	private string m_LastCacheNetworkType;

	private uint m_CheckNetwork_DelayCallID;

	public const uint OptionalReDefOwnedClothesId = 2u;

	public const uint OptionalReDefEquipedClothesId = 1u;

	private Dictionary<ResVersionInfo.FileInfo, int> m_SingleFileLastErrorMap;

	private Dictionary<uint, ActivityClientInfo> m_ActivityInfoMap;

	private Dictionary<uint, ClientActivityDesc> m_TagActivityInfoIdMap;

	private List<uint> m_NeedDownloadCloths;

	private Dictionary<uint, List<uint>> m_TagResDownloadTypesMap;

	private Dictionary<uint, List<uint>> m_ResTypeTagIDMap;

	private Dictionary<uint, DownloadInfoGroup> m_TabDownloadInfoMap;

	private Dictionary<uint, TagDownloadInfo> m_TagDownloadInfoItemMap;

	private List<uint> m_NormalPageShowTagList;

	private List<uint> m_RecommendPageShowTagList;

	private List<uint> m_AllPageShowTagList;

	private Dictionary<uint, List<ResVersionInfo.FileInfo>> m_NeedCheckDownloadingFilesByTypeDict;

	private ulong m_LastRepairTime;

	private uint m_RepairCount;

	private bool m_HasErrorOccur;

	private LinkedList<uint> m_PendingTag;

	private List<uint> m_WhiteListOptionalRedefId;

	private bool m_HaveInitWhiteListOptionalRes;

	private uint m_UpdateProcessTagPengindCallId;

	public bool m_HaveShowAutoDownloadTips;

	private BitArray m_BackgroundNotifiedFlag;

	private const uint BK_NOTIFIED_FILE_INFO = 1u;

	private const uint BK_NOTIFIED_SINGLE_DOWNLOAD = 2u;

	private const uint BK_NOTIFIED_TAG_DOWNLOAD = 4u;

	private const uint BK_NOTIFIED_TAGSINGLE_DOWNLOAD = 8u;

	private const uint BK_NOTIFIED_DOWNLOADERROR = 16u;

	public const string OptionalABDownLoadInfoKey = "OptionalABDownLoadInfoKey";

	private bool m_InWhiteListState;

	public static bool EnableAutoDownload;

	public bool RegisterUpdateAction;

	public bool m_IsProduceDynamicPack;

	private float m_LastErrMsgShowTime;

	private ulong m_LastNotifyRewardServiceTagTime;

	private const uint MAX_NOTIFYSERVICECDTIME = 600u;

	private bool m_LoginSuccess;

	private bool m_ProduceTagDownloadInfo;

	private List<uint> m_TempShowTagList;

	public ResDownloadType CurNotifyResType;

	private uint m_LastTag;

	private bool m_UpdateProgressPause;

	private Dictionary<uint, List<uint>> m_TypeCategoryOptionalIdsMap;

	private List<ResVersionInfo.FileInfo> m_TempRecordFileInfoList;

	private List<ResVersionInfo.FileInfo> m_TempRecordNeedDeletedFile;

	private List<uint> m_OwnedProcessedVault;

	private List<uint> m_EquipedProcessdVault;

	private List<ResourceID> m_OwnedProcessedVaultRes;

	private List<ResourceID> m_EquipedProcessValuetRes;

	private List<uint> m_OverTimeNeedClearResType;

	private List<RecordABPath> m_LocalRecordAbPath;

	private bool? m_UseHDAnim;

	private bool? m_UseHDEffect;

	private uint m_DelayCallVersionCheck;

	public EModelDownloadState DownloadState
	{
		get
		{
			return EModelDownloadState.None;
		}
		private set
		{
		}
	}

	public bool InSpeedUp
	{
		get
		{
			return _003CInSpeedUp_003Ek__BackingField;
		}
		private set
		{
			_003CInSpeedUp_003Ek__BackingField = value;
		}
	}

	public List<uint> RecommendPageShowTagList => null;

	public bool IsTagDownloadInfoReady => false;

	public bool UseHDAnim => false;

	public bool UseHDEffect => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void ClearCache()
	{
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public void VoiceContextClearLastLangFile()
	{
	}

	public void LocContextClearLastLangFile()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool NetWordIsWiFi()
	{
		return false;
	}

	public void SetUserInWhileListState(bool state)
	{
	}

	public bool CheckUserInWhileListState()
	{
		return false;
	}

	public bool CheckMapResInWhileList(uint mapConfigId)
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	public void RestLastErrMsgShowTime()
	{
	}

	public void InitTagDownloadInfoFormLogRecord(uint tagID, bool ismanaual, EoptionalTagDownloadTypeEntry entry)
	{
	}

	public static string GetPackNameByDownloadType(ResDownloadType type)
	{
		return null;
	}

	public void HintWithErrorCode(ResErrorCode error)
	{
	}

	public void CheckOptionalVersionInLauncher(bool parellelForEach = false)
	{
	}

	public bool CheckPlayerCanRepair()
	{
		return false;
	}

	public void RepairTargetContextFileinfo()
	{
	}

	private void InitFileinfoIsOldResourceTag()
	{
	}

	public void CheckOptionalVersion()
	{
	}

	public void CheckOptionalVersionWithCallback(Action checked_callback)
	{
	}

	private void ClearUpdatedResDownloadTypeAutoDownloadTag(List<uint> resdownloadtype_List)
	{
	}

	private void onVersionChecked(bool autoDownload = true)
	{
	}

	private void CheckNeedDelete()
	{
	}

	public void OnEnterLobby()
	{
	}

	private bool CheckShowAutoDownloadTips()
	{
		return false;
	}

	public void CheckOwenOrEquipedClothesOnEnterLobby()
	{
	}

	public void ReStartAndCheckEquippedDynamicDownloadInfo()
	{
	}

	public void CheckNeedDownload()
	{
	}

	public void PrepareForBackGroundDownload()
	{
	}

	private void InvokeBackGroundNotification(ResErrorCode errorCode, ResDownloadType type)
	{
	}

	public void UnPrepareForBackGroundDownload()
	{
	}

	public bool GetAutoDownloadFlag()
	{
		return false;
	}

	public void CheckAutoResumeResDownloadType()
	{
	}

	private bool ShouldSuppressAutoDownloadInLowSpecSocialArea()
	{
		return false;
	}

	public void PauseAllDownloadOnEnterLowSpecSocialAreaIfNeeded()
	{
	}

	public void CheckAutoDownload()
	{
	}

	public void CheckAndAutoDownload(List<uint> tags)
	{
	}

	private void StartAutoDownloadByTag(TagDownloadInfo tagDownloadInfo)
	{
	}

	private List<string> GetAbPathsWithDependencies(IEnumerable<string> abPaths)
	{
		return null;
	}

	private void AddAbPathWithDirectDependencies(string abPath, List<string> result, HashSet<string> added)
	{
	}

	private void AddAbPathWithDependencies(string abPath, List<string> result, HashSet<string> added, HashSet<string> visiting)
	{
	}

	public void DownloadSingleFile(ResourceID id, bool manualDownload = false)
	{
	}

	public void DownloadMutileRes(List<ResourceID> download_resList, bool downloadAllResOfGameMode = true, bool downloadInGame = false, bool ismanualDownload = false)
	{
	}

	public void DownloadMultiRes(List<string> fileNameList, bool downloadAllResOfGameMode = true, bool downloadInGame = false, bool ismanualDownload = false)
	{
	}

	private void StartDownloadMutileFileByTag(List<string> ab_path, bool downloadAllResOfGameMode = true, bool ismanualDownload = false)
	{
	}

	public void ManaualPauseDownloadByTagWithoutRemoveTag(uint tag)
	{
	}

	public void RecordTempPauseDownloadFilesByTag(uint tagID)
	{
	}

	private void PriorityOfCurSingleFileDownload(TagDownloadInfo tagDownloadInfo)
	{
	}

	private TagDownloadInfo GetEffectiveTagId(List<uint> tag_list)
	{
		return null;
	}

	public bool IsOptionalPackedRes(ResourceID id)
	{
		return false;
	}

	public bool IsOptionalPackedRes(string ab_path)
	{
		return false;
	}

	public void DownloadSingleFileForNewTagDownloadInfo(string ab_path, bool manualDownload = false)
	{
	}

	public void DownloadAllFileByResType(ResDownloadType type, bool manaualDownload = false, EoptionalTagDownloadTypeEntry entry = EoptionalTagDownloadTypeEntry.None)
	{
	}

	private void StartDownloadSingle(string ab_path, ResUpdateDownloadContext context, bool manualDownload = false)
	{
	}

	private void StartDownloadAll(ResUpdateDownloadContext context, bool isBackgroundThread = false)
	{
	}

	public void PauseDownload(bool need_auto_resume = false)
	{
	}

	public void CheckAllFileStatesByFileName(string file_name)
	{
	}

	public void CheckAllFileStatesByContextType(ResDownloadType context_type)
	{
	}

	public void NotifyServieTag(uint[] tagIds, Action<HttpErrorCode, object> onFinished = null)
	{
	}

	private void OnFileDownloadedNotify(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info, bool is_in_background)
	{
	}

	private void OnSingleFileDownloadedFinished(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info, bool is_in_background)
	{
	}

	public void SetAutoPopUpClearTaskFinished()
	{
	}

	public void StartAutoClear()
	{
	}

	public void AutoClear()
	{
	}

	public void DelFileGradually(List<ResVersionInfo.FileInfo> realNeedDelFile)
	{
	}

	public void LogAutoClearFile(List<ResVersionInfo.FileInfo> needDelFile)
	{
	}

	private void RefreshFileBelongTagDownloadState(List<ResVersionInfo.FileInfo> needDelFiles)
	{
	}

	private void OnDeletedFinished(ResDownloadType type, List<string> fileInfoNames, uint deleted_tag)
	{
	}

	private void OnDownloadedFinished(ResErrorCode error, ResDownloadType type)
	{
	}

	private void RefreshRepairErrorCode(ResErrorCode error)
	{
	}

	private void ClearNetWorkTypeCache()
	{
	}

	private void CacheNetWorkType()
	{
	}

	private void OnNetWorkCheck()
	{
	}

	public bool CheckErrorWithDownloadInfo()
	{
		return false;
	}

	public void RefreshDownloadInfoList(bool need_add_fileinfo = false)
	{
	}

	public long GetZipSizeWithResID(List<ResourceID> res_id_list, HashSet<ResVersionInfo.FileInfo> added_file_list = null)
	{
		return 0L;
	}

	public void GetZipInfoWithResID(ResourceID res_id, ref HashSet<ResVersionInfo.FileInfo> added_file_list, ref HashSet<ResVersionInfo.FileInfo> except_flie_list)
	{
	}

	public void GetZipInfoWithResID(ResourceID res_id, ref HashSet<ResVersionInfo.FileInfo> added_file_list)
	{
	}

	public long GetZipSizeWithResID(ResourceID res_id, HashSet<ResVersionInfo.FileInfo> added_file_list = null)
	{
		return 0L;
	}

	public List<ResVersionInfo.FileInfo> SimpleFileInfosByResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> FileInfosByResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	public float EstimateRemainDownloadedSize(List<ResourceID> resIds)
	{
		return 0f;
	}

	public bool NeedSecondConfirmForDownloadSingleFile(List<ResourceID> res_id_list)
	{
		return false;
	}

	public bool NeedSecondConfirmForDownloadSingleFile(ResourceID res_id)
	{
		return false;
	}

	public void ClearDeletedType(ResDownloadType type)
	{
	}

	public bool HasBeingDeletedTag(uint tag)
	{
		return false;
	}

	public void DeletedTag(uint tag)
	{
	}

	public void ClearDeletedTag(uint tag)
	{
	}

	public bool HaveFinishedOptionalDownloadActivity()
	{
		return false;
	}

	public void UpdateActivityStateWithTagId(uint tagId, ClientActivityDesc activit_desc)
	{
	}

	public void RecheckActivityState(bool foreceRefresh = false)
	{
	}

	private List<uint> GetAllNeedNotifyDownloadFinishedTagIDList()
	{
		return null;
	}

	public ResourceID GetTagActivityResouceIcon(uint tagId, out uint rewardNum)
	{
		rewardNum = default(uint);
		return default(ResourceID);
	}

	public ClientActivityDesc GetTagActivityDescInfo(uint tagId)
	{
		return null;
	}

	public proto.EActivity.State GetActivityStateByTagId(uint tagId, out bool have_activity_info)
	{
		have_activity_info = default(bool);
		return proto.EActivity.State.State_RECEIVED;
	}

	public void AwardByTagId(uint tagId)
	{
	}

	private float GetTargetUnzipSpeed(bool is_speed_up)
	{
		return 0f;
	}

	public void StartSpeedUp()
	{
	}

	public void BackToNormalSpeed()
	{
	}

	public bool IsTipsStateReady()
	{
		return false;
	}

	public void SetLocalClothReadyState(bool is_ready, List<uint> need_download_list)
	{
	}

	public void SetLocalPetSkinReadyState(bool is_ready)
	{
	}

	public void DownloadFilesQuickly(List<ResourceID> reslist)
	{
	}

	public EDownloadContextState GetDownloadContextStateByType(ResDownloadType type)
	{
		return EDownloadContextState.None;
	}

	public bool IsMapDownloading(List<ResourceID> mapRes)
	{
		return false;
	}

	public bool IsUGCMapDownloading(UGCSimpleDownloadTask resDownloadTask)
	{
		return false;
	}

	public TagDownloadInfo GetDownloadInfoByTag(uint tagId)
	{
		return null;
	}

	public uint GetOptionalLobbyResTag(EOptionalLobbyResType abType, uint abId)
	{
		return 0u;
	}

	public bool GetAbIdFromTag(out uint abId, uint tag, EOptionalLobbyResType abType, ResDownloadType resType = ResDownloadType.OptionalLobbyRes)
	{
		abId = default(uint);
		return false;
	}

	public bool IsLobbySocialAreaDeleteProtectedTag(uint tagId)
	{
		return false;
	}

	public List<ResVersionInfo.FileInfo> GetOptionalLobbyResFileInfo(EOptionalLobbyResType abType, uint abId)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetOptionalLobbyResFileInfo(uint abId)
	{
		return null;
	}

	public bool IsOptionalLobbyResDownloaded(EOptionalLobbyResType abType, uint abId, bool isShowPop = true)
	{
		return false;
	}

	public bool IsForceAllFileDownloadRes(List<ResourceID> needDownloadRes, ref ResDownloadType resType)
	{
		return false;
	}

	public void OptionalMapDownload(uint mapconfigId)
	{
	}

	public void StartDownloadMapRelativeRes(uint mapConfigID, bool needShowPopUpWnd = false, EoptionalTagDownloadTypeEntry formEntry = EoptionalTagDownloadTypeEntry.None)
	{
	}

	public List<ResVersionInfo.FileInfo> GetTagDownloadInfoFilesByMapconfigId(uint mapConfigID)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetMainTagFileInfosByMapconfigId(uint mapConfigID)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetDLCTagFileInfosByMapconfigId(uint mapConfigID)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetAllFileInfoByOptionalResdefID(uint optionalReDefID)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetAllFileDownloadResFileInfo(ResDownloadType resType)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetMapAllFileInfoByMapConfigId(uint mapConfigId, ResDownloadType type = ResDownloadType.None)
	{
		return null;
	}

	public List<ResVersionInfo.FileInfo> GetAllFileDownloadResTagFileInfo(ResDownloadType resType)
	{
		return null;
	}

	public float GetAllFileDownloadResSize(ResDownloadType resType)
	{
		return 0f;
	}

	public bool IsAllTagFileDownloaded(ResDownloadType resType, bool isShowPop = true, EoptionalTagDownloadTypeEntry downloadEntry = EoptionalTagDownloadTypeEntry.None)
	{
		return false;
	}

	public bool IsAllFileDownloaded(ResDownloadType resType, bool isShowPop = true, EoptionalTagDownloadTypeEntry entry = EoptionalTagDownloadTypeEntry.None)
	{
		return false;
	}

	private void SendOptionalDownloadInfoLog()
	{
	}

	private bool AddToPendingDownloadByTag(uint tag, bool isAddFirst = false)
	{
		return false;
	}

	private void RemoveFromPendingTag(uint tag)
	{
	}

	public EDownloadContextState IsPendingOrDownloadingByTag(uint tag)
	{
		return EDownloadContextState.None;
	}

	protected bool PendingTagListContainsTag(uint tag)
	{
		return false;
	}

	public uint GetDownloadingTagId()
	{
		return 0u;
	}

	public void PendingDownloadClick(uint tag)
	{
	}

	public void UpdateProcessTagPendingList(bool is_BackGroundDownload = false)
	{
	}

	private void CheckTagNeedRestartDownload()
	{
	}

	private void ClearTagNeedPauseDownloadingFileInfos()
	{
	}

	private void DownloadEngineRunningContextCallBack(ResUpdateDownloadContext runningContext, ResErrorCode error, bool is_BackgroundDownload)
	{
	}

	private void SendEventLog_OptionalBundleDownload(uint bundleId, string packageName, List<uint> resDownloadTypeList, ResErrorCode lastErrorCode)
	{
	}

	public ResErrorCode OnTagDownloadFinished(uint tag, bool is_background = false)
	{
		return ResErrorCode.OK;
	}

	public ResErrorCode OnTagSingleFileDownloadFinished(TagDownloadInfo tagDownloadInfo, bool is_background = false)
	{
		return ResErrorCode.OK;
	}

	private ResErrorCode GetResErrorCodeByTag(uint tag)
	{
		return ResErrorCode.OK;
	}

	private void InitTagDownloadInfoMap()
	{
	}

	private void ProduceDynamicDownloadInfo(bool forceRefresh = false)
	{
	}

	public void RecordDownloadInfoDownloadedSizeForDeleted()
	{
	}

	private List<ResVersionInfo.FileInfo> GetEffectiveAbPath(List<ResVersionInfo.FileInfo> fileinfo_list)
	{
		return null;
	}

	public void InitTagDownloadInfoShowState()
	{
	}

	private bool CheckOptionalShowStateIsOpenForWhiteList(uint tagID)
	{
		return false;
	}

	private void AddTypeTagPair(uint TypeId, uint TagId)
	{
	}

	public void InitTabDownloadInfo(bool login = false)
	{
	}

	public void ProduceOwnedDynamicDownloadInfo(bool forceNeedAll = false)
	{
	}

	private void ProduceTagDownloadInfo(uint tag, List<ResVersionInfo.FileInfo> fileInfo_List, List<uint> resDownloadTypeList)
	{
	}

	public bool GetResourceAbNames(List<ResourceID> resources, ref HashSet<string> abNameList)
	{
		return false;
	}

	private List<ResVersionInfo.FileInfo> InitFileInfoInContext(List<string> abPath_List, ResDownloadType type, uint tag, bool isRecommend = false)
	{
		return null;
	}

	private List<ResVersionInfo.FileInfo> InitFileInfoInContext(List<ResourceID> resId_List, ResDownloadType type, uint tag, bool isRecommend = false)
	{
		return null;
	}

	private void ClearTagTableByTag(uint tag)
	{
	}

	private List<ResVersionInfo.FileInfo> InitMutilFileInfoList(List<string> ab_patchList, uint tag, ref List<uint> resDownloadTypeList, bool onlyShowUnLoad = false)
	{
		return null;
	}

	public void StartDownloadByTag(uint tag, bool manualDownload = false, bool ChangeDownloadStateMode = false, EoptionalTagDownloadTypeEntry entryType = EoptionalTagDownloadTypeEntry.None)
	{
	}

	private void NotifyStartDownload(uint tag)
	{
	}

	private void StartDownloadByTagForPendingProcess(uint tag, bool isBackgroundThread = false)
	{
	}

	public void StartDownloadByType(uint type)
	{
	}

	private void StartDownloadBatch(List<uint> tagList, bool addFirst = false)
	{
	}

	public void PauseDownloadByTagForTagPendingUpdateProcess(uint tag)
	{
	}

	private void PauseDownloadByTag(uint tag, bool notify = true)
	{
	}

	public void ManaualPauseDownloadByTag(uint tag)
	{
	}

	public void BeginForceTutorialDownload(uint tutorialTag)
	{
	}

	public void PauseDownloadByType(uint type)
	{
	}

	public void PendingClickByTag(uint tag)
	{
	}

	public void PendingDownloadByType(uint type)
	{
	}

	public void RefreshTag(uint tag)
	{
	}

	public float GetTagAllDownloadedSizeMB(EDownloadCentreDownloadState state = EDownloadCentreDownloadState.Download)
	{
		return 0f;
	}

	public float GetAllDownloadedSizeMB_2()
	{
		return 0f;
	}

	public float GetAllDownloadedSizeMB()
	{
		return 0f;
	}

	public float GetAllDownloadedSizeMB_OLD()
	{
		return 0f;
	}

	public float GetDownloadedSizeWithoutRepeatByTagList(List<uint> tagList)
	{
		return 0f;
	}

	public float GetTagAllDownloadedSizeMBByTagList(List<uint> tagList, EDownloadCentreDownloadState state = EDownloadCentreDownloadState.Download)
	{
		return 0f;
	}

	public void DeleteFileByTagList(List<uint> tagList)
	{
	}

	public void DeleteFileByTag(uint tag, bool deleteRecommend = false)
	{
	}

	private List<uint> GetDownloadSortedTagList(List<uint> need_sort_list)
	{
		return null;
	}

	public int AutoDownloadSort(TagDownloadInfo x, TagDownloadInfo y)
	{
		return 0;
	}

	public DownloadInfoGroup GetTabDownloadInfoByTypeId(uint type)
	{
		return null;
	}

	public void DownloadAllTagDownloadInfo(bool downloadAll = false)
	{
	}

	private void RefreshTagPauseAutoDownloadStateForBatchStop(uint tag)
	{
	}

	private void PausePendingTagDownloadInfoOnEnterLowSpecSocialArea()
	{
	}

	public void PauseAllTagDownloadInfo(bool showTips = false)
	{
	}

	public bool isDownloadCentreAllShowDownloadedByPageState(bool isOtherPage = false)
	{
		return false;
	}

	public bool isDownloadCentreAllShowInPendingByPageState(bool isOtherPage = false)
	{
		return false;
	}

	public bool NothingInDownload()
	{
		return false;
	}

	public bool CheckTagIsNormalPage(uint tagId)
	{
		return false;
	}

	private void InitShowTagList()
	{
	}

	public List<uint> GetAllShowTagList(bool otherPage = false)
	{
		return null;
	}

	public List<uint> GetAllOtherPageShowTag()
	{
		return null;
	}

	public bool CheckTagDownloadInfoHaveReward(List<uint> needCheckTagId)
	{
		return false;
	}

	public bool IsAllShowTagInTagPending(List<uint> tagList)
	{
		return false;
	}

	public bool IsAllShowTagDownloadFinished(List<uint> tagList)
	{
		return false;
	}

	public List<uint> GetDownloadOptionalRedefIdListByType(uint type)
	{
		return null;
	}

	public List<uint> GetTabDownloadInfoIds()
	{
		return null;
	}

	public bool CheckCanDownloadAll(bool isOtherPage = false)
	{
		return false;
	}

	public bool GetTotalDownloadBtnShowStateByTagList(List<uint> needCheckTagList)
	{
		return false;
	}

	public bool IsTargetOptionalRedefInfoIsDownloaded(uint optionalRedefId)
	{
		return false;
	}

	public static float GetFreeStorageWithMB()
	{
		return 0f;
	}

	private void AddTagResDownloadType(uint tag, ResDownloadType type)
	{
	}

	private void AddResDownloadTypeTagDetail(uint tag, ResDownloadType type)
	{
	}

	private void InitTagResTypeMapDict(uint tag, ResDownloadType type)
	{
	}

	public EDownloadContextState GetAbStateByFileName(string file_fullName)
	{
		return EDownloadContextState.None;
	}

	public EDownloadShowState GetFileInfoListDownloadStateInGameRes(List<ResVersionInfo.FileInfo> fileInfoList)
	{
		return EDownloadShowState.None;
	}

	public EDownloadShowState GetFileInfoListDownloadState(List<ResVersionInfo.FileInfo> fileInfoList)
	{
		return EDownloadShowState.None;
	}

	private EDownloadContextState GetProvityDownloadstate(EDownloadContextState old_state, EDownloadContextState new_state)
	{
		return EDownloadContextState.None;
	}

	public void DownloadResForInGame(List<string> fileNameList, Action downloadFinishedCallback = null)
	{
	}

	private bool HaveEnoughStorage(long require_size)
	{
		return false;
	}

	private void RefreshOwnedProcessedVaultRes(List<ResourceID> add_res)
	{
	}

	public List<ResourceID> GetPlayerOwnedVaultResList()
	{
		return null;
	}

	public void RefreshOwnedNewVaultResList()
	{
	}

	public void OwnedNewValutWeaponOptionalRes(List<ResourceID> optional_weapon_res)
	{
	}

	public void OwnedFinalShotOptionalRes(List<ResourceID> optional_finalshot_res)
	{
	}

	public static bool IsValidBundleItem(CSSharedItemData itemData)
	{
		return false;
	}

	public List<ResourceID> ItemOptionalResReallyNeedDownload(CSSharedItemData itemData)
	{
		return null;
	}

	public void ItemOptionalRes(CSSharedItemData itemData, List<ResourceID> optionalRes)
	{
	}

	public static void ItemOptionalResStatic(CSSharedItemData itemData, List<ResourceID> optionalRes, bool needAllClothesRes = false)
	{
	}

	private static void AddBackPackMaterialRefRes(List<ResourceID> back_pack_res, uint item_id)
	{
	}

	private static void AddRecipeAbResIds(List<ResourceID> dst, int[] recipes)
	{
	}

	private static void AddRecipeAbResIds(List<ResourceID> dst, int recipe)
	{
	}

	public bool NeedDownloadRes(ResourceID resId)
	{
		return false;
	}

	public HashSet<string> SimpleAbNamesOfResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	public HashSet<string> AbNamesOfResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	public void RecordEquippedAndOwnedLogInfo()
	{
	}

	public void UpdatePGCTagDownloadInfo(UIModelMapOpeningInfo.PGCMapInfo pgcMapInfo)
	{
	}

	public List<ResourceID> GetCurrentAvatarResourceId()
	{
		return null;
	}

	public List<ResourceID> GetEquipedClothesResourceID(bool needAll = false)
	{
		return null;
	}

	public List<ResourceID> GetEquipedWeaponSkinResource()
	{
		return null;
	}

	public List<ResourceID> GetShowInLobbyWeaponSkin()
	{
		return null;
	}

	public List<ResourceID> GetAvatarEquipedCollection()
	{
		return null;
	}

	private void SetAvatarEquipedSkinInfo(List<uint> equipedItems, uint singleSkinID, uint subType)
	{
	}

	private void SetAvatarEquipedSlotInfo(List<uint> equipedItems, uint singleSkinID, uint subType)
	{
	}

	public List<ResourceID> GetHDLobbyWeaponRackResource()
	{
		return null;
	}

	public List<ResourceID> GetHDLobbyOtherShowResouce()
	{
		return null;
	}

	public void WriteUseAbPathFileInfoLocal()
	{
	}

	private void RefreshLocalAbRecordInfo(string abPath)
	{
	}

	private void LoadLocalRecordAbPathInfo()
	{
	}

	private List<RecordABPath> ParseRecordFile(string content)
	{
		return null;
	}

	private string GetOptionalAbRecordPath()
	{
		return null;
	}

	private bool CheckTypeNeedClearOverTimeUnUse(ResDownloadType resType)
	{
		return false;
	}

	public void InitNeedAutoClearOptionalTypeOverTime(string setting)
	{
	}

	public void InitNeedAutoClearOptionalTypeUnOwn(string setting)
	{
	}

	public uint GetOptionalHDResTag(EHDResType resType)
	{
		return 0u;
	}

	public bool GetOptionalHDResIsDownLoaded(EHDResType resType)
	{
		return false;
	}

	private void RefreshHDAnimFlag()
	{
	}

	private void RefreshHDEffectFlag()
	{
	}

	public void ResetHDAnimFlag()
	{
	}

	public void ResetHDEffectFlag()
	{
	}

	public void ResetHDResFlag()
	{
	}

	public void ProcessMapVersion(GetMapVersionDescNtf mapVersionInfo)
	{
	}

	private void CancelRunningGameVersionCheckDelayCall()
	{
	}

	private void _003CCheckOptionalVersionInLauncher_003Eb__105_0(ResErrorCode error)
	{
	}

	private void _003CRepairTargetContextFileinfo_003Eb__107_0(ResErrorCode errorCode)
	{
	}

	private void _003CCheckOptionalVersion_003Eb__109_0(ResErrorCode error)
	{
	}

	private void _003ConVersionChecked_003Eb__112_0()
	{
	}

	private void _003COnEnterLobby_003Eb__114_0()
	{
	}

	private void _003CPrepareForBackGroundDownload_003Eb__119_0(ResUpdateDownloadContext context, ResErrorCode errorCode, bool isBackground)
	{
	}

	private void _003CPrepareForBackGroundDownload_003Eb__119_1(ResDownloadType type, ResErrorCode errorCode)
	{
	}

	private void _003CCheckAndAutoDownload_003Eb__127_0()
	{
	}

	private void _003CCheckAndAutoDownload_003Eb__127_2()
	{
	}

	private void _003CCheckAndAutoDownload_003Eb__127_1()
	{
	}

	private void _003CStartSpeedUp_003Eb__188_0()
	{
	}

	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
