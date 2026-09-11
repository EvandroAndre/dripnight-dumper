namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebuggerBreakPointStatus
{
	private bool _003CIsEnable_003Ek__BackingField;

	private StackContext _003CCurContinueStack_003Ek__BackingField;

	private string _003CCurContinueStackID_003Ek__BackingField;

	public bool IsEnable
	{
		get
		{
			return _003CIsEnable_003Ek__BackingField;
		}
		set
		{
			_003CIsEnable_003Ek__BackingField = value;
		}
	}

	public StackContext CurContinueStack
	{
		get
		{
			return _003CCurContinueStack_003Ek__BackingField;
		}
		set
		{
			_003CCurContinueStack_003Ek__BackingField = value;
		}
	}

	public string CurContinueStackID
	{
		get
		{
			return _003CCurContinueStackID_003Ek__BackingField;
		}
		set
		{
			_003CCurContinueStackID_003Ek__BackingField = value;
		}
	}
}
