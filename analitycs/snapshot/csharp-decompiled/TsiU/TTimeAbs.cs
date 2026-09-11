namespace TsiU;

public struct TTimeAbs
{
	private const ulong S_TO_MS = 1000uL;

	private const float MS_TO_S = 0.001f;

	private ulong _time = 0uL;

	public TTimeAbs(float t)
	{
	}

	public TTimeAbs(ulong t)
	{
	}

	public TTimeAbs(TTimeAbs t)
	{
	}

	public ulong ToMilliseconds()
	{
		return 0uL;
	}

	public float ToSeconds()
	{
		return 0f;
	}

	public static bool operator ==(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator !=(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator >(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator <(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator >=(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator <=(TTimeAbs a, TTimeAbs b)
	{
		return false;
	}

	public static bool operator ==(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator !=(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator >(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator <(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator >=(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator <=(TTimeAbs a, ulong b)
	{
		return false;
	}

	public static bool operator ==(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator !=(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator >(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator <(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator >=(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator <=(ulong b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator ==(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator !=(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator >(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator <(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator >=(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator <=(TTimeAbs a, float b)
	{
		return false;
	}

	public static bool operator ==(float b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator !=(float b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator >(float b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator <(float b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator >=(float b, TTimeAbs a)
	{
		return false;
	}

	public static bool operator <=(float b, TTimeAbs a)
	{
		return false;
	}

	public static TTimeAbs operator +(TTimeAbs a, TTimeRel b)
	{
		return default(TTimeAbs);
	}

	public static TTimeRel operator -(TTimeAbs a, TTimeAbs b)
	{
		return default(TTimeRel);
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
