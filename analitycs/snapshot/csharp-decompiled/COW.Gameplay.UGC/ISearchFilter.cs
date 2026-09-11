using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public interface ISearchFilter<T>
{
	void Execute(IEnumerable<T> sourceSet, Action<IEnumerable<T>> resultCallback);
}
