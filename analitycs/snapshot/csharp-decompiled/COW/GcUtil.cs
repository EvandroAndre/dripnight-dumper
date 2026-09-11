using System;
using System.Runtime.InteropServices;
using GCommon;

namespace COW;

public static class GcUtil
{
	private delegate void OnGcFinishedDelegate(int ms);

	private const string LogPrefixTime = "[yyyy-MM-dd HH:mm:ss.fff] ";

	private const string LogPrefix = "OnGcFinished() manualCnt/totalCnt thisTime/totalTime=";

	private static MutableString s_CbString;

	public static int ManualGcCount;

	public static int LastManualGcFrame;

	public static int GcCount;

	public static int GcMs;

	public static bool Recorded;

	public static bool AutoGcDisabled;

	private static int s_DumpIl2cppStatsCnt;

	private static bool s_Il2cppStatsFileDeleted;

	public static void SetGcStart()
	{
	}

	public static long GetLastGCFinishTime()
	{
		return 0L;
	}

	public static void RegisterGcFinishedCallback(bool log)
	{
	}

	private static void OnGcFinished(int ms)
	{
	}

	public static void CheckGcCounts()
	{
	}

	public static void ClearGcCounts()
	{
	}

	public static void RecordGcInfo()
	{
	}

	public static void Collect()
	{
	}

	public static void DisableAutoGc()
	{
	}

	public static void EnableAutoGc()
	{
	}

	private static void EnableGcImpl(bool enable)
	{
	}

	private static void SetGcFinishCallback(IntPtr callback)
	{
	}

	private static long GetGCFinishTime()
	{
		return 0L;
	}

	private static void SetGCFinishTimeCallBack()
	{
	}

	public static void EnableLazyInitIl2cppMetaInfo(uint flags)
	{
	}

	public static void SetJoinThreadsWithTimeoutOnNativeDone(int timeoutMs, bool killOnTimeout)
	{
	}

	[PreserveSig]
	private static extern void il2cpp_set_join_timeout(int timeoutMs, bool killOnTimeout);

	public static void SetUnityPlayerDestroyTimeout(int ms)
	{
	}

	public static void SetUnityPlayerUpdateDisplayTimeout(int ms, bool checkRunning)
	{
	}

	public static long GetGcTotalBytes()
	{
		return 0L;
	}

	public static void IL2cppClearNativeSymbol()
	{
	}

	[PreserveSig]
	private static extern void il2cpp_clear_native_symbol();

	[PreserveSig]
	private static extern void il2cpp_stats_dump_to_file(string file);

	[PreserveSig]
	private static extern void il2cpp_stats_set_dump_stack_deep(int deep);

	public static void SetDumpStackDeep(int deep)
	{
	}

	public static void DumpIl2cppStats(string label)
	{
	}
}
