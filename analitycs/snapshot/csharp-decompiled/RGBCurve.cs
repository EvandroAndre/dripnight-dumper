using System;
using UnityEngine;

[Serializable]
public class RGBCurve : ScriptableObject
{
	public AnimationCurve R;

	public AnimationCurve G;

	public AnimationCurve B;

	public float length => 0f;

	public static float MaxTime(AnimationCurve curve)
	{
		return 0f;
	}

	public Vector3 Eval(float t)
	{
		return default(Vector3);
	}
}
