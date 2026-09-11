using System.Collections.Generic;

namespace GCommon;

public class ObjectPool<T> where T : IObjectPoolCallback, new()
{
	public readonly int InitCapacity;

	private int _003CAllocCount_003Ek__BackingField;

	protected List<T> m_FreeObjects;

	public int AllocCount
	{
		get
		{
			return _003CAllocCount_003Ek__BackingField;
		}
		private set
		{
			_003CAllocCount_003Ek__BackingField = value;
		}
	}

	public int FreeObjectCount => 0;

	public ObjectPool()
	{
	}

	public ObjectPool(int cap)
	{
	}

	public T AllocObject()
	{
		return default(T);
	}

	public void CollectObject(T obj)
	{
	}

	public virtual void Clear()
	{
	}

	protected virtual IObjectPoolCallback AllocObjectInternal()
	{
		return null;
	}

	protected virtual void CollectObjectInternal(T obj)
	{
	}
}
