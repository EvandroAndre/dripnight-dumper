using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCDebgguerNotifyNull : IUGCVMDebuggerClientNotify
{
	public void NotifyDebuggerReady()
	{
	}

	public void NotifyClientBreaked(ulong userid, int debuggerCtxID, DOMDODOIOBI code)
	{
	}

	public void NotifyClientContextSuspend(ulong userid, int debuggerCtxID)
	{
	}

	public void NotifyClientVariableValue(ulong userid, int debuggerCtxID, List<string> varNameList, List<string> varValueList, List<sbyte> varTypeList)
	{
	}

	public void NotifyClientCodeParam(ulong userid, int debuggerCtxID, List<string> varValueList, List<sbyte> varTypeList, List<string> varCodeIDList, List<string> callStack)
	{
	}

	public void NotifyClientConsoleLog(ulong userid, string codeID, int logType, string logText, bool isSystemLog, string locText, List<string> locTextParams)
	{
	}

	public void NotifyClientAssertLog(string codeID, string logText, bool assertResult, string graphName)
	{
	}

	public void NotifyClientCmd(ulong userid, int cmd)
	{
	}

	public void NotifyClientDebugInfomation(ulong userid, Dictionary<string, UGCVMDebuggerBreakPointStatus> breakpoints)
	{
	}
}
