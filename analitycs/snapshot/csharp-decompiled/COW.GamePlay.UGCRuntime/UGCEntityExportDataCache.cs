using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCEntityExportDataCache
{
	private Dictionary<string, PLMKOPJMIEP> m_EntityDataCache;

	private Dictionary<string, List<PLMKOPJMIEP>> m_EntityDataCacheByArchType;

	private Dictionary<string, JNBAKKBJNJD> m_PrefabDataCache;

	private Dictionary<string, AFAJGEBMGIP> m_PrefabEntityData;

	private UGCRuntime ugcRuntime;

	public UGCEntityExportDataCache(UGCRuntime runtime)
	{
	}

	public bool LoadRuntimeData(JOEANMPIFAB gameData)
	{
		return false;
	}

	public void UpdateEntityDataCache(List<PLMKOPJMIEP> allLogicEntityData)
	{
	}

	public bool UnloadRuntimeData()
	{
		return false;
	}

	public long[] GetComponentsIDByEntityID(string entityID)
	{
		return null;
	}

	public JNBAKKBJNJD GetPrefabDataByID(string prefabID)
	{
		return null;
	}

	public PLMKOPJMIEP GetEntityExportDataByEntityID(string entityID)
	{
		return null;
	}

	public List<PLMKOPJMIEP> FindEntityDataIncludeBaseByTypeFromCache(string archTypeID)
	{
		return null;
	}

	public UGCVarValueDataV2 GetEntityExportRepItemByEntityID(IUGCTypeMap typeMapper, string entityID, long propID)
	{
		return null;
	}
}
