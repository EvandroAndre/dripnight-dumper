using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCGame
{
	public delegate void CreateEntityBridgingHandle(EntityIndex index);

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public string varName;

		internal bool _003C_FindGraphVaribleValue_003Eb__0(BHHMMLJCPJN v)
		{
			return false;
		}
	}

	public LOIOFAFOMAG internalLibraryData;

	public JOEANMPIFAB gameData;

	internal Dictionary<string, GKGNPJEOEGP> graphDataCacheByGraphID;

	internal Dictionary<string, GKGNPJEOEGP> staticGraphDataCacheByGraphID;

	private Dictionary<string, string> graphNameToGraphID;

	private UGCRuntime ugcRuntime;

	private UGCEntityExportDataCache entityExportDataCache;

	private UGCLogicEntity globalEntity;

	private Dictionary<int, IUGCModule> moduleMap;

	private IndexRecyclePool indexRecyclePool;

	public LogicEntitiesMemory allEntities;

	private Dictionary<string, List<UGCLogicEntity>> archTypeChunks;

	private Dictionary<string, UGCLogicEntity> hasGraphEntities;

	private Dictionary<string, string> pendingCreateRemoteEntities;

	private List<UGCEventNoParamsHandle> OnPreTickEvent;

	private List<UGCEventNoParamsHandle> removedPreTickEvent;

	private List<UGCEventNoParamsHandle> OnVisualTickEvent;

	private List<UGCEventNoParamsHandle> removedVisualTickEvent;

	private List<UGCEventNoParamsHandle> OnTickEvent;

	private List<UGCEventNoParamsHandle> removedTickEvent;

	private List<UGCEventNoParamsHandle> OnPostTickEvent;

	private List<UGCEventNoParamsHandle> removedPostTickEvent;

	private List<UGCEventNoParamsHandle> OnFrameworkPostTickEvent;

	private List<UGCEventNoParamsHandle> removedFrameworkPostTickEvent;

	private List<UGCEventNoParamsHandle> OnFixedTickEvent;

	private List<UGCEventNoParamsHandle> removedFixedTickEvent;

	private Dictionary<long, CreateEntityBridgingHandle> onCreateEntityNeedBridging;

	private int entitiesCreatedInPerFrame;

	private int entitiesCreatedPerFrameMax;

	private int entitiesCreateBeRejectedInPerFrame;

	private int dynamicCreatedEntityCountInMatch;

	private int dynamicCreatedEntityCountInMatchMax;

	private int entitiesCreateBeRejectedInMatch;

	private int entitiesCountWarningRecord;

	private uint entitiesCountWarningCDRecord;

	private uint entitiesCountWarningCDInterval;

	private int entitiesCountWarningThreshold;

	private int entitiesCountWarningSegmentInterval;

	private List<UGCLogicEntity> filterEntitiesResult;

	public string AsyncLoadEntity;

	private bool isTicking;

	public UGCGame Init(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void OnPreTickEventHandle()
	{
	}

	public void OnVisualTickEventHandle()
	{
	}

	public void OnTickEventHandle()
	{
	}

	public void OnPostTickEventHandle()
	{
	}

	private void CleanupRemovedEvent()
	{
	}

	public void OnFixedTickEventHandle()
	{
	}

	public UGCEventBus GlobalEventBus()
	{
		return null;
	}

	public void DispatchToAllEventBus(long eventType, object[] args)
	{
	}

	internal void DispatchToAllEventBus(long eventType, List<AJFJEGOPEPP> paramsList)
	{
	}

	private void DispatchToAllEventBus(long eventType, List<UGCSimpleValue> args, bool back2Pool)
	{
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

	public void RemoveFixedTickEventHandler(UGCEventNoParamsHandle handle)
	{
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

	public void ClearAllModule()
	{
	}

	internal void _UpdateGraphDataCache(List<GKGNPJEOEGP> allGraphData)
	{
	}

	public void LoadInternalLibrary(LOIOFAFOMAG libraryData)
	{
	}

	public int UGCGetRoundNumMaxByWorkflowData(OHCGHBFNOFA workflow)
	{
		return 0;
	}

	public void MatchModuleInit()
	{
	}

	private void OnPostModuleInit()
	{
	}

	private void OnPlayerEntityCreated(string ugcEntity)
	{
	}

	private void OnObserverEntityCreated(string ugcEntity)
	{
	}

	private void OnPlayerBehaviorCreated(string ugcEntity)
	{
	}

	private void OnTeamCreated(string ugcEntity)
	{
	}

	public void LoadGameData(JOEANMPIFAB gameData)
	{
	}

	public void UnSerializeEntityInSceneChunk(string sceneId, JOEANMPIFAB tempData = null)
	{
	}

	public void UnSerializeEntityInPrefabChunk(string prefabId)
	{
	}

	private void OptionalModuleInit(JOEANMPIFAB gameData)
	{
	}

	private void CompatibleModuleInit(JOEANMPIFAB gameData)
	{
	}

	public void UnloadLevelData()
	{
	}

	public UGCLogicEntity GetGlobalEntity()
	{
		return null;
	}

	public void InitGlobalEntity()
	{
	}

	public void GlobalEntityAddGraphs()
	{
	}

	internal GKGNPJEOEGP _FindGraphDataFromCache(string graphID)
	{
		return null;
	}

	internal GKGNPJEOEGP _FindGraphDataFromCacheByName(string graphName)
	{
		return null;
	}

	internal UGCVarValueDataV2 _FindGraphVaribleValue(string graphName, string varName)
	{
		return null;
	}

	internal PLMKOPJMIEP FindEntityDataByIDFromCache(string prefabID)
	{
		return null;
	}

	public UGCLogicEntity GlobalEntity()
	{
		return null;
	}

	private void TryCreatePendingRemoteEntity(string entityID)
	{
	}

	public Tuple2<UGCLogicEntity, bool> TryGetEntity(EntityIndex entityIndex)
	{
		return default(Tuple2<UGCLogicEntity, bool>);
	}

	public bool TryGetByEntityID(string entityID, out UGCLogicEntity entity)
	{
		entity = null;
		return false;
	}

	public UGCLogicEntity FindEntity(EntityIndex entityIndex)
	{
		return null;
	}

	public List<UGCLogicEntity> FilterEntities(UGCArchTypeFilter filter)
	{
		return null;
	}

	public UGCLogicEntity CreateEntity(long[] componentIDs, string sourceID, string targetID, bool immediatelyAwake, bool addGraph = true)
	{
		return null;
	}

	public void CreateGlobalEntity(bool isRemote)
	{
	}

	public UGCLogicEntity CreateLocalPlayerEntity(string entityID, UGCEntityDataStore ds)
	{
		return null;
	}

	public void AddPendingRemoteEntity(string entityID, string archTypeID)
	{
	}

	public void RemovePendingRemoteEntity(string entityID)
	{
	}

	public UGCLogicEntity CreateRemoteEntity(string[] scriptIDs, string archTypeID, string entityID, bool immediatelyAwake = true)
	{
		return null;
	}

	public void RemoveEntity(UGCEntityDataStore ds, IUGCModuleTransform trs, string entityID)
	{
	}

	private void removeEntityInternal(UGCEntityDataStore ds, IUGCModuleTransform trs, UGCLogicEntity entity)
	{
	}

	public bool TryAddDynamicCreatedEntitiesInPerFrame()
	{
		return false;
	}

	public bool TryAddDynamicCreatedEntityCountInMatch()
	{
		return false;
	}

	public void TryMinusDynamicCreatedEntityCountInMatch()
	{
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

	public long[] GetEntityDefineComponentIDs(string entityID)
	{
		return null;
	}

	public void DispatchEventToEntity(EntityIndex entityIndex, long eventType, object[] args)
	{
	}

	private uint _PopEntityIndex()
	{
		return 0u;
	}

	public void _PushEntityIndex(uint value)
	{
	}

	private UGCLogicEntity _CreateEntityInternal(UGCEntityDataStore ds, uint attribute, string entityID, string archTypeID, bool isRemote = false)
	{
		return null;
	}

	private UGCLogicEntity CreateEntityFromMetaConfig(long[] componentIDs, uint entityAttribute, string entityID, bool addGraph = true)
	{
		return null;
	}

	private UGCLogicEntity CreateEntityFromEntityDataBase(PLMKOPJMIEP entityData, string entityID, bool addGraph = true)
	{
		return null;
	}

	public List<AFAJGEBMGIP> GenPrefabRefHierarchy(PLMKOPJMIEP entityData, string rootEntityID, int depth, Dictionary<string, string> prefab2instanceMapping, List<AFAJGEBMGIP> prefabHierarchy)
	{
		return null;
	}

	private UGCLogicEntity CreateEntityFromEntityData(PLMKOPJMIEP entityData, string rootEntityID, bool addGraph = true)
	{
		return null;
	}

	private UGCLogicEntity CreateEntityFromInstance(UGCLogicEntity prefabEntity, string entityID, bool addGraph = true)
	{
		return null;
	}

	private void _EntitiesCountWarningCheck()
	{
	}

	private void _Add2ArchTypeChunk(UGCLogicEntity logicEntity)
	{
	}

	private void _Remove4ArchTypeChunk(UGCLogicEntity logicEntity)
	{
	}

	private void _DestroyBindTheUserEntities(UGCLogicEntity logicEntity)
	{
	}

	private List<GKGNPJEOEGP> _LoadForTypeGraphs(string archTypeID, List<GKGNPJEOEGP> bindGraphs)
	{
		return null;
	}

	private List<GKGNPJEOEGP> _LoadForInstanceGraphs(PLMKOPJMIEP entityData, List<GKGNPJEOEGP> bindGraphs)
	{
		return null;
	}

	public PLMKOPJMIEP _LoadEntityData(int refDepth, string prefabID, PLMKOPJMIEP instanceEntityData)
	{
		return null;
	}

	public void FixEntityRefRedirection(List<UGCEntityRepDataItem> refRedirectionRepItems, Dictionary<string, string> prefab2instanceMapping, UGCRuntime ugcRuntime)
	{
	}

	public void ManualAwakeWithoutRoot(List<UGCLogicEntity> instances)
	{
	}

	public void AddCreateEntityBridgingHandler(long typeID, CreateEntityBridgingHandle handle)
	{
	}

	public void RemoveCreateEntityBridgingHandler(long typeID)
	{
	}

	public JNBAKKBJNJD GetPrefabDataByID(string prefabID)
	{
		return null;
	}

	public UGCVarValueDataV2 GetEntityExportRepItemByEntityID(IUGCTypeMap typeMapper, string entityID, long propID)
	{
		return null;
	}
}
