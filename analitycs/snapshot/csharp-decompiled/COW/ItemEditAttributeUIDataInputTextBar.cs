namespace COW;

public class ItemEditAttributeUIDataInputTextBar : ItemEditAttributeUIData_V2
{
	public int CharacterLimit;

	public int Validation;

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
