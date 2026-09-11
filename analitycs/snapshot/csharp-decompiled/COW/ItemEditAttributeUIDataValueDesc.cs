using message;

namespace COW;

public class ItemEditAttributeUIDataValueDesc
{
	protected MutableValue m_CurValue;

	protected MutableValue m_DefaultValue;

	public MutableValue CurValue => null;

	public MutableValue DefaultValue => null;

	public ItemEditAttributeUIDataValueDesc(MHJLOKOOGNB valueType)
	{
	}

	protected virtual void InitMutableValue(MHJLOKOOGNB valueType)
	{
	}
}
