using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeSliderBar : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	protected UISceneEditItemAttributeSliderView m_View;

	protected float m_CurFloatValue;

	protected int m_CurIntValue;

	protected bool m_IsIntType;

	protected string m_UGCType;

	protected string m_CurValueDisplay;

	protected float m_MinValue;

	protected float m_MaxValue;

	protected float m_StepValue;

	protected int m_DecimalPlaces;

	protected bool m_CheckStepValidation;

	protected string m_TipKey;

	protected PJKGGCKLOFF m_Condition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	protected void OnConditionHandler(bool value)
	{
	}

	private void OnInputLabelChanged()
	{
	}

	private void OnSliderBarChangedManully()
	{
	}

	protected virtual void SetValue(float value)
	{
	}

	protected float FormatAndValidateValue(float value)
	{
		return 0f;
	}

	protected virtual void UpdateLabelText()
	{
	}

	protected string FormatDisplayValue()
	{
		return null;
	}

	protected void UpdateSliderBar()
	{
	}

	protected void OnClickHintButton()
	{
	}

	public virtual void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public virtual void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
