using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class FunctionSearchFilter<T> : ISearchFilter<T>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<T, bool> _003C_003E9__2_0;

		internal bool _003CExecute_003Eb__2_0(T b)
		{
			return false;
		}
	}

	public static Func<T, bool> Always;

	public Func<T, bool> FilterFunction;

	public void Execute(IEnumerable<T> sourceSet, Action<IEnumerable<T>> resultCallback)
	{
	}
}
