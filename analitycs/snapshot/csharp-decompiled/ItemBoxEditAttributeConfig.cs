using System.Collections.Generic;
using COW.GamePlay;

public class ItemBoxEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string TitleNameKey;

	public List<int> DropIDList;

	public List<string> DropIDTxtKeyList;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectItemBox sceneEditObject)
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

	private void SetAttributeData(SceneEditObjectItemBox itemBox, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
