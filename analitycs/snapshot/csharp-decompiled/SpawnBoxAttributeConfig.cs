using System;
using System.Collections.Generic;
using COW.GamePlay;

public class SpawnBoxAttributeConfig : ItemEditAttributeBaseConfig
{
	public string SpawnPointCountKey;

	public int DefaultSpawnPointCount;

	public int MinSpawnPointCount;

	public int MaxSpawnPointCount;

	public string TeamIDKey;

	public int DefaultTeamID;

	public List<string> TeamIndexLocKeys;

	[NonSerialized]
	public List<string> TeamIndexStrs;

	public List<int> TeamIndexs;

	private void OnEnable()
	{
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	private void AddCompSpawnCount(int count, List<ItemEditAttributeUIData> comps)
	{
	}

	private void AddCompTeamID(int team, List<ItemEditAttributeUIData> comps)
	{
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	private int ParseSpawnCount(List<ItemEditAttributeCacheValueBase> vals)
	{
		return 0;
	}

	private int ParseTeamID(List<ItemEditAttributeCacheValueBase> vals)
	{
		return 0;
	}

	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase obj, List<ItemEditAttributeCacheValueBase> vals)
	{
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attr, List<ItemEditAttributeCacheValueBase> vals)
	{
	}
}
