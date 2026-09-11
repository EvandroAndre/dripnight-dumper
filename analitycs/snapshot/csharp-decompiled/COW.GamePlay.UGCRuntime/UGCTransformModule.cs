using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTransformModule : IUGCModuleTransform, IUGCModule
{
	internal class DeserializedTRSState : ObjectPoolCallbackBase
	{
		public uint PacketID;

		public int SyncID;

		public byte Flags;

		public int ParentSyncID;

		public Vector3 Position;

		public Quaternion Rotation;

		public Vector3 Scale;

		public Vector3 LinearVelocity;

		public Vector3 AngularVelocity;

		public void Initialize(uint packetID, AOLBHNEBMMP state)
		{
		}

		public override void OnCollected()
		{
		}

		public void _003C_003EiFixBaseProxy_OnCollected()
		{
		}
	}

	private const int INITIAL_NODES_NUM = 50;

	private UGCRuntime _003CRuntime_003Ek__BackingField;

	private UGCEntityDataStore _003CDataStore_003Ek__BackingField;

	private Dictionary<string, UGCTransformNode> m_NodesMap;

	private HashSet<string> m_orphans;

	public static bool SeparateLogicAndVisual;

	internal UGCEntityDataReceiver DSReceiver;

	private const int MAX_PACKET_ID_DIFFERENCE = 1000000;

	private const int MAX_ORPHAN_WAIT_PACKET_COUNT = 1000;

	private const int TRS_STATE_POOL_INIT_CAPACITY = 50;

	private ObjectPool<DeserializedTRSState> m_TRSStatePool;

	private Dictionary<int, DeserializedTRSState> m_OrphanTRSStates;

	private EHCAMOGKGKD m_allTrsStatesCache;

	public UGCRuntime Runtime
	{
		get
		{
			return _003CRuntime_003Ek__BackingField;
		}
		private set
		{
			_003CRuntime_003Ek__BackingField = value;
		}
	}

	public UGCEntityDataStore DataStore
	{
		get
		{
			return _003CDataStore_003Ek__BackingField;
		}
		private set
		{
			_003CDataStore_003Ek__BackingField = value;
		}
	}

	public UGCGameObjectManager GameObjectManager => null;

	public static float PacketLossRateForEditor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public UGCTransformModule Create(UGCRuntime v)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	private void OnTickEventHandle()
	{
	}

	public void Destroy()
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public bool HasNode(string entityID)
	{
		return false;
	}

	public UGCTransformNode GetNode(EntityIndex index)
	{
		return null;
	}

	public UGCTransformNode GetNode(string entityID)
	{
		return null;
	}

	public void AddNode(string entityID)
	{
	}

	public void RemoveNode(string entityID)
	{
	}

	public void SetVector3Property(string entityID, long propID, Vector3 v)
	{
	}

	public Vector3 GetVector3Property(string entityID, long propID)
	{
		return default(Vector3);
	}

	public void SetQuaternionProperty(string entityID, long propID, Quaternion v)
	{
	}

	public Quaternion GetQuaternionProperty(string entityID, long propID)
	{
		return default(Quaternion);
	}

	public void UpdateFromDataStore(EntityIndex index)
	{
	}

	public string[] GetChildren(EntityIndex index)
	{
		return null;
	}

	public List<string> GetAllParent(string entityID)
	{
		return null;
	}

	public string GetParent(string entityID)
	{
		return null;
	}

	public bool SetParent(UGCLogicEntity parent, UGCLogicEntity child, bool keepWorldPos)
	{
		return false;
	}

	public void AddToWaitList(string nodeID)
	{
	}

	public void RemoveFromWaitList(string nodeID)
	{
	}

	public void OnTransformNodeCreated(string nodeID)
	{
	}

	public void UpdateUnityTransformOnGameObjectChanged(string entityID, GameObject entityObject)
	{
	}

	public void SetParentByID(string parentID, string childID, bool keepWorldPos)
	{
	}

	private void ReceiveOrphanTRSState(DeserializedTRSState state)
	{
	}

	public void ApplyOrphanTRSState(int syncID, string entityID, uint packetID)
	{
	}

	private void ClearAllOrphanStates()
	{
	}

	internal void ReceiveTRSData(GDNEMJGOGBA data)
	{
	}

	internal void ReceiveTRSDataPB(OGHAIGFKMCP data)
	{
	}

	public string SyncIDToEntityID(int syncID)
	{
		return null;
	}

	public bool TrySetNodePacketID(string entityID, uint newPacketID)
	{
		return false;
	}

	public static bool IsPacketNewer(uint currentPacketID, uint newPacketID)
	{
		return false;
	}

	public static int CalculatePacketDifference(uint currentPacketID, uint newPacketID)
	{
		return 0;
	}

	public void OnTick(float gameTime, float deltaTime)
	{
	}
}
