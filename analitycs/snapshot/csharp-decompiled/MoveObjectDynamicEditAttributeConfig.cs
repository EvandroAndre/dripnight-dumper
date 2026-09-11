using System;
using System.Collections.Generic;
using COW.GamePlay;

[Serializable]
public class MoveObjectDynamicEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string MoveDynamicTypeConfigTitleNameKey;

	public int DefaultMoveMoveCSVCoinfigID;

	public List<int> MoveCSVCoinfigIDList;

	public List<string> MoveNameKey;

	public string MoveDynamicValueConfigTitleNameKey;

	public int MoveMinValue;

	public int MoveMaxValue;

	public int MoveDefaultValue;

	public int MoveStepValue;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectMoveObject sceneEditObject)
	{
		return null;
	}

	private bool CheckExistConfigId(int configId)
	{
		return false;
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

	private void SetAttributeData(SceneEditObjectMoveObject moveObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
