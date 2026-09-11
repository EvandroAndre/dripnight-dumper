using System.Collections.Generic;

namespace GCommon;

public class StackDictionary<TKey, TValue>
{
	private Dictionary<TKey, TValue> m_Dictionary;

	private List<TKey> m_KeyStack;

	public int Count => 0;

	public bool IsEmpty => false;

	public void Push(TKey key, TValue value)
	{
	}

	public TValue Pop()
	{
		return default(TValue);
	}

	public TValue Peek()
	{
		return default(TValue);
	}

	public void RemoveByKey(TKey key)
	{
	}

	public void Clear()
	{
	}
}
