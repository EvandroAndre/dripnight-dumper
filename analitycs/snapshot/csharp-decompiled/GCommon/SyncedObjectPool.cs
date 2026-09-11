namespace GCommon;

public class SyncedObjectPool<T> : ObjectPool<T> where T : IObjectPoolCallback, new()
{
	protected override IObjectPoolCallback AllocObjectInternal()
	{
		return null;
	}

	protected override void CollectObjectInternal(T obj)
	{
	}

	public override void Clear()
	{
	}
}
