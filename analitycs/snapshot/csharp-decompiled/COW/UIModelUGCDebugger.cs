using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using GCommon;
using message;
using tcp;

namespace COW;

public class UIModelUGCDebugger : UIBaseModel
{
	public class VariableValue
	{
		public string Name;

		public string Value;

		public int ValueType;
	}

	public class DebuggerContext
	{
		public int ContextID;

		public string HitCodeID;

		public Dictionary<string, VariableValue> StackVariable;

		public List<VariableValue> CodeParamVariable;

		public void UpdateVariableValue(List<string> varNames, List<string> varValues, List<sbyte> varTypes, Dictionary<string, VariableValue> watch)
		{
		}

		public void UpdateCodeParamValue(List<string> varValues, List<sbyte> varTypes)
		{
		}
	}

	public class BreakpointStatus
	{
		public string CodeID;

		public bool IsEnable;
	}

	public enum LogDataType
	{
		LOGGER_CHANNEL_DEFAULT,
		LOGGER_CHANNEL_DEBUG,
		LOGGER_CHANNEL_INFO,
		LOGGER_CHANNEL_WARNING,
		LOGGER_CHANNEL_ERROR,
		LOGGER_CHANNEL_NUM
	}

	public class LogData
	{
		public bool IsSystemLog;

		public int LogType;

		public string CodeID;

		public string LogText;

		public int LogLocTextID;

		public DateTime Time;

		public string GraphID;

		public string FinalDisplayText;

		public bool IsExportLog;

		public string Category;

		public Action<string> EditAction;

		public bool CanEdit;

		public void BuildFinalDisplayText()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public HNDHJGJILHC game;

		public Action<bool> exportCallback;

		public UIModelSceneEdit sceneEdit;

		internal void _003CExportAndSaveEditorData_003Eb__0(bool result)
		{
		}
	}

	public Dictionary<string, VariableValue> VariableWatch;

	private Dictionary<string, BreakpointStatus> m_localBreakPoints;

	private Dictionary<string, BreakpointStatus> m_breakPoints;

	private List<DebuggerContext> m_debuggerContextList;

	private int m_currentDebuggerContext;

	private bool m_debugEnabled;

	private bool m_WaitingForDatabaseResponse;

	private Action m_PendingQuitAction;

	private uint m_DatabaseGetTimeoutDelayCall;

	public List<LogData> AllLogs;

	private List<LogData> m_pendingLogs;

	private float m_beginDebugTimeThisTime;

	private uint m_totalDebugCountThisTime;

	private float m_totalDebugTimeThisTime;

	public Dictionary<string, BreakpointStatus> BreakPoints => null;

	public Dictionary<string, BreakpointStatus> LocalBreakPoints => null;

	public List<DebuggerContext> AllDebuggerContext => null;

	public int CurrentDebuggerContext
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint TotalDebugCount => 0u;

	public uint TotalDebugTime => 0u;

	public void AddBreakPoint(string codeID)
	{
	}

	public void ToggleBreakPoint(string codeID, bool isRemove)
	{
	}

	public void Step()
	{
	}

	public void Continue()
	{
	}

	public void Pause()
	{
	}

	public void RequestVariable(List<string> variableNameList)
	{
	}

	public void RequestVariable(DebuggerContext dbgCtx)
	{
	}

	public void ExecGMCmd(KDGIOGCEIIC gmCmdID)
	{
	}

	private int MapGMCmdToDebugCommandType(int gmCmdID)
	{
		return 0;
	}

	public void OnDebugInformation(List<string> breakPointList)
	{
	}

	public void OnBreakpointHited(int contextID, string hitCodeID)
	{
	}

	public void OnDebuggerContextSuspend(int contextID)
	{
	}

	public void OnVariableResponse(int contextID, List<string> varNames, List<string> varValues, List<sbyte> varTypes)
	{
	}

	public void OnCodeParamValueResponse(int contextID, List<string> varValues, List<sbyte> varTypes)
	{
	}

	public void ClearLogs()
	{
	}

	public void OnConsoleLog(int logType, string codeID, string logText, long unixTimeStamp, bool isSystemLog, string logLocText, List<string> logLocTextParams)
	{
	}

	public void ProcessPendingLogs(int perFrameLogsLimit)
	{
	}

	public void OnNotifyCmd(int cmdID)
	{
	}

	public void OnStopDebug()
	{
	}

	public DebuggerContext GetDebugContextByID(int contextID)
	{
		return null;
	}

	private void RemoveDebugContext(int contextID)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsDebuggerActive()
	{
		return false;
	}

	public bool IsDebugSwitchOpened()
	{
		return false;
	}

	public void LogEventClear()
	{
	}

	private void LogEventBeginDebug()
	{
	}

	private void LogEventEndDebug()
	{
	}

	public static UGCRuntime GetUGCClientRuntime()
	{
		return null;
	}

	public static void ExportAndSaveEditorData(Action<bool> exportCallback)
	{
	}

	public static UGCDebugStartReq BuildUGCDebugStartReq(bool startFromCurCamera, bool isFillFullBot, bool isStrictMode, bool enableBreakPoints, out CLAJGBDHLFE debugSettings, OHCGHBFNOFA workflowOverride = null)
	{
		debugSettings = null;
		return null;
	}

	private static void OnHandleReturnToEdit()
	{
	}

	public static bool ClientStartDebugGame(string serverAdd, ulong serviceRoomID, string secret, string udpHeadSecret, uint mapid, uint gamemode, uint groupmode, uint resourceLevel, bool isRejoin)
	{
		return false;
	}
}
