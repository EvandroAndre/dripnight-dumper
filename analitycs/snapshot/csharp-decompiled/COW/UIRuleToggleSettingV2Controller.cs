using GCommon;

namespace COW;

internal class UIRuleToggleSettingV2Controller : UIBaseController, IUIRuleBindVar
{
	private UIRuleToggleSettingV2View m_View;

	public CToggleData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CToggleData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void OnToggle(UIToggleButton btn)
	{
	}

	private void SetValue(bool newValue)
	{
	}

	public int GetModeVariableID()
	{
		return 0;
	}

	public UIWidget GetBindWidget()
	{
		return null;
	}

	private void OnValueChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
