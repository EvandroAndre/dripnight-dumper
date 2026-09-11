namespace GCommon;

public class BitArray
{
	public const uint NONE = 0u;

	public const uint FULL = uint.MaxValue;

	protected uint m_Value;

	public static bool HasFlag(uint value, uint flags)
	{
		return false;
	}

	public static bool HasFlagByPos(uint value, uint pos)
	{
		return false;
	}

	public static uint AddFlag(uint value, uint flags)
	{
		return 0u;
	}

	public static uint AddFlagByPos(uint value, uint pos)
	{
		return 0u;
	}

	public static uint RemoveFlag(uint value, uint flags)
	{
		return 0u;
	}

	public static uint RemoveFlagByPos(uint value, uint pos)
	{
		return 0u;
	}

	public static uint GetValueByRange(uint value, uint start, uint end)
	{
		return 0u;
	}

	public bool HasFlag(uint flags)
	{
		return false;
	}

	public bool OnlyHasFlag(uint flags)
	{
		return false;
	}

	public bool HasFlagByPos(uint pos)
	{
		return false;
	}

	public void AddFlag(uint flags)
	{
	}

	public void AddFlagByPos(uint pos)
	{
	}

	public void RemoveFlag(uint flags)
	{
	}

	public void RemoveFlagByPos(uint pos)
	{
	}

	public uint GetValue()
	{
		return 0u;
	}

	public void SetValue(uint value)
	{
	}

	public bool Equals(BitArray ba)
	{
		return false;
	}

	public override bool Equals(object ba)
	{
		return false;
	}
}
