using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW;

public class UGCEntityDataStore : IUGCModule
{
	public UGCRuntime ugcRuntime;

	private IUGCModuleTransform m_trs;

	private Dictionary<string, UGCEntityRepData> allEntityRepData;

	private UGCEntityRepDataItem recentlyUsedEntityRepItem;

	private Action<string, string> m_OnAddEntityEvent;

	private Action<string, string> m_OnRemoveEntityEvent;

	private Dictionary<long, Action<string>> m_OnTheCmptTypeAddEntityEvent;

	private Dictionary<long, Action<string>> m_OnTheCmptTypeRemoveEntityEvent;

	private Dictionary<string, Action<string>> m_OnEntityChangeEvent;

	private Dictionary<string, Action<long, UGCSimpleValue>> m_OnEntityPropertyChangeHandlers;

	private Dictionary<string, Action<bool>> m_OnEntityAOIVisibleChangeHandlers;

	private DataLegalRule m_DataLegalityChecker;

	public Dictionary<string, object> UserEntityID2Object;

	private Dictionary<string, HashSet<long>> m_dirtyCustomProperty;

	private List<AJFJEGOPEPP> m_pendingDispatch2ServerEvents;

	private Dictionary<string, List<long>> m_entityRemoveComponentsPerFrame;

	private int m_dispatch2ServerPacketBudgetBytes;

	private int m_dispatch2ServerMaxEventsPerFrame;

	private bool m_hasLoggedMaxEventsWarningThisFrame;

	public float MaxUGCRunSpeedUpScale;

	public float MaxUGCDashSpeedUpScale;

	public IUGCModuleTransform TRSModule => null;

	public UGCEntityDataStore(UGCRuntime ugcRuntime)
	{
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	internal void AddDataCheckerRule(DataLegalRule rule)
	{
	}

	internal bool CheckUGCPropValueLegality(long expectType, object targetValue, PropValueChangeOriginType changeOrigin)
	{
		return false;
	}

	public void InitRepDataForEntity(string archTypeID, string entityID, bool isRemote = false)
	{
	}

	public void UnInitRepDataForEntity(string archTypeID, EntityIndex entityIndex)
	{
	}

	public int TotalEntityCount()
	{
		return 0;
	}

	public Dictionary<string, UGCEntityRepData> AllEntityData()
	{
		return null;
	}

	public bool HasEntity(string entityID)
	{
		return false;
	}

	public void OnPostAddEntity(string entityID, EntitySourceType sType, string archTypeID = "", string[] scriptIDs = null)
	{
	}

	public void RemoveEntity(string entityID)
	{
	}

	public void ArchTypeCheckAndApply(string entityID, string archTypeID)
	{
	}

	public Dictionary<long, UGCEntityRepDataItem> GetOrAddEntityProperties(string entityID, string archTypeID)
	{
		return null;
	}

	public UGCEntityRepDataItem EntityAddNewProperty(string entityID, long propID)
	{
		return null;
	}

	public void EntityRemoveProperty(string entityID, long propID)
	{
	}

	public void EntityAddComponents(string archTypeID, string entityID, List<long> typeIDs)
	{
	}

	public bool EntityPasteComponent(EntityIndex sourceEntityIndex, EntityIndex targetEntityIndex, long typeID)
	{
		return false;
	}

	public void EntityRemoveComponentsRequest(string entityID, long typeID)
	{
	}

	public void RemoveEntityComponents()
	{
	}

	public UGCVarValueDataV2 GetEntityRepItemDefaultValue(string entityID, long propID)
	{
		return null;
	}

	public uint GetEntityKeywordAttribute(string entityID)
	{
		return 0u;
	}

	public string GetArchTypeIDByEntityID(string entityID)
	{
		return null;
	}

	public UGCEntityRepData FindEntityData(string entityId)
	{
		return null;
	}

	public UGCEntityRepData FindEntityData(EntityIndex entityIndex)
	{
		return null;
	}

	public bool CloneEntityData(EntityIndex originEntityIndex, EntityIndex targetEntityIndex)
	{
		return false;
	}

	public UGCEntityRepDataItem FindEntityRepItem(EntityIndex entityIndex, long propID)
	{
		return null;
	}

	public UGCEntityRepDataItem FindEntityRepItem(string entityID, long propID)
	{
		return null;
	}

	public Dictionary<long, UGCEntityRepDataItem> GetEntityRepData(EntityIndex entityIndex)
	{
		return null;
	}

	public void SetRepItem(string entityID, long propID, bool itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, int itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, long itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, float itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, Vector2 itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, Vector3 itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, Quaternion itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem(string entityID, long propID, UGCVarValueDataV2 itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItem<T>(string entityID, long propID, T itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL) where T : class
	{
	}

	private void SetRepItem(UGCEntityRepDataItem repItem, UGCSimpleValue itemValue, RepItemModifyType mType = RepItemModifyType.NORMAL)
	{
	}

	public void SetRepItemSkipSyncState(EntityIndex entityIndex, long propID, bool skipSync)
	{
	}

	public void SetRepItemSkipSyncState(string entityID, long propID, bool skipSync)
	{
	}

	private void SetRelatedTRSRepItemFlag(string entityID, long propID, bool syncState)
	{
	}

	private void _SetRepItem(string entityID, long propID, UGCEntityRepDataItem repItem, UGCSimpleValue value)
	{
	}

	public bool HasRepItem(string entityID, int propID)
	{
		return false;
	}

	public UGCSimpleValue GetRepItemNoGC(string entityID, long propID, bool forceDataDriven = false)
	{
		return null;
	}

	public UGCSimpleValue GetValueFromRepItemNoGC(string entityID, long propID)
	{
		return null;
	}

	public bool ShouldSkipSyncTheRepItem(UGCEntityRepDataItem dirtyItem)
	{
		return false;
	}

	public void RegisterSyncDirtyItem(string ugcEntityID, UGCEntityRepDataItem dirtyItem)
	{
	}

	public void OnPostTickEventHandle()
	{
	}

	public bool AddDispatch2ServerEvent(string entityID, long eventType, object[] args)
	{
		return false;
	}

	private void FlushDispatch2ServerEvents()
	{
	}

	private void SendDispatch2ServerBatch(List<AJFJEGOPEPP> batchParams, int bytesCount, string codeID = "")
	{
	}

	public void UpdateFromTRSVector3(string entityID, int propID, Vector3 newValue)
	{
	}

	public void UpdateFromTRSQuaternion(string entityID, int propID, Quaternion newValue)
	{
	}

	public void RegisterEntityChangeEvent(string entityID, Action<string> handler)
	{
	}

	public void UnRegisterEntityChangeEvent(string entityID, Action<string> handler)
	{
	}

	public void RegisterAddEntityEvent(Action<string, string> handler)
	{
	}

	public void UnRegisterAddEntityEvent(Action<string, string> handler)
	{
	}

	public void RegisterRemoveEntityEvent(Action<string, string> handler)
	{
	}

	public void UnRegisterRemoveEntityEvent(Action<string, string> handler)
	{
	}

	public void RegisterTheCmptAddEntityEvent(MHJLOKOOGNB cmptType, Action<string> handler)
	{
	}

	public void UnRegisterTheCmptAddEntityEvent(MHJLOKOOGNB cmptType, Action<string> handler)
	{
	}

	public void RegisterTheCmptRemoveEntityEvent(MHJLOKOOGNB cmptType, Action<string> handler)
	{
	}

	public void UnRegisterTheCmptRemoveEntityEvent(MHJLOKOOGNB cmptType, Action<string> handler)
	{
	}

	public void RegisterTheCmptEntityEvent(MHJLOKOOGNB cmptType, Action<string> addHandler, Action<string> removeHandler)
	{
	}

	public void UnRegisterTheCmptEntityEvent(MHJLOKOOGNB cmptType, Action<string> addHandler, Action<string> removeHandler)
	{
	}

	public void RegisterRepItemChangeEvent(string entityID, Action<long, UGCSimpleValue> handler)
	{
	}

	public void UnRegisterRepItemChangeEvent(string entityID, Action<long, UGCSimpleValue> handler)
	{
	}

	public void RegisterAOIVisibleChangeEvent(string entityID, Action<bool> handler)
	{
	}

	public void UnRegisterAOIVisibleChangeEvent(string entityID, Action<bool> handler)
	{
	}

	public void DispatchAOIVisibleChanged(string entityID, bool visiable)
	{
	}

	public void DispatchEntityChanged(string entityID)
	{
	}

	public void DispatchEntityPropertyChanged(string entityID, long propID, IUGCValue newVal)
	{
	}

	private void DispatchEntityCreated(string archTypeID, string entityID)
	{
	}

	private void DispatchEntityRemoved(string archTypeID, string entityID)
	{
	}

	public bool NeedInitDSForOffline(string entityID)
	{
		return false;
	}

	public void InitCustomProperty()
	{
	}

	private UGCComponentProp GetComPropByName(long componentType, string propName)
	{
		return null;
	}
}
