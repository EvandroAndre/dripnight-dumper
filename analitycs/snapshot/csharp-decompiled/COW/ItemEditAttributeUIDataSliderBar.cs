namespace COW;

public class ItemEditAttributeUIDataSliderBar : ItemEditAttributeUIData_V2
{
	protected float m_MaxValue;

	protected float m_StepValue;

	protected float m_PreciseStepValue;

	public float MinValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float StepValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PreciseStepValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int DecimalPlaces
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool CheckStepValidation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public SceneEditItemAttributeUIType _003C_003EiFixBaseProxy_GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}
}
