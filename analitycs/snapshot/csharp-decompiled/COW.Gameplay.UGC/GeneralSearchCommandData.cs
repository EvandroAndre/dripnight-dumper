using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class GeneralSearchCommandData<T>
{
	public ISearchFilter<T> Filter;

	public IEnumerable<T> SetToCombine;

	public Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> CombineFunction;
}
