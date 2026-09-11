using System.Collections.Generic;

namespace COW;

public class KSmallestHeap : BaseHeap
{
	public bool Full => false;

	public KSmallestHeap(int maxEntries)
		: base(0)
	{
	}

	public override void PushValue(float h)
	{
	}

	public override float PopValue()
	{
		return 0f;
	}

	public void Print()
	{
	}

	public bool HeapPropertyHolds(int index, int depth = 0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_PushValue(float P0)
	{
	}

	public float _003C_003EiFixBaseProxy_PopValue()
	{
		return 0f;
	}
}
public class KSmallestHeap<T> : KSmallestHeap
{
	private T[] objs;

	private T tempObjs;

	public T HeadHeapObject => default(T);

	public KSmallestHeap(int maxEntries)
		: base(0)
	{
	}

	protected override void Swap(int A, int B)
	{
	}

	public override void PushValue(float h)
	{
	}

	public void PushObj(T obj, float h)
	{
	}

	public override float PopValue()
	{
		return 0f;
	}

	public T PopObj()
	{
		return default(T);
	}

	public T PopObj(ref float heapValue)
	{
		return default(T);
	}

	public void FlushResult(List<T> resultList, List<float> heapList = null)
	{
	}
}
