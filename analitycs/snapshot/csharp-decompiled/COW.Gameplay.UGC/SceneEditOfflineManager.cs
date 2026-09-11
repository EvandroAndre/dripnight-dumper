using System;
using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class SceneEditOfflineManager : SingletonModule<SceneEditOfflineManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, string>, PFIGCEKKIOG> _003C_003E9__76_0;

		public static Func<FileInfo, DateTime> _003C_003E9__87_0;

		internal PFIGCEKKIOG _003CUpdateOfflineExportUrlInternal_003Eb__76_0(KeyValuePair<string, string> item)
		{
			return null;
		}

		internal DateTime _003CSendOfflineLog_003Eb__87_0(FileInfo f)
		{
			return default(DateTime);
		}
	}

	public const string OFFLINE_MODE_SWITCH_KEY = "offline_mode_switch";

	public const string OFFLINE_MODE_ACCOUNT_ID_KEY = "offline_mode_account_id";

	public const string OFFLINE_MODE_REGION_KEY = "offline_mode_region";

	public const string OFFLINE_MODE_LANG_RES_LACK_KEY = "offline_mode_lang_res_lack";

	public const string OFFLINE_MODE_TRAINING_GROUND_WORKSHOP_CODE_KEY = "offline_mode_training_ground_workshop_code";

	public const string OFFLINE_GAME_MODE_GUIDE_1_KEY = "offline_game_mode_guide_1";

	public const string OFFLINE_GAME_MODE_GUIDE_2_KEY = "offline_game_mode_guide_2";

	public const string OFFLINE_MODE_METADATA_DIR = "MetaData";

	public const string CONFIG_DIR = "Config";

	public const string OFFLINE_MODE_GAME_DATA_DIR = "GameData";

	public const string OFFLINE_MODE_LOCAL_LOG_DIR = "LocalLog";

	public static uint OfflineTag;

	public Dictionary<string, SceneEditSlotInfo> OfflineSlotInfos;

	public Dictionary<string, string> ExportDataUrlToOfflineDataUrl;

	public Dictionary<string, byte[]> OfflineDataUrlToExportData;

	private Dictionary<string, UGCSimpleDownloadTask> m_OfflineDownloadTaskCache;

	private List<CPIPKMAAIEK> OfflineLog;

	private bool m_IsOfflineLogEmpty;

	public const string OFFLINE_MODE_AUTO_DOWNLOAD_VERSION_KEY = "offline_mode_auto_download_version";

	public Dictionary<string, SceneEditSlotInfo> OfflineAutoDownloadWorkshopCodes;

	private bool m_AutoDownloadingFirstTime;

	private int m_AutoDownloadCnt;

	private static int m_IsOfflineModeSwitchState;

	private MonoBehaviour m_CorObject;

	private uint m_DelayCallAutoWriteOfflineLogID;

	private uint m_DelayCallAutoSendOfflineLogID;

	public static bool IsOfflineModeSwitch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsOfflineAdultContentWarning => false;

	public static string OfflineAge18Region => null;

	public static ulong OfflineModeAccountID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public static string OfflineModeRegion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool OfflineModeLangResLack
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string OfflineModeTrainingGroundWorkshopCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void AddOfflineDownloadTask(string offlineDataUrl, UGCSimpleDownloadTask downloadTask)
	{
	}

	public void RemoveOfflineDownloadTask(string offlineDataUrl)
	{
	}

	public UGCSimpleDownloadTask GetOfflineDownloadTask(string offlineDataUrl)
	{
		return null;
	}

	public void ClearOfflineDownloadTask()
	{
	}

	public void AddOfflineAutoDownloadWorkshopCode(string workshopCode, int index)
	{
	}

	public void UpdateOfflineAutoDownloadWorkshopCode(string workshopCode, SceneEditSlotInfo slotInfo)
	{
	}

	public void OnGameDataReady(string workshopCode)
	{
	}

	public void OfflineAutoDownloadWorkshopCodeFinished(string workshopCode)
	{
	}

	private bool CanAutoDownloadWorkshopCodeByIndex(int index)
	{
		return false;
	}

	private string GetAutoDownloadIndexKey(string workshopCode)
	{
		return null;
	}

	public static bool TryGetOfflineLobbyAge18Logo(out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public static bool TryGetOfflineInGameAge18Logo(out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	public static void InitOfflineModeRegion()
	{
	}

	public void SetOfflineModeSwitch(bool on)
	{
	}

	public static void SetOfflineModeAccountID(ulong accountID)
	{
	}

	public void Init(MonoBehaviour coroutineRoot)
	{
	}

	public void InitSwitchData()
	{
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadOfflineSlotInfos()
	{
	}

	public bool CheckOfflineModeTraningGround()
	{
		return false;
	}

	public void CheckAllOfflineRes(bool localUpdate = false)
	{
	}

	public void StartAutoDownloadForOfflineRes()
	{
	}

	private bool CheckResReady(string shareCode, bool localUpdate = false)
	{
		return false;
	}

	private bool CheckGameDataExists(string shareCode)
	{
		return false;
	}

	private bool CheckGameDataExistsInFile(string offlineDataUrl)
	{
		return false;
	}

	private void StartAutoDownloadTask()
	{
	}

	private void LoadExportDataUrlToOfflineDataUrl()
	{
	}

	public bool CheckOfflineModeUpdate(SceneEditSlotInfo info)
	{
		return false;
	}

	private bool CheckOfflineMapValid(string shareCode)
	{
		return false;
	}

	public void UpdateOfflineData(SceneEditSlotInfo info, bool forceUpdate = false, Action onUpdateComplete = null)
	{
	}

	public void UpdatePartialOfflineMetaData(SceneEditSlotInfo info)
	{
	}

	private void UpdateOfflineMetaDataInternal(SceneEditSlotInfo info)
	{
	}

	private bool UpdateOfflineExportUrlInternal(string originalExportDataUrl, string newExportDataUrl)
	{
		return false;
	}

	private void RemoveOfflineGameDataInternal(string gameDataUrl)
	{
	}

	private void UpdateOfflineGameDataInternal(string exportDataUrl)
	{
	}

	public byte[] GetOfflineGameData(string exportDataUrl, bool cache = false)
	{
		return null;
	}

	public void InitOfflineLogCache(bool start = true)
	{
	}

	public void InitOfflineLogSend(bool start = true)
	{
	}

	public void CacheOfflineCareLog(string eventType, EventLogger.EventLoggerBase payload)
	{
	}

	private void AutoWriteOfflineLog()
	{
	}

	public void WriteOfflineLog(bool login = false)
	{
	}

	private void SendOfflineLog()
	{
	}

	public static string GetLocalFileDirectory(string subDir)
	{
		return null;
	}
}
