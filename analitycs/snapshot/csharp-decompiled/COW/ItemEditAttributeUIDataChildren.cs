namespace COW;

public class ItemEditAttributeUIDataChildren : ItemEditAttributeUIData_V2
{
	public enum EChildType
	{
		Normal,
		WayPoint
	}

	public EChildType ChildType;

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
