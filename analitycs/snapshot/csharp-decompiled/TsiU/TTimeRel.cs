namespace TsiU;

public struct TTimeRel
{
	private const ulong S_TO_MS = 1000uL;

	private const float MS_TO_S = 0.001f;

	private ulong _time = 0uL;

	public TTimeRel(float t)
	{
	}

	public TTimeRel(ulong t)
	{
	}

	public TTimeRel(TTimeRel t)
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

	public static bool operator ==(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator !=(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator >(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator <(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator >=(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator <=(TTimeRel a, TTimeRel b)
	{
		return false;
	}

	public static bool operator ==(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator !=(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator >(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator <(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator >=(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator <=(TTimeRel a, ulong b)
	{
		return false;
	}

	public static bool operator ==(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator !=(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator >(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator <(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator >=(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator <=(ulong b, TTimeRel a)
	{
		return false;
	}

	public static bool operator ==(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator !=(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator >(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator <(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator >=(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator <=(TTimeRel a, float b)
	{
		return false;
	}

	public static bool operator ==(float b, TTimeRel a)
	{
		return false;
	}

	public static bool operator !=(float b, TTimeRel a)
	{
		return false;
	}

	public static bool operator >(float b, TTimeRel a)
	{
		return false;
	}

	public static bool operator <(float b, TTimeRel a)
	{
		return false;
	}

	public static bool operator >=(float b, TTimeRel a)
	{
		return false;
	}

	public static bool operator <=(float b, TTimeRel a)
	{
		return false;
	}

	public static TTimeAbs operator +(TTimeRel a, TTimeAbs b)
	{
		return default(TTimeAbs);
	}

	public static TTimeRel operator +(TTimeRel a, TTimeRel b)
	{
		return default(TTimeRel);
	}

	public static TTimeRel operator -(TTimeRel a, TTimeRel b)
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
