using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCLogicEntityInternal
{
	internal EntityIndex entityIndex;

	private UGCLogicEntity container;

	private long entityBridgingType;

	private string archTypeID;

	private UGCEventBus eventbus;

	internal UGCRuntime ugcRuntime;

	private Dictionary<string, IUGCGraph> graphMap;

	public bool hasAwaken;

	private bool isEnableDirtyCheckCache;

	public bool isDestroyed;

	internal IBridgingEntity bridgingEntityCache;

	private List<IUGCGraph> tickGraph;

	public UGCLogicEntityInternal Create(UGCLogicEntity container, UGCRuntime ugcRuntime, EntityIndex entityIndex, string archerTypeID)
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

	public void OnTickEventHandle()
	{
	}

	public void OnFixedEventHandle()
	{
	}

	public void OnLateTickEventHandle()
	{
	}

	public UGCEventBus EventBus()
	{
		return null;
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

	public void AddGraph(GKGNPJEOEGP graphData)
	{
	}

	public IUGCGraph GetGraph(string graphID)
	{
		return null;
	}

	public bool ExistGraph(string graphID)
	{
		return false;
	}

	public bool HasGraph()
	{
		return false;
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

	public void OnRepDataChangeHandler(long propID, UGCSimpleValue value)
	{
	}

	public void OnEnableChange()
	{
	}
}
