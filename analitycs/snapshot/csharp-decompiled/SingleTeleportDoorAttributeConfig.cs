using System;
using System.Collections.Generic;
using COW.GamePlay;

[Serializable]
public class SingleTeleportDoorAttributeConfig : ItemEditAttributeBaseConfig
{
	public string TeleportOnOffTitleNameKey;

	public int DefaultTeleportOnOff;

	public List<string> TeleportOnOffTypeNameKey;

	public List<int> TeleportOnOffValue;

	public string ConfigTitleNameKey;

	public int DefaultTeleportType;

	public List<string> TeleportTypeNameKey;

	public List<int> TeleportTypeValue;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditSingleTeleport sceneEditObject)
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	private void SetAttributeData(SceneEditObjectSingleTeleport moveObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
