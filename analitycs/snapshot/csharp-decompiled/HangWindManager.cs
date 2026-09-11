using COW;
using UnityEngine;

public static class HangWindManager
{
	private static bool _enable;

	private static bool _init;

	private static int _loopTime;

	private static float timeOffset;

	private static Vector3 _windMainDirection;

	private static float _windMainPower;

	private static Vector3 _windSecondaryDirection;

	private static float _windSecondaryPower;

	private static Quaternion _windQua;

	private static CreateCurveConfig _windMainCurve;

	private static CreateCurveConfig _windSecondaryCurve;

	public static bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Vector3 WindMainDirection => default(Vector3);

	public static float WindMainPower => 0f;

	public static Vector3 WindSecondaryDirection => default(Vector3);

	public static float WindSecondaryPower => 0f;

	public static CreateCurveConfig WindMainCurve => null;

	public static CreateCurveConfig WindSecondaryCurve => null;

	public static Quaternion WindQua
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	private static void Init()
	{
	}

	public static float GetDuration()
	{
		return 0f;
	}
}
