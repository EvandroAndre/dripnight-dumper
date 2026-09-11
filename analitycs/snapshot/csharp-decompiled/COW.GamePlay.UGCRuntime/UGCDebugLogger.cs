using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCDebugLogger
{
	public static string UGC_COMMON;

	public static bool IsLogEnabled;

	public static bool IsLog2ClientConsole;

	private UGCRuntime ugcRuntime;

	private IGameBridge bridgingGame;

	private bool debugEvent;

	private bool debugFunction;

	private List<string> debugEventWhitelist;

	private List<string> debugEventBlacklist;

	private List<string> debugFunctionWhitelist;

	private List<string> debugFunctionBlacklist;

	private int perFrameLogsLimit;

	private StackContext curStack;

	private UIModelUGCDebugger debugger;

	public UGCDebugLogger Create(IGameBridge bridgingGame, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public bool UGCDebugLoggerMatchFilter(List<string> whiteList, List<string> blackList, string name)
	{
		return false;
	}

	public bool UGCDebugLoggerEventWithFilter(string eventName)
	{
		return false;
	}

	public bool UGCDebugLoggerFunctionWithFilter(string variableName)
	{
		return false;
	}

	public void OnTickEventHandle()
	{
	}

	public bool IsLogEnable()
	{
		return false;
	}

	public void SetStack(StackContext stack)
	{
	}

	public void ForceLog(LOGGER_CHANNEL channel, object[] msgs)
	{
	}

	private void _Log(LOGGER_CHANNEL channel, object[] msgs)
	{
	}

	public void LogInfo(object[] msgs)
	{
	}

	public void LogDebug(object[] msgs)
	{
	}

	public void LogWarning(object[] msgs)
	{
	}

	public void LogError(object[] msgs)
	{
	}

	public void statsReport(string errType)
	{
	}

	private void PrintOnFE(uint logType, string graphID, string context)
	{
	}

	public void LogConsole(int logType, string logText, string codeID = "")
	{
	}
}
