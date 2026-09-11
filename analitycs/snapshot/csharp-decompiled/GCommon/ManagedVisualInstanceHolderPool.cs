namespace GCommon;

public static class ManagedVisualInstanceHolderPool
{
	private const int m_PoolCapacity = 64;

	private static readonly ObjectPool<ManagedVisualInstanceHolder> m_Pool;

	public static ManagedVisualInstanceHolder Allocate()
	{
		return null;
	}

	public static void Collect(ManagedVisualInstanceHolder obj)
	{
	}
}
