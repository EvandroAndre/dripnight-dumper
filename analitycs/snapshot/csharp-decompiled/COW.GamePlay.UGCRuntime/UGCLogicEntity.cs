using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCLogicEntity
{
	public UGCLogicEntityInternal internalEntity;

	private UGCLogicEntityLinkInfo linkInfo;

	private bool isLink;

	private bool isRemote;

	private uint attribute;

	public bool IsRemote
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint Attribute => 0u;

	public UGCLogicEntity Create(UGCRuntime ugcRuntime, uint entityIndex, string entityID, string archerTypeID)
	{
		return null;
	}

	public UGCLogicEntity CreateForLink(UGCRuntime ugcRuntime, string entityRefID, long[] componentsRefID)
	{
		return null;
	}

	public UGCLogicEntity CreateLinkForTarget(UGCRuntime ugcRuntime, string targetEntityID, UGCLogicEntity prefabEntity)
	{
		return null;
	}

	public bool HasLinked()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void Awake()
	{
	}

	public void Destroy()
	{
	}

	public bool IsEnable()
	{
		return false;
	}

	public bool IsAwoken()
	{
		return false;
	}

	public bool IsDestroyed()
	{
		return false;
	}

	public void OnTickEventHandle()
	{
	}

	public void OnFixedTickEventHandle()
	{
	}

	public UGCEventBus EventBus()
	{
		return null;
	}

	public EntityIndex EntityIndex()
	{
		return default(EntityIndex);
	}

	public string UGCEntityID()
	{
		return null;
	}

	public string ArchTypeID()
	{
		return null;
	}

	public void ChangeArchTypeID(string newArchTypeID)
	{
	}

	public bool HasComponent(long[] typeIDs)
	{
		return false;
	}

	private bool AddComponentCheck(long typeID, List<long> results, bool customOnly)
	{
		return false;
	}

	public Tuple2<List<long>, bool> AddComponent(long typeID, bool customOnly = true)
	{
		return default(Tuple2<List<long>, bool>);
	}

	public bool RemoveComponent(long typeID, bool customOnly = true)
	{
		return false;
	}

	public void SetRepItem(long propID, bool value)
	{
	}

	public void SetRepItem(long propID, int value)
	{
	}

	public void SetRepItem(long propID, float value)
	{
	}

	public void SetRepItem(long propID, long value)
	{
	}

	public void SetRepItem(long propID, Vector2 value)
	{
	}

	public void SetRepItem(long propID, Vector3 value)
	{
	}

	public void SetRepItem(long propID, Quaternion value)
	{
	}

	public void SetRepItem(long propID, List<float> value)
	{
	}

	public void SetRepItem(long propID, List<object> value)
	{
	}

	public void SetRepItem(long propID, UGCLogicEntity value)
	{
	}

	public void SetRepItem(long propID, string value)
	{
	}

	public UGCSimpleValue GetRepItemNoGC(long propID, bool forceDataDriven = false)
	{
		return null;
	}

	public long EntityBridgingType()
	{
		return 0L;
	}

	public void SetEntityBridgingType(long bridgingType)
	{
	}

	public void SetBridgingEntity(IBridgingEntity bridgingEntity)
	{
	}

	public IBridgingEntity ToBridgingEntity()
	{
		return null;
	}

	public void AddGraph(GKGNPJEOEGP graphData)
	{
	}

	public bool ExistGraph(string graphID)
	{
		return false;
	}

	public IUGCGraph GetGraph(string graphID)
	{
		return null;
	}

	public void RemoveGraph(string graphID)
	{
	}

	public void RemoveAllGraph()
	{
	}

	public List<GKGNPJEOEGP> GetAllGraphData()
	{
		return null;
	}

	public bool HasGraphs()
	{
		return false;
	}

	public bool GetGraphPropertyType(string graphID, string propertyID, out MHJLOKOOGNB pType)
	{
		pType = default(MHJLOKOOGNB);
		return false;
	}

	public bool GetGraphPropertyBool(string graphID, string propertyID)
	{
		return false;
	}

	public int GetGraphPropertyInt(string graphID, string propertyID)
	{
		return 0;
	}

	public long GetGraphPropertyInt64(string graphID, string propertyID)
	{
		return 0L;
	}

	public float GetGraphPropertyFloat(string graphID, string propertyID)
	{
		return 0f;
	}

	public Vector2 GetGraphPropertyVec2(string graphID, string propertyID)
	{
		return default(Vector2);
	}

	public Vector3 GetGraphPropertyVec3(string graphID, string propertyID)
	{
		return default(Vector3);
	}

	public void SetGraphProperty(string graphID, string propertyID, object value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, bool value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, int value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, long value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, float value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, Vector2 value)
	{
	}

	public void SetGraphProperty(string graphID, string propertyID, Vector3 value)
	{
	}

	public void SetActive(bool activeSelf)
	{
	}

	private void _SetActiveParent(bool activeParent, UGCRuntime ugcRuntime, IUGCModuleTransform transformMgr)
	{
	}

	public void SetAttribute(uint attr)
	{
	}

	public bool HasAttribute(AKHGCDIHALG keyword)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void UnRegisterHandler(long eventType, UGCEventVariadicHandle handle)
	{
	}

	public void RegisterHandler(long eventType, UGCEventVariadicHandle handle)
	{
	}

	public ScriptScope GetScope(string graphID)
	{
		return null;
	}

	public DOMDODOIOBI GetFunction(string graphID, string funcID)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
