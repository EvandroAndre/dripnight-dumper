using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public class UGCWardrobeEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string TriggerRadiusKey;

	public float TriggerRadiusMaxValue;

	public float TriggerRadiusMinValue;

	public float TriggerRadiusDefaultValue;

	public float TriggerRadiusStep;

	public string ModelShowKey;

	public List<int> ModelShowList;

	public List<string> ModelShowKeyList;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectWardrobe sceneEditObject)
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

	private void SetAttributeData(SceneEditObjectWardrobe wardrobe, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetDefaultUIData()
	{
		return null;
	}

	public List<ItemEditAttributeUIData> _003C_003EiFixBaseProxy_GetSceneEditObjectUIData(SceneEditObjectBase P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase P0, List<ItemEditAttributeCacheValueBase> P1)
	{
	}
}
