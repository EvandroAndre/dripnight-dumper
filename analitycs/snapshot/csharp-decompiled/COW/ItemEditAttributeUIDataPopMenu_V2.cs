using System.Collections.Generic;

namespace COW;

public class ItemEditAttributeUIDataPopMenu_V2 : ItemEditAttributeUIData_V2
{
	public List<string> OptionShowTxtKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<MutableValue> OptionValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
