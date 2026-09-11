namespace GCommon;

public class BitArrayBoolean : BitArray
{
	public enum EBitArrayBooleanMode
	{
		AND_TURE,
		OR_TRUE
	}

	private bool m_InitialValue;

	protected EBitArrayBooleanMode m_Mode;

	public BitArrayBoolean(bool v, EBitArrayBooleanMode mode = EBitArrayBooleanMode.OR_TRUE)
	{
	}

	public void SetBooleanValue(bool v)
	{
	}

	public void SetBooleanValue(uint flag, bool v)
	{
	}

	public bool GetBooleanValue()
	{
		return false;
	}

	public bool Equals(BitArrayBoolean ba)
	{
		return false;
	}

	public override bool Equals(object ba)
	{
		return false;
	}

	public static implicit operator bool(BitArrayBoolean ba)
	{
		return false;
	}

	public void ResetValue()
	{
	}

	public BitArrayBoolean Clone()
	{
		return null;
	}
}
