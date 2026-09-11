using System.Collections.Generic;

namespace COW;

public class FFRecordRealtime
{
	public enum ERecordType : byte
	{
		None,
		LauncherLoadingTime,
		SdkLoginTime,
		ServerLoginTime,
		RetrieveVersionTime,
		HotUpdateDownloadTime,
		LeaveGameLoadingTime,
		EnterWaitingIslandLoadingTime,
		EnterGameLoadingTime,
		EnterGameFakeLoadingTime,
		LeaveGameGlobalFps2Time
	}

	public class RecordRealtime
	{
		public ERecordType type;

		public float timestamp;

		public float times;

		public byte flag;
	}

	private static Dictionary<byte, RecordRealtime> m_RecordRealtimeDict;

	private static bool m_NeedRecordEngineStartupTime;

	private static float m_EngineStartupPauseTimes;

	private static float m_EngineStartupPauseTimestamp;

	public static void RecordApplicationPauseTime(bool paused)
	{
	}

	public static void StartRecordTime(ERecordType type, bool reStart = true)
	{
	}

	public static float EndRecordTime(ERecordType type)
	{
		return 0f;
	}

	public static float GetRecordTime(ERecordType type)
	{
		return 0f;
	}

	private static bool CheckIsValid()
	{
		return false;
	}

	private static void RecordApplicationPauseTimeForEngineTime(bool paused)
	{
	}

	public static float GetEngineTimePauseTime()
	{
		return 0f;
	}
}
