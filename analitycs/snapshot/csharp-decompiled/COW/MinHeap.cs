using System.Collections.Generic;

namespace COW;

public class MinHeap : BaseHeap
{
	public MinHeap(int initialSize = 2048)
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

	public void _003C_003EiFixBaseProxy_PushValue(float P0)
	{
	}

	public float _003C_003EiFixBaseProxy_PopValue()
	{
		return 0f;
	}
}
public class MinHeap<T> : MinHeap
{
	private T[] objs;

	private T tempObjs;

	public T HeadHeapObject => default(T);

	public MinHeap(int maxNodes = 2048)
		: base(0)
	{
	}

	protected override void Swap(int A, int B)
	{
	}

	public override void PushValue(float h)
	{
	}

	public override float PopValue()
	{
		return 0f;
	}

	public void PushObj(T obj, float h)
	{
	}

	public T PopObj()
	{
		return default(T);
	}

	public T PopObj(ref float heapValue)
	{
		return default(T);
	}

	protected override void UpsizeHeap()
	{
	}

	public void FlushResult(List<T> resultList, List<float> heapList = null)
	{
	}
}
