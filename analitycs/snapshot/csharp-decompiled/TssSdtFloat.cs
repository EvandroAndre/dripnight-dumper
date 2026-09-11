public class TssSdtFloat
{
	private TssSdtFloatSlot m_slot;

	public static TssSdtFloat NewTssSdtFloat()
	{
		return null;
	}

	public float GetValue()
	{
		return 0f;
	}

	public void SetValue(float v)
	{
	}

	public static implicit operator float(TssSdtFloat v)
	{
		return 0f;
	}

	public static implicit operator TssSdtFloat(float v)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(TssSdtFloat a, TssSdtFloat b)
	{
		return false;
	}

	public static bool operator !=(TssSdtFloat a, TssSdtFloat b)
	{
		return false;
	}

	public static TssSdtFloat operator ++(TssSdtFloat v)
	{
		return null;
	}

	public static TssSdtFloat operator --(TssSdtFloat v)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
