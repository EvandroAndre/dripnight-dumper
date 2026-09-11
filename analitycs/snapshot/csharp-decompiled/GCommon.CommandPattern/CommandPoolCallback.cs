namespace GCommon.CommandPattern;

public class CommandPoolCallback : ObjectPoolCallbackBase
{
	protected CommandPool m_Pool;

	public virtual void SetPool(CommandPool pool)
	{
	}

	public virtual void CollectSelf()
	{
	}
}
