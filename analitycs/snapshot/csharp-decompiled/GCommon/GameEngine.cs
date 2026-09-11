using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorldStreamer;

namespace GCommon;

internal class GameEngine : MonoBehaviour
{
	private sealed class _003CAsyncLoadPreloadResource_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameEngine _003C_003E4__this;

		public BaseGame game;

		private ResourceID[] _003Caudio_preloadedResource_003E5__2;

		private uint _003CcntPerFrame_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAsyncLoadPreloadResource_003Ed__63(int _003C_003E1__state)
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

	private sealed class _003CCleanAssets_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameEngine _003C_003E4__this;

		public bool shouldCleanPreloadResources;

		public bool waitCleanUp;

		public bool isInGame;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCleanAssets_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003CLoadGameProcess_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseGame game;

		public GameEngine _003C_003E4__this;

		private float _003Cgamescenestarttime_003E5__2;

		private ResourceID[] _003CsceneList_003E5__3;

		private string _003CsceneAbPath_003E5__4;

		private bool _003CuseAb_003E5__5;

		private int _003Ci_003E5__6;

		private AsyncOperation _003CsceneLoadState_003E5__7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadGameProcess_003Ed__64(int _003C_003E1__state)
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

	private sealed class _003CLoadLoadingScene_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameEngine _003C_003E4__this;

		public bool shouldCleanPreloadResources;

		private float _003Cloadingscenestarttime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadLoadingScene_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CLoadPreloadResource_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseGame game;

		public GameEngine _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private ResourceID[] _003Caudio_preloadedResource_003E5__3;

		private int _003Cpreload_count_003E5__4;

		private int _003CloadedCount_003E5__5;

		private uint _003CcntPerFrame_003E5__6;

		private ResourceID[] _003C_003E7__wrap6;

		private int _003C_003E7__wrap7;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadPreloadResource_003Ed__58(int _003C_003E1__state)
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

	private sealed class _003CPreloadAudioAsync_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceID[] audio_preloadedResource;

		public GameEngine _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPreloadAudioAsync_003Ed__59(int _003C_003E1__state)
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

	public static GameEngine instance;

	public static ObjectPool<TimerAction> GlobalTimerActionPool;

	private BaseGame m_CurrentGame;

	private TimeService m_EngineTimer;

	private ResourceID m_LoadingSceneResourceID;

	private Type m_PendingGameType;

	private BaseGameContext m_PendingGameContext;

	private float m_LoadingPreloadedResourceProgress;

	private bool m_LoadingInProcess;

	private bool m_UseAdditiveLoading;

	private Action m_OnLoadAndRunFinished;

	private bool MaualGcWhenCloseInGameAutoGC;

	private bool MaualGcWhenInGameNoGC;

	private FCoroutineMgr coroutineMgr;

	private UniqueIDGenerator m_UniqueIDGen;

	private Dictionary<uint, TimerAction> m_TimerActions;

	private List<uint> m_ExpiredTimerActions;

	private Dictionary<uint, Action> m_TimerActionsToBeCalled;

	public static Action<string, string, string> BugReportSetKeyValue;

	private float m_LoadingPendingGameProgress;

	private bool m_isLoading;

	private List<ResourceID> m_PreloadAudio_Unity;

	private Dictionary<uint, bool> m_WaitingAsyncLoadResource;

	public float LoadingPreloadedResourceProgress => 0f;

	public float LoadingPendingGameProgress => 0f;

	public TimeService EngineTimer => null;

	public Type PendingGameType => null;

	public bool LoadingInProcess => false;

	public bool IsLoading
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public BaseGame GetCurrentGame()
	{
		return null;
	}

	public void SetLoadingSceneResourceID(ResourceID id)
	{
	}

	public void StartFCoroutine(IEnumerator inEnu)
	{
	}

	public void FinishImmdiateFCoroutine(IEnumerator inEnu)
	{
	}

	public void StopFCoroutine(IEnumerator inEnu)
	{
	}

	public uint DelayCall(float delayTime, Action action, bool isRepeated = false)
	{
		return 0u;
	}

	public void CancelDelayCall(uint id)
	{
	}

	public void RunOneFrame()
	{
	}

	public void FixedRunOneFrame()
	{
	}

	public void LateRunOneFrame()
	{
	}

	public float GetEngineTime()
	{
		return 0f;
	}

	public bool LoadAndRun(Type gameType, BaseGameContext sharedData = null, bool useAdditiveLoading = false, Action OnFinished = null, bool waitAssetCleanUp = true)
	{
		return false;
	}

	private bool NeedLoadLoadingScene()
	{
		return false;
	}

	private void AfterCleanAssets(bool shouldCleanPreloadResources)
	{
	}

	public void LoadPendingGame()
	{
	}

	public void LoadPreloadResource()
	{
	}

	public void LoadAndRun<T>(BaseGameContext sharedData = null, bool useAdditiveLoading = false, Action onFinished = null, bool waitAssetCleanUp = true) where T : BaseGame, new()
	{
	}

	private IEnumerator CleanAssets(bool shouldCleanPreloadResources, bool isInGame, bool waitCleanUp)
	{
		return null;
	}

	public void EnableMaualGcWhenCloseInGameAutoGC()
	{
	}

	public void EnableMaualGcWhenCloseInGameNoGC()
	{
	}

	private IEnumerator LoadLoadingScene(bool shouldCleanPreloadResources)
	{
		return null;
	}

	private void ChangeScreenSize()
	{
	}

	private IEnumerator LoadPreloadResource(BaseGame game)
	{
		return null;
	}

	private IEnumerator PreloadAudioAsync(uint cntPerFrame, ResourceID[] audio_preloadedResource, int loadedCount = 0)
	{
		return null;
	}

	private void OnAsyncPreLoaded(uint ticket, bool succeeded, UnityEngine.Object resObj)
	{
	}

	public bool IsAsyncPreloadFinish()
	{
		return false;
	}

	private IEnumerator AsyncLoadPreloadResource(BaseGame game)
	{
		return null;
	}

	private IEnumerator LoadGameProcess(BaseGame game)
	{
		return null;
	}

	private bool LoadMapPatch(BaseGame game, ResourceID[] sceneList)
	{
		return false;
	}

	private void AddToListAtIndex(List<CFIJFGBBLON> patchOrder, AssetBundle scenePatchAB, int index)
	{
	}

	public void StartGameCoroutine(BaseGame game, IEnumerator enumerator)
	{
	}

	public float GetRealtimeSinceStartup()
	{
		return 0f;
	}
}
