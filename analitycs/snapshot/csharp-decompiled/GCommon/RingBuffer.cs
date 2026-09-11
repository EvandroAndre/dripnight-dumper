using System;
using System.Collections;
using System.Collections.Generic;

namespace GCommon;

public class RingBuffer<T> : IEnumerable<T>, IEnumerable, ICollection<T>, ICollection
{
	private sealed class _003CGetEnumerator_003Ed__17 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public RingBuffer<T> _003C_003E4__this;

		private int _003C_index_003E5__2;

		private int _003Ci_003E5__3;

		T IEnumerator<T>.Current => default(T);

		object IEnumerator.Current => null;

		public _003CGetEnumerator_003Ed__17(int _003C_003E1__state)
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

	protected int head;

	protected int tail;

	protected int size;

	protected T[] buffer;

	private bool allowOverflow;

	public bool AllowOverflow => false;

	public int Capacity => 0;

	public int Size => 0;

	public int Count => 0;

	public bool IsReadOnly => false;

	public object SyncRoot => null;

	public bool IsSynchronized => false;

	public T Get()
	{
		return default(T);
	}

	public void Put(T item)
	{
	}

	protected void addToBuffer(T toAdd, bool overflow)
	{
	}

	public RingBuffer()
	{
	}

	public RingBuffer(int capacity)
	{
	}

	public RingBuffer(int capacity, bool overflow)
	{
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Add(T item)
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}
}
