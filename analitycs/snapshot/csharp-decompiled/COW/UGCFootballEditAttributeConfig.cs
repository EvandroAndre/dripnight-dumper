using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public class UGCFootballEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string RadiusKey;

	public float RadiusMaxValue;

	public float RadiusMinValue;

	public float RadiusDefaultValue;

	public float RadiusStep;

	public string FrictionKey;

	public float FrictionMaxValue;

	public float FrictionMinValue;

	public float FrictionDefaultValue;

	public float FrictionStep;

	public string FrictionRushKey;

	public float FrictionRushMaxValue;

	public float FrictionRushMinValue;

	public float FrictionRushDefaultValue;

	public float FrictionRushStep;

	public string ShootAngleMinKey;

	public float ShootAngleMinMaxValue;

	public float ShootAngleMinMinValue;

	public float ShootAngleMinDefaultValue;

	public float ShootAngleMinStep;

	public string HighShootAngleMinKey;

	public float HighShootAngleMinMaxValue;

	public float HighShootAngleMinMinValue;

	public float HighShootAngleMinDefaultValue;

	public float HighShootAngleMinStep;

	public string HideTimeKey;

	public float HideTimeMaxValue;

	public float HideTimeMinValue;

	public float HideTimeDefaultValue;

	public float HideTimeStep;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectFootBall sceneEditObject)
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

	private void SetAttributeData(SceneEditObjectFootBall football, List<ItemEditAttributeCacheValueBase> uiDataList)
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
