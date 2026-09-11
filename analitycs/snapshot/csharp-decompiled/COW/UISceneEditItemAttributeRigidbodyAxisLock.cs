using GCommon;

namespace COW;

public class UISceneEditItemAttributeRigidbodyAxisLock : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	private UISceneEditItemAttributeRigidbodyAxisLockView m_View;

	private int m_CurLockAxisValue;

	private bool m_IsPosXSelected;

	private bool m_IsPosYSelected;

	private bool m_IsPosZSelected;

	private bool m_IsRotXSelected;

	private bool m_IsRotYSelected;

	private bool m_IsRotZSelected;

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

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	private void OnToggleClick(UIToggleButton toggle, ref bool isSelected)
	{
	}

	private void SetToggleState(UIToggleButton toggle, bool isSelected)
	{
	}

	private void _003COnUIInit_003Eb__9_0()
	{
	}

	private void _003COnUIInit_003Eb__9_1()
	{
	}

	private void _003COnUIInit_003Eb__9_2()
	{
	}

	private void _003COnUIInit_003Eb__9_3()
	{
	}

	private void _003COnUIInit_003Eb__9_4()
	{
	}

	private void _003COnUIInit_003Eb__9_5()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
