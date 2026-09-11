using System.Collections.Generic;
using COW.GamePlay;

public class MiniSentryEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string HPConfigTitleNameKey;

	public uint HP;

	public uint HPMin;

	public uint HPMax;

	public uint HPStep;

	public string AttackConfigTitleNameKey;

	public uint Attack;

	public uint AttackMin;

	public uint AttackMax;

	public uint AttackStep;

	public string DefenseConfigTitleNameKey;

	public float Defense;

	public float DefenseMin;

	public float DefenseMax;

	public float DefenseStep;

	public string AttackRangeConfigTitleNameKey;

	public List<string> AttackRangeTitles;

	public List<int> RangeList;

	public string AttackIntervalConfigTitleNameKey;

	public float AttackInterval;

	public float AttackIntervalMin;

	public float AttackIntervalMax;

	public float AttackIntervalStep;

	public string TeamConfigTitleNameKey;

	public string TeamLabelNeutralNameKey;

	public string TeamTipKey;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectMiniSentry miniSentryObj)
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

	private void SetAttributeData(SceneEditObjectMiniSentry sceneMiniSentry, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
