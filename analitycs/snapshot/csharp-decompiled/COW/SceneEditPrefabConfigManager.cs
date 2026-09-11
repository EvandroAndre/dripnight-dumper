using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneEditPrefabConfigManager : SingletonModule<SceneEditPrefabConfigManager>
{
	private List<SceneEditPrefabConfigData> mPrefabConfigDataList;

	private Dictionary<int, List<uint>> mInstanceGeneratorMap;

	public List<SceneEditPrefabConfigData> PrefabConfigDataList => null;

	protected override void OnInit()
	{
	}

	public void Load()
	{
	}

	public void ReLoad()
	{
	}

	protected override void OnCleanup()
	{
	}

	public SceneEditPrefabConfigData GetPrefabConfigData(uint itemID, bool includeCustomLevelObject = true)
	{
		return null;
	}

	public List<uint> GetPrefabConfigDataByUGCType(string ugcType, bool includeCustomLevelObject = true)
	{
		return null;
	}

	public void GetPrefabConfigDataByType(uint typeID, ref List<SceneEditPrefabConfigData> ret)
	{
	}

	public SceneEditPrefabConfigData GetPrefabConfigDataByItemType(uint itemType)
	{
		return null;
	}

	public void GetPrefabConfigDataByItemType(uint itemType, ref List<SceneEditPrefabConfigData> ret)
	{
	}

	public string ItemTypeToUGCTypeName(uint itemType)
	{
		return null;
	}

	public SceneEditPrefabConfigData GetDisplayItemDataForGroupID(int groupID)
	{
		return null;
	}

	public List<SceneEditPrefabConfigData> GetAllItemDataForGroupID(int groupID)
	{
		return null;
	}
}
