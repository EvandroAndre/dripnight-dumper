using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class GeneralSearch<T>
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public GeneralSearchCommandData<T> command;

		public Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> combineFunction;

		public int index;

		public GeneralSearch<T> _003C_003E4__this;

		public Action<IEnumerable<T>> resultCallback;

		internal void _003CExecuteInternal_003Eb__0(IEnumerable<T> result)
		{
		}
	}

	private List<GeneralSearchCommandData<T>> m_Commands;

	public void AddSearchCommand(ISearchFilter<T> searchFilter, IEnumerable<T> newSource, Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> combineFunction)
	{
	}

	public void AddFunctionSearchCommand(Func<T, bool> filterFunction, IEnumerable<T> newSource = null, Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> combineFunction = null)
	{
	}

	public void Execute(IEnumerable<T> source, Action<IEnumerable<T>> resultCallback)
	{
	}

	private void ExecuteInternal(int index, IEnumerable<T> source, Action<IEnumerable<T>> resultCallback)
	{
	}

	public void Clear()
	{
	}

	public static IEnumerable<T> IntersectCombineFunction(IEnumerable<T> source1, IEnumerable<T> source2)
	{
		return null;
	}

	public static IEnumerable<T> UnionCombineFunction(IEnumerable<T> source1, IEnumerable<T> source2)
	{
		return null;
	}
}
