public class TssSdtDataTypeFactory
{
	private static byte m_byte_xor_key;

	private static short m_short_xor_key;

	private static ushort m_ushort_xor_key;

	private static int m_int_xor_key;

	private static uint m_uint_xor_key;

	private static long m_long_xor_key;

	private static ulong m_ulong_xor_key;

	public static byte GetByteXORKey()
	{
		return 0;
	}

	public static void SetByteXORKey(byte v)
	{
	}

	public static short GetShortXORKey()
	{
		return 0;
	}

	public static ushort GetUshortXORKey()
	{
		return 0;
	}

	public static int GetIntXORKey()
	{
		return 0;
	}

	public static uint GetUintXORKey()
	{
		return 0u;
	}

	public static long GetLongXORKey()
	{
		return 0L;
	}

	public static ulong GetUlongXORKey()
	{
		return 0uL;
	}

	public static int GetRandomValueIndex()
	{
		return 0;
	}

	public static int GetValueArraySize()
	{
		return 0;
	}

	public static uint GetFloatEncValue(float v, byte key)
	{
		return 0u;
	}

	public static float GetFloatDecValue(uint v, byte key)
	{
		return 0f;
	}

	public static ulong GetDoubleEncValue(double v, byte key)
	{
		return 0uL;
	}

	public static double GetDoubleDecValue(ulong v, byte key)
	{
		return 0.0;
	}
}
