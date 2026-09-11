namespace COW.GamePlay.UGCRuntime;

public class UGCBreakPointWait : BaseWaitFor, IIterator, IUGCObjectPoolItem
{
	private UGCVMDebuggerContext _003CDebuggerContext_003Ek__BackingField;

	public UGCVMDebuggerContext DebuggerContext
	{
		get
		{
			return _003CDebuggerContext_003Ek__BackingField;
		}
		set
		{
			_003CDebuggerContext_003Ek__BackingField = value;
		}
	}

	public override void Reset()
	{
	}

	public override bool IsDone()
	{
		return false;
	}

	public bool Next()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Reset()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsDone()
	{
		return false;
	}
}
