using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCVMDebuggerClientNotify
{
	void NotifyDebuggerReady();

	void NotifyClientBreaked(ulong userid, int debuggerCtxID, DOMDODOIOBI code);

	void NotifyClientContextSuspend(ulong userid, int debuggerCtxID);

	void NotifyClientVariableValue(ulong userid, int debuggerCtxID, List<string> varNameList, List<string> varValueList, List<sbyte> varTypeList);

	void NotifyClientCodeParam(ulong userid, int debuggerCtxID, List<string> varValueList, List<sbyte> varTypeList, List<string> varCodeIDList, List<string> callStack);

	void NotifyClientConsoleLog(ulong userid, string codeID, int logType, string logText, bool isSystemLog, string locText, List<string> locTextParams);

	void NotifyClientCmd(ulong userid, int cmd);

	void NotifyClientDebugInfomation(ulong userid, Dictionary<string, UGCVMDebuggerBreakPointStatus> breakpoints);

	void NotifyClientAssertLog(string codeID, string logText, bool assertResult, string graphName);
}
