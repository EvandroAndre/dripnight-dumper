using System;

namespace VoxelBusters.ReplayKit.Internal;

public class SafeAndroidJNICall
{
	public static bool SafeCall(Action androidJavaCall, string tag = "AndroidJNI")
	{
		return false;
	}

	public static T SafeCall<T>(Func<T> androidJavaCall, T defaultValue = default(T), string tag = "AndroidJNI")
	{
		return default(T);
	}
}
