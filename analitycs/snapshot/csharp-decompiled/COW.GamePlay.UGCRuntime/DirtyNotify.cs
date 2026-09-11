namespace COW.GamePlay.UGCRuntime;

public class DirtyNotify : IDirtyNotify
{
	private EntityIndex _003CTarget_003Ek__BackingField;

	private long _003CPropID_003Ek__BackingField;

	private DirtyNotifyHandle _003CHandler_003Ek__BackingField;

	public EntityIndex Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		private set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}

	public long PropID
	{
		get
		{
			return _003CPropID_003Ek__BackingField;
		}
		private set
		{
			_003CPropID_003Ek__BackingField = value;
		}
	}

	public DirtyNotifyHandle Handler
	{
		get
		{
			return _003CHandler_003Ek__BackingField;
		}
		private set
		{
			_003CHandler_003Ek__BackingField = value;
		}
	}

	public void SetDirtyNotify(EntityIndex target, long propID, DirtyNotifyHandle handler)
	{
	}

	public void CleanDirtyNotify()
	{
	}

	public void NotifyDirty(object value)
	{
	}
}
