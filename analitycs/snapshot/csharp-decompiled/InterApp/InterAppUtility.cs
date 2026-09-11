using System.Collections.Generic;

namespace InterApp;

public static class InterAppUtility
{
	public delegate void LogDelegate(string log);

	public static LogDelegate OnLog;

	public static Dictionary<int, BaseAppInfo> appInfos;

	public static string[] LSApplicationQueriesSchemes => null;

	public static BaseAppInfo Info(InterAppName name)
	{
		return null;
	}

	public static void Log(string log)
	{
	}
}
