using System;
using COW.Gameplay;
using UnityEngine;

public class Debugger
{
	public const string CACHED_LOG_ENABLE = "CACHED_LOG_ENABLE";

	public static bool EnableLog;

	public static bool EnableProfilerLog;

	public static bool LogToFile;

	public static bool BackendLogToFile;

	private static ulong VerboseLogFlags;

	public static readonly char[] VERBOSE_LOG_SEPARATOR;

	public static string[] SomeLogCallStack;

	public static LogLevelType LogLevel;

	public static int MainThreadId;

	public static bool IsMainThread => false;

	private static uint curTick => 0u;

	public static void LogWithFilter(FilterType filter, object message, LogColor color = LogColor.None)
	{
	}

	public static void LogErrorWithFilter(FilterType filter, object message, LogColor color = LogColor.None)
	{
	}

	public static void LogFormatWithFilter(FilterType filter, string message, object[] args)
	{
	}

	public static void LogErrorFormatWithFilter(FilterType filter, string message, object[] args)
	{
	}

	public static void Init()
	{
	}

	public static void ParseVerboseLogs(string verbose)
	{
	}

	public static bool ShouldLog(VerboseLog log)
	{
		return false;
	}

	public static void DisableLogFor64bit(bool disable)
	{
	}

	public static void Flush()
	{
	}

	public static void OnApplicationQuit()
	{
	}

	public static void Log(object message)
	{
	}

	private static bool ShouldAttachCallStack(object message)
	{
		return false;
	}

	public static void LogCallStack(object message)
	{
	}

	public static void LogFormat(string format, object[] args)
	{
	}

	public static void LogWarningFormat(string format, object[] args)
	{
	}

	public static void LogErrorFormat(string format, object[] args)
	{
	}

	public static void Log(object message, UnityEngine.Object ownerInHierachy, bool callstack = false)
	{
	}

	public static void Log(object message, LogColor type, UnityEngine.Object ownerInHierachy = null, bool callstack = false)
	{
	}

	public static void ReportException(string sourceStr, Exception e, bool needThrow = false, bool showWindow = false)
	{
	}

	public static void ReportError(string sourceStr, string errorMsg, bool needThrow = false)
	{
	}

	public static void LogErrorIf(bool condition, object message)
	{
	}

	public static void LogError(object message)
	{
	}

	public static void LogErrorCallStack(object message)
	{
	}

	public static void LogError(object message, UnityEngine.Object ownerInHierachy, bool callstack = false)
	{
	}

	public static void LogErrorForcely(object message, UnityEngine.Object ownerInHierachy = null, bool callstack = false)
	{
	}

	public static void LogWarning(object message, UnityEngine.Object ownerInHierachy = null, bool callstack = false)
	{
	}

	private static void LogInternal(LogLevelType level, object message, UnityEngine.Object ownerInHierachy, bool callstack = false)
	{
	}

	public static void Assert(bool InCondition)
	{
	}

	public static void Assert(bool InCondition, string InFormat)
	{
	}

	private static string FormatMessage(object message, bool callstack = false)
	{
		return null;
	}

	private static void WriteToFile(string message)
	{
	}

	public static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
	}

	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
	{
	}

	public static void DrawLine(Vector3 start, Vector3 end)
	{
	}

	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
	{
	}

	public static bool GetPrefsCachedLogEnable()
	{
		return false;
	}

	public static void SetPrefsCachedLogEnable(bool enable)
	{
	}
}
