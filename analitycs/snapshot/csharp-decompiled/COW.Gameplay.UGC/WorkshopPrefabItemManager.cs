using System.Collections.Generic;

namespace COW.Gameplay.UGC;

internal class WorkshopPrefabItemManager
{
	private const uint Shop_Resource_Option_ID = 10000u;

	public static string IsPrefabNewKeyPrefix;

	public static uint SearchMainTab;

	private Dictionary<uint, WorkShopResourceTypeData> m_ResourceTypeDataList;

	public List<uint> m_ItemTabList;

	public Dictionary<uint, List<uint>> m_ItemSubTabDic;

	public Dictionary<uint, List<uint>> m_ItemPrefabDic;

	public Dictionary<ModeTemplate, List<uint>> m_MustModePrefabDic;

	public Dictionary<uint, uint> Prefab2rdTabDic;

	public Dictionary<uint, uint> Prefab1stTabDic;

	public Dictionary<uint, int> ItemTabIsNewDic;

	public Dictionary<uint, bool> ItemPrefabIsNewDic;

	public HashSet<uint> CollaborateInvalidResSet;

	private HashSet<uint> m_CustomLevelObjectPrefabIds;

	private Dictionary<uint, string> m_PrefabIdToStoreUUIDWithVersion;

	private uint m_MustModeOptionID;

	private UIModelSceneEdit editModel;

	private ModeTemplate curModeTemplate;

	public void OnInit()
	{
	}

	public void AddSimulationDataToItemPrefabDic(uint optionId, uint prefabId, bool checkRepeated = false)
	{
	}

	public void RemoveSimulateData(uint prefabId)
	{
	}

	public bool TryGetStoreUUIDWithVersion(uint prefabId, out string uuidWithVersion)
	{
		uuidWithVersion = null;
		return false;
	}

	public void RemoveStorePrefabItemIdFromExplorer(uint prefabId)
	{
	}

	public void SortItemPrefabs()
	{
	}

	public void OnChangeModeOrTemplate(uint modeType, uint templateID)
	{
	}

	public void OnDestroy()
	{
	}

	public bool CheckOptionIdValid(uint id)
	{
		return false;
	}

	public WorkShopResourceTypeData GetTabDataByOptionID(uint id)
	{
		return null;
	}

	public void GetTabDataByFatherOptionID(uint id, ref List<WorkShopResourceTypeData> list)
	{
	}

	public bool IsNewItemPrefab(uint prefabId)
	{
		return false;
	}

	public bool ShouldShowNewForTab(uint optionId)
	{
		return false;
	}

	public void RemoveNewItemPrefab(uint prefabId)
	{
	}

	public void RemoveNewForTab(uint optionId)
	{
	}

	public void RefreshTabNew(uint optionID, bool isAdd = true)
	{
	}

	public WorkShopPrefabResourceContentConfigData GetWorkShopPrefabResourceContentConfigData(uint prefabId)
	{
		return null;
	}

	public List<uint> GetValidPrefabIds(uint optionId)
	{
		return null;
	}

	private void LoadAssetsFromExplorer()
	{
	}

	private void LoadCreatedTemplatesFromExplorer(UGCAssetExplorer explorer)
	{
	}

	private void LoadStoreGameObjectsFromExplorer(UGCAssetExplorer explorer)
	{
	}

	public void RegisterStoreTemplate(UGCStoreMetadata storeMeta, uint optionId)
	{
	}

	public void RegisterStorePrefabPackage(UGCStoreMetadata storeMeta, uint optionId)
	{
	}

	private void ClearAssetsSimulationData()
	{
	}

	private bool _003COnInit_003Eb__18_1(int mt)
	{
		return false;
	}

	private bool _003COnInit_003Eb__18_2(int mt)
	{
		return false;
	}

	private bool _003COnInit_003Eb__18_3(int mt)
	{
		return false;
	}

	private int _003COnInit_003Eb__18_0(uint aId, uint bId)
	{
		return 0;
	}

	private int _003COnInit_003Eb__18_4(uint aId, uint bId)
	{
		return 0;
	}

	private int _003CSortItemPrefabs_003Eb__23_0(uint a, uint b)
	{
		return 0;
	}
}
