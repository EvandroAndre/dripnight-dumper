using System;
using System.Collections;
using System.Collections.Generic;

namespace GCommon.Utillities;

public class CircularBuffer<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__21 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public CircularBuffer<T> _003C_003E4__this;

		private long _003Cversion_003E5__2;

		private int _003Ci_003E5__3;

		T IEnumerator<T>.Current => default(T);

		object IEnumerator.Current => null;

		public _003CGetEnumerator_003Ed__21(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private T[] m_Buffer;

	private int m_Position;

	private long m_Version;

	private int _003CCapacity_003Ek__BackingField;

	private int _003CCount_003Ek__BackingField;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(int index)
	{
		return default(T);
	}

	public void set_Item(int index, T value)
	{
	}

	public int Capacity
	{
		get
		{
			return _003CCapacity_003Ek__BackingField;
		}
		private set
		{
			_003CCapacity_003Ek__BackingField = value;
		}
	}

	public int Count
	{
		get
		{
			return _003CCount_003Ek__BackingField;
		}
		private set
		{
			_003CCount_003Ek__BackingField = value;
		}
	}

	bool ICollection<T>.IsReadOnly => false;

	public CircularBuffer(int capacity)
	{
	}

	public void Add(T item)
	{
	}

	public T Add()
	{
		return default(T);
	}

	public void Init(Type type)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public void Insert(int index, T item)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
