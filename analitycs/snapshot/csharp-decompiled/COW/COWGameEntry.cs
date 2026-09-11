using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using GCommon;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace COW;

public class COWGameEntry : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public COWGameEntry _003C_003E4__this;

		public bool waitAssetCleanUp;

		internal void _003CEnterFrontEndGame_003Eb__0(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_1
	{
		public Scene scene;

		internal void _003CEnterFrontEndGame_003Eb__1()
		{
		}
	}

	private sealed class _003CChangeResolution_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CChangeResolution_003Ed__73(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CInitCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public COWGameEntry _003C_003E4__this;

		public bool fromAwake;

		public Action<COWGameEntry> afterAwake;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitCoroutine_003Ed__16(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRefreshConfigDataCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int callPos;

		public COWGameEntry _003C_003E4__this;

		public bool isRestart;

		private bool _003CdelayedAwake_003E5__2;

		private Stopwatch _003Csw_003E5__3;

		private int _003CyieldMs_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshConfigDataCoroutine_003Ed__39(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private GameEngine m_GameEngine;

	private StringBuilder m_OperChain;

	private UIPopupMessageBoxController m_QuitDialog;

	private bool _003CPaused_003Ek__BackingField;

	private bool _003CUseInitCoroutine_003Ek__BackingField;

	private bool m_GameInitializeCompleted;

	private bool m_ShaderWarmupCompleted;

	private bool m_EnteredFrontEndGame;

	private bool m_disableGcForCsv;

	private long m_DelayedAwakeEclipsedMs;

	public const string PREF_LOAD_TRANS_LAZY = "LOAD_TRANS_LAZY";

	private static float lowMemoryLastTime;

	private static float lowMemoryReportLastTime;

	private static int lowMemoryCount;

	private static float lowMemoryUnloadLastTime;

	public bool Paused
	{
		get
		{
			return _003CPaused_003Ek__BackingField;
		}
		set
		{
			_003CPaused_003Ek__BackingField = value;
		}
	}

	public bool UseInitCoroutine
	{
		get
		{
			return _003CUseInitCoroutine_003Ek__BackingField;
		}
		private set
		{
			_003CUseInitCoroutine_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private static void FinishCoroutine(IEnumerator ie)
	{
	}

	public IEnumerator InitCoroutine(bool fromAwake, Action<COWGameEntry> afterAwake)
	{
		return null;
	}

	private void InitBeforeRefreshConfigData()
	{
	}

	private void InitAfterRefreshConfigData()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void WarmUpEnum(object state)
	{
	}

	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	public string GetVersionString()
	{
		return null;
	}

	public void Restart()
	{
	}

	private void EnterFrontEndGame(bool waitAssetCleanUp = true)
	{
	}

	private void RecordEnableLoadResconfAndLocEarly()
	{
	}

	private void RecordEnableBugReportEarly()
	{
	}

	private static void ParseResourceConf()
	{
	}

	private static void ParseResconfHotupdate()
	{
	}

	private void RefreshConfigData(bool isRestart)
	{
	}

	private void ResetRefreshConfigDataCorFields()
	{
	}

	private IEnumerator RefreshConfigDataCoroutine(bool isRestart, int callPos)
	{
		return null;
	}

	private void LoadResconf()
	{
	}

	private void LoadIFix()
	{
	}

	private void LoadGameVar(bool isRestart)
	{
	}

	private void ApplyGameVar(bool disableGcForCsv)
	{
	}

	public static void SaveDelayLoadIl2cppOption(int val)
	{
	}

	private void InitRegionLangManager()
	{
	}

	private void InitSetBoolean()
	{
	}

	private void LoadCsvs_1()
	{
	}

	private void InitManagers_1()
	{
	}

	private void InitAutoPickup()
	{
	}

	private void LoadCsvs_2()
	{
	}

	private void InitManagers_2()
	{
	}

	private void InitServer()
	{
	}

	private void InitHttp()
	{
	}

	private void ReleaseAnoymousMappingTmp()
	{
	}

	private static void RefreshConfigForPlatformUtility()
	{
	}

	public static KeyValuePair<TKey, TValue> Pair<TKey, TValue>(TKey key, TValue value)
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	private void PreloadConfigData(Action actionBeforeWaitAllThreads)
	{
	}

	private List<KeyValuePair<ResourceID, Type>> GetPreloadConfigData()
	{
		return null;
	}

	private void LoadLoc()
	{
	}

	public static bool LoadLocLazyInNeed(TextAsset id_res, bool beforeGameVar = false)
	{
		return false;
	}

	private static FileStream OpenTransIdxFile()
	{
		return null;
	}

	private void RefreshPrezEnable()
	{
	}

	private void HandleBackButton()
	{
	}

	private void InitShaderGlobalVariant()
	{
	}

	private void EngineSwitchAndWarmUpShader()
	{
	}

	private static void WarmupStartupShaderCollection(int warmupStep, Action warmupCallback)
	{
	}

	private static void SetMetalShaderCompilationState(bool isCompiling)
	{
	}

	private void PreloadConfigMainThreadWork()
	{
	}

	private void CloseTripleBuffers()
	{
	}

	private void OnMainActivityConfigurationChanged(PlatformUtility_Android.ActivityConfiguration conf)
	{
	}

	private void OnMainActivityDisplayChanged()
	{
	}

	private IEnumerator ChangeResolution()
	{
		return null;
	}

	private static void OnLowMemory()
	{
	}

	private void OnGGPUpdate()
	{
	}

	private void OnGameInitializationReady()
	{
	}

	private void OnShaderWarmupReady()
	{
	}

	private void TryEnterFrontEndGame(bool waitAssetCleanUp = true)
	{
	}

	private void _003CHandleBackButton_003Eb__64_0()
	{
	}

	private void _003CHandleBackButton_003Eb__64_1()
	{
	}
}
