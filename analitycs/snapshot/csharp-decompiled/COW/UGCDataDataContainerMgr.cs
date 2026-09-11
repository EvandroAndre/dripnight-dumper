using System.Collections.Generic;
using message;

namespace COW;

internal class UGCDataDataContainerMgr
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public uint dataContainerID;

		internal bool _003CAddEntityLink_003Eb__0(uint n)
		{
			return false;
		}
	}

	private UGCEntityDataStore m_DataStore;

	private Dictionary<uint, UGCDataContainerInfo> m_DataDataContainerCache;

	private Dictionary<string, List<uint>> m_EntityLinkDataContainer;

	private Queue<uint> m_WaitDelDataDataContainer;

	public UGCDataDataContainerMgr(UGCEntityDataStore dataStore)
	{
	}

	public void Destroy()
	{
	}

	public object CreateDataContainerCache(uint id, KNNFBNIKIAA syncRepData)
	{
		return null;
	}

	public object GetDataContainerCache(uint id)
	{
		return null;
	}

	public object UpdataDataContainerCache(uint id, KNNFBNIKIAA syncRepData)
	{
		return null;
	}

	public void AddEntityLink(string entityID, long propID, uint dataContainerID)
	{
	}

	public void RemoveEntityLink(string entityID, long propID, object dataContainer)
	{
	}

	public void RemoveEntityLinkAll(string entityID)
	{
	}

	public void DataContainerSyncEnd()
	{
	}
}
