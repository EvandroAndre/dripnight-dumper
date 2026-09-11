using System;
using System.Collections.Generic;
using COW.GamePlay;

[Serializable]
public class MoveObjectEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string MoveTypeConfigTitleNameKey;

	public int DefaultMoveMoveCSVCoinfigID;

	public List<int> MoveCSVCoinfigIDList;

	public List<string> MoveNameKey;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectMoveObject sceneEditObject)
	{
		return null;
	}

	public int GetDefaultValue(uint objId)
	{
		return 0;
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	private void SetAttributeData(SceneEditObjectMoveObject moveObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
