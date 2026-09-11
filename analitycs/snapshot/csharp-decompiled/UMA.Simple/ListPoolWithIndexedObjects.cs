using System.Collections.Generic;

namespace UMA.Simple;

public class ListPoolWithIndexedObjects<T> where T : IGetSetIndex, new()
{
	private List<T> m_Pool;

	private int m_pFree;

	public T Allocate()
	{
		return default(T);
	}

	protected virtual T Create()
	{
		return default(T);
	}

	protected virtual void OnAllocate(T t)
	{
	}

	public void Release(T t)
	{
	}

	protected virtual void OnRelease(T t)
	{
	}
}
