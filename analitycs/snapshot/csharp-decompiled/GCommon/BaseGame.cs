using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;
using WorldStreamer;

namespace GCommon;

public abstract class BaseGame
{
	private sealed class _003COnPreprocessFinished_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnPreprocessFinished_003Ed__74(int _003C_003E1__state)
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

	private sealed class _003CStartInGameReloadCo_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BaseGame _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartInGameReloadCo_003Ed__143(int _003C_003E1__state)
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

	internal static Dictionary<uint, IEntityTicker> sTickedEntities;

	internal static Dictionary<uint, Entity> sAllEntities;

	internal static Dictionary<uint, LEntity> sAllLEntities;

	protected UIBaseScene m_UIScene;

	protected TimeService m_GameTimer;

	protected TimeService m_SimulationTimer;

	protected EventDispatcher m_GameEventDispatcher;

	protected BaseGameContext m_GameContext;

	protected LoadingProcessManager m_LoadingProcessManager;

	protected UniqueIDGenerator m_UniqueIDGen;

	protected DelayCallTimer m_ClientTimeDelayCall;

	protected DelayCallTimer m_ServerTimeDelayCall;

	protected int m_CurFrameArranged;

	protected ConditionActionManager m_conditionActionManager;

	private EntityVisualEffectManager m_VisualEffectManager;

	private BackgroundCacher _003CBgCacher_003Ek__BackingField;

	private OIAOIMOACIP m_FullScreenVfxManager;

	private bool m_HasInited;

	private bool m_HasLoadingFailed;

	private bool m_HasFixedUpdated;

	private bool m_SceneLoaded;

	protected bool m_IsPaused;

	public uint sUniqueEntityID;

	private bool m_IsMatchEnd;

	protected bool m_IsDuringInGameReload;

	public static uint[] LevelObjectTypeDoNotHandled;

	public UIBaseScene UIScene => null;

	public TimeService GameTimer => null;

	public TimeService SimulationTimer => null;

	public EventDispatcher GameEventDispatcher => null;

	public BaseGameContext GameContext => null;

	public BackgroundCacher BgCacher
	{
		get
		{
			return _003CBgCacher_003Ek__BackingField;
		}
		protected set
		{
			_003CBgCacher_003Ek__BackingField = value;
		}
	}

	public EntityVisualEffectManager VisualEffectManager => null;

	public bool IsMatchEnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDuringInGameReload => false;

	internal static void RegisterEntity(LEntity entity)
	{
	}

	internal static void UnregisterEntity(LEntity entity)
	{
	}

	internal static void RegisterEntity(Entity entity)
	{
	}

	internal static void UnregisterEntity(Entity entity)
	{
	}

	public static void HideAllEntity()
	{
	}

	public Entity GetEntityByUniqueID(uint id)
	{
		return null;
	}

	public uint GetUniqueID()
	{
		return 0u;
	}

	public void Init(BaseGameContext gameContext = null)
	{
	}

	protected virtual bool GetNeedUseOptEventDispatcher()
	{
		return false;
	}

	public void SceneLoaded()
	{
	}

	private void InitSceneIfNeed()
	{
	}

	public bool IsSceneLoaded()
	{
		return false;
	}

	public void SceneStart()
	{
	}

	public void PreloadLoaded()
	{
	}

	public virtual uint GetPreloadCountPerFrame()
	{
		return 0u;
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

	public void UnInit()
	{
	}

	public float GetNextArrageTime(float delayTime)
	{
		return 0f;
	}

	public uint DelayCall(float delayTime, Action action, bool isRepeated = false, bool forceSet = false, bool useServerTime = false)
	{
		return 0u;
	}

	public void ChangeDelayCallTime(uint id, float deltaTime)
	{
	}

	public uint CancelAndDelayCall(uint id, float delayTime, Action action, bool isRepeated = false)
	{
		return 0u;
	}

	public void CancelDelayCall(uint id)
	{
	}

	public void CancelDelayCallAnyWay(ref uint id)
	{
	}

	public bool ExistDelayCall(uint id)
	{
		return false;
	}

	public ConditionAction AddConditionAction(ConditionAction.ActionHandler callback)
	{
		return null;
	}

	public void CancelConditionAction(int guid)
	{
	}

	public bool HasInited()
	{
		return false;
	}

	public bool HasLoadingFailed()
	{
		return false;
	}

	public virtual void OnStartLoadScene()
	{
	}

	public virtual bool NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	public virtual IEnumerator OnPreprocessFinished()
	{
		return null;
	}

	protected virtual void OnAwake()
	{
	}

	protected virtual void OnSceneLoaded()
	{
	}

	protected virtual void OnPreloadLoaded()
	{
	}

	protected virtual void AfterPreloadLoaded()
	{
	}

	protected virtual void OnUnInit()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	protected virtual void OnInputUpdate()
	{
	}

	protected virtual void OnFixedUpdate()
	{
	}

	protected virtual void OnLateUpdate()
	{
	}

	protected virtual void OnNetworkFixedUpdate()
	{
	}

	public virtual bool SkipFixedUpdate()
	{
		return false;
	}

	public abstract ResourceID[] GetResourceID();

	public abstract Type GetUISceneType();

	public virtual void PreloadGameResource()
	{
	}

	public virtual ResourceID[] GetPreloadResourceIDSeq()
	{
		return null;
	}

	public virtual ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	public virtual ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	public virtual IEnumerator PreloadUmas()
	{
		return null;
	}

	public virtual List<int> GetPreloadUmaResource()
	{
		return null;
	}

	public virtual LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	public virtual bool IsOptWaitGameInitAfterLoadScene()
	{
		return false;
	}

	public virtual void OnLoadingFailed(int expectionProcessIndex)
	{
	}

	public virtual void OnLoadingSceneFailed()
	{
	}

	public virtual int GetGameType()
	{
		return 0;
	}

	public virtual int GetSubGameType()
	{
		return 0;
	}

	public virtual bool NotUsingAB()
	{
		return false;
	}

	public virtual void SetSceneABInfo(AssetBundle ab, bool useAB, string abPath, string streamPath)
	{
	}

	public virtual void SetScenePatchABInfo(Dictionary<int, List<CFIJFGBBLON>> patchAB)
	{
	}

	public virtual AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	public virtual Dictionary<int, List<CFIJFGBBLON>> GetStreamScenePatchAB()
	{
		return null;
	}

	public virtual byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	public virtual string GetSceneStreamABPath()
	{
		return null;
	}

	public virtual string GetSceneABPath()
	{
		return null;
	}

	public virtual string GetSceneName()
	{
		return null;
	}

	public virtual bool ShouldClearPreloadAssets(Type nextGameType)
	{
		return false;
	}

	public virtual void PauseGame(bool v)
	{
	}

	public virtual bool IsGamePaused()
	{
		return false;
	}

	public virtual bool NeedAimAssist()
	{
		return false;
	}

	public virtual void OnMatchStart()
	{
	}

	public virtual void OnMatchEnd()
	{
	}

	public virtual void LocalPlayerSelectEquipSet(uint index)
	{
	}

	public virtual void OnLoadingMaskClosed()
	{
	}

	public virtual bool CanShowGodEffect()
	{
		return false;
	}

	public virtual bool EnableGlassBG()
	{
		return false;
	}

	public virtual bool IsGameNeedCheckObserverMatchEnd()
	{
		return false;
	}

	public virtual bool EnableAvatarManager()
	{
		return false;
	}

	public virtual bool EnableSpecialTick()
	{
		return false;
	}

	public virtual void SimulationSpecialTick(float gameTime, float deltaTime)
	{
	}

	public virtual bool IsMatchFighting()
	{
		return false;
	}

	public virtual bool IsCabinWaitingGame()
	{
		return false;
	}

	public virtual bool CheckLeaderBoardTitleCanAutoShow()
	{
		return false;
	}

	public uint AppendFullScreenVfx(JDENHBGIAGE priority, ResourceID resId, ManagedVisualInstanceHolder.OnManagedInstanceAttached onCreated = null)
	{
		return 0u;
	}

	public uint AppendFullScreenVfx(JDENHBGIAGE priority, Action<bool> customVisibilityChangeCallback)
	{
		return 0u;
	}

	public void RemoveFullScreenVfx(ref uint uniqueId)
	{
	}

	public void RemoveAllFullScreenVfx()
	{
	}

	public bool IsFullScreenVfxExisted(uint uniqueId)
	{
		return false;
	}

	public void RefreshFullScreenVfxByUIGroup(UInt128 uiGroup)
	{
	}

	public virtual byte GetIIVFloatingLandPlayerCount()
	{
		return 0;
	}

	public virtual int GetIIVFloatingLandMaxPlayerCount()
	{
		return 0;
	}

	public virtual uint GetUniqueReplicationEntityID()
	{
		return 0u;
	}

	public virtual FJEEGHOAKOG GetUGCBridge()
	{
		return null;
	}

	public void CheckLevelObjectTypePreRegistered(uint lvlobjType)
	{
	}

	public void StartInGameReload()
	{
	}

	public IEnumerator StartInGameReloadCo()
	{
		return null;
	}

	private void InitWithInGameReload()
	{
	}

	private void UnInitWithInGameReload()
	{
	}

	protected virtual void OnInitWithInGameReload()
	{
	}

	protected virtual void OnUnInitWithInGameReload()
	{
	}

	private void _003CInit_003Eb__49_0(bool result, int exceptionProcessIndex)
	{
	}
}
