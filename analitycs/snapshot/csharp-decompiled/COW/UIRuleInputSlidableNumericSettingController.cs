using GCommon;
using UnityEngine;

namespace COW;

internal class UIRuleInputSlidableNumericSettingController : UIBaseController, IUIRuleBindVar
{
	protected UIRuleInputSlidableNumericSettingView m_View;

	public CInputSliderData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private bool m_IsSliderChangedInternally;

	private string unitText;

	public int ValueChangeCount;

	private static readonly Color32 m_GrayColor;

	private void Update()
	{
	}

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

	protected void OnEnable()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CInputSliderData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnInputFieldChange()
	{
	}

	private void OnSubBtnClick()
	{
	}

	private void OnMaskClick()
	{
	}

	protected virtual void OnSliderChanged()
	{
	}

	private void UpdateValueText()
	{
	}

	protected void SetFloatValue(float newValue)
	{
	}

	protected void SetIntValue(int newValue)
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

	protected void OnValueChanged()
	{
	}

	private void UpdateChangeState(bool canChange)
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
