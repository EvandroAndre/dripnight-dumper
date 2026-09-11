using COW;
using UnityEngine;

namespace GCommon;

public static class VibrateFeature_AND
{
	private static AndroidJavaClass m_VibrateUtil;

	private static AndroidJavaObject m_CurrentActivity;

	private static bool m_supportAmplitude;

	public static bool SupportAmplitudeControl => false;

	private static AndroidJavaClass VibrateUtil => null;

	private static AndroidJavaObject CurrentAvtivity => null;

	public static void SetupPattern(VibrationInfo info)
	{
	}

	public static bool StartVibrate(VibrationInfo info)
	{
		return false;
	}

	public static bool StopVibrate()
	{
		return false;
	}
}
