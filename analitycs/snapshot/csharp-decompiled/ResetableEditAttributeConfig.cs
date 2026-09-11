using System.Collections.Generic;
using COW.GamePlay;

public class ResetableEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectResetable sceneEditObject)
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

	private void SetAttributeData(SceneEditObjectResetable itemBox, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
