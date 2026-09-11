using System;
using System.Collections.Generic;
using System.Threading;

namespace GCommon;

public static class ParellelFor
{
	private class WorkContext<T>
	{
		public T Item;

		public Action<T> Function;

		public int[] RemainingCount;

		public ManualResetEvent DoneEvent;
	}

	[Serializable]
	private sealed class _003C_003Ec__1<T>
	{
		public static readonly _003C_003Ec__1<T> _003C_003E9;

		public static WaitCallback _003C_003E9__1_0;

		internal void _003CParellelForEach_003Eb__1_0(object state)
		{
		}
	}

	public static void ParellelForEach<T>(IEnumerable<T> collection, Action<T> function)
	{
	}
}
