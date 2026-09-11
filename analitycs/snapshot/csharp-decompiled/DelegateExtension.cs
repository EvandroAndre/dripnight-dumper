using System;

public static class DelegateExtension
{
	public static void SafeInvoke(Action self)
	{
	}

	public static void SafeInvoke<T>(Action<T> self, T t)
	{
	}

	public static void SafeInvoke<T1, T2>(Action<T1, T2> self, T1 t1, T2 t2)
	{
	}
}
