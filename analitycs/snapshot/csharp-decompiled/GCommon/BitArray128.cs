namespace GCommon;

public class BitArray128
{
	public static readonly UInt128 NONE;

	public static readonly UInt128 FULL;

	protected UInt128 m_Value;

	public static bool HasFlag(UInt128 value, UInt128 flags)
	{
		return false;
	}

	public static bool HasFlagByPos(UInt128 value, uint pos)
	{
		return false;
	}

	public static UInt128 AddFlag(UInt128 value, UInt128 flags)
	{
		return default(UInt128);
	}

	public static UInt128 AddFlagByPos(UInt128 value, uint pos)
	{
		return default(UInt128);
	}

	public static UInt128 RemoveFlag(UInt128 value, UInt128 flags)
	{
		return default(UInt128);
	}

	public static UInt128 RemoveFlagByPos(UInt128 value, uint pos)
	{
		return default(UInt128);
	}

	public BitArray128()
	{
	}

	public BitArray128(UInt128 value)
	{
	}

	public bool HasFlag(UInt128 flags)
	{
		return false;
	}

	public bool OnlyHasFlag(UInt128 flags)
	{
		return false;
	}

	public bool HasFlagByPos(uint pos)
	{
		return false;
	}

	public void AddFlag(UInt128 flags)
	{
	}

	public void AddFlagByPos(uint pos)
	{
	}

	public void RemoveFlag(UInt128 flags)
	{
	}

	public void RemoveFlagByPos(uint pos)
	{
	}

	public UInt128 GetValue()
	{
		return default(UInt128);
	}

	public void SetValue(UInt128 value)
	{
	}

	public void ResetValue()
	{
	}

	public bool Equals(BitArray128 ba)
	{
		return false;
	}

	public override bool Equals(object ba)
	{
		return false;
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
