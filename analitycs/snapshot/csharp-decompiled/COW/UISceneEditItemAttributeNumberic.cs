using COW.GamePlay;
using GCommon;

namespace COW;

internal class UISceneEditItemAttributeNumberic : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	protected UISceneEditItemAttributeNumbericView m_View;

	protected float m_CurFloatValue;

	protected int m_CurIntValue;

	protected bool m_IsIntType;

	protected float m_CurValue;

	protected float m_MinValue;

	protected float m_MaxValue;

	protected float m_StepValue;

	protected string m_UGCType;

	protected int m_DecimalPlaces;

	protected bool m_CheckStepValidation;

	protected string m_TipKey;

	protected PJKGGCKLOFF m_Condition;

	protected virtual float CurValue
	{
		get
		{
			return 0f;
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

	protected virtual void UpdateLabelText()
	{
	}

	protected void OnClickHintButton()
	{
	}

	protected float FormatAndValidateValue(float value)
	{
		return 0f;
	}

	private string FormatDisplay(float fDisplay)
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
