namespace GCommon;

public class BitArray64
{
	public const ulong NONE = 0uL;

	public const ulong FULL = ulong.MaxValue;

	protected ulong m_Value;

	public static bool HasFlag(ulong value, ulong flags)
	{
		return false;
	}

	public static bool HasFlagByPos(ulong value, uint pos)
	{
		return false;
	}

	public static ulong AddFlag(ulong value, ulong flags)
	{
		return 0uL;
	}

	public static ulong AddFlagByPos(ulong value, uint pos)
	{
		return 0uL;
	}

	public static ulong RemoveFlag(ulong value, ulong flags)
	{
		return 0uL;
	}

	public static ulong RemoveFlagByPos(ulong value, ulong pos)
	{
		return 0uL;
	}

	public bool HasFlag(ulong flags)
	{
		return false;
	}

	public bool HasFlagByPos(uint pos)
	{
		return false;
	}

	public void AddFlag(ulong flags)
	{
	}

	public void AddFlagByPos(uint pos)
	{
	}

	public void RemoveFlag(ulong flags)
	{
	}

	public void RemoveFlagByPos(uint pos)
	{
	}

	public ulong GetValue()
	{
		return 0uL;
	}

	public void ResetValue()
	{
	}

	public bool Equals(BitArray64 ba)
	{
		return false;
	}

	public override bool Equals(object ba)
	{
		return false;
	}
}
