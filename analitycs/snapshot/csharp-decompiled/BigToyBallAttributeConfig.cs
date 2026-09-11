using System.Collections.Generic;
using COW.GamePlay;

public class BigToyBallAttributeConfig : ItemEditAttributeBaseConfig
{
	public string VelocityXZConfigTitleNameKey;

	public float VelocityXZ;

	public float VelocityXZMin;

	public float VelocityXZMax;

	public float VelocityXZStep;

	public string VelocityYConfigTitleNameKey;

	public float VelocityY;

	public float VelocityYMin;

	public float VelocityYMax;

	public float VelocityYStep;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectBigToyBall bigToyBall)
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

	private void SetAttributeData(SceneEditObjectBigToyBall ballObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
