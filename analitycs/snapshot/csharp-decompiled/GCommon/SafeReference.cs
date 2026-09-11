using System.Collections.Generic;

namespace GCommon;

public class SafeReference<T>
{
	private HashSet<T> m_References;

	public void UnsafeAdd(T unique)
	{
	}

	public void UnsafeRemove(T unique)
	{
	}

	public bool UnsafeAsBool()
	{
		return false;
	}

	public static implicit operator bool(SafeReference<T> self)
	{
		return false;
	}
}
