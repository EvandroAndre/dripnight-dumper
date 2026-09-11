using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebuggerContext
{
	private StackContext _003CCurStack_003Ek__BackingField;

	private string _003CCurStackID_003Ek__BackingField;

	private string _003CCurBreakpointCodeID_003Ek__BackingField;

	private DOMDODOIOBI _003CCurCode_003Ek__BackingField;

	private UGCVMDebuggerClient _003CClient_003Ek__BackingField;

	private bool _003CIsNextCodeBreak_003Ek__BackingField;

	private bool _003CIsContinueRun_003Ek__BackingField;

	private int _003CID_003Ek__BackingField;

	public StackContext CurStack
	{
		get
		{
			return _003CCurStack_003Ek__BackingField;
		}
		set
		{
			_003CCurStack_003Ek__BackingField = value;
		}
	}

	public string CurStackID
	{
		get
		{
			return _003CCurStackID_003Ek__BackingField;
		}
		set
		{
			_003CCurStackID_003Ek__BackingField = value;
		}
	}

	public string CurBreakpointCodeID
	{
		get
		{
			return _003CCurBreakpointCodeID_003Ek__BackingField;
		}
		set
		{
			_003CCurBreakpointCodeID_003Ek__BackingField = value;
		}
	}

	public DOMDODOIOBI CurCode
	{
		get
		{
			return _003CCurCode_003Ek__BackingField;
		}
		set
		{
			_003CCurCode_003Ek__BackingField = value;
		}
	}

	public UGCVMDebuggerClient Client
	{
		get
		{
			return _003CClient_003Ek__BackingField;
		}
		set
		{
			_003CClient_003Ek__BackingField = value;
		}
	}

	public bool IsNextCodeBreak
	{
		get
		{
			return _003CIsNextCodeBreak_003Ek__BackingField;
		}
		set
		{
			_003CIsNextCodeBreak_003Ek__BackingField = value;
		}
	}

	public bool IsContinueRun
	{
		get
		{
			return _003CIsContinueRun_003Ek__BackingField;
		}
		set
		{
			_003CIsContinueRun_003Ek__BackingField = value;
		}
	}

	public int ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public bool IsBreakByStep(string codeID)
	{
		return false;
	}

	public void StepOver()
	{
	}

	public void Continue()
	{
	}
}
