using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class ItemFunctionAttributeBaseConfig : ScriptableObject
{
	public virtual void OnCreateObject(SceneEditObjectBase obj)
	{
	}

	public virtual List<ItemFunctionUIData> GetUIData(SceneEditObjectBase obj)
	{
		return null;
	}

	public virtual void Clear()
	{
	}
}
