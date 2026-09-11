using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class ItemEditAttributeBaseConfig : ScriptableObject
{
	public ItemEditAttributeUIDataHorizontalSelect GetResetPerRoundUIData(SceneEditObjectAttrBase sceneEditObject, bool isResetIfOldVersion = false)
	{
		return null;
	}

	public virtual List<ItemEditAttributeUIData> GetDefaultUIData()
	{
		return null;
	}

	public virtual List<ItemEditAttributeUIData> GetSceneEditObjectUIData(SceneEditObjectBase sceneEditObject)
	{
		return null;
	}

	public virtual void ApplyDataCacheValueToObjectAttribute(SceneEditObjectBase sceneEditObject, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}

	public virtual void ApplyChangedDataValueToObjectAttribute(SceneEditObjectAttrBase attrBase, List<ItemEditAttributeCacheValueBase> uiDataList)
	{
	}
}
