namespace COW.Gameplay.UGC;

public static class UGCDownloadDebugger
{
	public static bool DebugForceLog;

	private static bool m_EnableLog;

	public static bool EnableLog
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void Log(object message)
	{
	}

	public static void LogFormat(string format, object[] args)
	{
	}
}
