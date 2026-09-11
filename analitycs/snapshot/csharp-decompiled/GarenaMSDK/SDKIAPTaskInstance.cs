namespace GarenaMSDK;

internal class SDKIAPTaskInstance
{
	private SDKIAPTaskInfo _003CInfo_003Ek__BackingField;

	private SDKIAPTaskState m_TaskState;

	private SDKIAPTaskResult _003CResult_003Ek__BackingField;

	public SDKIAPTaskInfo Info
	{
		get
		{
			return _003CInfo_003Ek__BackingField;
		}
		private set
		{
			_003CInfo_003Ek__BackingField = value;
		}
	}

	public virtual SDKIAPTask Task => SDKIAPTask.None;

	public virtual SDKIAPTaskState TaskState
	{
		get
		{
			return SDKIAPTaskState.Created;
		}
		internal set
		{
		}
	}

	public virtual SDKIAPTaskResult Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		protected set
		{
			_003CResult_003Ek__BackingField = value;
		}
	}

	public SDKIAPTaskInstance(SDKIAPTaskInfo info)
	{
	}

	internal virtual string IdentifySelf()
	{
		return null;
	}

	public virtual bool IsGoodToGo()
	{
		return false;
	}

	public virtual bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return false;
	}

	public virtual bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return false;
	}

	private void StateChanged(SDKIAPTaskState prev, SDKIAPTaskState next)
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Succeed()
	{
	}

	protected virtual void Fail()
	{
	}

	protected virtual void Destroy()
	{
	}

	protected virtual void Retry()
	{
	}
}
