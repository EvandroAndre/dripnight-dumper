using System.Collections.Generic;
using COW.GamePlay;

public class BuffEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string BuffTypeConfigTitleNameKey;

	public List<uint> BuffTypeList;

	public List<string> BuffTypeTxtKeyList;

	public string BuffTimeConfigTitleNameKey;

	public int BuffMinTime;

	public int BuffMaxTime;

	public int BuffDefaultTime;

	public int BuffStepTime;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectBuff sceneEditObject)
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	public override List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	private void SetAttributeData(SceneEditObjectBuff sceneBuff, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
