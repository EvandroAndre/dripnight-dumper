using GCommon;

namespace COW;

internal class UIRuleVector3SettingController : UIBaseController, IUIRuleBindVar
{
	protected UIRuleVector3SettingView m_View;

	public CVector3Data Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnEnable()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CVector3Data data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
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

	private void OnXChange()
	{
	}

	private void OnYChange()
	{
	}

	private void OnZChange()
	{
	}

	private void OnLostFocus()
	{
	}

	protected void OnValueChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
