namespace GCommon;

public class ObjectPoolCallbackBase : IObjectPoolCallback
{
	private bool m_IsInPool;

	public virtual void OnAllocated()
	{
	}

	public virtual void OnCollected()
	{
	}

	public virtual bool IsInPool()
	{
		return false;
	}
}
