public class ItemEditAttributeUIData
{
	protected string m_AttributeTitleNameKey;

	public string AttributeTitleNameKey => null;

	public virtual SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public virtual void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	public virtual ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}
}
