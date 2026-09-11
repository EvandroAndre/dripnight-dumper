using System.Collections.Generic;
using message;

namespace COW;

internal class UGCEntityDataReceiver
{
	private UGCEntityDataStore m_DataStore;

	private UGCRepDataSmoothSystem m_SmoothSystem;

	private UGCDataDataContainerMgr m_DataContainerStore;

	private Dictionary<uint, string> m_EntitySyncID2IDCache;

	private Dictionary<string, uint> m_EntityID_To_SyncID;

	private Dictionary<string, HashSet<long>> m_EntityUnlegalDictCache;

	private Dictionary<string, HashSet<long>> m_PropRaiseEventDictCache;

	private HashSet<string> m_NewEntityCache;

	private HashSet<string> m_DirtyEntityCache;

	private uint _003CLastPacketID_003Ek__BackingField;

	private readonly Dictionary<uint, List<byte>> m_CachedUGCLevelDataSegments;

	public uint LastPacketID
	{
		get
		{
			return _003CLastPacketID_003Ek__BackingField;
		}
		private set
		{
			_003CLastPacketID_003Ek__BackingField = value;
		}
	}

	public UGCEntityDataReceiver(UGCEntityDataStore board, UGCRepDataSmoothSystem smoothSystem, UGCDataDataContainerMgr dataContainerStore)
	{
	}

	public void Destroy()
	{
	}

	public void OnSyncData(MIEIAPPOKBD msg)
	{
	}

	private string GetEntityIDBySyncID(NLAEMCBOAMK entitySyncMsg)
	{
		return null;
	}

	public string SyncIDToEntityID(uint syncID)
	{
		return null;
	}

	private bool CanSmoothRepItem(KNNFBNIKIAA item)
	{
		return false;
	}

	public void OnReceiveUGCGameData(uint segmentCount, uint index, List<byte> dataSegment)
	{
	}
}
