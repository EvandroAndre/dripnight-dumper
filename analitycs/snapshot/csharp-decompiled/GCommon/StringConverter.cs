namespace GCommon;

public static class StringConverter
{
	public static float ToFloat(string str, float defaultValue = 0f)
	{
		return 0f;
	}

	public static float ParseToFloat(string str)
	{
		return 0f;
	}

	public static int ToInt(string str, int defaultValue = 0)
	{
		return 0;
	}

	public static uint ToUInt(string str, uint defaultValue = 0u)
	{
		return 0u;
	}

	public static long ToLong(string str, long defaultValue = 0L)
	{
		return 0L;
	}

	public static bool ToUInt(string str, out uint value)
	{
		value = default(uint);
		return false;
	}

	public static bool ToBool(string str, bool defaultValue = false)
	{
		return false;
	}

	public static int ToHashCode(string str)
	{
		return 0;
	}

	public static int ToHashCode(string str, int begin, int count)
	{
		return 0;
	}
}
