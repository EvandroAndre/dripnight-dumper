using System;
using System.Reflection;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRuleInputSlidableNumericSettingControllerV2 : UIBaseController, IUIRuleBindVar
{
	protected UIRuleInputSlidableNumericSettingV2View m_View;

	private Action m_ValueChangeCallback;

	private FieldInfo m_FieldInfo;

	public CRangeData Data;

	private bool m_IsSliderChangedInternally;

	protected string unitText;

	public int ValueChangeCount;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private static readonly Color32 m_GrayColor;

	private void Update()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected void OnEnable()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CRangeData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	public void SetValueChangeCallback(Action callback)
	{
	}

	protected void OnValueChanged()
	{
	}

	protected void OnValueChangedInertnal()
	{
	}

	protected void SetFloatValue(float newValue)
	{
	}

	protected void SetIntValue(int newValue)
	{
	}

	private void UpdateValueText()
	{
	}

	private void OnInputFieldChange()
	{
	}

	protected void OnSliderChanged()
	{
	}

	private void Log()
	{
	}

	private void OnMaskClick()
	{
	}

	public int GetModeVariableID()
	{
		return 0;
	}

	public virtual UIWidget GetBindWidget()
	{
		return null;
	}

	private void UpdateChangeState(bool canChange)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
