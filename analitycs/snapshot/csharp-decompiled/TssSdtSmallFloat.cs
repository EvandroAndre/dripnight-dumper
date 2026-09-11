public class TssSdtSmallFloat
{
	private TssSdtLongSlot m_slot;

	public static TssSdtSmallFloat NewTssSdtSmallFloat()
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

	public static implicit operator float(TssSdtSmallFloat v)
	{
		return 0f;
	}

	public static implicit operator TssSdtSmallFloat(float v)
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

	public static bool operator ==(TssSdtSmallFloat a, TssSdtSmallFloat b)
	{
		return false;
	}

	public static bool operator !=(TssSdtSmallFloat a, TssSdtSmallFloat b)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
