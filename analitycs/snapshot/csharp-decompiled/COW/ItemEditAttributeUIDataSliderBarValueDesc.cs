using message;

namespace COW;

public class ItemEditAttributeUIDataSliderBarValueDesc : ItemEditAttributeUIDataValueDesc
{
	protected float m_MinValue;

	protected float m_MaxValue;

	protected float m_StepValue;

	protected float m_PreciseStepValue;

	public int DecimalPlaces;

	public bool CheckStepValidation;

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

	public ItemEditAttributeUIDataSliderBarValueDesc(MHJLOKOOGNB valueType)
		: base(MHJLOKOOGNB.Object)
	{
	}
}
