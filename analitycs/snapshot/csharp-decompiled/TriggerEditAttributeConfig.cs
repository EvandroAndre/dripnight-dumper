using System.Collections.Generic;
using COW.GamePlay;
using message;

public class TriggerEditAttributeConfig : ScaleItemEditAttributeConfig
{
	public string TriggerTypeTitleNameKey;

	public IFFEOMKPDKM DefaultTriggerType;

	public List<uint> TriggerTypeList;

	public List<string> TriggerTypeNameKeyList;

	public string TriggerIsShowTitleNameKey;

	public bool IsDefaultShow;

	public List<string> TriggerShowConfigNameKeyList;

	protected override int GetScaleUIDataBeginIndex => 0;

	public List<ItemEditAttributeUIData> GetTriggerUIData(SceneEditObjectTrigger sceneEditObject)
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

	private void SetTriggerAttributeData(SceneEditObjectTrigger triggerObj, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
