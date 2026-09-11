namespace COW;

public class ItemEditAttributeUIDataToggleButton : ItemEditAttributeUIData_V2
{
	private string _003CLeftKey_003Ek__BackingField;

	private string _003CRightKey_003Ek__BackingField;

	public string LeftKey
	{
		get
		{
			return _003CLeftKey_003Ek__BackingField;
		}
		set
		{
			_003CLeftKey_003Ek__BackingField = value;
		}
	}

	public string RightKey
	{
		get
		{
			return _003CRightKey_003Ek__BackingField;
		}
		set
		{
			_003CRightKey_003Ek__BackingField = value;
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
