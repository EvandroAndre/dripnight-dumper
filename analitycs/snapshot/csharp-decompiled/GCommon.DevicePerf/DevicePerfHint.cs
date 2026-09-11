using UnityEngine;

namespace GCommon.DevicePerf;

public static class DevicePerfHint
{
	public abstract class IDevicePerfHint
	{
		public virtual bool SupportPreferredUpdateRateRetrieving => false;

		public virtual bool SupportHintSession => false;

		public virtual bool SupportPreferPowerEfficiency => false;

		public virtual bool SupportSetThreadsToHintSession => false;

		public virtual long RetrievePreferredUpdateRateNanos()
		{
			return 0L;
		}

		public virtual int CreateHintSession(int[] threadIds, long initTargetWorkDurationNanos)
		{
			return 0;
		}

		public virtual void UpdateTargetWorkDuration(int sessionId, long targetWorkDurationNanos)
		{
		}

		public virtual void ReportActualWorkDuration(int sessionId, long actualWorkDurationNanos)
		{
		}

		public virtual int SetPreferPowerEfficiency(int sessionId, bool enabled)
		{
			return 0;
		}

		public virtual int SetThreadsToHintSession(int sessionId, int[] threadIds)
		{
			return 0;
		}

		public virtual void DestroyHintSession(int sessionId)
		{
		}
	}

	private class DevicePerfHint_Default : IDevicePerfHint
	{
	}

	private class DevicePerfHint_Android : IDevicePerfHint
	{
		private static AndroidJavaClass _ThreadDurationManager;

		public static AndroidJavaClass ThreadDurationManager => null;

		public override bool SupportPreferredUpdateRateRetrieving => false;

		public override bool SupportHintSession => false;

		public override bool SupportPreferPowerEfficiency => false;

		public override bool SupportSetThreadsToHintSession => false;

		public override long RetrievePreferredUpdateRateNanos()
		{
			return 0L;
		}

		public static AndroidJavaObject ToJava(string[] strings)
		{
			return null;
		}

		public static AndroidJavaObject ToJava(float[] floats)
		{
			return null;
		}

		public static AndroidJavaObject ToJava(byte[] bytes)
		{
			return null;
		}

		public static AndroidJavaObject ToJava(int[] ints)
		{
			return null;
		}

		private static AndroidJavaObject ToJava<T>(T[] ts, string javaClass)
		{
			return null;
		}

		public override int CreateHintSession(int[] threadIds, long initTargetWorkDurationNanos)
		{
			return 0;
		}

		public override void UpdateTargetWorkDuration(int sessionId, long targetWorkDurationNanos)
		{
		}

		public override void ReportActualWorkDuration(int sessionId, long actualWorkDurationNanos)
		{
		}

		public override int SetPreferPowerEfficiency(int sessionId, bool enabled)
		{
			return 0;
		}

		public override int SetThreadsToHintSession(int sessionId, int[] threadIds)
		{
			return 0;
		}

		public override void DestroyHintSession(int sessionId)
		{
		}
	}

	private static IDevicePerfHint _DevicePerfHint;

	public static IDevicePerfHint Device => null;

	static DevicePerfHint()
	{
	}
}
