using GCommon;

namespace COW;

internal class UISceneEditSecondLevelAttributeSliderBar : UIBaseController, IUISceneEditSecondLevelAttributeItem
{
	protected UIRuleSlidableNumericSettingView m_View;

	public ItemEditAttributeUIDataSliderBar Data;

	public bool m_IsSliderChangedInternally;

	private float m_MinValue;

	private float m_MaxValue;

	private float m_StepValue;

	private float m_DefaultValue;

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

	public void SetViewData(ItemEditAttributeUIData_V2 data, float width, float height)
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnSubBtnClick()
	{
	}

	protected virtual void OnSliderChanged()
	{
	}

	private void OnClickTip()
	{
	}

	private float GetFloatValue()
	{
		return 0f;
	}

	private void UpdateValueText()
	{
	}

	protected void SetCurValue(float newValue)
	{
	}

	protected void OnValueChanged()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
