using System;
using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCRuntime
{
	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public JOEANMPIFAB gameData;

		public UGCRuntime _003C_003E4__this;

		internal void _003CUnSerializeMainSceneEntity_003Eb__0()
		{
		}
	}

	private UGCEntityDataStore entityDataStore;

	private IUGCModuleTransform m_trs;

	private IUGCModuleAnimation aniModule;

	private IGameBridge bridgingGame;

	private UGCDebugLogger debugLogger;

	private UGCVMDebugger vmDebugger;

	public QuickObjectPoolMap objectPool;

	private Func<int, UGCFunctionDelegate> getFuncDelegateByFuncType;

	public UGCGame ugcGame;

	private IUGCModuleArchTypeMgr archTypeMgr;

	private UGCAssembly assembly;

	private bool enableEnergySavingMode;

	private List<DelayFrameTask> delayFrameTasks;

	private int nextTaskId;

	private Dictionary<int, UGCFunctionDelegate> delegateCache;

	public uint TickInterval => 0u;

	public float TickIntervalSecond => 0f;

	public UGCRuntime Create(IGameBridge bridgingGame)
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	public void OnPreTick()
	{
	}

	public void OnTick()
	{
	}

	public void OnPostTick()
	{
	}

	public void OnFixedTick()
	{
	}

	public void MatchModuleInit()
	{
	}

	public void EnableEnergySavingMode(bool enable)
	{
	}

	public bool ShouldSkipFrame()
	{
		return false;
	}

	public bool IsGamePaused()
	{
		return false;
	}

	public void AddPreTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void RemovePreTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void AddVisualTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void RemoveVisualTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void AddTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void RemoveTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void AddPostTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void RemovePostTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void AddFixedTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public void RemoveFixedTickEventHandler(UGCEventNoParamsHandle handler)
	{
	}

	public IGameBridge BridgingGame()
	{
		return null;
	}

	public UGCVMDebugger GetVMDebugger()
	{
		return null;
	}

	public LOIOFAFOMAG GetUGCInternalLibrary()
	{
		return null;
	}

	public JOEANMPIFAB GetUGCGameData()
	{
		return null;
	}

	public IUGCModuleArchTypeMgr ArchTypeMgr()
	{
		return null;
	}

	public IUGCTypeMap TypeMap()
	{
		return null;
	}

	public UGCEntityDataStore EntityDataStore()
	{
		return null;
	}

	public IUGCModuleTransform TransformModule()
	{
		return null;
	}

	internal IUGCModuleAnimation AnimationModule()
	{
		return null;
	}

	public UGCDebugLogger DebugLogger()
	{
		return null;
	}

	public UGCEventBus GlobalEventBus()
	{
		return null;
	}

	public void DispatchToAllEventBus(int eventType, object[] args = null)
	{
	}

	public QuickObjectPoolMap ObjectPool()
	{
		return null;
	}

	public void InitFuncTableHandler(Func<int, UGCFunctionDelegate> handler)
	{
	}

	public void InvokeAPI(DOMDODOIOBI funcCallerData, StackContext stackContext)
	{
	}

	public void CreateGlobalEntity(IBridgingEntity entity, bool isRemote)
	{
	}

	public void CreateLocalPlayerEntity(string entityID, IBridgingEntity player, UGCEntityDataStore ds)
	{
	}

	public void OnGamePreLoaded()
	{
	}

	public void LoadGameData(JOEANMPIFAB gameData)
	{
	}

	public void UnLoadGameData()
	{
	}

	public void LoadInternalLibrary(LOIOFAFOMAG libraryData)
	{
	}

	public UGCLogicEntity GlobalEntity()
	{
		return null;
	}

	public long[] GetEntityDefineComponentIDs(string entityID)
	{
		return null;
	}

	public void AddEntityGraph(UGCLogicEntity entity, string graphId)
	{
	}

	public void RemoveEntityGraph(UGCLogicEntity entity, string graphId)
	{
	}

	public bool ExistEntityGraph(UGCLogicEntity entity, string graphId)
	{
		return false;
	}

	public Tuple2<UGCLogicEntity, bool> TryGetEntityV2(EntityIndex entityIndex)
	{
		return default(Tuple2<UGCLogicEntity, bool>);
	}

	public Tuple2<UGCLogicEntity, bool> TryGetEntity(string entityID)
	{
		return default(Tuple2<UGCLogicEntity, bool>);
	}

	public bool TryGetEntity(string entityID, out UGCLogicEntity entity)
	{
		entity = null;
		return false;
	}

	public UGCLogicEntity FindEntityV2(EntityIndex entityIndex)
	{
		return null;
	}

	public UGCLogicEntity FindEntity(string entityID)
	{
		return null;
	}

	public List<UGCLogicEntity> FilterEntities(UGCArchTypeFilter filter)
	{
		return null;
	}

	public void RemoveEntity(string entityID)
	{
	}

	private void OnPreEntityRemoved(UGCLogicEntity entity)
	{
	}

	public void RemoveEntityV2(EntityIndex entityIndex)
	{
	}

	public void CreateRemoteEntityIfNeed(string entityID, string archTypeID, string[] scriptIDs)
	{
	}

	private UGCLogicEntity CreateRemoteEntity(string entityID, string archTypeID, bool immediatelyAwake, string[] scriptIDs = null)
	{
		return null;
	}

	public UGCLogicEntity CreateEntityRef(string entityRefID)
	{
		return null;
	}

	public UGCLogicEntity CreateEntityWithoutAwake(string entityID, long[] componentIDs)
	{
		return null;
	}

	public UGCLogicEntity InstantiateEntityWithArchType(string prefabID, string entityID, bool immediatelyAwake, long[] componentIDs)
	{
		return null;
	}

	public UGCLogicEntity InstantiateEntity(string prefabID, string entityID, bool immediatelyAwake, bool addGraph = true)
	{
		return null;
	}

	public void DispatchEvent(EntityIndex entityIndex, int eventType, object[] args)
	{
	}

	public void DispatchEventToEntity(string entityID, long eventType, object[] args = null)
	{
	}

	public bool TryAddDynamicCreatedEntitiesInPerFrame()
	{
		return false;
	}

	public PLMKOPJMIEP GetEntityDataByEntityID(string entityID)
	{
		return null;
	}

	public bool GetEntityExportRepItemByEntityID(string entityID, int propID, ref IUGCValue outValue)
	{
		return false;
	}

	public string GetEntityIDFromRegisteredAsset(RegisteredAssetType assetType, string assetKey)
	{
		return null;
	}

	public void AddModule(int moduleType, IUGCModule module)
	{
	}

	public IUGCModule GetModule(int moduleType)
	{
		return null;
	}

	public void RemoveModule(int moduleType)
	{
	}

	internal void HandleServerEvent(OPCLIDGELPE msg)
	{
	}

	public bool IsClientEntity(string entityID)
	{
		return false;
	}

	public int RegisterDelayFrameExecution(int delayFrames, Action action)
	{
		return 0;
	}

	public bool CancelDelayFrameExecution(int taskId)
	{
		return false;
	}

	private void ProcessDelayFrameTasks()
	{
	}

	public void UnSerializeMainSceneEntity(JOEANMPIFAB gameData, int delayFrames = 10)
	{
	}

	public BBJIAPMJCNO GetCustomEvent(long eventID)
	{
		return null;
	}
}
