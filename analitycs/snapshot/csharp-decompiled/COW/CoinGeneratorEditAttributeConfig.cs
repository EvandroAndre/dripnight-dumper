using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;

namespace COW;

public class CoinGeneratorEditAttributeConfig : ItemEditAttributeBaseConfig
{
	public string CoinGeneratorKey;

	public int CoinCountMaxValue;

	public int CoinCountMinValue;

	public int CoinDefaultValue;

	public int CoinChangeStep;

	private EditorEntityData m_Datas;

	public List<ItemEditAttributeUIData> GetUIData(SceneEditObjectCoinGenerator sceneEditAttribute)
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

	private void SetAttributeData(SceneEditObjectCoinGenerator coinGenerator, List<ItemEditAttributeCacheValueBase> uiDataList)
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
