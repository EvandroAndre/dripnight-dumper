using System;
using System.Reflection;
using GCommon;

namespace COW;

internal class UIRuleToggleSettingV3Controller : UIBaseController
{
	private UIRuleToggleSettingV3View m_View;

	public CToggleData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private Action m_ValueChangeCallback;

	private FieldInfo m_FieldInfo;

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

	private void OnBtnSwitchClick()
	{
	}

	private void SetValue(bool newValue)
	{
	}

	private void Log()
	{
	}

	private void OnValueChanged()
	{
	}

	public void SetValueChangeCallback(Action callback)
	{
	}

	private void OnValueChangedWithCallback()
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
