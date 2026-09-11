namespace TsiU;

public abstract class TBTActionLeaf : TBTAction
{
	private class TBTActionLeafContext : TBTActionContext
	{
		internal int status;

		internal bool needExit;

		private object _userData;

		public T getUserData<T>() where T : class, new()
		{
			return null;
		}
	}

	private const int ACTION_READY = 0;

	private const int ACTION_RUNNING = 1;

	private const int ACTION_FINISHED = 2;

	public TBTActionLeaf()
		: base(0)
	{
	}

	protected sealed override int onUpdate(TBTWorkingData wData)
	{
		return 0;
	}

	protected sealed override void onTransition(TBTWorkingData wData)
	{
	}

	protected T getUserContexData<T>(TBTWorkingData wData) where T : class, new()
	{
		return null;
	}

	protected virtual void onEnter(TBTWorkingData wData)
	{
	}

	protected virtual int onExecute(TBTWorkingData wData)
	{
		return 0;
	}

	protected virtual void onExit(TBTWorkingData wData, int runningStatus)
	{
	}
}
