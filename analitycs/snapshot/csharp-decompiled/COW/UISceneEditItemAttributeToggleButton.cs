using GCommon;

namespace COW;

internal class UISceneEditItemAttributeToggleButton : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	private UISceneEditItemAttributeToggleView m_View;

	private bool m_CurValue;

	private string m_TipKey;

	private bool CurValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	private void OnItemSelectCallback(UIToggleButton btn)
	{
	}

	private void OnClickHintButton()
	{
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
