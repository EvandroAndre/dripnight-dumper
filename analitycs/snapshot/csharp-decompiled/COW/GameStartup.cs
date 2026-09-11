using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class GameStartup : MonoBehaviour
{
	public enum EGameServerAddress
	{
		LOCAL_SERVER,
		SBT_SERVER,
		LIVE_SERVER,
		IOS_SERVER,
		RCT_SERVER,
		PREVIEW_SERVER,
		BETA_SERVER,
		EXP_SERVER,
		ART_SERVER,
		DESIGN_SERVER,
		ACTION_SERVER
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static NGUITools.OnLogCallback _003C_003E9__28_0;

		public static Func<StartUpShaderWarmupConfig, uint> _003C_003E9__64_0;

		internal void _003CAwake_003Eb__28_0(DebugLogType logType, string content)
		{
		}

		internal uint _003CLoadStartupShaderWarmupConfig_003Eb__64_0(StartUpShaderWarmupConfig value)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public GameStartup _003C_003E4__this;

		public bool isRestart;

		internal void _003CStartLauncher_003Eb__0()
		{
		}

		internal UIBaseController _003CStartLauncher_003Eb__1(string path, Type type)
		{
			return null;
		}
	}

	public static GameStartup instance;

	private bool m_IsEnterGame;

	private static long _003CStartUpTime_003Ek__BackingField;

	public bool UseAssetBundle;

	public bool MuteSound;

	public string DevId;

	public bool ShowDebugInfo;

	public EGameServerAddress m_gameServer;

	public string CDNAddr;

	public string ABHotUpdateCDNAddr;

	public string IconCDNAddr;

	public string VerAddr;

	public string GatewayAddr;

	public bool SkipVersionCheck;

	public bool ShowTutorial;

	public bool EnableBackgroundThread;

	private CSVAsyncDataMap<uint, StartUpShaderWarmupConfig> ShaderWarmupConfigs;

	private bool m_IsFirstStartup;

	private COWGameEntry m_MainEntry;

	private UILauncherController m_LaucherController;

	public static readonly string ENABLE_LOAD_RESCONF_AND_LOC_EARLY;

	public static readonly string LOAD_RESCONF_EARLY_FAILED;

	public static readonly string LOAD_RESCONF_EARLY_FIRST_STARTUP;

	public static readonly string ENABLE_BUG_REPORT_EARLY;

	private bool _003CEarlyLoadedLocFiles_003Ek__BackingField;

	private const string DelayLoadIndexerKey = "DELAY_LOAD_INDEXER";

	private const string AssetIndexerUrl = "Avatar/AssetIndexer";

	private static readonly string[] DONT_DESTROY_RESOURCES;

	private static int s_IsDelayLoadIndexer;

	public static long StartUpTime
	{
		get
		{
			return _003CStartUpTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartUpTime_003Ek__BackingField = value;
		}
	}

	public bool EarlyLoadedLocFiles
	{
		get
		{
			return _003CEarlyLoadedLocFiles_003Ek__BackingField;
		}
		set
		{
			_003CEarlyLoadedLocFiles_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Quit(string str)
	{
	}

	public static bool CheckEnableLoadResconfAndLocEarly()
	{
		return false;
	}

	public static bool CheckEnableBugReportEarly()
	{
		return false;
	}

	private void OnApplicationQuit()
	{
	}

	public string GetOBBPath()
	{
		return null;
	}

	public long GetOBBSize()
	{
		return 0L;
	}

	private static bool EarlyCheckLocFilesReady()
	{
		return false;
	}

	public static bool EarlyLoadLocRes()
	{
		return false;
	}

	public void StartGame()
	{
	}

	public void Restart()
	{
	}

	public void CloseLauncher()
	{
	}

	public void StartLauncher(bool isRestart)
	{
	}

	public static string[] GetDontDestroyResourcesForInit()
	{
		return null;
	}

	public static void SetDelayLoadIndexer(bool s)
	{
	}

	public static bool IsDelayLoadIndexer()
	{
		return false;
	}

	public static void DelayLoadIndexerInNeed()
	{
	}

	private void LaunchGame(bool isSoftRestart)
	{
	}

	private void ResetTutorialManager()
	{
	}

	private void CreateNGUICultureInfo()
	{
	}

	private void AfterGameEntryInit(COWGameEntry gameEntry)
	{
	}

	private T CreateUI<T>(Transform root, string path) where T : UIBaseController
	{
		return null;
	}

	private UIBaseController CreateUI(Transform root, string path, Type classType)
	{
		return null;
	}

	public bool IsFirstStartup()
	{
		return false;
	}

	public ResourceID GetStartupShaderCollectionResID()
	{
		return default(ResourceID);
	}

	private ResourceID GetShaderCollectionByConfig(int currentLOD)
	{
		return default(ResourceID);
	}

	private void LoadStartupShaderWarmupConfig()
	{
	}

	private void _003CStart_003Eb__29_0(Dictionary<int, bool> result)
	{
	}
}
