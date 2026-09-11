using System.Collections.Generic;

namespace GCommon;

public class IntervalTreeDic<T>
{
	public IntervalTree m_Tree;

	public List<T> m_Data;

	public int Count => 0;

	public IEnumerable<T> Values => null;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(uint id)
	{
		return default(T);
	}

	public void set_Item(uint id, T value)
	{
	}

	public bool TryGetValue(uint id, out T data)
	{
		data = default(T);
		return false;
	}
}
