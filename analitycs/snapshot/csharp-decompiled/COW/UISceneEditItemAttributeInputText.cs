using GCommon;

namespace COW;

internal class UISceneEditItemAttributeInputText : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView, IUISceneEditSecondLevelAttributeItem
{
	private UISceneEditItemAttributeInputTextView m_View;

	private string m_CurValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnTextSubmit()
	{
	}

	private void OnEditNameClick()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	private void SetValue(string value)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
