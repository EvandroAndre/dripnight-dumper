using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayMap<TVal> where TVal : class
{
	public struct Enumerator : IEnumerator<KeyValuePair<int, TVal>>, IEnumerator, IDisposable
	{
		private bool m_FallBackToDic = false;

		private int m_Index = 0;

		private int m_Length = 0;

		private object m_Current = null;

		private IList m_InnerList = null;

		private IDictionary m_InnerDic = null;

		private Dictionary<int, object>.Enumerator enumDic = default(Dictionary<int, object>.Enumerator);

		private object m_InvalidValue = null;

		public KeyValuePair<int, TVal> Current => default(KeyValuePair<int, TVal>);

		object IEnumerator.Current => null;

		internal Enumerator(bool fallBackToDic, object[] array, Dictionary<int, object> dic)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private bool m_FallBackToDic;

	private Dictionary<int, object> m_FallBackDic;

	private object[] m_ArrayMap;

	private static readonly object m_InvalidValue;

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public TVal get_Item(int key)
	{
		return null;
	}

	public void set_Item(int key, TVal value)
	{
	}

	public ArrayMap(int count)
	{
	}

	public void Add(int key, TVal val)
	{
	}

	public void Clear()
	{
	}

	public bool ContainsKey(int key)
	{
		return false;
	}

	public bool TryGetValue(int key, out TVal val)
	{
		val = null;
		return false;
	}

	public bool Remove(int key)
	{
		return false;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}
}
