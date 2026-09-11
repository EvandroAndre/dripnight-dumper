using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCCubicBezier : IUGCTweenCurve
{
	public const int SAMPLE_RESOLUTION = 50;

	public float x1;

	public float y1;

	public float x2;

	public float y2;

	public bool presampled;

	public List<Vector2> clips;

	public float Sample(float x)
	{
		return 0f;
	}

	public void Clear()
	{
	}

	private void presample()
	{
	}

	private Vector2 internalSample(float t)
	{
		return default(Vector2);
	}
}
