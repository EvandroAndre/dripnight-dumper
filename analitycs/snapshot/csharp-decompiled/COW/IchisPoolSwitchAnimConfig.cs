using UnityEngine;

namespace COW;

public class IchisPoolSwitchAnimConfig : ScriptableObject
{
	public float SlowSpeed;

	public float FastSpeed;

	public AnimationCurve Curve;

	public float EvaluateSpeed(float curveValue)
	{
		return 0f;
	}
}
