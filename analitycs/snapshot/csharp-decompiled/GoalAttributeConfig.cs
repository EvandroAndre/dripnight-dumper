using System;
using System.Collections.Generic;
using COW.GamePlay;

public class GoalAttributeConfig : ItemEditAttributeBaseConfig
{
	public string TeamIDKey;

	public int DefaultTeamID;

	public List<int> TeamIndexs;

	public List<string> TeamIndexLocKeys;

	[NonSerialized]
	public List<string> TeamIndexStrs;

	public void OnEnable()
	{
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	private void AddUIDataTeamID(int teamid, List<ItemEditAttributeUIData> uis)
	{
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase obj)
	{
		return null;
	}

	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase obj, List<ItemEditAttributeCacheValueBase> vals)
	{
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attr, List<ItemEditAttributeCacheValueBase> vals)
	{
	}
}
