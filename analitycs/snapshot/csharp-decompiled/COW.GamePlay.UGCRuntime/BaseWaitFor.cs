namespace COW.GamePlay.UGCRuntime;

public class BaseWaitFor
{
	protected bool isDone;

	public BaseWaitFor Create()
	{
		return null;
	}

	public virtual void Reset()
	{
	}

	public virtual bool IsDone()
	{
		return false;
	}

	public virtual void SetIsDone(bool v)
	{
	}
}
