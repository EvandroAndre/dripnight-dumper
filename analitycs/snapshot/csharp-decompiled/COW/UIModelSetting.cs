using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using GarenaMSDK;
using proto;

namespace COW;

public class UIModelSetting : UIBaseModel
{
	public enum SyncStatus
	{
		UpCover,
		DownCover,
		DownloadNotFound,
		ConflictResolve
	}

	private enum SettingDownloadFail
	{
		None,
		NetworkErr,
		EmptyData,
		Confilct
	}

	private enum SettingDownloadType
	{
		None,
		Manual,
		Auto
	}

	private enum SettingUploadFail
	{
		None,
		NetworkErr,
		EmptyData,
		Confilct
	}

	private enum SettingUploadType
	{
		None,
		Manual,
		Auto,
		LobbyManual
	}

	public enum LocalSyncStatus
	{
		None,
		DownloadFailure,
		UploadFailure,
		SyncSuccess,
		DontNeedSync
	}

	public enum NewbieSettingType
	{
		Default,
		QuickReload,
		FreeLook,
		RunMode,
		VehicleControlMode,
		SmartIceWallShow,
		FootStepsVibrate,
		CrossHairReload,
		CrossHairMode,
		HudButtonHint
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static SDKLogin.SAFGuestCb _003C_003E9__111_0;

		public static Action<HttpErrorCode, object> _003C_003E9__118_0;

		public static Comparison<DeviceInfo> _003C_003E9__119_1;

		internal void _003CGuestRestore_003Eb__111_0(SDKLogin.SAFGuestResult safResult)
		{
		}

		internal void _003CRequestCsSetHideMyLobbyInPrefersReq_003Eb__118_0(HttpErrorCode errorCode, object res)
		{
		}

		internal int _003CRequestLoginHistory_003Eb__119_1(DeviceInfo a, DeviceInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public UIModelSetting _003C_003E4__this;

		public AccountPlatform unbindPlatform;

		public Action<SDKBind.PlatformBindingInfo> _003C_003E9__1;

		internal void _003CRequestBindDelete_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}

		internal void _003CRequestBindDelete_003Eb__1(SDKBind.PlatformBindingInfo rsp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public Action<CSUseHudSettingsShareCodeRes> onComplete;

		public UIModelSetting _003C_003E4__this;

		public bool isFromKolHudPopWnd;

		internal void _003CReqUseHudShareCode_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public UIModelSetting _003C_003E4__this;

		public bool isAuto;

		public bool isLobbyManual;

		public CSPlayerSettingsReq actualReq;

		internal void _003CRequestUploadSetting_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	public const int PropID_UploadSettingCover = 1;

	public const int PropID_UploadSettingStart = 2;

	public const int PropID_UploadSettingFinish = 4;

	public const int PropID_DownloadSettingCover = 8;

	public const int PropID_DownloadSettingFailure = 16;

	public const int PropID_DownloadSettingFinish = 32;

	public const int PropID_UploadFailure = 64;

	public const int PropID_DownloadFailure = 128;

	public const int PropId_HasUnknownDevice = 256;

	public const int PropId_GetLoginHistory = 512;

	public const int PropId_UnbindSuccessful = 1024;

	public const int PropID_GetAllHudShareCodeOK = 2048;

	public const int PropID_GenerateHudShareCodeOK = 4096;

	public const int PropID_UseHudShareCodeOK = 8192;

	private const string m_HudShareCodePrefix = "#FFHUD";

	private StringBuilder m_StringBuilder;

	private const int m_HudShareCodeFromBackendLength = 16;

	public const string KEY_UPLOAD_SETTING_VN_LAST_SHOW_TIME = "KEY_UPLOAD_SETTING_VN_LAST_SHOW_TIME";

	public const string KEY_UPLOAD_SETTING_IND_LAST_SHOW_TIME = "KEY_UPLOAD_SETTING_IND_LAST_SHOW_TIME";

	private Dictionary<string, CustomHudDescData> m_CustomHudDescDataDic;

	private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudChangedConfigDic;

	private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudNewChangedConfigDic;

	private Dictionary<string, HudConfigItem> m_HudThreeChangedConfigDic;

	private Dictionary<string, HudConfigItem> m_HudThreeDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudThreeCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudFourChangedConfigDic;

	private Dictionary<string, HudConfigItem> m_HudFourDefaultConfigDic;

	private Dictionary<string, HudConfigItem> m_HudFourCustomizeConfigDic;

	private Dictionary<string, HudConfigItem> m_HudVehicleChangedConfigDic;

	private Dictionary<string, bool> m_EventHudAvalibleDic;

	private byte[] m_SettingDetailSerialized;

	private string m_Version;

	private SettingsTransferStatus m_Flag;

	private int m_UIRootWidth;

	private CustomerReportDesc m_CustermerReportDesc;

	private List<DeviceInfo> m_LoginHistoryInfo;

	private bool m_HasUnknownDevice;

	private string m_AccountCenterUrl;

	private List<uint> m_HasBindAccountPlatforms;

	private bool m_HasRequestLoginHistory;

	private bool m_HasDifferentDevice;

	private Dictionary<int, List<GlobalClickRecorder.ClickRecord>> m_HudClickRecordBuckets;

	private int m_CurrentHudPresetIndex;

	private UISettingController m_SettingCtrl;

	private static bool _ShownGuestRestorePopUp;

	public const string OVERWRITE_INSTALL_FIRST_STARTUP = "OVERWRITE_INSTALL_FIRST_STARTUP_{0}";

	public const string LOCAL_SETTING_VERSION = "LOCALSETTINGVERSION_{0}";

	private const string SETTING_DOWNLOADED = "SettingDownloaded_{0}";

	private const string AUTO_SYNC_SETTING_LOG = "AutoSyncSetting {0}  localVer:{1}    serverVer:{2}";

	public static string Auto_Download_Tried;

	public static bool FirstStartUp;

	public static int INVILD_SETTING_VERSION;

	public bool IsAutoPopSyncWndNeeded;

	private int _003CServerSettingVersion_003Ek__BackingField;

	private Dictionary<KeyValuePair<uint, uint>, SettingPic> m_SettingPicDict;

	private Dictionary<string, string> m_SettingPicCDNExchangeDict;

	private float m_GenetateHudShareCodeLastTime;

	private float m_UseHudShareCodeLastTime;

	private Dictionary<string, CustomHudDescData> CustomHudDescDataDic => null;

	public bool HasRequestLoginHistory => false;

	public bool HasDifferentDevice => false;

	public int UIRootWidth => 0;

	public List<DeviceInfo> LoginHistoryInfo => null;

	public bool HasUnknownDevice => false;

	public string AccountCenterUrl => null;

	public List<uint> HasBindAccountPlatforms => null;

	public LocalSyncStatus CurrentSyncStatus => LocalSyncStatus.None;

	private bool IsAutoDownloadTried => false;

	public bool IsCurrentAccoundSynced => false;

	public int ServerSettingVersion
	{
		get
		{
			return _003CServerSettingVersion_003Ek__BackingField;
		}
		set
		{
			_003CServerSettingVersion_003Ek__BackingField = value;
		}
	}

	public int LocalSettingVersion
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void SendHudDiffLog()
	{
	}

	private bool IsDifferentHudConfig(Dictionary<string, HudConfigItem> hudOne, Dictionary<string, HudConfigItem> hudTwo)
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}

	public Dictionary<string, HudConfigItem> GetHudChangedConfigDic()
	{
		return null;
	}

	public Dictionary<string, HudConfigItem> GetNewChangedConfigDic()
	{
		return null;
	}

	public Dictionary<string, HudConfigItem> GetThreeChangedConfigDic()
	{
		return null;
	}

	public Dictionary<string, HudConfigItem> GetFourChangedConfigDic()
	{
		return null;
	}

	public byte[] ZipString(string unCompressedString)
	{
		return null;
	}

	public string UnZipString(byte[] bytData)
	{
		return null;
	}

	public void ProcessURLSettingDesc(LoginDescRes desc)
	{
	}

	public CustomerReportDesc GetCustomerReportDesc()
	{
		return null;
	}

	public string GetUploadSettingMD5()
	{
		return null;
	}

	public string GetSettingMD5()
	{
		return null;
	}

	public void CheckUploadSetting()
	{
	}

	public void UploadSetting()
	{
	}

	public void LobbyManualUploadSetting()
	{
	}

	public void ForceUploadSetting()
	{
	}

	public void AutoUploadSetting()
	{
	}

	public void RequestUploadSetting(CSPlayerSettingsReq actualReq, bool isAuto = false, bool isLobbyManual = false)
	{
	}

	public void CheckDownloadSetting()
	{
	}

	public void DownloadSettingInConflict()
	{
	}

	public void AutoDownloadSetting(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void DownloadSetting()
	{
	}

	public void ProcessSettingDownload(CSPlayerSettingsRes playerSettings)
	{
	}

	private void SendSettingDownloadInfoLog(SettingDownloadType downloadType, bool isSuccess, SettingDownloadFail failReason = SettingDownloadFail.None)
	{
	}

	private void SendSettingFirstStartUpLog()
	{
	}

	private void SendSettingUploadInfoLog(SettingUploadType uploadType, bool isSuccess, SettingUploadFail failReason = SettingUploadFail.None)
	{
	}

	private void GenerateSettingContentBaseContent(EventLogger.SettingContentBase baseLog)
	{
	}

	public void SetSettingCtrl(UISettingController ctrl)
	{
	}

	public bool IsSettingCtrlOpen()
	{
		return false;
	}

	public void GetDownloadedHudConfig(string pos, Dictionary<string, HudConfigItem> hudChanged, bool isVehicle = false, bool needTryBuild51AddedHud = false, bool needTryBuild50AddedHud = false)
	{
	}

	private void CompareHudConfigForDownload()
	{
	}

	private void SetHudConfig()
	{
	}

	private void SetOtherConfig(SettingDetail settingDetail)
	{
	}

	public void GetDefaultHudConfig()
	{
	}

	public void LoadHudConfigFromPlayerPref()
	{
	}

	public void CompareHudConfigForUpload()
	{
	}

	public void InitSettingLogAll()
	{
	}

	public bool ShowGuestRestoreInSettings()
	{
		return false;
	}

	public bool ShowGuestBackupInSettings()
	{
		return false;
	}

	public void GuestRestore()
	{
	}

	public void GuestBackUp()
	{
	}

	public bool ShowGuestRestorePopUp()
	{
		return false;
	}

	public void ShowGuestRestorePopUpDone()
	{
	}

	public void GetNowSettingLogAll()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RequestCsSetHideMyLobbyInPrefersReq(bool show)
	{
	}

	public void RequestLoginHistory(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestBindDelete(AccountPlatform unbindPlatform)
	{
	}

	public void ProcessAccountCenterDesc(CSAccountCenterDescRes desc)
	{
	}

	public bool HasBindPlatformToday(AccountPlatform platform)
	{
		return false;
	}

	public bool IsAutoDownloadNeeded()
	{
		return false;
	}

	public void TryAutoDownloadSetting(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void SettingContentLog(string contentKey)
	{
	}

	public bool UpdateLocalVersionCode()
	{
		return false;
	}

	public void TryShowSyncPop(SyncStatus syncStatus)
	{
	}

	public void SettingVersionLog(string desc = "")
	{
	}

	public void UpdateDefaultSettingOnlyOnce()
	{
	}

	public void UpdateDefaultSettingInForceTutorial(EAccount.NewbieChoice newbieType, bool isHud4)
	{
	}

	private bool OnGrenadeSlotSet(int value)
	{
		return false;
	}

	private int GetNewbieSettingValueByType(EAccount.NewbieChoice newbieType, string settingVar)
	{
		return 0;
	}

	public SettingPic GetSettingPicData(uint TypeID, uint stateIndex)
	{
		return null;
	}

	private void LoadSettingPicData()
	{
	}

	public string GetExchangedSettingPicCDN(string originalCDN)
	{
		return null;
	}

	private void LoadSettingPicCDNExchangeData()
	{
	}

	private bool CurrentIsSameWithDefault(int currentPreset)
	{
		return false;
	}

	public void UpdateEventHud()
	{
	}

	public bool IsEventHudAvailable(string hudName)
	{
		return false;
	}

	public void ReqGenetateHudShareCode(int index)
	{
	}

	public bool ReqUseHudShareCode(string clientCode, bool isFromKolHudPopWnd = false, Action<CSUseHudSettingsShareCodeRes> onComplete = null)
	{
		return false;
	}

	public bool HudShareCodeClientCheckValid(string clientCode)
	{
		return false;
	}

	public CustomHudDescData GetCustomHudDescData(string hudName)
	{
		return null;
	}

	public bool IsSeletionDefaultByIdx(int idx)
	{
		return false;
	}

	public bool ShouldShowUploadSetting()
	{
		return false;
	}

	public bool CheckCanShowUploadSettingForCompliance()
	{
		return false;
	}

	public void SetCurrentHudPreset(int presetIndex)
	{
	}

	public int GetCurrentHudPreset()
	{
		return 0;
	}

	public void AddHudClickRecord(float x, float y, float timestamp, int fingerId)
	{
	}

	public List<GlobalClickRecorder.ClickRecord> GetHudClickRecords(int presetIndex)
	{
		return null;
	}

	private List<GlobalClickRecorder.ClickRecord> LoadClickRecordsFromFiles(int presetIndex)
	{
		return null;
	}

	public Dictionary<int, List<GlobalClickRecorder.ClickRecord>> GetAllHudClickRecordBuckets()
	{
		return null;
	}

	public int GetHudClickRecordsCount()
	{
		return 0;
	}

	public void ClearHudClickRecords()
	{
	}

	private void _003CCheckUploadSetting_003Eb__80_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CCheckDownloadSetting_003Eb__86_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CDownloadSettingInConflict_003Eb__87_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CAutoDownloadSetting_003Eb__88_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CDownloadSetting_003Eb__89_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLoginHistory_003Eb__119_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CReqGenetateHudShareCode_003Eb__166_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
