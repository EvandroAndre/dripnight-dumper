using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeReadOnlyText : UISceneEditItemAttributeControllerBase
{
	protected UISceneEditItemAttributeReadOnlyTextView m_View;

	protected string m_CurValue;

	protected float m_StepValue;

	protected string m_UGCType;

	protected int m_DecimalPlaces;

	protected bool m_CheckStepValidation;

	protected string m_TipKey;

	protected PJKGGCKLOFF m_Condition;

	protected virtual string CurValue
	{
		get
		{
			return null;
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

	private void OnAttributeChange(long repDataIndex, UGCSimpleValue newValue)
	{
	}

	protected void OnConditionHandler(bool value)
	{
	}

	protected virtual void UpdateLabelText()
	{
	}

	protected void OnClickHintButton()
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
