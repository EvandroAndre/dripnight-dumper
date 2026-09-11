using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebuggerClient
{
	private ulong _003CUserID_003Ek__BackingField;

	private int _003CNextContextID_003Ek__BackingField;

	private Dictionary<string, UGCVMDebuggerBreakPointStatus> _003CCurrentBreakpoints_003Ek__BackingField;

	private List<UGCVMDebuggerContext> _003CActiveDebuggerContext_003Ek__BackingField;

	private IUGCVMDebuggerClientNotify _003CNotify_003Ek__BackingField;

	private int _003CLastStepDebuggerContextID_003Ek__BackingField;

	private uint _003CAutoHealingTime_003Ek__BackingField;

	private ulong _003CAutoHealingUserID_003Ek__BackingField;

	public ulong UserID
	{
		get
		{
			return _003CUserID_003Ek__BackingField;
		}
		set
		{
			_003CUserID_003Ek__BackingField = value;
		}
	}

	public int NextContextID
	{
		get
		{
			return _003CNextContextID_003Ek__BackingField;
		}
		set
		{
			_003CNextContextID_003Ek__BackingField = value;
		}
	}

	public Dictionary<string, UGCVMDebuggerBreakPointStatus> CurrentBreakpoints
	{
		get
		{
			return _003CCurrentBreakpoints_003Ek__BackingField;
		}
		set
		{
			_003CCurrentBreakpoints_003Ek__BackingField = value;
		}
	}

	public List<UGCVMDebuggerContext> ActiveDebuggerContext
	{
		get
		{
			return _003CActiveDebuggerContext_003Ek__BackingField;
		}
		set
		{
			_003CActiveDebuggerContext_003Ek__BackingField = value;
		}
	}

	public IUGCVMDebuggerClientNotify Notify
	{
		get
		{
			return _003CNotify_003Ek__BackingField;
		}
		set
		{
			_003CNotify_003Ek__BackingField = value;
		}
	}

	public int LastStepDebuggerContextID
	{
		get
		{
			return _003CLastStepDebuggerContextID_003Ek__BackingField;
		}
		set
		{
			_003CLastStepDebuggerContextID_003Ek__BackingField = value;
		}
	}

	public uint AutoHealingTime
	{
		get
		{
			return _003CAutoHealingTime_003Ek__BackingField;
		}
		set
		{
			_003CAutoHealingTime_003Ek__BackingField = value;
		}
	}

	public ulong AutoHealingUserID
	{
		get
		{
			return _003CAutoHealingUserID_003Ek__BackingField;
		}
		set
		{
			_003CAutoHealingUserID_003Ek__BackingField = value;
		}
	}

	public UGCVMDebuggerClient Init()
	{
		return null;
	}

	public UGCVMDebuggerContext AddDebugContext(StackContext attachStackContext, DOMDODOIOBI code)
	{
		return null;
	}

	public bool IsNeedBreakByStep(StackContext stack, string codeID)
	{
		return false;
	}

	public bool IsNeedBreak(StackContext stack, string codeID)
	{
		return false;
	}

	public UGCVMDebuggerContext GetDebuggerContext(int debuggerCtxID)
	{
		return null;
	}

	public void StepOver(int debuggerCtxID)
	{
	}

	public Tuple<string, string, StackContext> Continue(int debuggerCtxID)
	{
		return default(Tuple<string, string, StackContext>);
	}

	public void AddBreakpoint(string codeID)
	{
	}

	public void RemoveBreakpoint(string codeID)
	{
	}

	public void ContinueBreakpoint(string codeID, string stackID, StackContext stack, bool isContinue)
	{
	}

	public void RemoveDebugContext(UGCVMDebuggerContext debuggerContext)
	{
	}
}
