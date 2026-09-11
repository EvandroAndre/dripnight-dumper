namespace GCommon;

public struct UInt128
{
	private ulong low = 0uL;

	private ulong high = 0uL;

	public static UInt128 Zero => default(UInt128);

	public static UInt128 MaxValue => default(UInt128);

	public UInt128(ulong high, ulong low)
	{
	}

	public UInt128(ulong value)
	{
	}

	public ulong GetHigh()
	{
		return 0uL;
	}

	public ulong GetLow()
	{
		return 0uL;
	}

	public ulong SplitNum(out byte sort)
	{
		sort = default(byte);
		return 0uL;
	}

	public static UInt128 operator &(UInt128 a, UInt128 b)
	{
		return default(UInt128);
	}

	public static UInt128 operator |(UInt128 a, UInt128 b)
	{
		return default(UInt128);
	}

	public static UInt128 operator ^(UInt128 a, UInt128 b)
	{
		return default(UInt128);
	}

	public static UInt128 operator ~(UInt128 a)
	{
		return default(UInt128);
	}

	public static UInt128 operator <<(UInt128 a, int shift)
	{
		return default(UInt128);
	}

	public static UInt128 operator >>(UInt128 a, int shift)
	{
		return default(UInt128);
	}

	public static bool operator ==(UInt128 a, UInt128 b)
	{
		return false;
	}

	public static bool operator !=(UInt128 a, UInt128 b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static implicit operator UInt128(ulong value)
	{
		return default(UInt128);
	}

	public static implicit operator UInt128(int value)
	{
		return default(UInt128);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
