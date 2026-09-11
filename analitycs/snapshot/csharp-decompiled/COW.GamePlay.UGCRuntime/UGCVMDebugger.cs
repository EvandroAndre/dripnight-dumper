using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebugger
{
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public List<string> localCodeIDList;

		public List<string> localValueList;

		public List<sbyte> localTypeList;

		internal IteratorResultType _003CProcessQueryCodeParamVariable_003Eb__0(int index, StackVar stackVar)
		{
			return IteratorResultType.Continue;
		}
	}

	private UGCVMDebuggerClient _003CCurrentClient_003Ek__BackingField;

	private IUGCVMDebuggerClientNotify _003CDefaultClientNotify_003Ek__BackingField;

	private ulong _003CInitTime_003Ek__BackingField;

	private bool _003CisDebugSettingApplyed_003Ek__BackingField;

	private int _003CapplyDebugSettingTimeout_003Ek__BackingField;

	private CLAJGBDHLFE _003CdebugSettings_003Ek__BackingField;

	private long _003CstartDebugTimeSecond_003Ek__BackingField;

	private bool _003CdebugUserQuited_003Ek__BackingField;

	private IGameBridge _003Cgamecore_003Ek__BackingField;

	private bool _003CisPaused_003Ek__BackingField;

	private string _003CcurrentExecCodeID_003Ek__BackingField;

	private ulong _003CguessPlayerGroupID_003Ek__BackingField;

	private bool _003CisBotLoaded_003Ek__BackingField;

	private int _003Clog2ClientMaxLength_003Ek__BackingField;

	public UGCVMDebuggerClient CurrentClient
	{
		get
		{
			return _003CCurrentClient_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentClient_003Ek__BackingField = value;
		}
	}

	public IUGCVMDebuggerClientNotify DefaultClientNotify
	{
		get
		{
			return _003CDefaultClientNotify_003Ek__BackingField;
		}
		private set
		{
			_003CDefaultClientNotify_003Ek__BackingField = value;
		}
	}

	public ulong InitTime
	{
		get
		{
			return _003CInitTime_003Ek__BackingField;
		}
		private set
		{
			_003CInitTime_003Ek__BackingField = value;
		}
	}

	public bool isDebugSettingApplyed
	{
		get
		{
			return _003CisDebugSettingApplyed_003Ek__BackingField;
		}
		private set
		{
			_003CisDebugSettingApplyed_003Ek__BackingField = value;
		}
	}

	public int applyDebugSettingTimeout
	{
		get
		{
			return _003CapplyDebugSettingTimeout_003Ek__BackingField;
		}
		private set
		{
			_003CapplyDebugSettingTimeout_003Ek__BackingField = value;
		}
	}

	public CLAJGBDHLFE debugSettings
	{
		get
		{
			return _003CdebugSettings_003Ek__BackingField;
		}
		private set
		{
			_003CdebugSettings_003Ek__BackingField = value;
		}
	}

	public long startDebugTimeSecond
	{
		get
		{
			return _003CstartDebugTimeSecond_003Ek__BackingField;
		}
		private set
		{
			_003CstartDebugTimeSecond_003Ek__BackingField = value;
		}
	}

	public bool debugUserQuited
	{
		get
		{
			return _003CdebugUserQuited_003Ek__BackingField;
		}
		private set
		{
			_003CdebugUserQuited_003Ek__BackingField = value;
		}
	}

	public IGameBridge gamecore
	{
		get
		{
			return _003Cgamecore_003Ek__BackingField;
		}
		private set
		{
			_003Cgamecore_003Ek__BackingField = value;
		}
	}

	public bool isPaused
	{
		get
		{
			return _003CisPaused_003Ek__BackingField;
		}
		private set
		{
			_003CisPaused_003Ek__BackingField = value;
		}
	}

	public string currentExecCodeID
	{
		get
		{
			return _003CcurrentExecCodeID_003Ek__BackingField;
		}
		private set
		{
			_003CcurrentExecCodeID_003Ek__BackingField = value;
		}
	}

	public ulong guessPlayerGroupID
	{
		get
		{
			return _003CguessPlayerGroupID_003Ek__BackingField;
		}
		private set
		{
			_003CguessPlayerGroupID_003Ek__BackingField = value;
		}
	}

	public bool isBotLoaded
	{
		get
		{
			return _003CisBotLoaded_003Ek__BackingField;
		}
		private set
		{
			_003CisBotLoaded_003Ek__BackingField = value;
		}
	}

	public int log2ClientMaxLength
	{
		get
		{
			return _003Clog2ClientMaxLength_003Ek__BackingField;
		}
		private set
		{
			_003Clog2ClientMaxLength_003Ek__BackingField = value;
		}
	}

	public UGCVMDebugger(IGameBridge gamecore)
	{
	}

	public UGCVMDebuggerClient InitClient(ulong userID, IUGCVMDebuggerClientNotify clientNotify)
	{
		return null;
	}

	public UGCVMDebuggerClient GetClientByID(ulong userID)
	{
		return null;
	}

	public Tuple2<bool, ulong> IsNeedBreak(StackContext stack, string codeID)
	{
		return default(Tuple2<bool, ulong>);
	}

	public void OnCodeBreaked(ulong userID, StackContext breakedStack, DOMDODOIOBI code)
	{
	}

	public StackContext GetDebuggingStack(ulong userID, int debuggerCtxID)
	{
		return null;
	}

	public Tuple2<string, int> Variable2String(string codeID, UGCVarValueDataV2 cp, StackContext stack)
	{
		return default(Tuple2<string, int>);
	}

	public Tuple2<string, int> VariableValue2String(object valueInteface)
	{
		return default(Tuple2<string, int>);
	}

	public void ProcessBreakPointCmd(ulong clientID, uint cmdID, string codeID)
	{
	}

	public void ProcessClientCmd(ulong clientID, uint cmdID, int debuggerCtxID)
	{
	}

	public bool ProcessQueryVariable(ulong clientID, int debuggerCtxID, List<string> variableNameList, out UGCVMDebugVariableQueryResult result)
	{
		result = null;
		return false;
	}

	public bool ProcessQueryCodeParamVariable(ulong clientID, int debuggerCtxID, out UGCVMDebugCodeParamQueryResult result)
	{
		result = null;
		return false;
	}

	private List<int> GetInvokeArgsIndex(DOMDODOIOBI code)
	{
		return null;
	}

	public void ProcessGMCmd(ulong clientID, uint playerID, int gmCMDID)
	{
	}

	public bool IsDebugEnable()
	{
		return false;
	}

	public void Pause()
	{
	}

	public void Continue(ulong clientID, int debuggerCtxID)
	{
	}

	public void AddBreakpoint(ulong clientID, string codeID)
	{
	}

	public void SetBreakpoints(ulong clientID, List<string> codeIDList)
	{
	}

	public void RemoveBreakpoint(ulong clientID, string codeID)
	{
	}

	public void StepOver(ulong clientID, int debuggerCtxID)
	{
	}

	public void StepInto(ulong clientID, int debuggerCtxID)
	{
	}

	public void PreExecCode(StackContext stack, string codeID)
	{
	}

	public void PostExecCode(StackContext stack, string codeID)
	{
	}

	public string GetCurExecCodeID()
	{
		return null;
	}

	public void LogAssert(bool assertResult, string tips, string graphName)
	{
	}

	private void ApplyLocalDebugPause(bool isPaused)
	{
	}

	public void Tick(TimeAbsMS curTime, IGameBridge gamecore)
	{
	}

	public void LoadDebugSetting(CLAJGBDHLFE debugSettings)
	{
	}

	public bool IsDebugForceEnd(int maxDebugMinute)
	{
		return false;
	}

	public void LoadBot()
	{
	}

	public void ApplyDebugSetting(IGameBridge gamecore)
	{
	}
}
