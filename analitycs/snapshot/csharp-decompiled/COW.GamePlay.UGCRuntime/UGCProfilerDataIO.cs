using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public static class UGCProfilerDataIO
{
	private const string CSV_HEADER = "FrameIndex,TimeOffsetMs,SampleIndex,ParentIndex,Depth,Name,CallCount,TotalMs,TotalMemoryDelta";

	public static void ExportToCSV(string filePath, List<ProfilerFrame> frames)
	{
	}

	public static List<ProfilerFrame> ImportFromCSV(string filePath)
	{
		return null;
	}

	private static string EscapeCSV(string field)
	{
		return null;
	}

	private static string[] ParseCSVLine(string line)
	{
		return null;
	}
}
