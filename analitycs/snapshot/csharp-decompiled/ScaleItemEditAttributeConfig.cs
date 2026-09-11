using System.Collections.Generic;
using COW.GamePlay;

public class ScaleItemEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string ScaleXConfigTitleNameKey;

	public float ScaleXMinValue;

	public float ScaleXMaxValue;

	public float ScaleXDefaultValue;

	public float ScaleXStepValue;

	public string ScaleYConfigTitleNameKey;

	public float ScaleYMinValue;

	public float ScaleYMaxValue;

	public float ScaleYDefaultValue;

	public float ScaleYStepValue;

	public string ScaleZConfigTitleNameKey;

	public float ScaleZMinValue;

	public float ScaleZMaxValue;

	public float ScaleZDefaultValue;

	public float ScaleZStepValue;

	protected virtual int GetScaleUIDataBeginIndex => 0;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectScalableItem sceneEditObject)
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

	public override void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	public override void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	protected void SetScaleAttributeData(SceneEditObjectScalableItem scalableItem, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
