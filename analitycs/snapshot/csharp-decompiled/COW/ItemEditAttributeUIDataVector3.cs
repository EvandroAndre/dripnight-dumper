using LitJson;
using UnityEngine;

namespace COW;

public class ItemEditAttributeUIDataVector3 : ItemEditAttributeUIData_V2
{
	public Vector3 MinValue
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 MaxValue
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public void SetUIData(JsonData data)
	{
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
