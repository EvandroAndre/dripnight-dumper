using System.Collections.Generic;

public class LazyDictionary<TKey, TValue>
{
	private static readonly Dictionary<TKey, TValue>.Enumerator s_EmptyEnumerator;

	private Dictionary<TKey, TValue> m_InnerDic;

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public TValue get_Item(TKey key)
	{
		return default(TValue);
	}

	public void set_Item(TKey key, TValue value)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	public void Clear()
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	private void EnsureCreated()
	{
	}

	public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}
}
